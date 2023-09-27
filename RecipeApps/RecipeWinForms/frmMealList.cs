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
            SqlCommand cmd = SQLUtility.GetSQLCommand("MealListGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            gMeal.DataSource = SQLUtility.GetDataTable(cmd);
            WindowsFormUtility.FormatGridForSearchResults(gMeal, "MealList");
        }
    }
}
