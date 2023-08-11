using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        public frmRecipe()
        {
            InitializeComponent();
        }
        public void ShowForm(int recipeid)
        {
            dtrecipe = Recipe.Load(recipeid);
            if (recipeid == 0) { dtrecipe.Rows.Add(); }
            DataTable dtcuisine = Recipe.GetCuisineList();
            DataTable dtusername = Recipe.GetUsernameList();

            //WindowsFormUtility.SetListBinding(lstCuisineType, dtcuisine, dtrecipe, "Cuisine");
            //WindowsFormUtility.SetListBinding(lstUsernameName, dtusername, dtrecipe, "Username");
            //WindowsFormUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDateDrafted, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtRecipeImage, dtrecipe);

            this.Show();
        }
        private void Delete()
        {
            Recipe.Delete(dtrecipe);
            this.Close();
        }
        private void Save()
        {
            Recipe.Save(dtrecipe);
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
