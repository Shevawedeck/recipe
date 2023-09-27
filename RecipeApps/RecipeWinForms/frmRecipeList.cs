﻿using CPUFramework;
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
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            btnNewRecipe.Click += BtnNewRecipe_Click;
            LoadTable();
            gRecipeList.CellDoubleClick += GRecipeList_CellDoubleClick;
           // this.BindForm();
        }

        private void BindForm()
        {
            
        }

        private void GRecipeList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void LoadTable()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            gRecipeList.DataSource = SQLUtility.GetDataTable(cmd);
            WindowsFormUtility.FormatGridForSearchResults(gRecipeList, "Recipe");
        }
        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if(rowindex > -1)
            {
                id = WindowsFormUtility.GetIdFromGrid(gRecipeList, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmNewRecipe), id);
            }
        }
        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
    }
}
