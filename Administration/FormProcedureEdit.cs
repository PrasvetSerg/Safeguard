using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using ServiceTypes;

namespace Administration
{
    //ТИП FEDIT4+
    public partial class FormProcedureEdit : DevExpress.XtraEditors.XtraForm
    {
        ActionType actionType;
        int recordId;

        public FormProcedureEdit(ActionType actionType, int recordId)
        {
            this.actionType = actionType;
            this.recordId = recordId;

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
                DataTable dataTable = DBConnection.SqlQuery.ReadData(this, string.Format("dtr_acl_procedure_get 'by_acl_procedure_id',{0}", this.RecordId));

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    this.idTextEdit.Text = dataTable.Rows[0]["acl_procedure_id"].ToString();
                    this.nameTextEdit.Text = dataTable.Rows[0]["procedure_name"].ToString();
                    this.displayNameTextEdit.Text = dataTable.Rows[0]["procedure_display_name"].ToString();
                    this.commentMemoEdit.Text = dataTable.Rows[0]["comment"].ToString();                   
                }
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
                this.Text = "Регистрация новой процедуры";

                this.nameTextEdit.Properties.ReadOnly = false;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.displayNameTextEdit.Properties.ReadOnly = false;
                this.displayNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.commentMemoEdit.Properties.ReadOnly = false;
                this.commentMemoEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
            else if (this.actionType == ActionType.Edit && this.RecordId > 0)
            {
                this.Text = "Редактирование информации о процедуре";

                this.nameTextEdit.Properties.ReadOnly = true;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.displayNameTextEdit.Properties.ReadOnly = false;
                this.displayNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.commentMemoEdit.Properties.ReadOnly = false;
                this.commentMemoEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
            else if (this.actionType == ActionType.Archive && this.RecordId > 0)
            {
                this.Text = "Прекращение действия записи";

                this.actionButton.Text = "В архив";
                this.nameTextEdit.Properties.ReadOnly = true;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.displayNameTextEdit.Properties.ReadOnly = true;
                this.displayNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.commentMemoEdit.Properties.ReadOnly = true;
                this.commentMemoEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            }
            else if (this.actionType == ActionType.Remove && this.RecordId > 0)
            {
                this.Text = "Удаление текущей записи";

                this.actionButton.Text = "Удалить";
                this.nameTextEdit.Properties.ReadOnly = true;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.displayNameTextEdit.Properties.ReadOnly = true;
                this.displayNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.commentMemoEdit.Properties.ReadOnly = true;
                this.commentMemoEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            }
            else
            {
                this.Text = "Просмотр текущей записи";
                this.actionButton.Enabled = false;

                this.nameTextEdit.Properties.ReadOnly = true;
                this.nameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.displayNameTextEdit.Properties.ReadOnly = true;
                this.displayNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.commentMemoEdit.Properties.ReadOnly = true;
                this.commentMemoEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            }
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
            /*
            if (isInputedDataValid == true && (this.personalAccountTextEdit.Text.Length < 3))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Заполните поле наименования", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */
            if (isInputedDataValid == true && (this.nameTextEdit.Text.Trim().Length < 3))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Заполните поле процедура", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && (this.displayNameTextEdit.Text.Trim().Length < 3))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Заполните поле название", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*
            //проверка на дубликат среди действующиз
            if (isInputedDataValid == true && this.actionType == ActionType.Add)
            {
                //запрос всех записай
                string query = string.Format("dtr_acl_procedure_get 'all'"
                    );
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);
                
                //отбор совпадающих записей
                if (dataTable != null)// && dataTable.Rows.Count > 0)
                {
                    string filterExprssion = string.Format("expiration_date IS NULL AND (acl_procedure_name='{0}')"
                        , this.nameTextEdit.Text.Trim()
                        );

                    if (dataTable.Select(filterExprssion).Length > 0)
                    {
                        isInputedDataValid = false;
                        DevExpress.XtraEditors.XtraMessageBox.Show(this, "В базе уже тариф с таким наименованием", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    isInputedDataValid = false;
                }
            }
            */
            return isInputedDataValid;
        }
        
        //запись в базу данных с формы
        private bool SaveData()
        {
            bool isSavedData = false;

            string query = string.Concat("dtr_acl_procedure_set"
                , " @command=" + DBConnection.SqlQuery.ActionTypeToDbString(this.actionType)
                , ",@acl_procedure_id=" + this.RecordId
                , ",@procedure_name=" + DBConnection.SqlQuery.StrToDbString(this.nameTextEdit.Text.Trim())
                , ",@procedure_display_name=" + DBConnection.SqlQuery.StrToDbString(this.displayNameTextEdit.Text.Trim())
                , ",@comment=" + DBConnection.SqlQuery.StrToDbString(this.commentMemoEdit.Text.Trim())
                );

            try
            {
                DataTable dataTable = DBConnection.SqlQuery.RunTableQuery(query);
                if (dataTable.Rows.Count == 1)
                {
                    isSavedData = true;

                    this.recordId = (int)dataTable.Rows[0]["acl_procedure_id"];
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
