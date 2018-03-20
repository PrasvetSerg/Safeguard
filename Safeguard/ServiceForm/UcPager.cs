using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Xml.Linq;

namespace Safeguard.ServiceForm
{
    public partial class UcPager : DevExpress.XtraEditors.XtraUserControl
    {
        readonly string idFieldName = "message_id";
        readonly string storedProcedureName = "usp_message_get";

        public enum DisplayMode
        {
            All,
            LastMonth,
            LastWeek,
            LastDay
        }

        private DisplayMode displayMode;
        DataTable dataTable;

        //перенести в конфигурационный файл
        int lastMessageId = -1;
        
        #region Constructors
        public UcPager()
        {
            InitializeComponent();
            this.Name = "ucPager";

            this.lastMessageId = LoadLastMessageId();

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

        #endregion

        #region Manage Form

        //активация элементов управления на форме
        private void ActivateControl()
        {
            this.ShowFindPanel = this.searchBarButtonItem.Down;

            if (this.dataTable != null)
            {
                this.refreshBarBtnItem.Enabled = true;
                /*
                this.addBarBtnItem.Enabled = this.ucDataList.IsAllowedAction(ActionType.Add);
                this.editBarBtnItem.Enabled = this.ucDataList.IsAllowedAction(ActionType.Edit);
                this.deleteBarBtnItem.Enabled = this.ucDataList.IsAllowedAction(ActionType.Remove);
                */
            }
            else
            {
                this.refreshBarBtnItem.Enabled = false;
                /*
                this.addBarBtnItem.Enabled = false;
                this.editBarBtnItem.Enabled = false;
                this.deleteBarBtnItem.Enabled = false;
                */
            }

            if (this.newMessageMemoEdit.EditValue != null && this.newMessageMemoEdit.EditValue.ToString().Trim().Length > 0)
            {
                this.sendNewMessageSimpleButton.Enabled = true;
            }
            else
            {
                this.sendNewMessageSimpleButton.Enabled = false;
            }


            if (this.displayMode == DisplayMode.LastDay)
            {
                this.lastDayBarButtonItem.Down = true;
                this.lastDayBarButtonItem.Appearance.Font = new Font(this.lastMonthBarButtonItem.Appearance.Font, FontStyle.Bold);
            }
            else
            {
                this.lastDayBarButtonItem.Down = false;
                this.lastDayBarButtonItem.Appearance.Font = new Font(this.lastMonthBarButtonItem.Appearance.Font, FontStyle.Regular);
            }

            if (this.displayMode == DisplayMode.LastWeek)
            {
                this.lastWeekBarButtonItem.Down = true;
                this.lastWeekBarButtonItem.Appearance.Font = new Font(this.lastMonthBarButtonItem.Appearance.Font, FontStyle.Bold);
            }
            else
            {
                this.lastWeekBarButtonItem.Down = false;
                this.lastWeekBarButtonItem.Appearance.Font = new Font(this.lastMonthBarButtonItem.Appearance.Font, FontStyle.Regular);
            }

            if (this.displayMode == DisplayMode.LastMonth)
            {
                this.lastMonthBarButtonItem.Down = true;
                this.lastMonthBarButtonItem.Appearance.Font = new Font(this.lastMonthBarButtonItem.Appearance.Font, FontStyle.Bold);
            }
            else
            {
                this.lastMonthBarButtonItem.Down = false;
                this.lastMonthBarButtonItem.Appearance.Font = new Font(this.lastMonthBarButtonItem.Appearance.Font, FontStyle.Regular);
            }

            if (this.displayMode == DisplayMode.All)
            {
                this.allBarButtonItem.Down = true;
                this.allBarButtonItem.Appearance.Font = new Font(this.lastMonthBarButtonItem.Appearance.Font, FontStyle.Bold);
            }
            else
            {
                this.allBarButtonItem.Down = false;
                this.allBarButtonItem.Appearance.Font = new Font(this.lastMonthBarButtonItem.Appearance.Font, FontStyle.Regular);
            }
        }

        public void ShowList(DisplayMode displayMode, int recordId)
        {
            this.displayMode = displayMode;
            ActivateControl();//Тоже под вопросом

            LoadSettings();

            string mode = "";
            switch (displayMode)
            {
                case DisplayMode.All:
                    mode = "all_view";
                    break;
                case DisplayMode.LastMonth:
                    mode = "last_month_view";
                    break;
                case DisplayMode.LastWeek:
                    mode = "last_week_view";
                    break;
                case DisplayMode.LastDay:
                    mode = "last_day_view";
                    break;
            }
            /*
            //общий фильтр для всех режимов отображения
            this.gridView.Columns["is_deleted_record"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo("is_deleted_record = False");
            */
            string query = string.Format("{0} '{1}',{2}"
                , this.storedProcedureName
                , mode
                , DBConnection.SqlQuery.IdToDbId(recordId)
                );
            UpdateData(query);

            if (recordId > 0)
            {
                SelectRow(recordId);
                /*//Поиск в архивных
                if (this.SelectedRecordId != recordId) //действительное не равно желаемому
                {
                    this.showArchiveBarButtonItem.Down = true;
                    ActivateControl();
                    SelectRow(recordId);
                }
                */
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
            //this.recordCountBarStaticItem.Caption = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).RowCount.ToString();
            SendEvent_RowSelected();//При поиске не происходит FocusedRowChanged, если результат отображается в той же выделенной строке
            //this.recordCountBarStaticItem.Caption = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).RowCount.ToString();
        }

        //
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ActivateControl();
            SendEvent_RowSelected();
            //SendEvent();
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
        
        public void LoadSettings()
        {
            string path = ServiceTypes.UserSettings.ProgramSettingsPath + this.Name.ToString() + this.displayMode.ToString() + ".xml";
            if (System.IO.File.Exists(path) == true)
            {
                this.gridControl.MainView.RestoreLayoutFromXml(path);
            }
        }

        public void SaveSettings()
        {
            //создание необходимой директории
            if (!System.IO.Directory.Exists(ServiceTypes.UserSettings.ProgramSettingsPath))
            {
                System.IO.Directory.CreateDirectory(ServiceTypes.UserSettings.ProgramSettingsPath);
            }

            string path = ServiceTypes.UserSettings.ProgramSettingsPath + this.Name.ToString() + this.displayMode.ToString() + ".xml";
            this.gridControl.MainView.SaveLayoutToXml(path);
        }

        public void ResetSettings()
        {
            string path = ServiceTypes.UserSettings.ProgramSettingsPath + this.Name.ToString() + this.displayMode.ToString() + ".xml";
            if (System.IO.File.Exists(path) == true)
            {
                System.IO.File.Delete(path);
            }
        }
        
        public int GetVisibleRowCount()
        {
            return this.gridView.DataRowCount;
        }

        //public delegate void DelegateFocuseRowChanged(int id);
        public delegate void DelegateFocuseRowChanged(DataRow row, int id);
        public event DelegateFocuseRowChanged FocusedRowChanged;
        protected void SendEvent_RowSelected()
        {
            if (FocusedRowChanged != null)
            {
                FocusedRowChanged(this.SelectedRecord, this.SelectedRecordId);
                //FocusedRowChanged(this.SelectedRecordId);
            }

            //SendEvent_FocusedRowChanged();
        }
        #endregion

        private void sendNewMessageSimpleButton_Click(object sender, EventArgs e)
        {
            if (this.newMessageMemoEdit.EditValue != null && this.newMessageMemoEdit.EditValue.ToString().Trim().Length > 0)
            {
                string query = string.Format("usp_message_set {0},{1}"
                    , DBConnection.SqlQuery.ActionTypeToDbString(ServiceTypes.ActionType.Add)
                    , DBConnection.SqlQuery.StrToDbString(this.newMessageMemoEdit.EditValue.ToString()));
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);

                if (dataTable != null && dataTable.Rows.Count == 1)
                {
                    this.newMessageMemoEdit.EditValue = null;
                    UpdateData(this.lastQuery);
                    SelectRow((int)dataTable.Rows[0][0]);
                }
            }
        }

        private void newMessageMemoEdit_EditValueChanged(object sender, EventArgs e)
        {
            ActivateControl();
        }

        private void refreshBarBtnItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateData(this.lastQuery);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActivateControl();
        }

        private void lastDayBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeShownPeriod(DisplayMode.LastDay);
        }

        private void lastWeekBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeShownPeriod(DisplayMode.LastWeek);
        }

        private void lastMonthBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeShownPeriod(DisplayMode.LastMonth);
        }

        private void allBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeShownPeriod(DisplayMode.All);
        }

        private void ChangeShownPeriod(DisplayMode newDisplayMode)
        {
            if (newDisplayMode != this.displayMode)
            {
                ShowList(newDisplayMode, this.SelectedRecordId);
            }
            else
            {
                ActivateControl();
            }
        }

        public int GetNewMessage()
        {
            int newMessageCount = 0;
            string query = string.Format("usp_message_get 'new_message_view',{0}"
                , this.lastMessageId
                );

            DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);
            if (dataTable != null)
            {
                newMessageCount = dataTable.Rows.Count;

                foreach (DataRow row in dataTable.Rows)
                {
                    this.alertControl.Show(this.ParentForm, (string)row["user_name_update"], (string)row["message"],null,this.messageTypeImageCollection.Images[0],(int)row["message_id"]);
                }
            }

            return newMessageCount;
        }

        public void StartTimer(int tick)
        {
            this.timer.Interval = tick;
            this.timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (GetNewMessage() > 0 && this.lastQuery != null && this.lastQuery.Length > 0)
            {
                UpdateData(lastQuery);
            }
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ;
        }

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            ;
            //this.gridView.getrow
            //this.gridView.GetVisibleIndex();
            //this.gridView.IsLastVisibleRow;
            //this.gridView.IsRowVisible;
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0) 
            {
                int id = (int)this.gridView.GetRowCellValue(e.RowHandle, this.idGridColumn);
                if (this.lastMessageId < id)
                {
                    this.lastMessageId = id;
                    SaveLastMessageId(id);
                }
            }
        }

        private void SaveLastMessageId(int lastMessageId)
        {
            if (!System.IO.Directory.Exists(ServiceTypes.UserSettings.ProgramSettingsPath))
            {
                System.IO.Directory.CreateDirectory(ServiceTypes.UserSettings.ProgramSettingsPath);
            }

            string path = ServiceTypes.UserSettings.ProgramSettingsPath + this.Name.ToString() + "_Pager.xml";

            XDocument xd;
            if (System.IO.File.Exists(path) == true)
            {
                xd = XDocument.Load(path);

                if (xd != null && xd.Root != null)
                {

                    foreach (XElement el in xd.Root.Elements("Settings"))
                    {
                        if (el.Attribute("ModuleName").Value == this.Name)
                        {
                            if (el.Element("lastMessageId") != null)
                            {
                                el.Element("lastMessageId").SetValue(lastMessageId.ToString());
                            }
                            else
                            {
                                el.Add(new XElement("lastMessageId", lastMessageId.ToString()));
                            }
                        }
                    }
                }
            }
            else
            {
                xd = new XDocument(new XElement("Safeguard"));
                
                xd.Root.Add(new XElement("Settings",
                    new XAttribute("ModuleName", this.Name),
                    new XElement("lastMessageId", lastMessageId.ToString()))
                    );
            }

            xd.Save(path);
        }

        private int LoadLastMessageId()
        {
            int lastMessageId = -1;

            string path = ServiceTypes.UserSettings.ProgramSettingsPath + this.Name.ToString() + "_Pager.xml";
            if (System.IO.File.Exists(path) == true)
            {
                XDocument xd = XDocument.Load(path);

                foreach (XElement el in xd.Root.Elements("Settings"))
                {
                    if (el.Attribute("ModuleName").Value == this.Name)
                    {
                        lastMessageId = int.Parse(el.Element("lastMessageId").Value);
                    }
                }
            }
            
            return lastMessageId;
        }

        public delegate void DelegateMessageSelected(int id);
        public event DelegateMessageSelected MessageSelected;
        protected void SendEvent_MessageSelected(int id)
        {
            if (MessageSelected != null)
            {
                MessageSelected(id);
            }
        }

        private void alertControl_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e)
        {
            //e.ActivateOwner = true;
            SendEvent_MessageSelected((int)e.Info.Tag);
        }

        private void helpBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Help.ShowHelp(this, "http://soft.lan.naftan.by/Safeguard/HTML-help/index.html?pager.htm");
        }
    }
}
