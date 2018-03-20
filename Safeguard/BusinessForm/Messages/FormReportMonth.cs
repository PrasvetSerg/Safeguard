using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using ServiceTypes;

namespace Safeguard.BusinessForm.Messages
{
    //ТИП FEDIT4+
    public partial class FormReportMonth : DevExpress.XtraEditors.XtraForm
    {
        //ActionType actionType;
        //int recordId;

        public enum DisplayMode
        {
            YearMonth,
            YearQuartal
        }

        DisplayMode displayMode;

        public FormReportMonth()
            : this(DisplayMode.YearMonth)
        {
            ;
        }

        public FormReportMonth(DisplayMode mode) 
        {
            InitializeComponent();

            this.displayMode = mode;
        }
        
        #region Properties
        /*
        /// <summary>
        /// Gets a editing record ID shn object
        /// </summary>
        public int RecordId
        {
            get { return this.recordId; }
        }
        */
        
        public DateTime Period
        {
            get 
            {
                DateTime period = this.periodDateEdit.DateTime;

                if (this.displayMode == DisplayMode.YearQuartal)
                {
                    period = new DateTime(this.yearDateEdit.DateTime.Year, 1 + 3*((int)this.quartalImageComboBoxEdit.EditValue-1),1);
                }

                return period; 
            }
        }

        public int RenterGroupId
        {
            get { return this.renterDataSelectOutOfPlace.RecordId; }
        }

        public int CallServiceId
        {
            get { return this.callServiceDataSelectOutOfPlace.RecordId; }
        }

        public int NdsServiceId
        {
            get { return this.ndsServiceDataSelectOutOfPlace.RecordId; }
        }
        #endregion
        
        #region Form management
        //заполнение данных при отображении формы
        private void FormEdit_Shown(object sender, EventArgs e)
        {
            InitControl();

            UpdateDataOnForm();
        }

        //загрузка данных в селекторы
        private void InitControl()
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            //TODO: загрузить данные в контролы
            if (this.displayMode == DisplayMode.YearMonth)
            {
                this.periodDateEdit.Visible = this.periodLabelControl.Visible = true;
            }
            else if (this.displayMode == DisplayMode.YearQuartal)
            {
                this.yearDateEdit.Visible = this.yearLabelControl.Visible = true;
                this.quartalImageComboBoxEdit.Visible = this.quartalLabelControl.Visible = true;
            }

            Cursor.Current = currentCursor;
        }

        //загрузка рабочих данных
        private void UpdateDataOnForm()
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            //if (this.recordId > 0)
            {
                this.periodDateEdit.DateTime = DateTime.Now.Date.AddMonths(0);

                this.yearDateEdit.EditValue = DateTime.Now.Date;
                this.quartalImageComboBoxEdit.EditValue = 1;
                /*
                this.renterDataSelectOutOfPlace.RecordId = 2;
                this.callServiceDataSelectOutOfPlace.RecordId = 6;
                this.ndsServiceDataSelectOutOfPlace.RecordId = 2;
                 * */
                /*
                //чтение рабочих данных
                //заполнение рабочих элементов
                DataTable dataTable = DBConnection.SqlQuery.ReadData(this, string.Format("dtr_ats_tariff_get 'by_ats_tariff_id',{0}", this.RecordId));

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    this.idTextEdit.Text = dataTable.Rows[0]["ats_tariff_id"].ToString();

                    this.nameTextEdit.Text = dataTable.Rows[0]["ats_tariff_name"].ToString();                    
                    this.commentTextEdit.Text = dataTable.Rows[0]["comment"].ToString();

                    this.publicationDateEdit.EditValue = dataTable.Rows[0]["publication_date"];
                    this.expirationDateEdit.EditValue = dataTable.Rows[0]["expiration_date"] == DBNull.Value ? null : dataTable.Rows[0]["expiration_date"];
                }
                */
            }

            ActivateControl();

            Cursor.Current = currentCursor;
        }

        //активация элементов управления на форме
        private void ActivateControl()
        {
            /*
            if (this.actionType == ActionType.Add)
            {
                this.Text = "Регистрация нового тарифа";

                this.nameTextEdit.Properties.ReadOnly = false;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.commentTextEdit.Properties.ReadOnly = false;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;

                this.publicationDateEdit.Properties.ReadOnly = false;
                this.publicationDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.expirationDateEdit.Properties.ReadOnly = false;
                this.expirationDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
            else if (this.actionType == ActionType.Edit && this.RecordId > 0)
            {
                this.Text = "Редактирование информации о тарифе";

                this.nameTextEdit.Properties.ReadOnly = true;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.commentTextEdit.Properties.ReadOnly = false;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;

                this.publicationDateEdit.Properties.ReadOnly = true;
                this.publicationDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.expirationDateEdit.Properties.ReadOnly = false;
                this.expirationDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
            else if (this.actionType == ActionType.Archive && this.RecordId > 0)
            {
                this.Text = "Прекращение действия записи";

                this.actionButton.Text = "В архив";
                this.nameTextEdit.Properties.ReadOnly = true;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.commentTextEdit.Properties.ReadOnly = true;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

                this.publicationDateEdit.Properties.ReadOnly = true;
                this.publicationDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.expirationDateEdit.Properties.ReadOnly = true;
                this.expirationDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            }
            else if (this.actionType == ActionType.Remove && this.RecordId > 0)
            {
                this.Text = "Удаление текущей записи";

                this.actionButton.Text = "Удалить";
                this.nameTextEdit.Properties.ReadOnly = true;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.commentTextEdit.Properties.ReadOnly = true;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

                this.publicationDateEdit.Properties.ReadOnly = true;
                this.publicationDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.expirationDateEdit.Properties.ReadOnly = true;
                this.expirationDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            }
            else
            {
                this.Text = "Просмотр текущей записи";
                this.actionButton.Enabled = false;

                this.nameTextEdit.Properties.ReadOnly = true;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.commentTextEdit.Properties.ReadOnly = true;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

                this.publicationDateEdit.Properties.ReadOnly = true;
                this.publicationDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.expirationDateEdit.Properties.ReadOnly = true;
                this.expirationDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            }
             * */
        }
        /*
        //выбор группы аренды
        private void renterGroupDataSelectOutOfPlace_ButtonSelectClick(DevExpress.XtraEditors.XtraUserControl control)
        {
            ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace;

            using (FormTariffList formList = new FormTariffList(true, dataSelectOutOfPlace.RecordId))
            {
                formList.ShowRateList = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                    dataSelectOutOfPlace.RecordId = formList.SelectedRecordId;
                }
            }
        }

        private void renterGroupDataSelectOutOfPlace_RecordIdChanged(DevExpress.XtraEditors.XtraUserControl control, int recordId)
        {
            ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace;

            if (recordId > 0)
            {
                string query = string.Format(string.Format("dtr_renter_get 'by_renter_id',{0}", recordId));
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);

                dataSelectOutOfPlace.ShownText = string.Format("{0}", dataTable.Rows[0]["renter_name"].ToString());
            }
            else
            {
                dataSelectOutOfPlace.ShownText = "";
            }
            
            ActivateControl();
        }

        //выбор услуги
        private void serviceDataSelectOutOfPlace_ButtonSelectClick(DevExpress.XtraEditors.XtraUserControl control)
        {
            ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace;

            using (FormServiceList formList = new FormServiceList(true, dataSelectOutOfPlace.RecordId))
            {
                formList.ShowRateList = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                    dataSelectOutOfPlace.RecordId = formList.SelectedRecordId;
                }
            }
        }

        private void serviceDataSelectOutOfPlace_RecordIdChanged(DevExpress.XtraEditors.XtraUserControl control, int recordId)
        {
            ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace;

            if (recordId > 0)
            {
                string query = string.Format(string.Format("dtr_ats_service_get 'by_ats_service_id',{0}", recordId));
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);

                dataSelectOutOfPlace.ShownText = string.Format("{0}", dataTable.Rows[0]["ats_service_name"].ToString());
            }
            else
            {
                dataSelectOutOfPlace.ShownText = "";
            }

            ActivateControl();
        }
         * */
        #endregion

        #region User Action
        //перенос фокус по кнопке ввода
        private void MoveFocesToNextControlIfEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //передача фокуса следующему контролу
                this.SelectNextControl(ActiveControl, true, true, true, true);

                //блокировка вставки символа перевода строки в поле MemoEdit
                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #region Save data
        //фиксация результата изменения данных
        private void actionButton_Click(object sender, EventArgs e)
        {
            //созранить данные
            
            this.DialogResult = DialogResult.None;

            //запись данных в базу
            if (IsInputedDataValid() == true)
            {
                if (SaveData())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(this, "Выполнить изменение не удалось. Попробуйте позже.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        //проверка введённых данных
        private bool IsInputedDataValid()
        {
            bool isInputedDataValid = true;

            //проверка введёных данных

            if (isInputedDataValid == true && (this.periodDateEdit.Text.Length < 3))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Задайте расчётный период", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return isInputedDataValid;
        }
        
        //запись в базу данных с формы
        private bool SaveData()
        {
            bool isSavedData = false; 
            
            isSavedData = true;
            /*
            string query = string.Format("dtr_ats_tariff_set {0},{1},{2},{3},{4},{5}"
                , DBConnection.SqlQuery.ActionTypeToDbString(this.actionType)
                , this.RecordId
                , DBConnection.SqlQuery.StrToDbString(this.nameTextEdit.Text.Trim())
                , DBConnection.SqlQuery.StrToDbString(this.commentTextEdit.Text.Trim())
                , DBConnection.SqlQuery.StrToDbString(this.publicationDateEdit.Text)
                , DBConnection.SqlQuery.StrToDbString(this.expirationDateEdit.EditValue != null ? this.expirationDateEdit.DateTime.ToString() : "")
                );

            try
            {
                DataTable dataTable = DBConnection.SqlQuery.RunTableQuery(query);
                if (dataTable.Rows.Count == 1)
                {
                    isSavedData = true;

                    this.recordId = (int)dataTable.Rows[0]["ats_tariff_id"];
                }
            }
            catch (SqlException exception)
            {
                ExceptionHandler.Handler.ProcessSqlException(this, exception);
            }
             * */
            return isSavedData;
        }
        #endregion

        private void publicationDateEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != null && ((DateTime)e.NewValue).Day != 1)
            {
                e.NewValue = ((DateTime)e.NewValue).AddDays(1.0 - ((DateTime)e.NewValue).Day);
            }
        }
    }
}
