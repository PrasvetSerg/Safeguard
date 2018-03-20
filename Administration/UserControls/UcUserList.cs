using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using ServiceTypes;

namespace Administration
{
    //ТИП CLIST4++
    public partial class UcUserList : DevExpress.XtraEditors.XtraUserControl
    {
        readonly string idFieldName = "acl_user_id";

        public enum DisplayMode
        {
            All
        }

        private DisplayMode displayMode;
        DataTable dataTable;
        //private int id;
        
        #region Constructors
        public UcUserList()
        {
            InitializeComponent();

            ActivateControl();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets a selected record ID
        /// </summary>
        [Browsable(false)]
        [DefaultValue(-1)]
        public int SelectedRecordId
        {
            get
            {
                int selectedRecordId = -1;
                if (this.gridView.GetFocusedDataRow() != null && this.gridView.FocusedRowHandle >= 0
                    && this.gridView.GetFocusedDataRow()[idFieldName] != DBNull.Value)
                {
                    selectedRecordId = (int)this.gridView.GetFocusedDataRow()[idFieldName];
                }
                return selectedRecordId;
            }
        }

        /// <summary>
        /// Gets a selected record
        /// </summary>
        [Browsable(false)]
        public DataRow SelectedRecord
        {
            get
            {
                return this.gridView.GetFocusedDataRow();
            }
        }

        /// <summary>
        /// Show or hide Find panel 
        /// </summary>
        [Description("Отображение панели поиска")]
        [DefaultValue(true)]
        public bool ShowFindPanel
        {
            get 
            { 
                return this.gridView.OptionsFind.AlwaysVisible; 
            }
            set
            {
            	this.gridView.OptionsFind.AlwaysVisible = value;
            }
        }

        /// <summary>
        /// Show or hide Tools panel 
        /// </summary>
        [Description("Отображение панели управления")]
        [DefaultValue(true)]
        public bool ShowToolsPanel
        {
            get
            {
                return this.barTools.Visible;
            }
            set
            {
                this.barTools.Visible = value;
            }
        }
        #endregion

        #region Manage Form
        //активация элементов управления на форме
        private void ActivateControl()
        {
            if (this.gridView.DataSource != null)
            {
                this.refreshBarButtonItem.Enabled = true;
                this.createBarButtonItem.Enabled = true;

                if (this.SelectedRecordId > 0
                    && (bool)this.gridView.GetFocusedDataRow()["is_deleted_record"] == false)
                {
                    this.editBarButtonItem.Enabled = true;
                    this.archiveBarButtonItem.Enabled = true;
                    this.deleteBarButtonItem.Enabled = true;
                }
                else
                {
                    this.editBarButtonItem.Enabled = false;
                    this.archiveBarButtonItem.Enabled = false;
                    this.deleteBarButtonItem.Enabled = false;
                }

                //фильтрация действующих записей
                if (this.showArchiveBarButtonItem.Down == true)
                {
                    this.gridView.Columns["is_deleted_record"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo();
                }
                else
                {
                    this.gridView.Columns["is_deleted_record"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(string.Format("[is_deleted_record] = False"));
                }
            }
            else
            {
                this.refreshBarButtonItem.Enabled = false;
                this.createBarButtonItem.Enabled = false;

                this.editBarButtonItem.Enabled = false;
                this.archiveBarButtonItem.Enabled = false;
                this.deleteBarButtonItem.Enabled = false;
            }
        }
        
        public void ShowList(DisplayMode displayMode, int id)
        {
            this.displayMode = displayMode;
            ActivateControl();

            string mode = "";
            switch (displayMode)
            {
                case DisplayMode.All:
                    mode = "all_view";
                    break;
            }

            string query = string.Format("dtr_acl_user_get '{0}'"//,{1}"
                , mode
                //, DBConnection.SqlQuery.IdToDbId(id)
                );
            UpdateData(query);

            if (id > 0)
            {
                SelectRow(id);

                if (this.SelectedRecordId != id) //действительное не равно желаемому
                {
                    this.showArchiveBarButtonItem.Down = true;
                    ActivateControl();
                    SelectRow(id);
                }
            }
        }

        //загрузка данных из базы
        string lastQuery;
        private void UpdateData(string query)
        {
            if (this.lastQuery != query || this.dataTable == null)
            {
                this.lastQuery = query;
                this.dataTable = DBConnection.SqlQuery.ReadData(null, query);
                this.gridControl.DataSource = this.dataTable;
            }
            else
            {
                //добавляет или обновляет строки в DataTable (но не удаляет)
                this.gridView.BeginDataUpdate();
                DBConnection.SqlQuery.ReadData(null, this.dataTable, query);
                //DBConnection.SqlQuery.ReadData(this.ParentForm, this.dataTable, query);//не проверено
                //this.gridView.ActiveFilterString = "declaration_status_id = 8";
                this.gridView.EndDataUpdate();
            }

            //задание первичного ключа
            if (this.dataTable != null && this.dataTable.PrimaryKey.Length == 0 && this.dataTable.Rows.Count > 0)
            {
                this.dataTable.PrimaryKey = new DataColumn[] { this.dataTable.Columns[idFieldName] };
            }

            ActivateControl();//обдумать необходимость размещения здесь или в вызывающих методах
            SendEvent_RowSelected();//при обновлении ChangeRow не срабатывает
        }

        //отображение количества видимых карточек
        private void gridView_RowCountChanged(object sender, EventArgs e)
        {
            this.recordCountBarStaticItem.Caption = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).RowCount.ToString();
            SendEvent_RowSelected();
        }

        //
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ActivateControl();
            SendEvent_RowSelected();
        }

        //задание фокуса на строку, содержащую переданые данные 
        public void SelectRow(int id)
        {
            if (this.dataTable != null)
            {
                //если есть первичный ключ
                if (this.dataTable.PrimaryKey.Length > 0)
                {
                    int index = dataTable.Rows.IndexOf(dataTable.Rows.Find(id));
                    int rowHandle = this.gridView.GetRowHandle(index);

                    this.gridView.FocusedRowHandle = rowHandle;
                    this.gridView.SelectRow(rowHandle);
                }
                else
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
            }
        }

        private void showArchiveBarButtonItem_DownChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //treeList.FilterConditions[0].Visible = this.showArchiveBarButtonItem.Down;
        }

        /// <summary>
        /// Show form Edit
        /// </summary>
        /// <param name="actionType"></param>
        /// <param name="countryCode">not used if actionType ADD</param>
        private void RunEdit(ActionType actionType, int id)
        {
            using (FormUsersEdit formEdit = new FormUsersEdit(actionType, id))
            {
                if (formEdit.ShowDialog(this) == DialogResult.OK)
                {
                    /*
                    if (actionType == ActionType.Remove)
                    {
                        if (this.dataTable.PrimaryKey.Length > 0)
                        {
                            int curIndex = this.gridView.FocusedRowHandle;
                            this.dataTable.Rows.Remove(this.dataTable.Rows.Find(id));
                            curIndex = curIndex == 0 ? 1 : curIndex;
                            this.gridView.FocusedRowHandle = curIndex - 1;
                            this.gridView.SelectRow(curIndex - 1);

                        }
                        else
                        {
                            int curIndex = this.gridView.FocusedRowHandle;
                            this.dataTable.Rows.Remove(this.gridView.GetDataRow(curIndex));//наверное лучше и универсальнее чем вариант выше.
                            curIndex = curIndex == 0 ? 1 : curIndex;
                            this.gridView.FocusedRowHandle = curIndex - 1;
                            this.gridView.SelectRow(curIndex - 1);
                        }
                    }
                    */
                    UpdateData(this.lastQuery);

                    if (actionType == ActionType.Add)
                    {
                        SelectRow(formEdit.RecordId);
                    }

                    //ActivateControl();
                }
            }
        }

        public delegate void DelegateFocuseRowChanged(DataRow row, int id);
        //public delegate void DelegateFocuseRowChanged(int id);
        public event DelegateFocuseRowChanged FocusedRowChanged;

        private void SendEvent_RowSelected()
        {
            if (FocusedRowChanged != null)
            {
                FocusedRowChanged(this.SelectedRecord, this.SelectedRecordId);
                //FocusedRowChanged(this.SelectedRecordId);
            }
        }

        public delegate void DelegateRowDoubleClick(DataRow row, int id);
        //public delegate void DelegateRowDoubleClick(int id);
        public event DelegateRowDoubleClick RowDoubleClick;
        /*
        private void SendEvent_RowDoubleClick()
        {
            if (RowDoubleClick != null)// && this.gridView.GetFocusedDataRow() != null)
            {
                RowDoubleClick(this.SelectedRecordId);
            }
        }
        */
        #endregion

        #region User Action
        //обновить
        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateData(lastQuery);
        }

        private void createBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RunEdit(ActionType.Add, -1);
        }

        private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RunEdit(ActionType.Edit, this.SelectedRecordId);
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RunEdit(ActionType.Remove, this.SelectedRecordId);
        }

        private void archiveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RunEdit(ActionType.Archive, this.SelectedRecordId);
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataTable != null)
            {
                if (this.SelectedRecordId > 0)
                {
                    if (RowDoubleClick != null)
                    {
                        //SendEvent_RowDoubleClick();
                        RowDoubleClick(this.SelectedRecord, this.SelectedRecordId);
                        //RowDoubleClick(this.SelectedRecordId);
                    }
                    else
                    {
                        /*
                        if ((bool)this.gridView.GetFocusedDataRow()["is_deleted_record"] == false)
                        {
                            RunEdit(ActionType.Edit, SelectedRecordId);
                        }
                        else
                        {
                            RunEdit(ActionType.None, SelectedRecordId);
                        }
                        */
                    }
                }
                else
                {
                    RunEdit(ActionType.Add, -1);
                }
            }
        }

        private void exportToExcelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportToExcel();
        }

        /// <summary>
        /// Экспорт отображаемого списка в Excel
        /// </summary>
        public void ExportToExcel()
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

        private void showArchiveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActivateControl();
        }


    }
}
