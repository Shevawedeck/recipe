using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Username, Cuisine, Ingredient, MeasurementType, Course }
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.Username;
        string deletecolname = "deletecol";
        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            gData.CellContentClick += GData_CellContentClick;
            SetupRadioButtons();
            BindData(currenttabletype);
        }
        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            //switch (tabletype)
            //{
            //    case TableTypeEnum.Cuisine:
            //        WindowsFormUtility.AddComboBoxToGrid(gData, DataMaintenance.GetDataList(TableTypeEnum.Cuisine.ToString()), "Cuisine", "CuisineType");
            //        break;
            //    case TableTypeEnum.Course:
            //        WindowsFormUtility.AddComboBoxToGrid(gData, DataMaintenance.GetDataList(TableTypeEnum.Course.ToString()), "Course", "CourseType");
            //        break;
            //}
            WindowsFormUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }
        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }
        private void Delete(int rowindex)
        {
            var response = DialogResult.No;
            if (currenttabletype.ToString() == "Username")
            {
                response = MessageBox.Show($"Are you sure you want to delete this user and all related recipes, meals and cookbooks?", "HeartyHearth", MessageBoxButtons.YesNo);
            }
            else
            {
                response = MessageBox.Show($"Are you sure you want to delete this {currenttabletype.ToString()} and all related records?", "HeartyHearth", MessageBoxButtons.YesNo);
            }
            
            int id = WindowsFormUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                finally
                {
                    Application.UseWaitCursor = false;
                }
            }
            else if (id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.Remove(gData.Rows[rowindex]);
            }
        }
        private void SetupRadioButtons()
        {
            foreach (Control c in pnlOptButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optUsername.Tag = TableTypeEnum.Username;
            optCuisine.Tag = TableTypeEnum.Cuisine;
            optIngredient.Tag = TableTypeEnum.Ingredient;
            optMeasurement.Tag = TableTypeEnum.MeasurementType;
            optCourse.Tag = TableTypeEnum.Course;
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }
        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex);
            }
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtlist))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
