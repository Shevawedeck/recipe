namespace RecipeWinForms
{
    partial class frmNewRecipe
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
            tblMain = new TableLayoutPanel();
            btnSaveRecipe = new Button();
            btnDelete = new Button();
            btnChangeStatus = new Button();
            lblRecipeName = new Label();
            lblCuisine = new Label();
            lblNumCalories = new Label();
            tbIngredientsSteps = new TabControl();
            tabPage1 = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnSaveIngredients = new Button();
            gIngredients = new DataGridView();
            tabPage2 = new TabPage();
            tblSteps = new TableLayoutPanel();
            gSteps = new DataGridView();
            btnSaveSteps = new Button();
            lblCurrentStatus = new Label();
            lblStatusDates = new Label();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtCurrentStatus = new TextBox();
            lstCuisine = new ComboBox();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            tblMain.SuspendLayout();
            tbIngredientsSteps.SuspendLayout();
            tabPage1.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tabPage2.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2206154F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.3472F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.1681728F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.625679F));
            tblMain.Controls.Add(btnSaveRecipe, 0, 0);
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(btnChangeStatus, 2, 0);
            tblMain.Controls.Add(lblRecipeName, 0, 1);
            tblMain.Controls.Add(lblCuisine, 0, 2);
            tblMain.Controls.Add(lblNumCalories, 0, 4);
            tblMain.Controls.Add(tbIngredientsSteps, 0, 8);
            tblMain.Controls.Add(lblCurrentStatus, 0, 5);
            tblMain.Controls.Add(lblStatusDates, 0, 7);
            tblMain.Controls.Add(lblDrafted, 1, 6);
            tblMain.Controls.Add(lblPublished, 2, 6);
            tblMain.Controls.Add(lblArchived, 3, 6);
            tblMain.Controls.Add(txtDateDrafted, 1, 7);
            tblMain.Controls.Add(txtDatePublished, 2, 7);
            tblMain.Controls.Add(txtDateArchived, 3, 7);
            tblMain.Controls.Add(txtCurrentStatus, 1, 5);
            tblMain.Controls.Add(lstCuisine, 1, 2);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5631065F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0762463F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9032259F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.609971F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9032259F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9032259F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.85044F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 330F));
            tblMain.Size = new Size(911, 675);
            tblMain.TabIndex = 0;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.Location = new Point(4, 4);
            btnSaveRecipe.Margin = new Padding(4);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(129, 41);
            btnSaveRecipe.TabIndex = 0;
            btnSaveRecipe.Text = "Save";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(258, 4);
            btnDelete.Margin = new Padding(20, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 41);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblMain.SetColumnSpan(btnChangeStatus, 2);
            btnChangeStatus.Location = new Point(728, 4);
            btnChangeStatus.Margin = new Padding(4);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(179, 41);
            btnChangeStatus.TabIndex = 2;
            btnChangeStatus.Text = "Change Status...";
            btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(4, 50);
            lblRecipeName.Margin = new Padding(4, 0, 4, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(126, 28);
            lblRecipeName.TabIndex = 3;
            lblRecipeName.Text = "Recipe Name";
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Location = new Point(4, 98);
            lblCuisine.Margin = new Padding(4, 0, 4, 0);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(74, 28);
            lblCuisine.TabIndex = 5;
            lblCuisine.Text = "Cuisine";
            // 
            // lblNumCalories
            // 
            lblNumCalories.AutoSize = true;
            lblNumCalories.Location = new Point(4, 185);
            lblNumCalories.Margin = new Padding(4, 0, 4, 0);
            lblNumCalories.Name = "lblNumCalories";
            lblNumCalories.Size = new Size(129, 28);
            lblNumCalories.TabIndex = 6;
            lblNumCalories.Text = "Num Calories";
            // 
            // tbIngredientsSteps
            // 
            tblMain.SetColumnSpan(tbIngredientsSteps, 4);
            tbIngredientsSteps.Controls.Add(tabPage1);
            tbIngredientsSteps.Controls.Add(tabPage2);
            tbIngredientsSteps.Dock = DockStyle.Fill;
            tbIngredientsSteps.Location = new Point(4, 345);
            tbIngredientsSteps.Margin = new Padding(4);
            tbIngredientsSteps.Name = "tbIngredientsSteps";
            tbIngredientsSteps.SelectedIndex = 0;
            tbIngredientsSteps.Size = new Size(903, 326);
            tbIngredientsSteps.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tblIngredients);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(895, 285);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingredients";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblIngredients.Controls.Add(btnSaveIngredients, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(4, 4);
            tblIngredients.Margin = new Padding(4);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 16.17647F));
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 83.82353F));
            tblIngredients.Size = new Size(887, 277);
            tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.Location = new Point(4, 4);
            btnSaveIngredients.Margin = new Padding(4);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(129, 35);
            btnSaveIngredients.TabIndex = 0;
            btnSaveIngredients.Text = "Save";
            btnSaveIngredients.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(4, 48);
            gIngredients.Margin = new Padding(4);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.RowTemplate.Height = 29;
            gIngredients.Size = new Size(879, 225);
            gIngredients.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tblSteps);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(537, 284);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Steps";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Controls.Add(btnSaveSteps, 0, 0);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(4, 4);
            tblSteps.Margin = new Padding(4);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8088236F));
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 84.19118F));
            tblSteps.Size = new Size(529, 276);
            tblSteps.TabIndex = 0;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(4, 47);
            gSteps.Margin = new Padding(4);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.RowTemplate.Height = 29;
            gSteps.Size = new Size(521, 225);
            gSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.Location = new Point(4, 4);
            btnSaveSteps.Margin = new Padding(4);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(129, 34);
            btnSaveSteps.TabIndex = 1;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(4, 229);
            lblCurrentStatus.Margin = new Padding(4, 0, 4, 0);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(135, 28);
            lblCurrentStatus.TabIndex = 7;
            lblCurrentStatus.Text = "Current Status";
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(4, 304);
            lblStatusDates.Margin = new Padding(4, 0, 4, 0);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(119, 28);
            lblStatusDates.TabIndex = 4;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDrafted.AutoSize = true;
            lblDrafted.Location = new Point(485, 273);
            lblDrafted.Margin = new Padding(4, 0, 4, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(78, 28);
            lblDrafted.TabIndex = 9;
            lblDrafted.Text = "Drafted";
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Location = new Point(571, 273);
            lblPublished.Margin = new Padding(4, 0, 4, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(97, 28);
            lblPublished.TabIndex = 10;
            lblPublished.Text = "Published";
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Location = new Point(744, 273);
            lblArchived.Margin = new Padding(4, 0, 4, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(89, 28);
            lblArchived.TabIndex = 11;
            lblArchived.Text = "Archived";
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDateDrafted.Enabled = false;
            txtDateDrafted.Location = new Point(468, 308);
            txtDateDrafted.Margin = new Padding(4);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(95, 34);
            txtDateDrafted.TabIndex = 12;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Location = new Point(571, 308);
            txtDatePublished.Margin = new Padding(4);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(97, 34);
            txtDatePublished.TabIndex = 13;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Location = new Point(744, 308);
            txtDateArchived.Margin = new Padding(4);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(96, 34);
            txtDateArchived.TabIndex = 14;
            // 
            // txtCurrentStatus
            // 
            txtCurrentStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblMain.SetColumnSpan(txtCurrentStatus, 3);
            txtCurrentStatus.Location = new Point(603, 233);
            txtCurrentStatus.Margin = new Padding(4);
            txtCurrentStatus.Name = "txtCurrentStatus";
            txtCurrentStatus.Size = new Size(304, 34);
            txtCurrentStatus.TabIndex = 15;
            // 
            // lstCuisine
            // 
            lstCuisine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblMain.SetColumnSpan(lstCuisine, 3);
            lstCuisine.FormattingEnabled = true;
            lstCuisine.Location = new Point(603, 102);
            lstCuisine.Margin = new Padding(4);
            lstCuisine.Name = "lstCuisine";
            lstCuisine.Size = new Size(304, 36);
            lstCuisine.TabIndex = 16;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblMain.SetColumnSpan(txtRecipeName, 3);
            txtRecipeName.Location = new Point(603, 54);
            txtRecipeName.Margin = new Padding(4);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(304, 34);
            txtRecipeName.TabIndex = 17;
            // 
            // txtCalories
            // 
            txtCalories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblMain.SetColumnSpan(txtCalories, 3);
            txtCalories.Location = new Point(603, 189);
            txtCalories.Margin = new Padding(4);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(304, 34);
            txtCalories.TabIndex = 18;
            // 
            // frmNewRecipe
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 675);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmNewRecipe";
            Text = "New Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tbIngredientsSteps.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tabPage2.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSaveRecipe;
        private Button btnDelete;
        private Button btnChangeStatus;
        private Label lblRecipeName;
        private Label lblStatusDates;
        private Label lblCuisine;
        private Label lblNumCalories;
        private Label lblCurrentStatus;
        private TabControl tbIngredientsSteps;
        private TabPage tabPage1;
        private TableLayoutPanel tblIngredients;
        private TabPage tabPage2;
        private Button btnSaveIngredients;
        private DataGridView gIngredients;
        private TableLayoutPanel tblSteps;
        private DataGridView gSteps;
        private Button btnSaveSteps;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtCurrentStatus;
        private ComboBox lstCuisine;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
    }
}