using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Safeguard.BusinessForm.Reports
{
    public partial class FormStatistic : DevExpress.XtraEditors.XtraForm
    {
        public FormStatistic()
        {
            InitializeComponent();

            this.calcDateStartBarEditItem.EditValue = DateTime.Now.AddMonths(-1);//new DateTime(DateTime.Now.Year, 1, 1);
            this.calcDateEndBarEditItem.EditValue = DateTime.Now; //new DateTime(DateTime.Now.Year, 12, 31);

            UpdateList();
        }

        private void pivotGridControl2_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e)
        {
            XtraForm form = new XtraForm();
            form.Text = "Вошедшие в сумму данные";
            form.StartPosition = FormStartPosition.CenterParent;
            DataGridView grid = new DataGridView();
            grid.Parent = form;
            grid.Dock = DockStyle.Fill;
            grid.DataSource = e.CreateDrillDownDataSource();
            form.Width = 520;
            form.Height = 300;
            form.ShowDialog();
            form.Dispose();
        }

        private void exportToFileBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DialogResult.OK == this.saveFileDialog.ShowDialog())
            {
                try
                {
                    if (this.pivotGridControl2.Focused == true)
                    {
                        this.pivotGridControl2.ExportToXls(this.saveFileDialog.FileName);
                    }
                    else if (this.chartControl.ContainsFocus == true)
                    {
                        this.chartControl.ExportToXls(this.saveFileDialog.FileName);
                    }
                    else
                    {
                        XtraMessageBox.Show("Внимание", "Ни одна таблица не выбрана.");
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Внимание", "Не удалось сохранить файл.");
                }
            }
        }

        private void calcDateStartdateEdit_EditValueChanged(object sender, EventArgs e)
        {
            /*
            if (((DateTime)this.calcDateStartBarEditItem.EditValue).Day != 1)
            {
                this.calcDateStartBarEditItem.EditValue = ((DateTime)this.calcDateStartBarEditItem.EditValue).AddDays(1.0 - ((DateTime)this.calcDateStartBarEditItem.EditValue).Day);
            }
            else
            {
                //UpdateList();
            }
            */
        }

        private void calcDateEndDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            /*
            if (((DateTime)this.calcDateEndBarEditItem.EditValue).Day != 1)
            {
                this.calcDateEndBarEditItem.EditValue = ((DateTime)this.calcDateEndBarEditItem.EditValue).AddDays(1.0 - ((DateTime)this.calcDateEndBarEditItem.EditValue).Day);
            }
            else
            {
                //UpdateList();
            }
            */
        }

        //отображение справки
        private void helpBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //System.Diagnostics.Process.Start("http://ivc-project.lan.naftan.by/ats/HTML-help/index.html?modtarificationbeltel.htm");

            //InternalWebBrowser.FormWebBrowser form = new InternalWebBrowser.FormWebBrowser("Справка по программе", "http://ivc-project.lan.naftan.by/ats/HTML-help/index.html?modbrowsingdetail.htm");
            //form.Show();
        }

        private void showBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateList();
        }

        private void UpdateList()
        {
            DataSet ds = new DataSet();
            string tableName = "Имя таблицы";
            DataTable dataTable = DBConnection.SqlQuery.ReadData(null, string.Format("dtr_offense_get 'report_for_period','{0}','{1}'"
                , ((DateTime)this.calcDateStartBarEditItem.EditValue).Date.ToString()
                , ((DateTime)this.calcDateEndBarEditItem.EditValue).Date.AddDays(1).ToString()));

            if (dataTable != null)
            {
                dataTable.TableName = "Имя таблицы";
                ds.Tables.Add(dataTable);

                this.pivotGridControl2.DataSource = ds.Tables[tableName].DefaultView;
                this.pivotGridControl2.CollapseAllRows();
            }
            else
            {
                this.pivotGridControl2.DataSource = null;
            }
        }
    }
}