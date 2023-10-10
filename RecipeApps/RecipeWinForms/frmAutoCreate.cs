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
            WindowsFormUtility.SetListBinding(lstUsername, DataMaintenance.GetDataList("Username"), null, "Username");
        }
        private void CreateCookbook()
        {
            int usernameid = WindowsFormUtility.GetIdFromComboBox(lstUsername);
            Cursor = Cursors.WaitCursor;
            try
            {
                Cookbook.AutoCreateCookbook(usernameid);
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmNewCookbook));
                    //frmNewRecipe.LoadForm(recipeid);
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
