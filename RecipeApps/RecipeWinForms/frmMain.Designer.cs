namespace RecipeWinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileDashboard = new ToolStripMenuItem();
            mnuRecipes = new ToolStripMenuItem();
            mnuRecipesList = new ToolStripMenuItem();
            mnuRecipesNew = new ToolStripMenuItem();
            mnuRecipesClone = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealsList = new ToolStripMenuItem();
            mnuCookbooks = new ToolStripMenuItem();
            mnuCookbooksList = new ToolStripMenuItem();
            mnuCookbookNew = new ToolStripMenuItem();
            mnuCookbookAuto = new ToolStripMenuItem();
            mnuDataMaintenance = new ToolStripMenuItem();
            mnuDataMaintenanceEdit = new ToolStripMenuItem();
            mnuWindows = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipes, mnuMeals, mnuCookbooks, mnuDataMaintenance, mnuWindows });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new Padding(8, 3, 0, 3);
            mnuMain.Size = new Size(1100, 38);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileDashboard });
            mnuFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(56, 32);
            mnuFile.Text = "File";
            // 
            // mnuFileDashboard
            // 
            mnuFileDashboard.Name = "mnuFileDashboard";
            mnuFileDashboard.Size = new Size(194, 32);
            mnuFileDashboard.Text = "Dashboard";
            // 
            // mnuRecipes
            // 
            mnuRecipes.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipesList, mnuRecipesNew, mnuRecipesClone });
            mnuRecipes.Name = "mnuRecipes";
            mnuRecipes.Size = new Size(91, 32);
            mnuRecipes.Text = "Recipes";
            // 
            // mnuRecipesList
            // 
            mnuRecipesList.Name = "mnuRecipesList";
            mnuRecipesList.Size = new Size(225, 32);
            mnuRecipesList.Text = "List";
            // 
            // mnuRecipesNew
            // 
            mnuRecipesNew.Name = "mnuRecipesNew";
            mnuRecipesNew.Size = new Size(225, 32);
            mnuRecipesNew.Text = "New Recipe";
            // 
            // mnuRecipesClone
            // 
            mnuRecipesClone.Name = "mnuRecipesClone";
            mnuRecipesClone.Size = new Size(225, 32);
            mnuRecipesClone.Text = "Clone a Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealsList });
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(77, 32);
            mnuMeals.Text = "Meals";
            // 
            // mnuMealsList
            // 
            mnuMealsList.Name = "mnuMealsList";
            mnuMealsList.Size = new Size(127, 32);
            mnuMealsList.Text = "List";
            // 
            // mnuCookbooks
            // 
            mnuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbooksList, mnuCookbookNew, mnuCookbookAuto });
            mnuCookbooks.Name = "mnuCookbooks";
            mnuCookbooks.Size = new Size(126, 32);
            mnuCookbooks.Text = "Cookbooks";
            // 
            // mnuCookbooksList
            // 
            mnuCookbooksList.Name = "mnuCookbooksList";
            mnuCookbooksList.Size = new Size(234, 32);
            mnuCookbooksList.Text = "List";
            // 
            // mnuCookbookNew
            // 
            mnuCookbookNew.Name = "mnuCookbookNew";
            mnuCookbookNew.Size = new Size(234, 32);
            mnuCookbookNew.Text = "New Cookbook";
            // 
            // mnuCookbookAuto
            // 
            mnuCookbookAuto.Name = "mnuCookbookAuto";
            mnuCookbookAuto.Size = new Size(234, 32);
            mnuCookbookAuto.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            mnuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { mnuDataMaintenanceEdit });
            mnuDataMaintenance.Name = "mnuDataMaintenance";
            mnuDataMaintenance.Size = new Size(184, 32);
            mnuDataMaintenance.Text = "Data Maintenance";
            // 
            // mnuDataMaintenanceEdit
            // 
            mnuDataMaintenanceEdit.Name = "mnuDataMaintenanceEdit";
            mnuDataMaintenanceEdit.Size = new Size(178, 32);
            mnuDataMaintenanceEdit.Text = "Edit Data";
            // 
            // mnuWindows
            // 
            mnuWindows.Name = "mnuWindows";
            mnuWindows.Size = new Size(107, 32);
            mnuWindows.Text = "Windows";
            // 
            // tsMain
            // 
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Location = new Point(0, 38);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1100, 25);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tsMain);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Hearty Hearth";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileDashboard;
        private ToolStripMenuItem mnuRecipes;
        private ToolStripMenuItem mnuRecipesList;
        private ToolStripMenuItem mnuRecipesNew;
        private ToolStripMenuItem mnuRecipesClone;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealsList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbooksList;
        private ToolStripMenuItem mnuCookbookNew;
        private ToolStripMenuItem mnuCookbookAuto;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuDataMaintenanceEdit;
        private ToolStripMenuItem mnuWindows;
        private ToolStrip tsMain;
    }
}