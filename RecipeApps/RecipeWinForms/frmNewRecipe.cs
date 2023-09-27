using CPUFramework;

namespace RecipeWinForms
{
    public partial class frmNewRecipe : Form
    {
        DataTable dtrecipe = new();
        DataTable dtdirection = new DataTable();
        DataTable dtingredients = new DataTable();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        int recipeid = 0;
        public frmNewRecipe()
        {
            InitializeComponent();
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            btnDelete.Click += BtnDelete_Click;
            this.FormClosing += FrmNewRecipe_FormClosing;
            btnSaveIngredients.Click += BtnSaveIngredients_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            btnChangeStatus.Click += BtnChangeStatus_Click;
        }
        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0) { dtrecipe.Rows.Add(); }
            DataTable dtcuisine = Recipe.GetCuisineList();
            //DataTable dtusername = Recipe.GetUsernameList();
            WindowsFormUtility.SetListBinding(lstCuisine, dtcuisine, dtrecipe, "Cuisine");
            // WindowsFormUtility.SetListBinding(lstUsernameName, dtusername, dtrecipe, "Username");
            WindowsFormUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormUtility.SetControlBinding(txtDateDrafted, bindsource);
            WindowsFormUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormUtility.SetControlBinding(txtDateArchived, bindsource);
            this.Text = GetRecipeDesc();
            LoadDirection();
            LoadIngredient();
            SetButtonsEnabledBasedOnNew();
        }
        private void LoadDirection()
        {
            dtdirection = Direction.LoadByRecipeId(recipeid);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtdirection;
            WindowsFormUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gSteps, "Direction");
        }
        private void LoadIngredient()
        {
            dtdirection = Direction.LoadByRecipeId(recipeid);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtdirection;
            WindowsFormUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gIngredients, "Ingredient");
        }
        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", "HeartyHearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HeartyHearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;
                SetButtonsEnabledBasedOnNew();
                this.Text = GetRecipeDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HeartyHearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }
        private void SaveOther(DataTable dt)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            Direction.SaveTable(dt, recipeid);
        }
        private void DeleteDirection(int rowindex)
        {
            int id = WindowsFormUtility.GetIdFromGrid(gSteps, rowindex, "DirectionId");
            if (id > 0)
            {
                try
                {
                    Direction.Delete(id);
                    LoadDirection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gSteps.Rows.Count)
            {
                gSteps.Rows.RemoveAt(rowindex);
            }
        }
        private void DeleteIngredient(int rowindex)
        {
            int id = WindowsFormUtility.GetIdFromGrid(gSteps, rowindex, "DirectionId");
            if (id > 0)
            {
                try
                {
                    Ingredient.Delete(id);
                    LoadIngredient();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gSteps.Rows.Count)
            {
                gSteps.Rows.RemoveAt(rowindex);
            }
        }
        private void SetButtonsEnabledBasedOnNew()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveIngredients.Enabled = b;
            btnSaveSteps.Enabled = b;
        }
        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "Calories") + SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }
        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteDirection(e.RowIndex);
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveOther(dtdirection);
        }

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            SaveOther(dtingredients);
        }

        private void FrmNewRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe))
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

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeStatus));
        }

    }
}
