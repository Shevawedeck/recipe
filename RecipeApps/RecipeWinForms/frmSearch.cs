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

namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            FormatGrid();
    }

    private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        ShowRecipeForm(e.RowIndex);
    }

    private void SearchForPresident(string recipename)
    {
        string sql = "select RecipeId, RecipeName, Calories from recipe r where r.RecipeName like '%" + recipename + "%' ";
        DataTable dt = SQLUtility.GetDataTable(sql);
        gRecipe.DataSource = dt;
        gRecipe.Columns["RecipeId"].Visible = false;
    }
    private void ShowRecipeForm(int rowindex)
    {
        int id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
        frmRecipe frm = new();
        frm.ShowForm(id);
    }
    private void BtnSearch_Click(object? sender, EventArgs e)
    {
        SearchForPresident(txtRecipe.Text);
    }
    private void FormatGrid()
    {
        gRecipe.AllowUserToAddRows = false;
        gRecipe.ReadOnly = true;
        gRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        gRecipe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }
}
}
