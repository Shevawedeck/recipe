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
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            btnArchive = new Button();
            btnPublish = new Button();
            btnDraft = new Button();
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
            tblMain.Controls.Add(lblDateDrafted, 1, 3);
            tblMain.Controls.Add(lblDatePublished, 2, 3);
            tblMain.Controls.Add(lblDateArchived, 3, 3);
            tblMain.Controls.Add(btnArchive, 3, 4);
            tblMain.Controls.Add(btnPublish, 2, 4);
            tblMain.Controls.Add(btnDraft, 1, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
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
            lblStatus.Anchor = AnchorStyles.None;
            lblStatus.AutoSize = true;
            tblMain.SetColumnSpan(lblStatus, 4);
            lblStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(267, 136);
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
            lblStatusDates.TabIndex = 5;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblArchived.Location = new Point(412, 202);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(81, 25);
            lblArchived.TabIndex = 6;
            lblArchived.Text = "Archived";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Location = new Point(200, 280);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(50, 20);
            lblDateDrafted.TabIndex = 7;
            lblDateDrafted.Text = "label7";
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.Location = new Point(305, 280);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(50, 20);
            lblDatePublished.TabIndex = 8;
            lblDatePublished.Text = "label8";
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(412, 280);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(50, 20);
            lblDateArchived.TabIndex = 9;
            lblDateArchived.Text = "label9";
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
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Button btnArchive;
        private Button btnPublish;
        private Button btnDraft;
    }
}