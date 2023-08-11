using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipes(string recipename)
        {
            string sql = "select RecipeId, RecipeName, Calories from recipe r where r.RecipeName like '%" + recipename + "%' ";
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select r.*, u.UsernameName, c.CuisineType from recipe r join Cuisine c on c.CuisineId = r.CuisineId join Username u on u.UsernameId = r.UsernameId where r.RecipeId =" + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }
        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select CuisineType, CuisineId from Cuisine");
        }
        public static DataTable GetUsernameList()
        {
            return SQLUtility.GetDataTable("select UsernameName, UsernameId from Username");
        }
        public static void Save(DataTable dtrecipe)
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = $"update recipe set UsernameId = '{r["UsernameId"]}', CuisineId = '{r["CuisineId"]}', RecipeName = '{r["RecipeName"]}', Calories = '{r["Calories"]}', DateDrafted = '{r["DateDrafted"]}', DatePublished = '{r["DatePublished"]}' where RecipeId = '{r["RecipeId"]}' ";
            }
            else
            {
                sql = $"insert Recipe(UsernameId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished) select '{r["UsernameId"]}', '{r["CuisineId"]}', '{r["RecipeName"]}', {r["Calories"]}, '{r["DateDrafted"]}', '{r["DatePublished"]}' ";
            }
            SQLUtility.ExecuteSql(sql);
        }
        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSql(sql);
        }
    }
}
