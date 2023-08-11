using System.Data;

namespace RecipeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true");
        }
        [Test]
        [TestCase("squash soup", "sweet salmon", 400, "2010-01-01", "2011-01-01")]
        public void InsertNewRecipe(string recipename, string recipename2, int calories, DateTime datedrafted, DateTime datepublished)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "cant run test - no cuisines in db");
            int usernameid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usernameid from username");
            Assume.That(usernameid > 0, "cant run test - no usernames in db");
            DataTable dtwithrecipe = SQLUtility.GetDataTable("select r.recipeid, r.RecipeName from recipe r where r.RecipeName = " +  recipename);
            if (dtwithrecipe.Rows.Count == 1)
            {
                recipename = recipename2;
            }
            r["RecipeName"] = recipename;
            r["CuisineId"] = cuisineid;
            r["UsernameId"] = usernameid;
            r["Calories"] = calories;
            r["DateDrafted"] = datedrafted;
            r["DatePublished"] = datepublished;
            Recipe.Save(dt);
            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where RecipeName = " + recipename);
            Assert.IsTrue(newid > 0, "recipe " + recipename + "is not found in db");
            TestContext.WriteLine("recipe with name " + recipename + " is found in db with pk value = " + newid);
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
    }
}