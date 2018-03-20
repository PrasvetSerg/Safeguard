using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ServiceTypes;

namespace Safeguard.ServiceForm
{
    public partial class FormErrorLogList : DevExpress.XtraEditors.XtraForm
    {
        readonly string idFieldName = "error_log_id";
                
        bool isSelectMode;
        int selectedRecordId;
        DataTable dataTable;

        public FormErrorLogList()
        {
            this.selectedRecordId = -1;
            this.isSelectMode = false;

            InitializeComponent();
        }

        public FormErrorLogList(int selectedRecordId)
        {
            this.selectedRecordId = selectedRecordId;
            this.isSelectMode = true;

            InitializeComponent();

            SelectRow(this.selectedRecordId);
        }

        #region Properties
        /// <summary>
        /// Gets a selected record ID
        /// </summary>
        public int SelectedRecordId
        {
            get
            {
                int selectedRecordId = -1;
                if (this.gridView.GetFocusedDataRow() != null && this.gridView.FocusedRowHandle >= 0)
                {
                    selectedRecordId = (int)this.gridView.GetFocusedDataRow()[idFieldName];
                }
                return selectedRecordId;
            }
        }
        #endregion

        #region Manage Form
        //обработка загрузки формы
        private void FormList_Shown(object sender, EventArgs e)
        {
            InitControl();

            UpdateDataOnForm();

            if (this.isSelectMode == true)
            {
                SelectRow(this.selectedRecordId);
            }
        }

        //загрузка данных в селекторы
        private void InitControl()
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            //инициализация грида
            if (this.dataTable == null)
            {
                this.dataTable = new DataTable();
                this.gridControl.DataSource = this.dataTable;
            }

            Cursor.Current = currentCursor;
        }
        
        //обновление данных на форме и активация контролов
        private void UpdateDataOnForm()
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            //СОЗДАТЬ УНИВЕРСАЛЬНЫЙ МЕТОД ОБНОВЛЕНИЯ ОТОБРАЖАЕМЫХ ДАННЫХ
            //int focusedRowHandle = this.gridView.FocusedRowHandle;
            //this.gridView.FocusedRowHandle = focusedRowHandle;

            //добавляет или обновляет строки в DataTable (но не удаляет)
            DBConnection.SqlQuery.ReadData(this, this.dataTable, "usp_error_log_get 'all_view',''");

            //задание первичного ключа
            if (this.dataTable.PrimaryKey.Length == 0 && this.dataTable.Rows.Count > 0)
            {
                this.dataTable.PrimaryKey = new DataColumn[] { this.dataTable.Columns[idFieldName] };
            }
            ActivateControl();

            Cursor.Current = currentCursor;
        }

        //активация элементов управления на форме
        private void ActivateControl()
        {
            if (this.gridView.GetFocusedDataRow() != null && this.gridView.FocusedRowHandle >= 0)
                //&& this.gridView.GetFocusedDataRow()["expiration_date"] == DBNull.Value)
            {
                this.editBarBtnItem.Enabled = true;
                this.deleteBarBtnItem.Enabled = true;
            }
            else
            {
                this.editBarBtnItem.Enabled = false;
                this.deleteBarBtnItem.Enabled = false;
            }

            this.refreshBarBtnItem.Enabled = true;
            this.addBarBtnItem.Enabled = true;
        }

        //отображение количества видимых карточек
        private void gridView_RowCountChanged(object sender, EventArgs e)
        {
            this.recordCountBarStaticItem.Caption = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).RowCount.ToString();
        }

        //
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ActivateControl();
            //SendEvent();
        }

        //задание фокуса на строку, содержащую переданые данные 
        private void SelectRow(int id)
        {
            for (int rowHandle = 0; rowHandle < this.gridView.RowCount; rowHandle++)
            {
                if (id == (int)this.gridView.GetRowCellValue(rowHandle, idFieldName))
                {
                    this.gridView.FocusedRowHandle = rowHandle;
                    this.gridView.SelectRow(rowHandle);
                    break;
                }
            }
        }

        /// <summary>
        /// Run form Edit
        /// </summary>
        /// <param name="actionType"></param>
        /// <param name="ID"></param>
        private void RunEdit(ServiceTypes.ActionType actionType, int id)
        {
            /*
            using (FormCurrencyEdit formEdit = new FormCurrencyEdit(actionType, id))
            {
                if (formEdit.ShowDialog(this) == DialogResult.OK)
                {        
                    UpdateDataOnForm();
                    
                    if (actionType == ServiceTypes.ActionType.Add)
                    {
                        //this.gridView.FocusedRowHandle = this.gridView.GetRowHandle(dataSet.Tables["organization"].Rows.IndexOf(dataSet.Tables["organization"].Rows.Find(formOrganizationsEdit.RecordId)));
                        SelectRow(formEdit.RecordId);
                    }
                }
            }
            */
        }
        #endregion

        #region Process user Action
        //повторная загрузка списка
        private void refreshBarBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateDataOnForm();
        }

        private void addBarBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RunEdit(ActionType.Add, -1);
        }

        private void editBarBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RunEdit(ActionType.Edit, SelectedRecordId);
        }

        private void archiveBarBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RunEdit(ActionType.Archive, SelectedRecordId);
        }

        private void deleteBarBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RunEdit(ActionType.Remove, SelectedRecordId);
        }

        //Обработка двойного клика для изменения текущей записи
        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedRecordId > 0)
            {
                if (isSelectMode == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    RunEdit(ServiceTypes.ActionType.Edit, SelectedRecordId);
                    /*
                    if (this.gridView.GetFocusedDataRow()["expiration_date"] == DBNull.Value)
                    {
                        RunEdit(ServiceTypes.ActionType.Edit, SelectedRecordId);
                    }
                    else
                    {
                        RunEdit(ServiceTypes.ActionType.None, SelectedRecordId);
                    }
                     * */
                }
            }
            else
            {
                RunEdit(ServiceTypes.ActionType.Add, -1);
            }
        }

        private void exportToExcelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DialogResult.OK == this.saveFileDialog.ShowDialog())
            {
                try
                {
                    this.gridView.ExportToXls(this.saveFileDialog.FileName);
                }
                catch
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(this, "Не удалось сохранить файл.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion   

    }
}
