﻿using System;
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
    //ТИП CLIST4 //add asinc call
    public partial class UcCommandList : DevExpress.XtraEditors.XtraUserControl
    {
        readonly string idFieldName = "acl_command_id";

        public enum DisplayMode
        {
            All,
            ByProcedureId
        }

        private DisplayMode displayMode;

        public UcCommandList()
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            this.displayMode = DisplayMode.All;

            InitializeComponent();
            InitData();

            Cursor.Current = currentCursor;
        }

        #region Properties
        /// <summary>
        /// Get ID focused shield card
        /// </summary>
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
        public DataRow SelectedRecord
        {
            get
            {
                return this.gridView.GetFocusedDataRow();
            }
        }

        string seachingText;
        /// <summary>
        /// Gets or set string having searching text
        /// </summary>
        public string SearchingText
        {
            set
            {
                seachingText = value; 
                this.gridView.RefreshData();
            }
            get
            {
                return this.seachingText;
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

        #region Form Management
        private void InitData()
        {
            ;
        }

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
                    this.deleteBarButtonItem.Enabled = true;
                }
                else
                {
                    this.editBarButtonItem.Enabled = false;
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
                this.deleteBarButtonItem.Enabled = false;
            }
        }

        public void ShowList(DisplayMode displayMode, int bookTreeId, int shieldCardIdForSelect = -1)
        {
            this.displayMode = displayMode;
            if (shieldCardIdForSelect > 0)
            {
                this.shieldIdForSelect = shieldCardIdForSelect;
            }

            Showshield(bookTreeId);
        }

        //Отображение абонентов для объекта
        private delegate DataTable ShowshieldsDelegate(Form form, string query);
        private ShowshieldsDelegate showshieldsDelegate;

        int shieldIdForSelect = -1;

        int bookTreeId;
        int newBookTreeId;

        private IAsyncResult aResult;
        private void Showshield(int bookTreeId)
        {
            this.newBookTreeId = bookTreeId;

            if (this.aResult == null || this.aResult.IsCompleted == true)
            {
                this.bookTreeId = bookTreeId;

                this.gridControl.DataSource = null;

                string mode = "";
                switch (displayMode)
                {
                    case DisplayMode.All:
                        mode = "all_view";
                        break;
                    case DisplayMode.ByProcedureId:
                        mode = "by_acl_procedure_id_view";
                        break;
                }
                string query = string.Format("dtr_acl_command_get '{0}',{1}"
                    , mode
                    , bookTreeId
                    );

                this.showshieldsDelegate = new ShowshieldsDelegate(DBConnection.SqlQuery.ReadData);
                this.aResult = this.showshieldsDelegate.BeginInvoke(null, query, new AsyncCallback(StartShowshield), this.showshieldsDelegate);
            }
        }

        private delegate void EndShowshieldsDelegate(DataTable shields);
        private void StartShowshield(IAsyncResult re)
        {
            this.Invoke(new EndShowshieldsDelegate(EndShowshield), new object[] { showshieldsDelegate.EndInvoke(re) });
        }

        //ПЕРЕДЕЛАТЬ
        private void EndShowshield(DataTable dataTable)
        {
            //if (this.displayMode == DisplayMode.ByObject)//ПЕРЕДЕЛАТЬ ужасное условие, необходимо для предотвращения наложения асинхрона на синхронный вывод
            {      
                //на случай если что-то поменялось за время выполнения
                if (this.bookTreeId == this.newBookTreeId)
                {
                    this.gridControl.DataSource = dataTable;
                    //this.gridView.FocusedRowHandle = this.focusedRowHandle;
                    
                    //задание первичного ключа
                    if (dataTable != null && dataTable.PrimaryKey.Length == 0 && dataTable.Rows.Count > 0)
                    {
                        dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns[this.idFieldName]};
                    }
                    

                    if (this.shieldIdForSelect > 0)
                    {
                        SelectRow(this.shieldIdForSelect);
                        this.shieldIdForSelect = -1;
                    }

                    SendEvent_RowSelected();//возможно при обновлении тоже не срабатывает ChangeRow
                }
                else
                {
                    Showshield(this.newBookTreeId);
                }
            }
        }

        //отображение количества видимых карточек
        private void gridView_RowCountChanged(object sender, EventArgs e)
        {
            this.recordCountBarStaticItem.Caption = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).RowCount.ToString();
            SendEvent_RowSelected();
        }

        //выбор другого элемента списка
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ActivateControl();
            SendEvent_RowSelected();
        }

        //задание фокуса на строку, содержащую переданые данные 
        private void SelectRow(int id)
        {
            /*
            for (int rowHandle = 0; rowHandle < this.gridView.RowCount; rowHandle++)
            {
                if (this.gridView.GetRowCellValue(rowHandle, this.idFieldName) != DBNull.Value && id == (int)this.gridView.GetRowCellValue(rowHandle, this.idFieldName))
                {
                    this.gridView.FocusedColumn = this.gridColumn2;
                    this.gridView.FocusedRowHandle = rowHandle;
                    this.gridView.SelectRow(rowHandle);
                    break;
                }
            }
            */
            DataTable dataTable = (DataTable)this.gridControl.DataSource;
            if (dataTable != null)
            {
                //если есть первичный ключ
                if (dataTable.PrimaryKey.Length > 0)
                {
                    int index = dataTable.Rows.IndexOf(dataTable.Rows.Find(id));
                    int rowHandle = this.gridView.GetRowHandle(index);

                    this.gridView.FocusedRowHandle = rowHandle;
                    this.gridView.SelectRow(rowHandle);
                }
                else //не фурычит при наличии группировки
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

        /// <summary>
        /// Show form Edit
        /// </summary>
        /// <param name="actionType"></param>
        /// <param name="countryCode">not used if actionType ADD</param>
        private void RunEdit(ActionType actionType, int shieldCardId)
        {
            using (FormCommandEdit formEdit = new FormCommandEdit(actionType, shieldCardId, bookTreeId))
            {
                if (formEdit.ShowDialog(this) == DialogResult.OK)
                {
                    ShowList(this.displayMode, this.bookTreeId, formEdit.RecordId);
                    /*
                    if (IsNeedChangeObject(this.bookTreeId, formEdit.ObjectId) == true)
                    {
                        this.shieldCatdIdForSelect = formEdit.RecordId;
                        SendEvent_NeedChangeObjectTree(formEdit.RecordId, formEdit.ObjectId);
                    }
                    else
                    {
                        ShowList(this.displayMode, this.bookTreeId, formEdit.RecordId);
                    }
                    */
                }
            }
        }
        #endregion

        #region User Action
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

        //обновить
        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowList(this.displayMode, this.bookTreeId);
        }

        private void showArchiveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActivateControl();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            /*
            //Добавление изменение карточки  
            if (gridView.FocusedColumn.FieldName != "sequence_object")
            {
                if (this.FocusedshieldCardId > 0)
                {
                    RunEdit(ActionType.Edit, this.FocusedshieldCardId);
                }
                else if (this.displayMode == DisplayMode.ByObject)
                {
                    RunEdit(ActionType.Add, -1);
                }
            }
            */
            if (RowDoubleClick != null)
            {
                SendEvent_RowDoubleClick();
            }
            else
            {
                int[] rowHandles = this.gridView.GetSelectedRows();
                if ((rowHandles.Length == 1) && (rowHandles[0] >= 0))
                {
                    /*
                    if (this.gridView.GetFocusedDataRow()["expiration_date"] == DBNull.Value)
                    {
                        RunEdit(ActionType.None, this.FocusedshieldCardId);
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(this, "Архивные записи редактировать запрещено.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    */
                }
            }
        }

        //Экспорт в Excel
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
        public delegate void DelegateFocuseCardChanged(DataRow row, int id);
        public event DelegateFocuseCardChanged FocusedRowChanged;
        private void SendEvent_RowSelected()
        {
            if (FocusedRowChanged != null)
            {
                FocusedRowChanged(this.SelectedRecord, this.SelectedRecordId);
            }
        }
        
        public delegate void DelegateRowDoubleClick(DataRow row, int id);
        public event DelegateRowDoubleClick RowDoubleClick;
        private void SendEvent_RowDoubleClick()
        {
            if (RowDoubleClick != null && this.gridView.GetFocusedDataRow() != null)
            {
                RowDoubleClick(this.SelectedRecord, this.SelectedRecordId);
            }
        }

        private void gridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && this.SelectedRecordId > 0)
            {
                //Point pointToScreen = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GridControl.PointToScreen(e.Location);

                this.popupMenu.ShowPopup(this.barManager, this.gridControl.PointToScreen(e.Location));
            } 
        }
    }
}
