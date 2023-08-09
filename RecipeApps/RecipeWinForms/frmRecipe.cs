using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUWinFormsFramework;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            txtRecipeName.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select r.*, u.UsernameName, c.CuisineType from recipe r join Cuisine c on c.CuisineId = r.CuisineId join Username u on u.UsernameId = r.UsernameId where r.RecipeId =" + recipeid.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (recipeid == 0) { dtrecipe.Rows.Add(); }
            DataTable dtcuisine = SQLUtility.GetDataTable("select CuisineType, CuisineId from Cuisine");
            DataTable dtusername = SQLUtility.GetDataTable("select UsernameName, UsernameId from Username");

            WindowsFormUtility.SetListBinding(lstCuisineType, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormUtility.SetListBinding(lstUsernameName, dtusername, dtrecipe, "Username");
            WindowsFormUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDateDrafted, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtRecipeImage, dtrecipe);

            this.Show();
        }
        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSql(sql);
            this.Close();
        }
        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = $"update recipe set UsernameId = '{r["UsernameId"]}', CuisineId = '{r["CuisineId"]}', RecipeName = '{r["RecipeName"]}', Calories = '{r["Calories"]}', DateDrafted = '{r["DateDrafted"]}', DatePublished = '{r["DatePublished"]}', RecipeImage = '{r["RecipeImage"]}' where RecipeId = '{r["RecipeId"]}' ";
            }
            else
            {
                sql = $"insert Recipe(UsernameId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished) select '{r["UsernameId"]}', '{r["CuisineId"]}', '{r["RecipeName"]}', {r["Calories"]}, '{r["DateDrafted"]}', '{r["DatePublished"]}' ";
            }
            SQLUtility.ExecuteSql(sql);
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

    }
}
