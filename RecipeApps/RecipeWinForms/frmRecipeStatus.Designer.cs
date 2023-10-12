namespace RecipeWinForms
{
    partial class frmRecipeStatus
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
            lblRecipeName = new Label();
            lblStatus = new Label();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblStatusDates = new Label();
            lblArchived = new Label();
            btnArchive = new Button();
            btnPublish = new Button();
            btnDraft = new Button();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            lblRecipeStatus = new Label();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.20376F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.7962379F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 294F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblStatus, 0, 1);
            tblMain.Controls.Add(lblDrafted, 1, 2);
            tblMain.Controls.Add(lblPublished, 2, 2);
            tblMain.Controls.Add(lblStatusDates, 0, 3);
            tblMain.Controls.Add(lblArchived, 3, 2);
            tblMain.Controls.Add(btnArchive, 3, 4);
            tblMain.Controls.Add(btnPublish, 2, 4);
            tblMain.Controls.Add(btnDraft, 1, 4);
            tblMain.Controls.Add(txtDateDrafted, 1, 3);
            tblMain.Controls.Add(txtDatePublished, 2, 3);
            tblMain.Controls.Add(txtDateArchived, 3, 3);
            tblMain.Controls.Add(lblRecipeStatus, 3, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(704, 453);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.None;
            lblRecipeName.AutoSize = true;
            tblMain.SetColumnSpan(lblRecipeName, 4);
            lblRecipeName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(303, 30);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(97, 41);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "label1";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Right;
            lblStatus.AutoSize = true;
            tblMain.SetColumnSpan(lblStatus, 3);
            lblStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(237, 136);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(169, 31);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Current Status: ";
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDrafted.Location = new Point(200, 202);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(72, 25);
            lblDrafted.TabIndex = 3;
            lblDrafted.Text = "Drafted";
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPublished.Location = new Point(305, 202);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(89, 25);
            lblPublished.TabIndex = 4;
            lblPublished.Text = "Published";
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(103, 280);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(91, 20);
            lblStatusDates.TabIndex = 6;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblArchived.Location = new Point(412, 202);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(81, 25);
            lblArchived.TabIndex = 5;
            lblArchived.Text = "Archived";
            // 
            // btnArchive
            // 
            btnArchive.Anchor = AnchorStyles.Left;
            btnArchive.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnArchive.Location = new Point(412, 381);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(94, 40);
            btnArchive.TabIndex = 12;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.None;
            btnPublish.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPublish.Location = new Point(308, 381);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(94, 40);
            btnPublish.TabIndex = 11;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnDraft
            // 
            btnDraft.Anchor = AnchorStyles.None;
            btnDraft.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDraft.Location = new Point(202, 381);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(94, 40);
            btnDraft.TabIndex = 10;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Enabled = false;
            txtDateDrafted.Location = new Point(200, 283);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(99, 27);
            txtDateDrafted.TabIndex = 7;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Enabled = false;
            txtDatePublished.Location = new Point(305, 283);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(101, 27);
            txtDatePublished.TabIndex = 8;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Enabled = false;
            txtDateArchived.Location = new Point(412, 283);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(125, 27);
            txtDateArchived.TabIndex = 9;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.Anchor = AnchorStyles.Left;
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Location = new Point(412, 141);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(50, 20);
            lblRecipeStatus.TabIndex = 2;
            lblRecipeStatus.Text = "label1";
            // 
            // frmRecipeStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 453);
            Controls.Add(tblMain);
            Name = "frmRecipeStatus";
            Text = "Recipe Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblStatus;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblStatusDates;
        private Label lblArchived;
        private Button btnArchive;
        private Button btnPublish;
        private Button btnDraft;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private Label lblRecipeStatus;
    }
}