namespace RecipeWinForms
{
    partial class frmAutoCreate
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
            lstUsernameName = new ComboBox();
            btnCreateCookbook = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 310F));
            tblMain.Controls.Add(lstUsernameName, 0, 0);
            tblMain.Controls.Add(btnCreateCookbook, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(597, 269);
            tblMain.TabIndex = 0;
            // 
            // lstUsernameName
            // 
            lstUsernameName.Anchor = AnchorStyles.None;
            lstUsernameName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lstUsernameName.FormattingEnabled = true;
            lstUsernameName.Location = new Point(41, 115);
            lstUsernameName.Name = "lstUsernameName";
            lstUsernameName.Size = new Size(205, 39);
            lstUsernameName.TabIndex = 0;
            lstUsernameName.Text = "Select a User";
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.Anchor = AnchorStyles.None;
            btnCreateCookbook.AutoSize = true;
            btnCreateCookbook.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateCookbook.Location = new Point(343, 114);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(198, 41);
            btnCreateCookbook.TabIndex = 1;
            btnCreateCookbook.Text = "Create Cookbook";
            btnCreateCookbook.UseVisualStyleBackColor = true;
            // 
            // frmAutoCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 269);
            Controls.Add(tblMain);
            Name = "frmAutoCreate";
            Text = "Auto-Create a Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstUsernameName;
        private Button btnCreateCookbook;
    }
}