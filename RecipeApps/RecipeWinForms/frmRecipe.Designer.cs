namespace RecipeWinForms
{
    partial class frmRecipe
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
            btnDelete = new Button();
            btnSave = new Button();
            lblCaptionRecipeName = new Label();
            lblCaptionCalories = new Label();
            lblCaptionRecipeImage = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionCuisineType = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionUsernameName = new Label();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtRecipeImage = new TextBox();
            txtCalories = new TextBox();
            lstCuisineType = new ComboBox();
            txtRecipeName = new TextBox();
            lstUsernameName = new ComboBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.125F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.875F));
            tblMain.Controls.Add(btnDelete, 1, 7);
            tblMain.Controls.Add(btnSave, 0, 7);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Controls.Add(lblCaptionCalories, 0, 1);
            tblMain.Controls.Add(lblCaptionRecipeImage, 0, 6);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 2);
            tblMain.Controls.Add(lblCaptionCuisineType, 0, 5);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 3);
            tblMain.Controls.Add(lblCaptionUsernameName, 0, 4);
            tblMain.Controls.Add(txtDateDrafted, 1, 2);
            tblMain.Controls.Add(txtDatePublished, 1, 3);
            tblMain.Controls.Add(txtRecipeImage, 1, 6);
            tblMain.Controls.Add(txtCalories, 1, 1);
            tblMain.Controls.Add(lstCuisineType, 1, 5);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(lstUsernameName, 1, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(834, 472);
            tblMain.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(170, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 47);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(3, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 47);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeName.Location = new Point(3, 15);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(126, 28);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCalories.Location = new Point(3, 74);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(81, 28);
            lblCaptionCalories.TabIndex = 2;
            lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionRecipeImage
            // 
            lblCaptionRecipeImage.Anchor = AnchorStyles.Left;
            lblCaptionRecipeImage.AutoSize = true;
            lblCaptionRecipeImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeImage.Location = new Point(3, 369);
            lblCaptionRecipeImage.Name = "lblCaptionRecipeImage";
            lblCaptionRecipeImage.Size = new Size(128, 28);
            lblCaptionRecipeImage.TabIndex = 3;
            lblCaptionRecipeImage.Text = "Recipe Image";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Left;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDateDrafted.Location = new Point(3, 133);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(124, 28);
            lblCaptionDateDrafted.TabIndex = 4;
            lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionCuisineType
            // 
            lblCaptionCuisineType.Anchor = AnchorStyles.Left;
            lblCaptionCuisineType.AutoSize = true;
            lblCaptionCuisineType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCuisineType.Location = new Point(3, 310);
            lblCaptionCuisineType.Name = "lblCaptionCuisineType";
            lblCaptionCuisineType.Size = new Size(120, 28);
            lblCaptionCuisineType.TabIndex = 5;
            lblCaptionCuisineType.Text = "Cuisine Type";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Left;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDatePublished.Location = new Point(3, 192);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(143, 28);
            lblCaptionDatePublished.TabIndex = 6;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionUsernameName
            // 
            lblCaptionUsernameName.Anchor = AnchorStyles.Left;
            lblCaptionUsernameName.AutoSize = true;
            lblCaptionUsernameName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionUsernameName.Location = new Point(3, 251);
            lblCaptionUsernameName.Name = "lblCaptionUsernameName";
            lblCaptionUsernameName.Size = new Size(156, 28);
            lblCaptionUsernameName.TabIndex = 7;
            lblCaptionUsernameName.Text = "Username Name";
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Top;
            txtDateDrafted.Location = new Point(170, 121);
            txtDateDrafted.Multiline = true;
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(661, 34);
            txtDateDrafted.TabIndex = 10;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Top;
            txtDatePublished.Location = new Point(170, 180);
            txtDatePublished.Multiline = true;
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(661, 34);
            txtDatePublished.TabIndex = 11;
            // 
            // txtRecipeImage
            // 
            txtRecipeImage.Dock = DockStyle.Top;
            txtRecipeImage.Location = new Point(170, 357);
            txtRecipeImage.Multiline = true;
            txtRecipeImage.Name = "txtRecipeImage";
            txtRecipeImage.Size = new Size(661, 34);
            txtRecipeImage.TabIndex = 14;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Top;
            txtCalories.Location = new Point(170, 62);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(661, 34);
            txtCalories.TabIndex = 15;
            // 
            // lstCuisineType
            // 
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(170, 298);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(213, 28);
            lstCuisineType.TabIndex = 16;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Top;
            txtRecipeName.Location = new Point(170, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(661, 27);
            txtRecipeName.TabIndex = 17;
            // 
            // lstUsernameName
            // 
            lstUsernameName.FormattingEnabled = true;
            lstUsernameName.Location = new Point(170, 239);
            lstUsernameName.Name = "lstUsernameName";
            lstUsernameName.Size = new Size(213, 28);
            lstUsernameName.TabIndex = 18;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 472);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "frmRecipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCalories;
        private Label lblCaptionRecipeImage;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionCuisineType;
        private Label lblCaptionDatePublished;
        private Label lblCaptionUsernameName;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtRecipeImage;
        private TextBox txtCalories;
        private Button btnDelete;
        private Button btnSave;
        private ComboBox lstCuisineType;
        private TextBox txtRecipeName;
        private ComboBox lstUsernameName;
    }
}