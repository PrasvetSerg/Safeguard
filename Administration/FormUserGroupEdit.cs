using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ServiceTypes;

namespace Administration
{
    public partial class FormUserGroupEdit : DevExpress.XtraEditors.XtraForm
    {
        ActionType actionType;
        int recordId;
        int parentRecordId;

        public FormUserGroupEdit(ServiceTypes.ActionType actionType = ActionType.None, int recordId = -1, int parentId = -1)
        {
            this.actionType = actionType;
            this.recordId = recordId;
            this.parentRecordId = parentId;

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
                DataTable dataTable = DBConnection.SqlQuery.ReadData(this, string.Format("dtr_acl_user_group_get 'by_acl_user_group_id',{0}", this.RecordId));

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    this.idTextEdit.Text = dataTable.Rows[0]["acl_user_group_id"].ToString();
                    this.parentRecordId = (int)dataTable.Rows[0]["acl_user_id"];
                    this.groupDataSelectOutOfPlace.RecordId = (int)dataTable.Rows[0]["acl_group_id"];
                }
            }
            else
            {
                //this.automaticPositionTextEdit.Text = relativePosition.ToString();
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
                this.Text = "Добавление разрешения на группу";

                this.groupDataSelectOutOfPlace.ReadOnly = false;
            }
            else if (this.actionType == ActionType.Edit && this.RecordId > 0)
            {
                this.Text = "Редактирование о группе";
                                
                this.groupDataSelectOutOfPlace.ReadOnly = true;
            }
            else if (this.actionType == ActionType.Archive && this.RecordId > 0)
            {
                this.Text = "Прекращение действия записи";
                this.actionButton.Text = "В архив";

                this.groupDataSelectOutOfPlace.ReadOnly = true;
            }
            else if (this.actionType == ActionType.Remove && this.RecordId > 0)
            {
                this.Text = "Удаление текущей записи";
                this.actionButton.Text = "Удалить";

                this.groupDataSelectOutOfPlace.ReadOnly = true;
            }
            else
            {
                this.Text = "Просмотр текущей записи";
                this.actionButton.Enabled = false;

                this.groupDataSelectOutOfPlace.ReadOnly = true;
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
            if (isInputedDataValid == true && (this.groupDataSelectOutOfPlace.RecordId < 1))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Задайте группу", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            //проверка на дубликат среди действующиз
            if (isInputedDataValid == true && this.actionType == ActionType.Add)
            {
                /*
                //запрос всех валют для указанной страны
                string query = string.Format("usp_tnved_get 'all'"
                    );
                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, query);
                
                //отбор совпадающих записей
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    string filterExprssion = string.Format("expiration_date IS NULL AND (tnved_code='{0}')"
                        , this.nameTextEdit.Text
                        );

                    if (dataTable.Select(filterExprssion).Length > 0)
                    {
                        isInputedDataValid = false;
                        DevExpress.XtraEditors.XtraMessageBox.Show(this, "В базе уже присутствует такой код по ТН ВЭД", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                */
            }

            return isInputedDataValid;
        }
        
        //запись в базу данных с формы
        private bool SaveData()
        {
            bool isSavedData = false;

            string query = string.Concat("dtr_acl_user_group_set"
                , " @command=" + DBConnection.SqlQuery.ActionTypeToDbString(this.actionType)
                , ",@acl_user_group_id=" + this.RecordId.ToString()
                , ",@acl_user_id=" + this.parentRecordId.ToString()
                , ",@group_id=" + this.groupDataSelectOutOfPlace.RecordId
                );

            try
            {
                DataTable dataTable = DBConnection.SqlQuery.RunTableQuery(query);
                if (dataTable.Rows.Count == 1)
                {
                    isSavedData = true;

                    this.recordId = (int)dataTable.Rows[0]["cr_shield_card_id"];
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
