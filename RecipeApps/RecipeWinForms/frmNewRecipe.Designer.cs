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
            txtRecipeStatus = new TextBox();
            lstCuisineType = new ComboBox();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            lblUsername = new Label();
            lstUsernameName = new ComboBox();
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
            tblMain.Controls.Add(txtRecipeStatus, 1, 5);
            tblMain.Controls.Add(lstCuisineType, 1, 2);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(lblUsername, 0, 3);
            tblMain.Controls.Add(lstUsernameName, 2, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
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
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 271F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tblMain.Size = new Size(745, 554);
            tblMain.TabIndex = 0;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.Location = new Point(3, 3);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(106, 34);
            btnSaveRecipe.TabIndex = 0;
            btnSaveRecipe.Text = "Save";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(210, 3);
            btnDelete.Margin = new Padding(16, 3, 3, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 34);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblMain.SetColumnSpan(btnChangeStatus, 2);
            btnChangeStatus.Location = new Point(561, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(181, 34);
            btnChangeStatus.TabIndex = 2;
            btnChangeStatus.Text = "Change Status...";
            btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(3, 41);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(111, 23);
            lblRecipeName.TabIndex = 3;
            lblRecipeName.Text = "Recipe Name";
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Location = new Point(3, 80);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(65, 23);
            lblCuisine.TabIndex = 5;
            lblCuisine.Text = "Cuisine";
            // 
            // lblNumCalories
            // 
            lblNumCalories.AutoSize = true;
            lblNumCalories.Location = new Point(3, 151);
            lblNumCalories.Name = "lblNumCalories";
            lblNumCalories.Size = new Size(113, 23);
            lblNumCalories.TabIndex = 9;
            lblNumCalories.Text = "Num Calories";
            // 
            // tbIngredientsSteps
            // 
            tblMain.SetColumnSpan(tbIngredientsSteps, 4);
            tbIngredientsSteps.Controls.Add(tabPage1);
            tbIngredientsSteps.Controls.Add(tabPage2);
            tbIngredientsSteps.Dock = DockStyle.Fill;
            tbIngredientsSteps.Location = new Point(3, 281);
            tbIngredientsSteps.Name = "tbIngredientsSteps";
            tbIngredientsSteps.SelectedIndex = 0;
            tbIngredientsSteps.Size = new Size(739, 270);
            tbIngredientsSteps.TabIndex = 20;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tblIngredients);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(731, 234);
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
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 16.17647F));
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 83.82353F));
            tblIngredients.Size = new Size(725, 228);
            tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredients
            // 
            btnSaveIngredients.Location = new Point(3, 3);
            btnSaveIngredients.Name = "btnSaveIngredients";
            btnSaveIngredients.Size = new Size(106, 29);
            btnSaveIngredients.TabIndex = 0;
            btnSaveIngredients.Text = "Save";
            btnSaveIngredients.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 39);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.RowTemplate.Height = 29;
            gIngredients.Size = new Size(719, 186);
            gIngredients.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tblSteps);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(731, 237);
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
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8088236F));
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 84.19118F));
            tblSteps.Size = new Size(725, 231);
            tblSteps.TabIndex = 0;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 39);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.RowTemplate.Height = 29;
            gSteps.Size = new Size(719, 189);
            gSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(106, 28);
            btnSaveSteps.TabIndex = 1;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(3, 187);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(119, 23);
            lblCurrentStatus.TabIndex = 11;
            lblCurrentStatus.Text = "Current Status";
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(3, 248);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(104, 23);
            lblStatusDates.TabIndex = 16;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDrafted.AutoSize = true;
            lblDrafted.Location = new Point(393, 223);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(67, 23);
            lblDrafted.TabIndex = 13;
            lblDrafted.Text = "Drafted";
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Top;
            lblPublished.AutoSize = true;
            lblPublished.Location = new Point(492, 223);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(84, 23);
            lblPublished.TabIndex = 14;
            lblPublished.Text = "Published";
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Location = new Point(608, 223);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(76, 23);
            lblArchived.TabIndex = 15;
            lblArchived.Text = "Archived";
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDateDrafted.Enabled = false;
            txtDateDrafted.Location = new Point(382, 251);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(78, 30);
            txtDateDrafted.TabIndex = 17;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Top;
            txtDatePublished.Enabled = false;
            txtDatePublished.Location = new Point(494, 251);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(80, 30);
            txtDatePublished.TabIndex = 18;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Enabled = false;
            txtDateArchived.Location = new Point(608, 251);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(79, 30);
            txtDateArchived.TabIndex = 19;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblMain.SetColumnSpan(txtRecipeStatus, 3);
            txtRecipeStatus.Enabled = false;
            txtRecipeStatus.Location = new Point(466, 190);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(276, 30);
            txtRecipeStatus.TabIndex = 12;
            // 
            // lstCuisineType
            // 
            lstCuisineType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblMain.SetColumnSpan(lstCuisineType, 3);
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(466, 83);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(276, 31);
            lstCuisineType.TabIndex = 6;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblMain.SetColumnSpan(txtRecipeName, 3);
            txtRecipeName.Location = new Point(466, 44);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(276, 30);
            txtRecipeName.TabIndex = 4;
            // 
            // txtCalories
            // 
            txtCalories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblMain.SetColumnSpan(txtCalories, 3);
            txtCalories.Location = new Point(466, 154);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(276, 30);
            txtCalories.TabIndex = 10;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(2, 116);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username";
            // 
            // lstUsernameName
            // 
            tblMain.SetColumnSpan(lstUsernameName, 2);
            lstUsernameName.FormattingEnabled = true;
            lstUsernameName.Location = new Point(465, 118);
            lstUsernameName.Margin = new Padding(2);
            lstUsernameName.Name = "lstUsernameName";
            lstUsernameName.Size = new Size(277, 31);
            lstUsernameName.TabIndex = 8;
            // 
            // frmNewRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 554);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmNewRecipe";
            Text = "Recipe";
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
        private TextBox txtRecipeStatus;
        private ComboBox lstCuisineType;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private Label lblUsername;
        private ComboBox lstUsernameName;
    }
}