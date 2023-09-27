using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Ingredient
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSQLCommand("IngredientGet");
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
            SQLUtility.SaveDataTable(dt, "IngredientUpdate");
        }
        public static void Delete(int directionid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("IngredientDelete");
            cmd.Parameters["@IngredientId"].Value = directionid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
