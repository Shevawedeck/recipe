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
    public partial class frmAutoCreate : Form
    {
        public frmAutoCreate()
        {
            InitializeComponent();
            BindData();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }
        private void BindData()
        {
            WindowsFormUtility.SetListBinding(lstUsernameName, DataMaintenance.GetDataList("Username"), null, "Username");
        }
        private void CreateCookbook()
        {
            DataTable dt = new DataTable();
            int usernameid = WindowsFormUtility.GetIdFromComboBox(lstUsernameName);
            Cursor = Cursors.WaitCursor;
            try
            {
                dt = Cookbook.AutoCreateCookbook(usernameid);
                int id = SQLUtility.GetValueFromFirstRowAsInt(dt, "CookbookId");
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmNewCookbook), id);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
        }
    }
}
