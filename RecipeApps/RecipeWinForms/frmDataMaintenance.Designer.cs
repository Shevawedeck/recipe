namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            pnlOptButtons = new FlowLayoutPanel();
            optUsername = new RadioButton();
            optCuisine = new RadioButton();
            optIngredient = new RadioButton();
            optMeasurement = new RadioButton();
            optCourse = new RadioButton();
            btnSave = new Button();
            gData = new DataGridView();
            tblMain.SuspendLayout();
            pnlOptButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.727272F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.27273F));
            tblMain.Controls.Add(pnlOptButtons, 0, 0);
            tblMain.Controls.Add(btnSave, 1, 1);
            tblMain.Controls.Add(gData, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 86.21291F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7870855F));
            tblMain.Size = new Size(978, 573);
            tblMain.TabIndex = 0;
            // 
            // pnlOptButtons
            // 
            pnlOptButtons.Controls.Add(optUsername);
            pnlOptButtons.Controls.Add(optCuisine);
            pnlOptButtons.Controls.Add(optIngredient);
            pnlOptButtons.Controls.Add(optMeasurement);
            pnlOptButtons.Controls.Add(optCourse);
            pnlOptButtons.Dock = DockStyle.Fill;
            pnlOptButtons.FlowDirection = FlowDirection.TopDown;
            pnlOptButtons.Location = new Point(4, 4);
            pnlOptButtons.Margin = new Padding(4);
            pnlOptButtons.Name = "pnlOptButtons";
            pnlOptButtons.Size = new Size(233, 486);
            pnlOptButtons.TabIndex = 3;
            // 
            // optUsername
            // 
            optUsername.Anchor = AnchorStyles.Left;
            optUsername.AutoSize = true;
            optUsername.Checked = true;
            optUsername.Location = new Point(4, 4);
            optUsername.Margin = new Padding(4);
            optUsername.Name = "optUsername";
            optUsername.Size = new Size(80, 32);
            optUsername.TabIndex = 0;
            optUsername.TabStop = true;
            optUsername.Text = "Users";
            optUsername.UseVisualStyleBackColor = true;
            // 
            // optCuisine
            // 
            optCuisine.Anchor = AnchorStyles.Left;
            optCuisine.AutoSize = true;
            optCuisine.Location = new Point(4, 44);
            optCuisine.Margin = new Padding(4);
            optCuisine.Name = "optCuisine";
            optCuisine.Size = new Size(103, 32);
            optCuisine.TabIndex = 1;
            optCuisine.TabStop = true;
            optCuisine.Text = "Cuisines";
            optCuisine.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            optIngredient.Anchor = AnchorStyles.Left;
            optIngredient.AutoSize = true;
            optIngredient.Location = new Point(4, 84);
            optIngredient.Margin = new Padding(4);
            optIngredient.Name = "optIngredient";
            optIngredient.Size = new Size(131, 32);
            optIngredient.TabIndex = 2;
            optIngredient.TabStop = true;
            optIngredient.Text = "Ingredients";
            optIngredient.UseVisualStyleBackColor = true;
            // 
            // optMeasurement
            // 
            optMeasurement.Anchor = AnchorStyles.Left;
            optMeasurement.AutoSize = true;
            optMeasurement.Location = new Point(4, 124);
            optMeasurement.Margin = new Padding(4);
            optMeasurement.Name = "optMeasurement";
            optMeasurement.Size = new Size(160, 32);
            optMeasurement.TabIndex = 3;
            optMeasurement.TabStop = true;
            optMeasurement.Text = "Measurements";
            optMeasurement.UseVisualStyleBackColor = true;
            // 
            // optCourse
            // 
            optCourse.Anchor = AnchorStyles.Left;
            optCourse.AutoSize = true;
            optCourse.Location = new Point(4, 164);
            optCourse.Margin = new Padding(4);
            optCourse.Name = "optCourse";
            optCourse.Size = new Size(101, 32);
            optCourse.TabIndex = 4;
            optCourse.TabStop = true;
            optCourse.Text = "Courses";
            optCourse.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(821, 505);
            btnSave.Margin = new Padding(4, 4, 28, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 57);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(245, 4);
            gData.Margin = new Padding(4);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.RowTemplate.Height = 29;
            gData.Size = new Size(729, 486);
            gData.TabIndex = 1;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 573);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Text = "frmDataMaintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            pnlOptButtons.ResumeLayout(false);
            pnlOptButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private DataGridView gData;
        private FlowLayoutPanel pnlOptButtons;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton optMeasurement;
        private RadioButton radioButton8;
        private RadioButton optUsername;
        private RadioButton optCuisine;
        private RadioButton optIngredient;
        private RadioButton optCourse;
        private RadioButton radioButton5;
        private RadioButton radioButton9;
    }
}