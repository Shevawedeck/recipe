namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        public frmCloneRecipe()
        {
            InitializeComponent();
            BindData();
            btnClone.Click += BtnClone_Click;
        }
        private void BindData()
        {
            WindowsFormUtility.SetListBinding(lstRecipeName, DataMaintenance.GetDataList("Recipe"), null, "Recipe");
            //lstRecipe.DataSource = Recipe.Load(recipeid);
        }
        private void CloneARecipe()
        {
            int recipeid = WindowsFormUtility.GetIdFromComboBox(lstRecipeName);
            Cursor = Cursors.WaitCursor;
            try
            {
                DataTable dt = new DataTable();
                dt = Recipe.CloneAndGetDT(recipeid);
                int newrecipeid = SQLUtility.GetValueFromFirstRowAsInt(dt, "RecipeId");
                //int newrecipeid = 
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmNewRecipe), newrecipeid);
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
        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneARecipe();
        }
    }
}