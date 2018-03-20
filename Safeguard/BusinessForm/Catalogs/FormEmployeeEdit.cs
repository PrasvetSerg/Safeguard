﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ServiceTypes;

namespace Safeguard.BusinessForm.Catalogs
{
    public partial class FormEmployeeEdit : DevExpress.XtraEditors.XtraForm
    {
        ActionType actionType;
        int recordId;
        int parentRecordId;
        int relativePosition;

        public FormEmployeeEdit(ServiceTypes.ActionType actionType = ActionType.None, int recordId = -1, int parentId = -1, int relativePosition = 999)
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
                DataTable dataTable = DBConnection.SqlQuery.ReadData(this, string.Format("dtr_employee_get 'by_employee_id',{0}", this.RecordId));

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    this.idTextEdit.Text = dataTable.Rows[0]["employee_id"].ToString();
                    //this.parentRecordId = (dataTable.Rows[0]["parent_employee_id"] == DBNull.Value ? -1 : (int)dataTable.Rows[0]["parent_employee_id"]);
                    this.nameTextEdit.Text = dataTable.Rows[0]["employee_name"].ToString();
                    this.postDataSelectOutOfPlace.RecordId = (dataTable.Rows[0]["post_id"] == DBNull.Value ? -1 : (int)dataTable.Rows[0]["post_id"]);
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
                this.Text = "Регистрация нового сотрудника";

                this.nameTextEdit.Properties.ReadOnly = false;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.postDataSelectOutOfPlace.ReadOnly = false;
                this.commentTextEdit.Properties.ReadOnly = false;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.sequenceTextEdit.Properties.ReadOnly = false;
                this.sequenceTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
            else if (this.actionType == ActionType.Edit && this.RecordId > 0)
            {
                this.Text = "Редактирование информации о сотруднике";

                this.nameTextEdit.Properties.ReadOnly = false;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.postDataSelectOutOfPlace.ReadOnly = false;
                this.commentTextEdit.Properties.ReadOnly = false;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.sequenceTextEdit.Properties.ReadOnly = false;
                this.sequenceTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
            else if (this.actionType == ActionType.Remove && this.RecordId > 0)
            {
                this.Text = "Удаление текущей записи";
                this.actionButton.Text = "Удалить";

                this.nameTextEdit.Properties.ReadOnly = true;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.postDataSelectOutOfPlace.ReadOnly = true;
                this.sequenceTextEdit.Properties.ReadOnly = true;
                this.sequenceTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.commentTextEdit.Properties.ReadOnly = false;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
            else
            {
                this.Text = "Просмотр текущей записи";
                this.actionButton.Enabled = false;

                this.nameTextEdit.Properties.ReadOnly = true;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.postDataSelectOutOfPlace.ReadOnly = true;
                this.sequenceTextEdit.Properties.ReadOnly = true;
                this.sequenceTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.commentTextEdit.Properties.ReadOnly = true;
                this.commentTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            }
        }


        //изменение подрядчика
        private void steelDataSelectOutOfPlace_ButtonSelectClick(DevExpress.XtraEditors.XtraUserControl control)
        {
            Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace;

            //using (Safeguard._FormPaymentTypeList formList = new Safeguard._FormPaymentTypeList(this.paymentTypeDataSelectOutOfPlace.RecordId))
            using (Safeguard.BusinessForm.Catalogs.FormPostManager formList = new Safeguard.BusinessForm.Catalogs.FormPostManager(true, dataSelectOutOfPlace.RecordId))
            {
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                    dataSelectOutOfPlace.RecordId = formList.SelectedRecordId;
                }
            }
        }

        private void steelDataSelectOutOfPlace_RecordIdChanged(DevExpress.XtraEditors.XtraUserControl control, int recordId)
        {
            if (recordId > 0)
            {
                string query = string.Format(string.Format("dtr_post_get 'by_post_id',{0}", recordId));
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);

                this.postDataSelectOutOfPlace.ShownText = string.Format("{0}", dataTable.Rows[0]["post_name"].ToString());
            }
            else
            {
                this.postDataSelectOutOfPlace.ShownText = "";
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
            if (isInputedDataValid == true && (this.nameTextEdit.Text.Length < 1))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Заполните поле наименования", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && (this.postDataSelectOutOfPlace.RecordId < 1))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Задайте должность", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && (this.nameTextEdit.Text.Length < 1))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Заполните поле Последовательность", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isInputedDataValid;
        }
        
        //запись в базу данных с формы
        private bool SaveData()
        {
            bool isSavedData = false;

            string query = string.Concat("dtr_employee_set"
                , " @command=" + DBConnection.SqlQuery.ActionTypeToDbString(this.actionType)
                , ",@employee_id=" + this.RecordId
                //, ",@parent_employee_id=" + DBConnection.SqlQuery.IdToDbId(this.parentRecordId)
                , ",@employee_name=" + DBConnection.SqlQuery.StrToDbString(this.nameTextEdit.Text.Trim())
                , ",@post_id=" + DBConnection.SqlQuery.IdToDbId(this.postDataSelectOutOfPlace.RecordId)
                , ",@comment=" + DBConnection.SqlQuery.StrToDbString(this.commentTextEdit.Text.Trim())
                //, ",@sequence=" + this.sequenceTextEdit.Text.ToString()
                );

            try
            {
                DataTable dataTable = DBConnection.SqlQuery.RunTableQuery(query);
                if (dataTable.Rows.Count == 1)
                {
                    isSavedData = true;

                    this.recordId = (int)dataTable.Rows[0]["employee_id"];
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
