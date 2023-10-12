using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmRecipeStatus : Form
    {
        private enum StatusEnum { Drafted, Archived, Published }
        StatusEnum currentstatus = StatusEnum.Drafted;
        DataTable dtrecipe = new();
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
            BindingSource bindsource = new();
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            WindowsFormUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormUtility.SetControlBinding(lblRecipeName, bindsource);
        }
        private void ChangeStatus(Button btn)
        {
            Recipe.Save(dtrecipe);


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
        private void ChangeStatus()
        {

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
