using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmRecipeStatus : Form
    {
        private enum StatusEnum { Drafted, Archived, Published }
        StatusEnum currentstatus = StatusEnum.Drafted;
        public frmRecipeStatus()
        {
            InitializeComponent();
            btnPublish.Click += BtnPublish_Click;
            btnDraft.Click += BtnDraft_Click;
            btnArchive.Click += BtnArchive_Click;
        }
        public void LoadForm(int recipeid)
        {
            this.Tag = recipeid;
            DataTable dtrecipe = new();
            BindingSource bindsource = new();
            bindsource.DataSource = dtrecipe;
            DataTable dt = Recipe.Load(recipeid);
            WindowsFormUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateArchived, bindsource);
        }
        private void ChangeStatus()
        {

        }
        private void EnableDisable()
        {
            switch (currentstatus)
            {
                case StatusEnum.Drafted:
                    btnDraft.Enabled = false;
                    break;
                case StatusEnum.Archived:
                    btnArchive.Enabled = false;
                    break;
                case StatusEnum.Published:
                    btnPublish.Enabled = false;
                    break;
            }
        }
        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
