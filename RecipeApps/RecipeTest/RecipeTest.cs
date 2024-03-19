using System.Data;
using System.Configuration;

namespace RecipeTest
{
    public class RecipeTest
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;

        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(connstring, true);
        }
        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new();
            DBManager.SetConnectionString(testconnstring, false);
            dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(connstring, false);
            return dt;
        }
        private int GetFirstColumnFirstRowValue(string sql)
        {
            int n = 0;
            DBManager.SetConnectionString(testconnstring, false);
            n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            DBManager.SetConnectionString(connstring, false);
            return n;
        }
        private void ExecuteSQL(string sql)
        {
            DBManager.SetConnectionString(testconnstring, false);
            ExecuteSQL(sql);
            DBManager.SetConnectionString(connstring, false);
        }
        [Test]
        [TestCase("chicken soup", 400, "2010-01-01", "2011-01-01")]
        [TestCase("corn salad", 200, "2010-01-02", "2011-01-01")]
        public void InsertNewRecipe(string recipename, int calories, DateTime datedrafted, DateTime datepublished)
        {
            int cuisineid = GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "cant run test - no cuisines in db");
            int usernameid = GetFirstColumnFirstRowValue("select top 1 usernameid from username");
            Assume.That(usernameid > 0, "cant run test - no usernames in db");
            BizRecipe rec = new();
            rec.RecipeName = recipename;
            rec.CuisineId = cuisineid;
            rec.UsernameId = usernameid;
            rec.Calories = calories;
            rec.DateDrafted = datedrafted;
            rec.DatePublished = datepublished;
            
            rec.Save();
            int pkid = rec.RecipeId;

            Assert.IsTrue(pkid > 0, "primary key not updated in datatable");
            TestContext.WriteLine("new primary key " + pkid);
        }
        [Test]
        public void ChangeExistingRecipeCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "no recipes in DB, cant run test");
            int calories = GetFirstColumnFirstRowValue("select Calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Calories for recipeid " + recipeid + " is " + calories);
            calories = calories + 100;
            TestContext.WriteLine("change Calories to " + calories);
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["Calories"] = calories;
            Recipe.Save(dt);

            int newCalories = GetFirstColumnFirstRowValue("select Calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newCalories == calories, "Calories for recipe (" + recipeid + ") = " + newCalories);
            TestContext.WriteLine("Calories for recipe (" + recipeid + ") = " + newCalories);
        }
        [Test]
        public void ChangeExistingRecipeToInvalidCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "no recipes in DB, cant run test");
            int calories = GetFirstColumnFirstRowValue("select Calories from recipe where recipeid = " + recipeid);
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
            TestContext.WriteLine("change recipeid " + recipeid + " recipename from " + currecipename + " to " + recipename + " which belongs to a diff recipe");
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["RecipeName"] = recipename;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }
        private DataTable GetRecipeForDelete()
        {
            string sql = @"select top 1 r.recipeid, RecipeName from recipe r left join Direction d on d.recipeid = r.RecipeId where d.DirectionId is null";
            //"select top 1 r.recipeid, RecipeName from Recipe r left join CookbookRecipe cr on r.RecipeId = cr.CookbookRecipeId left join RecipeIngredient ri on ri.RecipeId = r.RecipeId";
            DataTable dt = GetDataTable(sql);
            return dt;
        }
        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = GetRecipeForDelete();
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
            BizRecipe rec = new();
            rec.Load(recipeid);
            rec.Delete();
            DataTable dtafterdelete = GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in db");
            TestContext.WriteLine("record with recipeid " + recipeid + " does not exist in database");
        }
        [Test]
        public void DeleteRecipeById()
        {
            DataTable dt = GetRecipeForDelete();
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["Recipeid"];
                recipedesc = dt.Rows[0]["RecipeId"] + " " + dt.Rows[0]["RecipeName"];
            }
            Assume.That(recipeid > 0, "no recipes without related records in DB, cant run test");
            TestContext.WriteLine("existing recipe without related records with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            BizRecipe rec = new();
            rec.Delete(recipeid);
            DataTable dtafterdelete = GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in db");
            TestContext.WriteLine("record with recipeid " + recipeid + " does not exist in database");
        }
        [Test]
        public void DeleteRecipeByDataTable()
        {
            DataTable dt = GetRecipeForDelete();
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["Recipeid"];
                recipedesc = dt.Rows[0]["RecipeId"] + " " + dt.Rows[0]["RecipeName"];
            }
            Assume.That(recipeid > 0, "no recipes without related records in DB, cant run test");
            TestContext.WriteLine("existing recipe without related records with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            BizRecipe rec = new();
            rec.Delete(dt);
            DataTable dtafterdelete = GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in db");
            TestContext.WriteLine("record with recipeid " + recipeid + " does not exist in database");
        }
        [Test]
        public void DeleteRecipeWithDirection()
        {
            string sql = @"select top 1 r.RecipeId, RecipeName, r.Calories from Recipe r join Direction d on d.recipeid = r.RecipeId where d.DirectionId is not null";
            DataTable dt = GetDataTable(sql);
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
            DataTable dt = GetDataTable(sql);
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
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "no recipes in DB, cant run test");
            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("ensure that app loads recipe " + recipeid);
            BizRecipe rec = new();
            DataTable dt = rec.Load(recipeid);
            int loadedid = rec.RecipeId;
            string recipename = rec.RecipeName;
            Assert.IsTrue(loadedid == recipeid && recipename != "", loadedid + " <> " + recipeid + " RecipeName = " + recipename);
            TestContext.WriteLine("loaded recipe (" + loadedid + ") RecipeName = " + recipename);
        }
        [Test]
        public void SearchRecipe()
        {
            string criteria = "a";
            int num = GetFirstColumnFirstRowValue("select total = count(*) from recipe where recipename like '%" + criteria + "%'");
            Assume.That(num > 0, "There are no recipes that match the search for " + num);
            TestContext.WriteLine(num + " recipes that match the search for " + criteria);
            TestContext.WriteLine("ensure that search returns " + num + "rows");
            DataTable dt = Recipe.SearchRecipes(criteria);
            int results = dt.Rows.Count;
            Assert.IsTrue(results == num, "results of recipe search does not match num of presidents, " + results + " <> " + num);
            TestContext.WriteLine("number of rows returned by recipe search is " + results);
        }
        [Test]
        public void GetListOfCuisines()
        {
            int cuisinecount = GetFirstColumnFirstRowValue("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "No parties in DB; cant test");
            TestContext.WriteLine("Number of cuisnes in DB = " + cuisinecount);
            TestContext.WriteLine("ensure that Number of Rows return by app = " + cuisinecount);
            DataTable dt = Recipe.GetCuisineList();

            Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows returned (" + dt.Rows.Count + ") <> " + cuisinecount);
            TestContext.WriteLine("Number of Rows in Cuisine returned by app = " + dt.Rows.Count);
        }
        private int GetExistingRecipeId()
        {
            return GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
        private string GetFirstColumnFirstRowValueAsString(string sql)
        {
            string n = "";
            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    n = dt.Rows[0][0].ToString();
                }
            }
            return n;
        }
        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfIngredients(bool includeblank)
        {
            int ingcount = GetFirstColumnFirstRowValue("select total = count(*) from ingredient");
            if (includeblank == true) { ingcount = ingcount + 1; }
            Assume.That(ingcount > 0, "No ingredients in DB; cant test");
            TestContext.WriteLine("Number of ingredients in DB = " + ingcount);
            TestContext.WriteLine("ensure that Number of Rows return by app = " + ingcount);
            BizIngredient i = new();
            var lst = i.GetList(includeblank);

            Assert.IsTrue(lst.Count == ingcount, "num rows returned (" + lst.Count + ") <> " + ingcount);
            TestContext.WriteLine("Number of Rows in Ingredient returned by app = " + lst.Count);
        }
        [Test]
        public void SearchIngredients()
        {
            string ingname = "";
            int ingcount = GetFirstColumnFirstRowValue($"select total = count(*) from ingredient where ingredientname = '%{ingname}%'");
            TestContext.WriteLine("Num of search results in DB = " + ingcount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + ingcount);
            BizIngredient i = new();
            List<BizIngredient> lst = i.Search(ingname);
            Assert.IsTrue(lst.Count == ingcount, "num rows returned by search (" + lst.Count + ") <> " + ingcount);
            TestContext.WriteLine("Number of rows in search results return by app = " + lst.Count);
        }
    }
}