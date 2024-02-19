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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuFileDashboard.Click += MnuFileDashboard_Click;
            mnuRecipesList.Click += MnuRecipesList_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuCookbooksList.Click += MnuCookbooksList_Click;
            mnuRecipesNew.Click += MnuRecipesNew_Click;
            mnuRecipesClone.Click += MnuRecipesClone_Click;
            mnuCookbookNew.Click += MnuCookbookNew_Click;
            mnuCookbookAuto.Click += MnuCookbookAuto_Click;
            mnuDataMaintenanceEdit.Click += MnuDataMaintenanceEdit_Click;
            mnuWindowsCascade.Click += MnuWindowsCascade_Click;
            mnuWindowsTile.Click += MnuWindowsTile_Click;
            this.Shown += FrmMain_Shown;
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            frmLogin f = new() { StartPosition = FormStartPosition.CenterParent };
            bool b = f.ShowLogin();
            if (b == false)
            {
                this.Close();
                Application.Exit();
                return;
            }
            OpenForm(typeof(frmDashboard));
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormUtility.IsFormOpen(frmtype);
            Form? newfrm = null;
            if (b == false)
            {
               
                if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new frmDashboard();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmNewRecipe))
                {
                    if (pkvalue == 0)
                    {
                        frmNewRecipe f = new();
                        newfrm = f;
                    }
                    if (pkvalue > 0)
                    {
                        frmNewRecipe f = new();
                        newfrm = f;
                        f.LoadForm(pkvalue);
                    }
                }
                else if (frmtype == typeof(frmNewCookbook))
                {
                    frmNewCookbook f = new();
                    newfrm = f;
                    //pkvalue = Cookbook
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmCloneRecipe))
                {
                    frmCloneRecipe f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmAutoCreate))
                {
                    frmAutoCreate f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeStatus))
                {
                    frmRecipeStatus f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Frm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }
                WindowsFormUtility.SetUpNav(tsMain);
            }
            else if (b == true)
            {
                if (frmtype == typeof(frmNewRecipe))
                {
                    frmNewRecipe f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                //else if(frmtype == typeof(frmNewRecipe) && pkvalue == 0)
            }
        }
        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormUtility.SetUpNav(tsMain);
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormUtility.SetUpNav(tsMain);
        }
        private void MnuWindowsTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuWindowsCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }


        private void MnuFileDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        private void MnuCookbooksList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuMealsList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void MnuRecipesList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }

        private void MnuDataMaintenanceEdit_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

        private void MnuCookbookAuto_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAutoCreate));
        }

        private void MnuCookbookNew_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmNewCookbook));
        }

        private void MnuRecipesClone_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneRecipe));
        }

        private void MnuRecipesNew_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmNewRecipe));
        }
    }
}
