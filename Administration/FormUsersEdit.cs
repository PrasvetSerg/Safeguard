using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

using ServiceTypes;

namespace Administration
{
    public partial class FormUsersEdit : DevExpress.XtraEditors.XtraForm
    {
        ActionType actionType;
        int recordId;
        
        public FormUsersEdit(ServiceTypes.ActionType actionType, int recordId)
        {
            this.actionType = actionType;
            this.recordId = recordId;

            InitializeComponent();
        }

        #region Properties
        /// <summary>
        /// Gets a editing record ID
        /// </summary>
        public int RecordId
        {
            get { return recordId; }
        }

        #endregion
        
        #region Form management
        //заполнение данных при отображении формы
        private void FormEdit_Shown(object sender, EventArgs e)
        {
            InitControl();

            //возможно условие не актуально
            if (this.actionType == ActionType.Add)
            {
                //задание первичных значений

                ActivateControl();
            }
            else
            {
                UpdateDataOnForm();
            }
        }

        //загрузка данных в селекторы
        private void InitControl()
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            //Code here:

            Cursor.Current = currentCursor;
        }

        //загрузка рабочих данных
        private void UpdateDataOnForm()
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            if (this.RecordId > 0)
            {
                DataTable dataTable = DBConnection.SqlQuery.ReadData(this, string.Format("dtr_acl_user_get 'by_acl_user_id',{0}", this.RecordId));
                
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    this.idTextEdit.Text = dataTable.Rows[0]["acl_user_id"].ToString();
                    this.lastNameTextEdit.Text = dataTable.Rows[0]["last_name"].ToString();
                    this.firstNameTextEdit.Text = dataTable.Rows[0]["first_name"].ToString();
                    this.middleNameTextEdit.Text = dataTable.Rows[0]["middle_name"].ToString();
                    this.shortNameTextEdit.Text = dataTable.Rows[0]["short_name"].ToString();
                    this.loginTextEdit.Text = dataTable.Rows[0]["login"].ToString();
                    this.isBlockedCheckEdit.Checked = (bool)dataTable.Rows[0]["is_blocked_user"];
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
                this.Text = "Регистрация нового пользователя";
                
                this.firstNameTextEdit.Properties.ReadOnly = false;
                this.firstNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.middleNameTextEdit.Properties.ReadOnly = false;
                this.middleNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.lastNameTextEdit.Properties.ReadOnly = false;
                this.lastNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.shortNameTextEdit.Properties.ReadOnly = false;
                this.shortNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;

                this.isBlockedCheckEdit.Properties.ReadOnly = false;

                this.commentMemoEdit.Properties.ReadOnly = false;
                this.commentMemoEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
            else if (this.actionType == ActionType.Edit && this.recordId > 0)
            {
                this.Text = "Редактирование информации о пользователе";

                this.firstNameTextEdit.Properties.ReadOnly = false;
                this.firstNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.middleNameTextEdit.Properties.ReadOnly = false;
                this.middleNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.lastNameTextEdit.Properties.ReadOnly = false;
                this.lastNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.shortNameTextEdit.Properties.ReadOnly = false;
                this.shortNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;

                this.isBlockedCheckEdit.Properties.ReadOnly = false;

                this.commentMemoEdit.Properties.ReadOnly = false;
                this.commentMemoEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            }
            else if (this.actionType == ActionType.Remove && this.recordId > 0)
            {
                this.Text = "Удаление текущей записи";
                this.actionButton.Text = "Удалить";

                this.firstNameTextEdit.Properties.ReadOnly = true;
                this.firstNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.middleNameTextEdit.Properties.ReadOnly = true;
                this.middleNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.lastNameTextEdit.Properties.ReadOnly = true;
                this.lastNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.shortNameTextEdit.Properties.ReadOnly = true;
                this.shortNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

                this.isBlockedCheckEdit.Properties.ReadOnly = true;

                this.commentMemoEdit.Properties.ReadOnly = false;
                this.commentMemoEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            }
            else
            {
                this.Text = "Просмотр текущей записи";
                this.actionButton.Enabled = false;

                this.firstNameTextEdit.Properties.ReadOnly = true;
                this.firstNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.middleNameTextEdit.Properties.ReadOnly = true;
                this.middleNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.lastNameTextEdit.Properties.ReadOnly = true;
                this.lastNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.shortNameTextEdit.Properties.ReadOnly = true;
                this.shortNameTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

                this.isBlockedCheckEdit.Properties.ReadOnly = true;

                this.commentMemoEdit.Properties.ReadOnly = true;
                this.commentMemoEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            }
        }
        
        /// <summary>
        /// Auto fill short name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateShortName_EditValueChanged(object sender, EventArgs e)
        {
            this.shortNameTextEdit.Text = "";
            if (this.lastNameTextEdit.Text.Length > 0)
            {
                this.shortNameTextEdit.Text += this.lastNameTextEdit.Text[0].ToString().ToUpper();
            }

            if (this.lastNameTextEdit.Text.Length > 1)
            {
                this.shortNameTextEdit.Text += this.lastNameTextEdit.Text.Substring(1, this.lastNameTextEdit.Text.Length - 1).ToLower();
            }

            this.shortNameTextEdit.Text += " ";

            if (this.firstNameTextEdit.Text.Length > 0)
            {
                this.shortNameTextEdit.Text += this.firstNameTextEdit.Text.Substring(0, 1).ToUpper();
            }

            this.shortNameTextEdit.Text += ".";

            if (this.middleNameTextEdit.Text.Length > 0)
            {
                this.shortNameTextEdit.Text += this.middleNameTextEdit.Text.Substring(0, 1).ToUpper();
            }

            this.shortNameTextEdit.Text += ".";
        }
        #endregion

        #region User Action
        //устаревший метод
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

        private bool IsInputedDataValid()
        {
            bool isInputedDataValid = true;

            if (isInputedDataValid == true && this.loginTextEdit.Text.Length < 1)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Заполните имя входа пользователя", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && (this.firstNameTextEdit.Text.Length < 2 || this.lastNameTextEdit.Text.Length < 2 || this.middleNameTextEdit.Text.Length < 2))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Заполните фамилию, имя и отчество полностью", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && this.shortNameTextEdit.Text.Length < 7)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Заполните поле Коротко фамилией и инициалами пользователя", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isInputedDataValid;
        }
        
        //запись в базу данных с формы
        private bool SaveData()
        {
            bool isSavedData = false;

            string query = string.Concat("dtr_acl_user_set"
                , " @command=" + DBConnection.SqlQuery.ActionTypeToDbString(this.actionType)
                , ",@acl_user_id=" + this.RecordId.ToString()
                , ",@login=" + DBConnection.SqlQuery.StrToDbString(this.loginTextEdit.Text.Trim())
                , ",@first_name=" + DBConnection.SqlQuery.StrToDbString(this.firstNameTextEdit.Text.Trim())
                , ",@middle_name=" + DBConnection.SqlQuery.StrToDbString(this.middleNameTextEdit.Text.Trim())
                , ",@last_name=" + DBConnection.SqlQuery.StrToDbString(this.lastNameTextEdit.Text.Trim())
                , ",@short_name=" + DBConnection.SqlQuery.StrToDbString(this.shortNameTextEdit.Text.Trim())
                , ",@is_blocked_user=" + (this.isBlockedCheckEdit.Checked == true ? 1 : 0).ToString()
                , ",@comment=" + DBConnection.SqlQuery.StrToDbString(this.commentMemoEdit.Text.Trim())
                );

            try
            {
                DataTable dataTable = DBConnection.SqlQuery.RunTableQuery(query);
                if (dataTable !=null && dataTable.Rows.Count == 1)
                {
                    isSavedData = true;
                    this.recordId = (int)dataTable.Rows[0]["acl_user_id"];
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
