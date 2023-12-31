﻿using RecipeSystem;
using System.Diagnostics.Eventing.Reader;

namespace RecipeWinForms
{
    public partial class frmRecipeStatus : Form
    {
        private enum StatusEnum { Drafted, Archived, Published }
        StatusEnum currentstatus = new();
        DataTable dtrecipe = new();
        int recipeid = 0;
        BindingSource bindsource = new();
        public frmRecipeStatus()
        {
            InitializeComponent();
            btnPublish.Click += BtnPublish_Click;
            btnDraft.Click += BtnDraft_Click;
            btnArchive.Click += BtnArchive_Click;
        }
        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            WindowsFormUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormUtility.SetControlBinding(lblRecipeName, bindsource);
            GetCurrentStatus();
            EnableDisable();
        }
        private void EnableDisable()
        {

            switch (currentstatus)
            {
                case StatusEnum.Drafted:
                    btnDraft.Enabled = false;
                    btnArchive.Enabled = true;
                    btnPublish.Enabled = true;
                    break;
                case StatusEnum.Archived:
                    btnArchive.Enabled = false;
                    btnPublish.Enabled = true;
                    btnDraft.Enabled = true;
                    break;
                case StatusEnum.Published:
                    btnPublish.Enabled = false;
                    btnDraft.Enabled = true;
                    btnArchive.Enabled = true;
                    break;
            }
        }
        private void GetCurrentStatus()
        {
            switch (dtrecipe.Rows[0]["RecipeStatus"].ToString())
            {
                case "drafted":
                    currentstatus = StatusEnum.Drafted;
                    break;
                case "archived":
                    currentstatus = StatusEnum.Archived;
                    break;
                case "published":
                    currentstatus = StatusEnum.Published;
                    break;
            }
        }
        private void ChangeStatus(Button btn)
        {
            var response = MessageBox.Show($"Are you sure you want to change this recipe to {btn.Text}?", "HeartyHearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                if (btn == btnArchive)
                {
                    txtDateArchived.Clear();
                    txtDateArchived.Text = DateTime.Now.Date.ToString();
                    currentstatus = StatusEnum.Archived;
                }
                else if (btn == btnPublish)
                {
                    txtDatePublished.Clear();
                    txtDatePublished.Text = DateTime.Now.Date.ToString();
                    currentstatus = StatusEnum.Published;
                }
                else if (btn == btnDraft)
                {
                    txtDateDrafted.Clear();
                    txtDateDrafted.Text = DateTime.Now.Date.ToString();
                    if (currentstatus == StatusEnum.Archived) { txtDateArchived.Clear(); } 
                    else if (currentstatus == StatusEnum.Published) {  txtDatePublished.Clear(); }
                    currentstatus = StatusEnum.Drafted;
                }
                Recipe.SaveDate(dtrecipe);
                EnableDisable();
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
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
        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            ChangeStatus(btnArchive);
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            ChangeStatus(btnDraft);
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            ChangeStatus(btnPublish);
        }
    }
}
