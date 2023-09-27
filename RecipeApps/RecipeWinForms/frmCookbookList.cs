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
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            btnNewCookbook.Click += BtnNewCookbook_Click;
            LoadTable();
        }
        private void LoadTable()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookListGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            gCookbook.DataSource = SQLUtility.GetDataTable(cmd);
            WindowsFormUtility.FormatGridForSearchResults(gCookbook, "CookbookList");
        }
        private void ShowForm(Type frmtype)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(frmtype);
            }
        }
        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmNewCookbook));
        }
    }
}
