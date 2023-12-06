﻿using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmNewCookbook : Form
    {
        DataTable dtcookbookrecipe = new();
        DataTable dtcookbook = new DataTable();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        int cookbookid = 0;
        public frmNewCookbook()
        {
            InitializeComponent();
            //BindData();
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
            btnSaveRecipes.Click += BtnSaveRecipes_Click;
            this.FormClosing += FrmNewCookbook_FormClosing;
            gRecipe.CellContentClick += GRecipe_CellContentClick;
        }
        public void LoadForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = Cookbook.Load(cookbookid);
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0) { dtcookbook.Rows.Add(); }
            DataTable dtusername = Cookbook.GetUsernameList();
            WindowsFormUtility.SetListBinding(lstUsernameName, dtusername, dtcookbook, "Username");
            WindowsFormUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateCreated, bindsource);
            WindowsFormUtility.SetControlBinding(ckbIsActive, bindsource);
            this.Text = GetCookbookDesc();
            LoadCookbookRecipes();
            SetButtonsEnabledBasedOnNew();
        }
        private void SetButtonsEnabledBasedOnNew()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            //btnSave.Enabled = b;
            btnSaveRecipes.Enabled = b;
        }
        private void LoadCookbookRecipes()
        {
            dtcookbookrecipe = Cookbook.LoadCookbookRecipeByCookbookId(cookbookid);
            gRecipe.Columns.Clear();
            gRecipe.DataSource = dtcookbookrecipe;
            WindowsFormUtility.AddComboBoxToGrid(gRecipe, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormUtility.AddDeleteButtonToGrid(gRecipe, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gRecipe, "CookbookRecipe");
        }
        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "Price") + SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return value;
        }
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
                this.Tag = cookbookid;
                SetButtonsEnabledBasedOnNew();
                this.Text = GetCookbookDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }
        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this cookbook?", "HeartyHearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtcookbookrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private void SaveCookbookRecipe()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            Cookbook.SaveCookbookRecipe(dtcookbookrecipe, cookbookid);
        }
        private void DeleteCookbookRecipe(int rowindex)
        {
            int id = WindowsFormUtility.GetIdFromGrid(gRecipe, rowindex, "CookbookRecipeId");
            if (id > 0)
            {
                try
                {
                    Cookbook.DeleteCookbookRecipe(id);
                    LoadCookbookRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gRecipe.Rows.Count)
            {
                gRecipe.Rows.RemoveAt(rowindex);
            }
        }
        //private void ShowForm(Type frmtype)
        //{
        //    if (this.MdiParent != null && this.MdiParent is frmMain)
        //    {
        //        ((frmMain)this.MdiParent).OpenForm(frmtype);
        //    }
        //}
        private void BindData()
        {
            DataTable dtlist = new();
            string deletecolname = "deletecol";
            dtlist = DataMaintenance.GetDataList("Recipe");
            gRecipe.Columns.Clear();
            gRecipe.DataSource = dtlist;
            WindowsFormUtility.AddComboBoxToGrid(gRecipe, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormUtility.AddDeleteButtonToGrid(gRecipe, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gRecipe, "Recipe");
        }
        private void BtnSaveRecipes_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void FrmNewCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbookrecipe))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
        private void GRecipe_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteCookbookRecipe(e.RowIndex);
        }
    }
}
