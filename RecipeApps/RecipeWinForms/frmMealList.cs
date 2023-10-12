using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            LoadTable();
        }
        private void LoadTable()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("MealGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            gMeal.DataSource = SQLUtility.GetDataTable(cmd);
            WindowsFormUtility.FormatGridForSearchResults(gMeal, "Meal");
            gMeal.Columns["DateCreated"].Visible = false;
            gMeal.Columns["IsActive"].Visible = false;
            gMeal.Columns["MealImage"].Visible = false;
        }
    }
}
