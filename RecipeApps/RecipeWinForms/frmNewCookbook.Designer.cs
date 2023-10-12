namespace RecipeWinForms
{
    partial class frmNewCookbook
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
            btnSave = new Button();
            btnDelete = new Button();
            lblCookbookName = new Label();
            txtCookbookName = new TextBox();
            lblUser = new Label();
            lstUsernameName = new ComboBox();
            lblDateLabel = new Label();
            lblDateCreated = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            lblActive = new Label();
            btnSaveRecipes = new Button();
            gRecipe = new DataGridView();
            ckbIsActive = new CheckBox();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.28264F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.85868F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.85868F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lstUsernameName, 1, 2);
            tblMain.Controls.Add(lblDateLabel, 2, 3);
            tblMain.Controls.Add(lblDateCreated, 2, 4);
            tblMain.Controls.Add(txtPrice, 1, 4);
            tblMain.Controls.Add(lblPrice, 0, 4);
            tblMain.Controls.Add(lblActive, 0, 5);
            tblMain.Controls.Add(btnSaveRecipes, 0, 6);
            tblMain.Controls.Add(gRecipe, 0, 7);
            tblMain.Controls.Add(ckbIsActive, 1, 5);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(245, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCookbookName
            // 
            lblCookbookName.AutoSize = true;
            lblCookbookName.Location = new Point(3, 35);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(121, 20);
            lblCookbookName.TabIndex = 2;
            lblCookbookName.Text = "Cookbook Name";
            // 
            // txtCookbookName
            // 
            tblMain.SetColumnSpan(txtCookbookName, 2);
            txtCookbookName.Location = new Point(245, 38);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(390, 27);
            txtCookbookName.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 68);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 20);
            lblUser.TabIndex = 4;
            lblUser.Text = "User";
            // 
            // lstUsernameName
            // 
            tblMain.SetColumnSpan(lstUsernameName, 2);
            lstUsernameName.FormattingEnabled = true;
            lstUsernameName.Location = new Point(245, 71);
            lstUsernameName.Name = "lstUsernameName";
            lstUsernameName.Size = new Size(390, 28);
            lstUsernameName.TabIndex = 5;
            // 
            // lblDateLabel
            // 
            lblDateLabel.AutoSize = true;
            lblDateLabel.Location = new Point(523, 102);
            lblDateLabel.Name = "lblDateLabel";
            lblDateLabel.Size = new Size(97, 20);
            lblDateLabel.TabIndex = 6;
            lblDateLabel.Text = "Date Created";
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(523, 122);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(13, 20);
            lblDateCreated.TabIndex = 9;
            lblDateCreated.Text = "l";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(245, 125);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 8;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 122);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Location = new Point(3, 155);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(50, 20);
            lblActive.TabIndex = 10;
            lblActive.Text = "Active";
            // 
            // btnSaveRecipes
            // 
            btnSaveRecipes.Location = new Point(3, 181);
            btnSaveRecipes.Name = "btnSaveRecipes";
            btnSaveRecipes.Size = new Size(94, 29);
            btnSaveRecipes.TabIndex = 12;
            btnSaveRecipes.Text = "Save";
            btnSaveRecipes.UseVisualStyleBackColor = true;
            // 
            // gRecipe
            // 
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gRecipe, 3);
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 216);
            gRecipe.Name = "gRecipe";
            gRecipe.RowHeadersWidth = 51;
            gRecipe.RowTemplate.Height = 29;
            gRecipe.Size = new Size(794, 231);
            gRecipe.TabIndex = 13;
            // 
            // ckbIsActive
            // 
            ckbIsActive.AutoSize = true;
            ckbIsActive.Location = new Point(245, 158);
            ckbIsActive.Name = "ckbIsActive";
            ckbIsActive.Size = new Size(18, 17);
            ckbIsActive.TabIndex = 11;
            ckbIsActive.UseVisualStyleBackColor = true;
            // 
            // frmNewCookbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmNewCookbook";
            Text = "frmNewCookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCookbookName;
        private TextBox txtCookbookName;
        private Label lblUser;
        private ComboBox lstUsernameName;
        private Label lblDateLabel;
        private Label lblDateCreated;
        private TextBox txtPrice;
        private Label lblPrice;
        private Label lblActive;
        private Button btnSaveRecipes;
        private DataGridView gRecipe;
        private CheckBox ckbIsActive;
    }
}