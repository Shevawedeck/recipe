using CPUFramework;
using RecipeSystem;
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
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            btnNewCookbook.Click += BtnNewCookbook_Click;
            LoadTable();
            gCookbook.CellDoubleClick += GCookbook_CellDoubleClick;
        }

        private void LoadTable()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            gCookbook.DataSource = SQLUtility.GetDataTable(cmd);
            WindowsFormUtility.FormatGridForSearchResults(gCookbook, "Cookbook");
            gCookbook.Columns["IsActive"].Visible = false;
            gCookbook.Columns["DateCreated"].Visible = false;
          
        }
        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormUtility.GetIdFromGrid(gCookbook, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmNewCookbook), id);
            }
        }
        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }
        private void GCookbook_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }

    }
}
