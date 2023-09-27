namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        public frmCloneRecipe()
        {
            InitializeComponent();
            btnClone.Click += BtnClone_Click;
        }
        private void BindForm()
        {
            //lstRecipe.DataSource = Recipe.Load(recipeid);
        }
        private void BtnClone_Click(object? sender, EventArgs e)
        {
            
        }
    }
}