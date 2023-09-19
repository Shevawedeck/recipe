namespace RecipeWinForms
{
    partial class frmDashboard
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
            lblWelcome = new Label();
            lblDescription = new Label();
            gData = new DataGridView();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.04279F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.9572048F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 373F));
            tblMain.Controls.Add(lblWelcome, 0, 0);
            tblMain.Controls.Add(lblDescription, 0, 1);
            tblMain.Controls.Add(gData, 0, 2);
            tblMain.Controls.Add(btnRecipeList, 0, 3);
            tblMain.Controls.Add(btnCookbookList, 2, 3);
            tblMain.Controls.Add(btnMealList, 1, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 4, 4, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 49.2957764F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50.7042236F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 251F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblMain.Size = new Size(901, 630);
            tblMain.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            tblMain.SetColumnSpan(lblWelcome, 3);
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(4, 0);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(893, 147);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Hearty Hearth Desktop App";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            tblMain.SetColumnSpan(lblDescription, 3);
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Location = new Point(80, 187);
            lblDescription.Margin = new Padding(80, 40, 80, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(741, 111);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Welcome to the Hearty Hearth desktop app.  In this app you can create recipes and and cookbooks. You can also... ";
            // 
            // gData
            // 
            gData.Anchor = AnchorStyles.None;
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gData, 3);
            gData.Location = new Point(217, 302);
            gData.Margin = new Padding(4, 4, 4, 4);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.RowTemplate.Height = 29;
            gData.Size = new Size(467, 242);
            gData.TabIndex = 2;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRecipeList.Location = new Point(236, 553);
            btnRecipeList.Margin = new Padding(4, 4, 4, 4);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(129, 41);
            btnRecipeList.TabIndex = 3;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Anchor = AnchorStyles.Top;
            btnMealList.Location = new Point(383, 553);
            btnMealList.Margin = new Padding(4, 4, 4, 4);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(129, 41);
            btnMealList.TabIndex = 4;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.AutoSize = true;
            btnCookbookList.Location = new Point(531, 553);
            btnCookbookList.Margin = new Padding(4, 4, 4, 4);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(148, 41);
            btnCookbookList.TabIndex = 5;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblWelcome;
        private Label lblDescription;
        private DataGridView gData;
        private Button btnRecipeList;
        private Button btnCookbookList;
        private Button btnMealList;
    }
}