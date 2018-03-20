using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ServiceTypes;
using System.Collections.Generic;

using System.Xml.Serialization;
using Safeguard.BusinessObjects;

namespace Safeguard.BusinessForm.Journals
{
    public partial class FormOffenseEdit : DevExpress.XtraEditors.XtraForm
    {
        ActionType actionType;
        int recordId;
        int parentRecordId;
        int relativePosition;

        public FormOffenseEdit(ServiceTypes.ActionType actionType = ActionType.None, int recordId = -1, int parentId = -1, int relativePosition = 999)
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
                DataTable dataTable = DBConnection.SqlQuery.ReadData(this, string.Format("dtr_offense_get 'by_offense_id',{0}", this.RecordId));

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    if (this.actionType == ActionType.Copy)
                    {
                        this.actionType = ActionType.Add;
                    }
                    else
                    {
                        this.idTextEdit.Text = dataTable.Rows[0]["offense_id"].ToString();
                    }

                    this.talonNumberTextEdit.Text = dataTable.Rows[0]["talon_number"].ToString();
                    this.offenseDateEdit.EditValue = dataTable.Rows[0]["offense_datetime"];
                    this.kppDataSelectOutOfPlace.RecordId = (int)dataTable.Rows[0]["kpp_id"];

                    this.offenseTypeDataSelectOutOfPlace.RecordId = (int)dataTable.Rows[0]["offense_type_id"];// (dataTable.Rows[0]["offense_id"] == DBNull.Value ? -1 : (int)dataTable.Rows[0]["instrument_id"]);

                    this.employeeDataSelectOutOfPlace.RecordId = (int)dataTable.Rows[0]["employee_id"];
                    this.offenseTypeDataSelectOutOfPlace.RecordId = (int)dataTable.Rows[0]["offense_type_id"];

                    this.offenseCommentMemoEdit.EditValue = dataTable.Rows[0]["offense_comment"];
                    this.actTextEdit.Text = dataTable.Rows[0]["act_number"].ToString();
                    this.offenseResultMemoEdit.EditValue = dataTable.Rows[0]["offense_result"];

                    this.offenderDataSelectOutOfPlace.RecordId = (int)dataTable.Rows[0]["offender_id"];
                    this.organizationDataSelectOutOfPlace.RecordId = (dataTable.Rows[0]["organization_id"] == DBNull.Value ? -1 : (int)dataTable.Rows[0]["organization_id"]);
                    this.commentMemoEdit.Text = dataTable.Rows[0]["comment"].ToString();
                }
            }
            else
            {
                this.offenseDateEdit.EditValue = DateTime.Now;
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
                this.Text = "Регистрация нового факта правонарушения";

                this.offenseDateEdit.Properties.ReadOnly = false;
                this.offenseDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.offenseDateEdit.Properties.Buttons[0].Visible = true;
                this.kppDataSelectOutOfPlace.ReadOnly = false;

                this.offenseCommentMemoEdit.Enabled = true;
                this.offenseResultMemoEdit.Enabled = true;
            }
            else if (this.actionType == ActionType.Edit && this.RecordId > 0)
            {
                this.Text = "Редактирование информации о правонарушении";

                this.offenseDateEdit.Properties.ReadOnly = false;
                this.offenseDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.offenseDateEdit.Properties.Buttons[0].Visible = true;
                this.kppDataSelectOutOfPlace.ReadOnly = false;

                this.offenseCommentMemoEdit.Enabled = true;
                this.offenseResultMemoEdit.Enabled = true;
            }
            else if (this.actionType == ActionType.Remove && this.RecordId > 0)
            {
                this.Text = "Удаление текущей записи";
                this.actionButton.Text = "Удалить";

                this.offenseDateEdit.Properties.ReadOnly = true;
                this.offenseDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.offenseDateEdit.Properties.Buttons[0].Visible = false;
                this.kppDataSelectOutOfPlace.ReadOnly = true;

                this.offenseCommentMemoEdit.Enabled = false;
                this.showReasonListSimpleButton.Enabled = false;
                this.offenseResultMemoEdit.Enabled = false;
                this.showPenaltyListSimpleButton.Enabled = false;
            }
            else
            {
                this.Text = "Просмотр текущей записи";
                this.actionButton.Enabled = false;

                this.offenseDateEdit.Properties.ReadOnly = true;
                this.offenseDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.offenseDateEdit.Properties.Buttons[0].Visible = false;
                this.kppDataSelectOutOfPlace.ReadOnly = true;

                this.offenseCommentMemoEdit.Enabled = false;
                this.showReasonListSimpleButton.Enabled = false;
                this.offenseResultMemoEdit.Enabled = false;
                this.showPenaltyListSimpleButton.Enabled = false;
            }
        }
        
        private void kppDataSelectOutOfPlace_ButtonSelectClick(DevExpress.XtraEditors.XtraUserControl control)
        {
            Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace;

            //using (Safeguard._FormPaymentTypeList formList = new Safeguard._FormPaymentTypeList(this.paymentTypeDataSelectOutOfPlace.RecordId))
            using (Safeguard.BusinessForm.Catalogs.FormKppManager formList = new Safeguard.BusinessForm.Catalogs.FormKppManager(true, dataSelectOutOfPlace.RecordId))
            {
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                    dataSelectOutOfPlace.RecordId = formList.SelectedRecordId;
                }
            }
        }

        private void kppDataSelectOutOfPlace_RecordIdChanged(DevExpress.XtraEditors.XtraUserControl control, int recordId)
        {
            if (recordId > 0)
            {
                string query = string.Format(string.Format("dtr_kpp_get 'by_kpp_id',{0}", recordId));
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);

                this.kppDataSelectOutOfPlace.ShownText = string.Format("{0}", dataTable.Rows[0]["kpp_name"].ToString());
            }
            else
            {
                this.kppDataSelectOutOfPlace.ShownText = "";
            }
            EditValueChanged(control as object, null);
        }

        
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
            Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace;

            if (recordId > 0)
            {
                string query = string.Format(string.Format("dtr_employee_get 'by_employee_id',{0}", recordId));
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);

                dataSelectOutOfPlace.ShownText = string.Format("{0}", dataTable.Rows[0]["employee_name"].ToString());
            }
            else
            {
                dataSelectOutOfPlace.ShownText = "";
            }
            EditValueChanged(control as object, null);
        }

        private void offenderDataSelectOutOfPlace_ButtonSelectClick(DevExpress.XtraEditors.XtraUserControl control)
        {
            Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace;

            //using (Safeguard._FormPaymentTypeList formList = new Safeguard._FormPaymentTypeList(this.paymentTypeDataSelectOutOfPlace.RecordId))
            using (Safeguard.BusinessForm.Catalogs.FormOffenderManager formList = new Safeguard.BusinessForm.Catalogs.FormOffenderManager(true, dataSelectOutOfPlace.RecordId))
            {
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                    dataSelectOutOfPlace.RecordId = formList.SelectedRecordId;
                }
            }
        }

        private void offenderDataSelectOutOfPlace_RecordIdChanged(DevExpress.XtraEditors.XtraUserControl control, int recordId)
        {
            Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace;

            if (recordId > 0)
            {
                string query = string.Format(string.Format("dtr_offender_get 'by_offender_id',{0}", recordId));
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);

                dataSelectOutOfPlace.ShownText = string.Format("{0}", dataTable.Rows[0]["offender_name"].ToString());
            }
            else
            {
                dataSelectOutOfPlace.ShownText = "";
            }
            EditValueChanged(control as object, null);
        }

        private void offenseTypeDataSelectOutOfPlace_ButtonSelectClick(DevExpress.XtraEditors.XtraUserControl control)
        {
            Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace;

            //using (Safeguard._FormPaymentTypeList formList = new Safeguard._FormPaymentTypeList(this.paymentTypeDataSelectOutOfPlace.RecordId))
            using (Safeguard.BusinessForm.Catalogs.FormOffenseTypeManager formList = new Safeguard.BusinessForm.Catalogs.FormOffenseTypeManager(true, dataSelectOutOfPlace.RecordId))
            {
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                    dataSelectOutOfPlace.RecordId = formList.SelectedRecordId;
                }
            }
        }

        private void offenseTypeDataSelectOutOfPlace_RecordIdChanged(DevExpress.XtraEditors.XtraUserControl control, int recordId)
        {
            Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace;

            if (recordId > 0)
            {
                string query = string.Format(string.Format("dtr_offense_type_get 'by_offense_type_id',{0}", recordId));
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);

                dataSelectOutOfPlace.ShownText = string.Format("{0}", dataTable.Rows[0]["offense_type_name"].ToString());

                this.reasonVariants = BusinessObjects.AnswerVariants.RestoreFromXmlString(dataTable.Rows[0]["reason_variants"].ToString());
                this.penaltyVariants = BusinessObjects.AnswerVariants.RestoreFromXmlString(dataTable.Rows[0]["penalty_variants"].ToString());

                this.showReasonListSimpleButton.Enabled = true;
                this.showPenaltyListSimpleButton.Enabled = true;
            }
            else
            {
                dataSelectOutOfPlace.ShownText = "";
                this.reasonVariants = new AnswerVariants();
                this.penaltyVariants = new AnswerVariants();
                
                this.showReasonListSimpleButton.Enabled = false;
                this.showPenaltyListSimpleButton.Enabled = false;
            }
            EditValueChanged(control as object, null);
        }

        //изменение подрядчика
        private void organizationDataSelectOutOfPlace_ButtonSelectClick(DevExpress.XtraEditors.XtraUserControl control)
        {
            Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace dataSelectOutOfPlace = control as Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace;

            //using (Safeguard._FormPaymentTypeList formList = new Safeguard._FormPaymentTypeList(this.paymentTypeDataSelectOutOfPlace.RecordId))
            using (Safeguard.BusinessForm.Catalogs.FormOrganizationManager formList = new Safeguard.BusinessForm.Catalogs.FormOrganizationManager(true, dataSelectOutOfPlace.RecordId))
            {
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                    dataSelectOutOfPlace.RecordId = formList.SelectedRecordId;
                }
            }
        }

        private void organizationDataSelectOutOfPlace_RecordIdChanged(DevExpress.XtraEditors.XtraUserControl control, int recordId)
        {
            if (recordId > 0)
            {
                string query = string.Format(string.Format("dtr_organization_get 'by_organization_id',{0}", recordId));
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);

                this.organizationDataSelectOutOfPlace.ShownText = string.Format("{0}", dataTable.Rows[0]["organization_name"].ToString());
            }
            else
            {
                this.organizationDataSelectOutOfPlace.ShownText = "";
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

            if (isInputedDataValid == true && this.offenseDateEdit.EditValue == null)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Задайте дату задержания", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && (this.kppDataSelectOutOfPlace.RecordId < 1))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Задайте место задержания", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && (this.organizationDataSelectOutOfPlace.RecordId < 1))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Задайте место работы", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isInputedDataValid;
        }
        
        //запись в базу данных с формы
        private bool SaveData()
        {
            bool isSavedData = false;

            string query = string.Concat("dtr_offense_set"
                , " @command=" + DBConnection.SqlQuery.ActionTypeToDbString(this.actionType)
                , ",@offense_id=" + this.RecordId
                , ",@talon_number=" + DBConnection.SqlQuery.StrToDbString(this.talonNumberTextEdit.Text)
                , ",@offense_datetime=" + DBConnection.SqlQuery.StrToDbString(this.offenseDateEdit.Text)
                , ",@offense_type_id=" + DBConnection.SqlQuery.IdToDbId(this.offenseTypeDataSelectOutOfPlace.RecordId)

                , ",@kpp_id=" + DBConnection.SqlQuery.IdToDbId(this.kppDataSelectOutOfPlace.RecordId)
                , ",@offender_id=" + DBConnection.SqlQuery.IdToDbId(this.offenderDataSelectOutOfPlace.RecordId)
                , ",@organization_id=" + DBConnection.SqlQuery.IdToDbId(this.organizationDataSelectOutOfPlace.RecordId)
                , ",@employee_id=" + DBConnection.SqlQuery.IdToDbId(this.employeeDataSelectOutOfPlace.RecordId)

                , ",@offense_comment=" + DBConnection.SqlQuery.StrToDbString(this.offenseCommentMemoEdit.Text.Trim())
                , ",@offense_result=" + DBConnection.SqlQuery.StrToDbString(this.offenseResultMemoEdit.Text.Trim())
                , ",@act_number=" + DBConnection.SqlQuery.StrToDbString(this.actTextEdit.Text.Trim())
                                
                , ",@comment=" + DBConnection.SqlQuery.StrToDbString(this.commentMemoEdit.Text.Trim())
                );

            try
            {
                DataTable dataTable = DBConnection.SqlQuery.RunTableQuery(query);
                if (dataTable.Rows.Count == 1)
                {
                    isSavedData = true;

                    this.recordId = (int)dataTable.Rows[0]["offense_id"];
                }
            }
            catch (SqlException exception)
            {
                ExceptionHandler.Handler.ProcessSqlException(this, exception);
            }
            return isSavedData;
        }
        #endregion

        private void documentTypeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            ActivateControl();
        }

        private void documentTypeLookUpEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            ActivateControl();
        }

        AnswerVariants reasonVariants = new AnswerVariants();
        AnswerVariants penaltyVariants = new AnswerVariants();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            /*
            List<string> list = new List<string>();
            list.AddRange(new []{"вход","выход","заперто"});

            AnswerVariants answerVariants = new AnswerVariants(list);
            XmlSerializer xmlFormat = new XmlSerializer(typeof(AnswerVariants));

            //Вариант2. Самый правильный
            //запись в строку
            string result = string.Empty;
            using (System.IO.TextWriter stream = new System.IO.StringWriter())
            {
                using (System.Xml.XmlWriter fStrim = new System.Xml.XmlTextWriter(stream))
                {
                    xmlFormat.Serialize(fStrim, answerVariants);
                }
                result = stream.ToString();
            }

            //чтение со строки
            AnswerVariants variants2 = null;
            using (System.IO.TextReader stream = new System.IO.StringReader(result))
            {
                using (System.Xml.XmlReader fStrim = new System.Xml.XmlTextReader(stream))
                {
                    variants2 = (AnswerVariants)xmlFormat.Deserialize(fStrim);
                }
            }

            //чтение из файла
            AnswerVariants variants = null;
            using (System.IO.Stream fStrim = new System.IO.FileStream("d:\\answers_xml.xml", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                variants = (AnswerVariants)xmlFormat.Deserialize(fStrim);
            }
            */
            using (FormSelectValues formSelect = new FormSelectValues(reasonVariants.List))
            {
                if (formSelect.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    this.offenseCommentMemoEdit.EditValue = this.offenseCommentMemoEdit.EditValue + formSelect.GetSelectedValues();
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            using (FormSelectValues formSelect = new FormSelectValues(penaltyVariants.List))
            {
                if (formSelect.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    this.offenseResultMemoEdit.EditValue = this.offenseResultMemoEdit.EditValue + formSelect.GetSelectedValues();
                }
            }
        }

    }

}
