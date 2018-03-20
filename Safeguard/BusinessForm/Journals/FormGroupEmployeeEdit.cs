using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ServiceTypes;

namespace Safeguard.BusinessForm.Journals
{
    public partial class FormGroupEmployeeEdit : DevExpress.XtraEditors.XtraForm
    {
        ActionType actionType;
        int recordId;
        int parentRecordId;
        int relativePosition;

        public FormGroupEmployeeEdit(ServiceTypes.ActionType actionType = ActionType.None, int recordId = -1, int parentId = -1, int relativePosition = 999)
        {
            this.actionType = actionType;
            this.recordId = recordId;
            this.parentRecordId = parentId;
            this.relativePosition = relativePosition;

            InitializeComponent();
        }
        
        #region Properties
        /// <summary>
        /// Gets a editing record ID shn object
        /// </summary>
        public int RecordId
        {
            get { return this.recordId; }
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

            Cursor.Current = currentCursor;
        }

        //загрузка рабочих данных
        private void UpdateDataOnForm()
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            if (this.recordId > 0)
            {
                //чтение рабочих данных
                //заполнение рабочих элементов
                DataTable dataTable = DBConnection.SqlQuery.ReadData(this, string.Format("dtr_group_employee_get 'by_group_employee_id',{0}", this.RecordId));

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    this.idTextEdit.Text = dataTable.Rows[0]["group_employee_id"].ToString();
                    //this.parentRecordId = (dataTable.Rows[0]["parent_group_employee_id"] == DBNull.Value ? -1 : (int)dataTable.Rows[0]["parent_group_employee_id"]);
                    this.groupDataSelectOutOfPlace.RecordId = (dataTable.Rows[0]["group_id"] == DBNull.Value ? -1 : (int)dataTable.Rows[0]["group_id"]);
                    this.employeeDataSelectOutOfPlace.RecordId = (dataTable.Rows[0]["employee_id"] == DBNull.Value ? -1 : (int)dataTable.Rows[0]["employee_id"]);

                    this.useFromDateEdit.EditValue = dataTable.Rows[0]["use_from_date"];
                    this.useToDateEdit.EditValue = dataTable.Rows[0]["use_to_date"];

                    this.commentTextEdit.Text = dataTable.Rows[0]["comment"].ToString();
                    //this.sequenceTextEdit.Text = dataTable.Rows[0]["sequence"].ToString();
                }
            }
            else
            {
                this.sequenceTextEdit.Text = relativePosition.ToString();
            }

            ActivateControl();

            Cursor.Current = currentCursor;
        }

        //активация элементов управления на форме
        private void ActivateControl()
        {
            this.idTextEdit.Properties.ReadOnly = true;
            this.idTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            
            if (this.actionType == ActionType.Add)
            {
                this.Text = "Регистрация новогй принадлежности сотрудника к группе";

                this.groupDataSelectOutOfPlace.ReadOnly = false;
                this.employeeDataSelectOutOfPlace.ReadOnly = false;
                this.useFromDateEdit.Properties.ReadOnly = false;
                this.useFromDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.useToDateEdit.Properties.ReadOnly = false;
                this.useToDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.commentTextEdit.Properties.ReadOnly = false;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.sequenceTextEdit.Properties.ReadOnly = false;
                this.sequenceTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
            else if (this.actionType == ActionType.Edit && this.RecordId > 0)
            {
                this.Text = "Редактирование информации о принадлежности";

                this.groupDataSelectOutOfPlace.ReadOnly = true;
                this.employeeDataSelectOutOfPlace.ReadOnly = true;
                this.useFromDateEdit.Properties.ReadOnly = false;
                this.useFromDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.useToDateEdit.Properties.ReadOnly = false;
                this.useToDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.commentTextEdit.Properties.ReadOnly = false;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.sequenceTextEdit.Properties.ReadOnly = false;
                this.sequenceTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
            else if (this.actionType == ActionType.Remove && this.RecordId > 0)
            {
                this.Text = "Удаление текущей записи";
                this.actionButton.Text = "Удалить";

                this.groupDataSelectOutOfPlace.ReadOnly = true;
                this.employeeDataSelectOutOfPlace.ReadOnly = true;
                this.useFromDateEdit.Properties.ReadOnly = true;
                this.useFromDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.useToDateEdit.Properties.ReadOnly = true;
                this.useToDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.sequenceTextEdit.Properties.ReadOnly = true;
                this.sequenceTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.commentTextEdit.Properties.ReadOnly = false;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
            else
            {
                this.Text = "Просмотр текущей записи";
                this.actionButton.Enabled = false;

                this.groupDataSelectOutOfPlace.ReadOnly = true;
                this.employeeDataSelectOutOfPlace.ReadOnly = true;
                this.useFromDateEdit.Properties.ReadOnly = true;
                this.useFromDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.useToDateEdit.Properties.ReadOnly = true;
                this.useToDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.sequenceTextEdit.Properties.ReadOnly = true;
                this.sequenceTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.commentTextEdit.Properties.ReadOnly = true;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            }
        }


        //изменение подрядчика
        private void groupDataSelectOutOfPlace_ButtonSelectClick(DevExpress.XtraEditors.XtraUserControl control)
        {
            Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace;

            //using (Safeguard._FormPaymentTypeList formList = new Safeguard._FormPaymentTypeList(this.paymentTypeDataSelectOutOfPlace.RecordId))
            using (Safeguard.BusinessForm.Catalogs.FormGroupManager formList = new Safeguard.BusinessForm.Catalogs.FormGroupManager(true, dataSelectOutOfPlace.RecordId))
            {
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                    dataSelectOutOfPlace.RecordId = formList.SelectedRecordId;
                }
            }
        }

        private void groupDataSelectOutOfPlace_RecordIdChanged(DevExpress.XtraEditors.XtraUserControl control, int recordId)
        {
            if (recordId > 0)
            {
                string query = string.Format(string.Format("dtr_group_get 'by_group_id',{0}", recordId));
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);

                this.groupDataSelectOutOfPlace.ShownText = string.Format("{0}", dataTable.Rows[0]["group_name"].ToString());
            }
            else
            {
                this.groupDataSelectOutOfPlace.ShownText = "";
            }
            EditValueChanged(control as object, null);
        }

        //изменение подрядчика
        private void employeeDataSelectOutOfPlace_ButtonSelectClick(DevExpress.XtraEditors.XtraUserControl control)
        {
            Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace;

            //using (Safeguard._FormPaymentTypeList formList = new Safeguard._FormPaymentTypeList(this.paymentTypeDataSelectOutOfPlace.RecordId))
            using (Safeguard.BusinessForm.Catalogs.FormEmployeeManager formList = new Safeguard.BusinessForm.Catalogs.FormEmployeeManager(true, dataSelectOutOfPlace.RecordId))
            {
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                    dataSelectOutOfPlace.RecordId = formList.SelectedRecordId;
                }
            }
        }

        private void employeeDataSelectOutOfPlace_RecordIdChanged(DevExpress.XtraEditors.XtraUserControl control, int recordId)
        {
            if (recordId > 0)
            {
                string query = string.Format(string.Format("dtr_employee_get 'by_employee_id',{0}", recordId));
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);

                this.employeeDataSelectOutOfPlace.ShownText = string.Format("{0}", dataTable.Rows[0]["employee_name"].ToString());
            }
            else
            {
                this.employeeDataSelectOutOfPlace.ShownText = "";
            }
            EditValueChanged(control as object, null);
        }

        bool isDataNeedSaving = false;
        private void EditValueChanged(object sender, EventArgs e)
        {
            this.isDataNeedSaving = true;
        }
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
            if (isInputedDataValid == true && (this.groupDataSelectOutOfPlace.RecordId < 1))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Заполните группу", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && (this.employeeDataSelectOutOfPlace.RecordId < 1))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Задайте сотрудника", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && this.useFromDateEdit.EditValue == null)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Задайте дату с", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isInputedDataValid;
        }
        
        //запись в базу данных с формы
        private bool SaveData()
        {
            bool isSavedData = false;

            string query = string.Concat("dtr_group_employee_set"
                , " @command=" + DBConnection.SqlQuery.ActionTypeToDbString(this.actionType)
                , ",@group_employee_id=" + this.RecordId
                , ",@group_id=" + this.groupDataSelectOutOfPlace.RecordId
                , ",@employee_id=" + this.employeeDataSelectOutOfPlace.RecordId
                , ",@use_from_date=" + DBConnection.SqlQuery.StrToDbString(this.useFromDateEdit.Text)
                , ",@use_to_date=" + DBConnection.SqlQuery.StrToDbString(this.useToDateEdit.Text)
                , ",@comment=" + DBConnection.SqlQuery.StrToDbString(this.commentTextEdit.Text.Trim())
                //, ",@sequence=" + this.sequenceTextEdit.Text.ToString()
                );

            try
            {
                DataTable dataTable = DBConnection.SqlQuery.RunTableQuery(query);
                if (dataTable.Rows.Count == 1)
                {
                    isSavedData = true;

                    this.recordId = (int)dataTable.Rows[0]["group_employee_id"];
                }
            }
            catch (SqlException exception)
            {
                ExceptionHandler.Handler.ProcessSqlException(this, exception);
            }
            return isSavedData;
        }
        #endregion

    }
}
