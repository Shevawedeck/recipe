using System.Data;
using System.Configuration;

namespace RecipeTest
{
    public class Tests
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;

        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(connstring,true);
        }
        [Test]
        [TestCase("squash soup", 400, "2010-01-01", "2011-01-01")]
        public void InsertNewRecipe(string recipename, int calories, DateTime datedrafted, DateTime datepublished)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "cant run test - no cuisines in db");
            int usernameid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usernameid from username");
            Assume.That(usernameid > 0, "cant run test - no usernames in db");
            r["RecipeName"] = recipename;
            r["CuisineId"] = cuisineid;
            r["UsernameId"] = usernameid;
            r["Calories"] = calories;
            r["DateDrafted"] = datedrafted;
            r["DatePublished"] = datepublished;
            Recipe.Save(dt);
            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where RecipeName = " + "'" + recipename + "'");
            Assert.IsTrue(newid > 0, "recipe " + recipename + "is not found in db");
            TestContext.WriteLine("recipe with name " + recipename + " is found in db with pk value = " + newid);
            DataTable dtwithrecipe = SQLUtility.GetDataTable("select * from recipe r where r.RecipeName = " + "'" + recipename + "'");
            Recipe.Delete(dtwithrecipe);
        }
        [Test]
        public void ChangeExistingRecipeCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "no recipes in DB, cant run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select Calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Calories for recipeid " + recipeid + " is " + calories);
            calories = calories + 100;
            TestContext.WriteLine("change Calories to " + calories);
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["Calories"] = calories;
            Recipe.Save(dt);

            int newCalories = SQLUtility.GetFirstColumnFirstRowValue("select Calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newCalories == calories, "Calories for recipe (" + recipeid + ") = " + newCalories);
            TestContext.WriteLine("Calories for recipe (" + recipeid + ") = " + newCalories);
        }
        [Test]
        public void ChangeExistingRecipeToInvalidCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "no recipes in DB, cant run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select Calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Calories for recipeid " + recipeid + " is " + calories);
            calories = calories - 1000;
            TestContext.WriteLine("change Calories to " + calories);
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["Calories"] = calories;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void ChangeExistingRecipeToInvalidRecipeName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "no recipes in DB, cant run test");
            string recipename = GetFirstColumnFirstRowValueAsString("select top 1 RecipeName from recipe where recipeid <> " + recipeid);
            string currecipename = GetFirstColumnFirstRowValueAsString("select top 1 RecipeName from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("change recipeid " + recipeid + " recipename from " + currecipename + " to " + recipename + "which belongs to a diff recipe");
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["RecipeName"] = recipename;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, RecipeName from recipe r left join Direction d on d.recipeid = r.RecipeId where d.DirectionId is null");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeId"] + " " + dt.Rows[0]["RecipeName"];
            }
            Assume.That(recipeid > 0, "no recipes without related records in DB, cant run test");
            TestContext.WriteLine("existing recipe without related records with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in db");
            TestContext.WriteLine("record with recipeid " + recipeid + " does not exist in database");
        }
        [Test]
        public void DeleteRecipeWithDirection()
        {
            string sql = @"select top 1 r.RecipeId, RecipeName, r.Calories from Recipe r join Direction d on d.recipeid = r.RecipeId where d.DirectionId is not null";
            DataTable dt = SQLUtility.GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeId"] + " " + dt.Rows[0]["RecipeName"];
            }
            Assume.That(recipeid > 0, "no recipes with Directions in DB, cant run test");
            TestContext.WriteLine("existing recipe with direction with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app cannot delete " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void DeleteRecipeThatsNotArchiveFor30DaysOrDrafted()
        {
            string sql = @"select top 1 r.RecipeId, RecipeName, r.Calories from Recipe r where (datediff(day, r.DateArchived, current_timestamp) <= 30 or r.RecipeStatus = 'published')";
            DataTable dt = SQLUtility.GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeId"] + " " + dt.Rows[0]["RecipeName"];
            }
            Assume.That(recipeid > 0, "no recipes not archived for more than 30 days in DB, cant run test");
            TestContext.WriteLine("existing recipe archived less than 30 days or not archived or not drafted with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app cannot delete " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void Loadrecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "no recipes in DB, cant run test");
            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("ensure that app loads recipe " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("loaded recipe (" + loadedid + ")");
        }
        [Test]
        public void GetListOfCuisines()
        {
            int cuisinecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "No parties in DB; cant test");
            TestContext.WriteLine("Number of cuisnes in DB = " + cuisinecount);
            TestContext.WriteLine("ensure that Number of Rows return by app = " + cuisinecount);
            DataTable dt = Recipe.GetCuisineList();

            Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows returned (" + dt.Rows.Count + ") <> " + cuisinecount);
            TestContext.WriteLine("Number of Rows in Cuisine returned by app = " + dt.Rows.Count);
        }
        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
        private string GetFirstColumnFirstRowValueAsString(string sql)
        {
            string n = "";
            DataTable dt = SQLUtility.GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    dt.Rows[0][0].ToString();
                }
            }
            return n;
        }
    }
}