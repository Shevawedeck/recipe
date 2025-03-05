using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class RecipeIngredient
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "RecipeIngredientUpdate");
        }
        public static void Delete(int recipeingredientid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientDelete");
            cmd.Parameters["@RecipeIngredientId"].Value = recipeingredientid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
