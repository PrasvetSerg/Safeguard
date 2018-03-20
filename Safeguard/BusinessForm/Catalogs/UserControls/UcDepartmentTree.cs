using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

using ServiceTypes;

namespace Safeguard.BusinessForm.Catalogs.UserControls
{
    //отображение дерева организаций и подразделений для нужд модуля Управление абонентами
    //отображение как для пользователей Справочника абонентов
    public partial class UcDepartmentTree : DevExpress.XtraEditors.XtraUserControl
    {
        readonly string idFieldName = "department_id";

        public enum DisplayMode
        {
            All            
        }

        DisplayMode displayMode;
        DataTable dataTable;

        #region Constructors
        public UcDepartmentTree()
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
                if (this.treeList.FocusedNode != null && this.treeList.FocusedNode[idFieldName] != DBNull.Value)
                {
                    selectedRecordId = (int)this.treeList.FocusedNode[idFieldName];
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
                DataRow row = null;
                if (this.treeList.FocusedNode != null)
                {
                    row = ((DataRowView)this.treeList.GetDataRecordByNode(this.treeList.FocusedNode)).Row;
                }

                return row; 
            }
        }
        /*
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
        */

        /// <summary>
        /// Show or hide Tools panel 
        /// </summary>
        [Description("Отображение панели управления")]
        [DefaultValue(true)]
        public bool ShowToolsPanel
        {
            get
            {
                return this.toolsBar.Visible;
            }
            set
            {
                this.toolsBar.Visible = value;
            }
        }
        #endregion

        #region Manage Form
        //активация элементов управления на форме
        private void ActivateControl()
        {
            this.searchBar.Visible = this.showSearchPanelBarButtonItem.Down;

            if (this.treeList.DataSource != null)
            {
                this.addHereBarButtonItem.Enabled = (this.SelectedRecordId > 0 && this.treeList.FocusedNode.ParentNode != null ? (bool)this.treeList.FocusedNode.ParentNode["is_deleted_record"] == false : true);

                if (this.SelectedRecordId > 0
                    && (bool)this.treeList.FocusedNode["is_deleted_record"] == false)
                {
                    this.addChildBarButtonItem.Enabled = true;

                    this.moveUpBarButtonItem.Enabled = (this.treeListColumn8.SortOrder == System.Windows.Forms.SortOrder.Ascending);
                    this.moveDownBarButtonItem.Enabled = (this.treeListColumn8.SortOrder == System.Windows.Forms.SortOrder.Ascending);

                    this.editBarButtonItem.Enabled = true;
                    this.deleteBarButtonItem.Enabled = true;

                    this.searchNextBarButtonItem.Enabled = true;
                }
                else
                {
                    this.addChildBarButtonItem.Enabled = false;

                    this.moveUpBarButtonItem.Enabled = false;
                    this.moveDownBarButtonItem.Enabled = false;

                    this.editBarButtonItem.Enabled = false;
                    this.deleteBarButtonItem.Enabled = false;

                    this.searchNextBarButtonItem.Enabled = false;
                }

                this.refreshBarButtonItem.Enabled = true;
                this.showArchiveBarButtonItem.Enabled = true;

                this.searchStringBarEditItem.Enabled = true;
                this.searchFromStartBarButtonItem.Enabled = true;
                
                //фильтрация действующих записей
                if (this.showArchiveBarButtonItem.Down == true)
                {
                    if (this.treeList.FilterConditions.Count > 0)
                    {
                        this.treeList.FilterConditions.Clear();
                    }
                }
                else
                {
                    if (this.treeList.FilterConditions.Count == 0)
                    {
                        this.treeList.FilterConditions.Add(new FilterCondition(FilterConditionEnum.Equals, this.treeList.Columns["is_deleted_record"], true, null, false));
                        //this.treeList.FilterConditions.Add(new FilterCondition(FilterConditionEnum.NotEquals, this.treeList.Columns["expiration_date"], System.DBNull.Value, null, false));
                    }
                }
            }
            else
            {
                this.refreshBarButtonItem.Enabled = false;

                this.addHereBarButtonItem.Enabled = false;
                this.addChildBarButtonItem.Enabled = false;

                this.moveUpBarButtonItem.Enabled = false;
                this.moveDownBarButtonItem.Enabled = false;

                this.editBarButtonItem.Enabled = false;
                this.deleteBarButtonItem.Enabled = false;
                this.showArchiveBarButtonItem.Enabled = false;

                this.searchStringBarEditItem.Enabled = false;
                this.searchFromStartBarButtonItem.Enabled = false;
                this.searchNextBarButtonItem.Enabled = false;
            }
        }

        public void ShowList(DisplayMode displayMode, int id=-1)
        {
            this.displayMode = displayMode;
            ActivateControl();
            
            if (id > 0)//тушим непотребное сообщение, так как правильное второе
            {
                this.treeList.FocusedNodeChanged -= treeList_FocusedNodeChanged;
            }
            
            string mode = "";
            switch (displayMode)
            {
                case DisplayMode.All:
                    mode = "all_view";
                    break;
            }

            string query = string.Format("dtr_department_get @command='{0}'"
                , mode
                );
            UpdateData(query);

            //используется в режиме селектора
            if (id > 0)
            {
                this.treeList.FocusedNodeChanged += treeList_FocusedNodeChanged;
                SelectRow(id);

                if (this.SelectedRecordId != id) //действительное не равно желаемому
                {
                    this.showArchiveBarButtonItem.Down = true;
                    ActivateControl();
                    SelectRow(id);
                }
            }
            else
            {
                this.treeList.FocusedNode = this.treeList.Nodes.FirstNode;
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
                this.treeList.DataSource = dataTable;

                this.treeList.CollapseAll();//иначе остаётся открытым ветка с первым загруженным узлом

                if (this.treeList.FilterConditions.Count < 1)
                {
                    this.treeList.FilterConditions.Add(new FilterCondition(FilterConditionEnum.Equals, this.treeList.Columns["is_deleted_record"], true, null, false));
                }
            }
            else
            {
                //добавляет или обновляет строки в DataTable (но не удаляет)
                //this.treeList.BeginUpdate();
                //this.treeList.BeginUnboundLoad();
                this.treeList.LockReloadNodes();//здесь нет разницы с this.treeList.BeginUnboundLoad(); всё-равно FocusedNodeChanged срабатывает дважды
                DBConnection.SqlQuery.ReadData(null, this.dataTable, query);
                //DBConnection.SqlQuery.ReadData(this.ParentForm, this.dataTable, query);//не проверено
                //this.gridView.ActiveFilterString = "declaration_status_id = 8";
                this.treeList.UnlockReloadNodes();
                //this.treeList.EndUnboundLoad();
                //this.treeList.EndUpdate();
            }

            //задание первичного ключа
            if (this.dataTable != null && this.dataTable.PrimaryKey.Length == 0 && this.dataTable.Rows.Count > 0)
            {
                this.dataTable.PrimaryKey = new DataColumn[] { this.dataTable.Columns[idFieldName]};
            }

            //this.recordCountBarStaticItem.Caption = this.dataTable.Rows.Count.ToString();

            ActivateControl();//обдумать необходимость размещения здесь или в вызывающих методах
            //SendEvent_RowSelected();//при обновлении ChangeRow не срабатывает//а с условием выше всё срабатывает
        }

        private void treeList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            ActivateControl();
            UpdateInfo();
            SendEvent_RowSelected();
        }

        private void UpdateInfo()
        {
            DataRow row = this.SelectedRecord;
            if (row != null)
            {
                this.renterNameLabelControl.Text = row["department_name"].ToString();
                this.renterCommentLabelControl.Text = row["comment"].ToString();
            }
            else
            {
                this.renterNameLabelControl.Text = "Объект не выбран";
                this.renterCommentLabelControl.Text = "";
            }
        }

        //задание фокуса на строку, содержащую переданые данные 
        public void SelectRow(int renterId)
        {
            if (renterId != this.SelectedRecordId)
            {
                this.treeList.SetFocusedNode(this.treeList.FindNodeByKeyID(renterId));//расскрывает дерево объектов и переходит на узел
            }
            else
            {
                SendEvent_RowSelected();
            }
            /*//Недоработанная альтернатива
            foreach (TreeListNode node in this.treeList.Nodes)
            {
                if((int)node["organizationId"]==organizationId && (int)node["objectId"]==objectId)
                {
                    node.Expanded = true;
                    break;
                }
                //при наличие детей выполнить цикл для них
            }
            */
            /*
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
            */
        }

        private int GetObjectId(TreeListNode node)
        {
            int parentId = -1;
            if (node != null && node[idFieldName] != DBNull.Value)
            {
                parentId = (int)node[idFieldName];
            }
            return parentId;
        }

        /// <summary>
        /// Show form Edit
        /// </summary>
        /// <param name="actionType"></param>
        /// <param name="countryCode">not used if actionType ADD</param>
        private void RunEdit(ActionType actionType, int recordId, int parentRecordId)
        {
            using (FormDepartmentEdit formEdit = new FormDepartmentEdit(actionType, recordId, parentRecordId))
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

        //public delegate void DelegateFocuseRowChanged(DataRow row, int id);
        public delegate void DelegateFocuseRowChanged(DataRow row, int renterId);
        public event DelegateFocuseRowChanged FocusedRowChanged;

        private void SendEvent_RowSelected()
        {
            if (FocusedRowChanged != null)
            {
                FocusedRowChanged(this.SelectedRecord, this.SelectedRecordId);
            }
        }

        public delegate void DelegateRowDoubleClick(DataRow row, int renterId);
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

        private void createParentBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.treeList.FocusedNode != null)
            {
                RunEdit(ActionType.Add, -1, GetObjectId(this.treeList.FocusedNode.ParentNode));
            }
            else
            {
                RunEdit(ActionType.Add, -1, -1);
            }
        }

        private void createChildBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.treeList.FocusedNode.ParentNode != null)
            {
                RunEdit(ActionType.Add, -1, GetObjectId(this.treeList.FocusedNode.ParentNode));
            }
            else
            {
                RunEdit(ActionType.Add, -1, GetObjectId(this.treeList.FocusedNode));
            }
        }

        private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RunEdit(ActionType.Edit, this.SelectedRecordId, -1);
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RunEdit(ActionType.Remove, this.SelectedRecordId, -1);
        }

        private void archiveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RunEdit(ActionType.Archive, this.SelectedRecordId, -1);
        }

        private void showArchiveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActivateControl();
        }

        private void moveUpBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int curPosition = (int)this.treeList.FocusedNode["sequence"];// (this.treeList.FocusedNode["manual_sequence"] != DBNull.Value ? (int)this.treeList.FocusedNode["manual_sequence"] : (int)this.treeList.FocusedNode["automatic_sequence"]);
            
            if (curPosition > 0)
            {
                TreeListNode prevNode = this.treeList.FocusedNode.PrevNode;
                while (prevNode != null
                    && ((int)prevNode["sequence"] >= curPosition
                        || ((bool)prevNode["is_deleted_record"] == true && this.showArchiveBarButtonItem.Down == false))
                    )
                {
                    prevNode = prevNode.PrevNode;
                }

                if (prevNode != null)
                {
                    int prevPosition = (int)prevNode["sequence"];
                    this.treeList.FocusedNode["sequence"] = (curPosition == prevPosition + 1 ? prevPosition : prevPosition + 1);
                }
                else
                {
                    this.treeList.FocusedNode["sequence"] = curPosition - 1;
                }

                if (SaveNewPosition(this.treeList.FocusedNode))
                {
                    UpdateData(this.lastQuery);
                    //SelectRow(formEdit.RecordId);
                }
            }
        }

        private void moveDownBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int curPosition = (int)this.treeList.FocusedNode["sequence"]; //(this.treeList.FocusedNode["manual_sequence"] != DBNull.Value ? (int)this.treeList.FocusedNode["manual_sequence"] : (int)this.treeList.FocusedNode["automatic_sequence"]);

            //if (curPosition > 999999)
            {
                TreeListNode nextNode = this.treeList.FocusedNode.PrevNode;
                while (nextNode != null
                    && ((int)nextNode["sequence"] <= curPosition
                        || ((bool)nextNode["is_deleted_record"] == true && this.showArchiveBarButtonItem.Down == false))
                    )
                {
                    nextNode = nextNode.NextNode;
                }



                if (nextNode != null)
                {
                    int nextPosition = (int)nextNode["sequence"];
                    this.treeList.FocusedNode["sequence"] = (curPosition == nextPosition - 1 ? nextPosition : nextPosition - 1);
                }
                else
                {
                    this.treeList.FocusedNode["sequence"] = curPosition + 1;
                }

                if (SaveNewPosition(this.treeList.FocusedNode))
                {
                    UpdateData(this.lastQuery);
                    //SelectRow(formEdit.RecordId);
                }
            }
            /*
            TreeListNode nextNode = this.treeList.FocusedNode.NextNode;
            while (nextNode != null && nextNode["expiration_date"] != DBNull.Value && this.showArchiveBarButtonItem.Down == false)
            {
                nextNode = nextNode.NextNode;
            }

            if (nextNode != null)
            {
                this.treeList.FocusedNode["manual_sequence"] = 1 + (nextNode["manual_sequence"] == DBNull.Value ? (int)nextNode["automatic_sequence"] : (int)nextNode["manual_sequence"]);

                if (SaveNewPosition(this.treeList.FocusedNode))
                {
                    UpdateData(this.lastQuery);
                    //SelectRow(formEdit.RecordId);
                }
            }
            */
        }

        private bool SaveNewPosition(TreeListNode node)
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            bool isSavedData = false;

            string query = string.Concat("dtr_department_set"
                , " @command=" + DBConnection.SqlQuery.ActionTypeToDbString(ServiceTypes.ActionType.Edit)
                , ",@department_id=" + node[idFieldName]

                //, ",@parent_department_id=" + DBConnection.SqlQuery.StrToDbString(node["parent_department_id"].ToString())
                , ",@department_name=" + DBConnection.SqlQuery.StrToDbString(node["department_name"].ToString())
                , ",@comment=" + DBConnection.SqlQuery.StrToDbString(node["comment"].ToString())
                , ",@sequence=" + DBConnection.SqlQuery.StrToDbString(node["sequence"].ToString())
                );

            try
            {
                DataTable dataTable = DBConnection.SqlQuery.RunTableQuery(query);
                if (dataTable.Rows.Count == 1)
                {
                    isSavedData = true;

                    //this.recordId = (int)dataTable.Rows[0][idFieldName];
                }
            }
            catch (System.Data.SqlClient.SqlException exception)
            {
                ExceptionHandler.Handler.ProcessSqlException(this, exception);
            }

            Cursor.Current = currentCursor;
            return isSavedData;
        }

        private void treeList_DoubleClick(object sender, EventArgs e)
        {
            if (this.treeList.DataSource != null)
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
                        if (//(bool)this.treeList.FocusedNode["is_deleted_record"] == false
                            && this.treeList.FocusedNode["expiration_date"] == DBNull.Value)
                        {
                            RunEdit(ActionType.Edit, this.SelectedRecordId, -1);
                        }
                        else
                        {
                            RunEdit(ActionType.None, SelectedRecordId, -1);
                        }
                        */
                    }
                }
                else
                {
                    RunEdit(ActionType.Add, -1, -1);
                }
            }
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
                    this.treeList.ExportToXls(this.saveFileDialog.FileName);
                }
                catch
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(this, "Не удалось сохранить файл.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        private void treeList_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {            
            if (e.Node.Level == 0)
            {
                e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, e.Appearance.Font.Size, FontStyle.Bold);
            }
        }

        private void treeList_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            if (e.Node.ParentNode == null)
            {
                if (e.Node.Expanded == false)
                {
                    e.NodeImageIndex = 0;
                }
                else
                {
                    e.NodeImageIndex = 1;
                }
            }
            else
            {
                e.NodeImageIndex = 2;
            }
        }

        private void treeList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F3)
            {
                this.treeList.DoIncrementalSearch(true);
            }
            else if (e.KeyData == (Keys.F3 | Keys.Shift))
            {
                this.treeList.DoIncrementalSearch(false);
            }
        }

        private void showSearchPanelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActivateControl();
        }

        private void searchStringRepositoryItemTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.barManager.ActiveEditItemLink.PostEditor();//без этого в EditValue содержится значение до редактирования
                BeginSearch(this.treeList.Nodes.FirstNode);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.searchStringBarEditItem.EditValue = string.Empty;
                //ClearFound();
            }
        }

        private void searchFromStartBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BeginSearch(this.treeList.Nodes.FirstNode);
        }

        private void searchNextBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BeginSearch(this.treeList.FocusedNode.HasChildren == true ? this.treeList.FocusedNode.Nodes.FirstNode : this.treeList.FocusedNode.NextVisibleNode);
        }


        //подъём на уровень выше
        private bool BeginSearch(TreeListNode node)
        {
            bool isFind = false;

            if (this.searchStringBarEditItem.EditValue != null && this.searchStringBarEditItem.EditValue.ToString().Length > 0)
            {
                node = SearchNodeInTree(this.searchStringBarEditItem.EditValue.ToString().ToUpper()
                    , node);

                if (node != null)
                {
                    this.treeList.SetFocusedNode(node);
                    isFind = true;
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(this, "Искомый текст не найден", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Введите текст для поиска", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return isFind;
        }

        //ищет заданную строку среди элементов дерева начиная с заданного элемента включительно
        private TreeListNode SearchNodeInTree(string searchString, TreeListNode startNode)
        {
            TreeListNode curNode = startNode;
            while (curNode != null)
            {
                //проверка на соответствие искомому
                if (curNode["department_name"].ToString().ToUpper().Contains(searchString) == true 
                    && (this.showArchiveBarButtonItem.Down == true || (bool)curNode["is_deleted_record"] == false))
                {
                    break;
                }

                //вглубь дашьше или выше со смещением дальше
                if (curNode.HasChildren)
                {
                    curNode = curNode.Nodes.FirstNode;
                }
                else if (curNode.NextNode == null)
                {
                    //подъём до уровня имеющего следующие элементы или на самый верхний уровень
                    while (curNode.ParentNode != null && curNode.ParentNode.NextNode == null)
                    {
                        curNode = curNode.ParentNode;
                    }
                    curNode = (curNode.ParentNode != null ? curNode.ParentNode.NextNode : null);
                }
                else
                {
                    curNode = curNode.NextNode;
                }
            }

            return curNode;
        }
    }
}
