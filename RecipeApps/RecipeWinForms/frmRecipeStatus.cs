using RecipeSystem;
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
            txtDateDrafted.DataBindings.Clear();
            WindowsFormUtility.SetControlBinding(txtDateDrafted, bindsource);
            txtDatePublished.DataBindings.Clear();
            WindowsFormUtility.SetControlBinding(txtDatePublished, bindsource);
            txtDateArchived.DataBindings.Clear();
            WindowsFormUtility.SetControlBinding(txtDateArchived, bindsource);
            lblRecipeStatus.DataBindings.Clear();
            WindowsFormUtility.SetControlBinding(lblRecipeStatus, bindsource);
            lblRecipeName.DataBindings.Clear();
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
                    Recipe.SaveDate(dtrecipe);
                }
                else if (btn == btnPublish)
                {
                    txtDatePublished.Clear();
                    txtDatePublished.Text = DateTime.Now.Date.ToString();
                    currentstatus = StatusEnum.Published;
                    Recipe.SaveDate(dtrecipe);
                }
                else if (btn == btnDraft)
                {

                    if (currentstatus == StatusEnum.Archived) { txtDateArchived.Clear(); }
                    else if (currentstatus == StatusEnum.Published)
                    {txtDatePublished.Clear();}
                    Recipe.SaveDateDraft(dtrecipe);
                    txtDateDrafted.Clear();
                    txtDateDrafted.Text = DateTime.Now.Date.ToString();
                    currentstatus = StatusEnum.Drafted;
                    Recipe.SaveDateDraft(dtrecipe);
                }
                EnableDisable();
                LoadForm(recipeid);
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
