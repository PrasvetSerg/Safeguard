using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

using ServiceTypes;

namespace Safeguard.BusinessForm.Messages
{
    public partial class FormReportOnDateByFactory : DevExpress.XtraEditors.XtraForm
    {
        public FormReportOnDateByFactory()
        {
            InitializeComponent();
        }

        #region Properties

        public int FactoryId
        {
            get
            {
                return (int)(this.groupLookUpEdit.EditValue ?? -1);
            }
        }

        public DateTime Date
        {
            get
            {
                return this.dateEdit.DateTime.Date;
            }
        }

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string WindowCaption
        {
            set
            {
                this.Text = value;
            }
        }

        /// <summary>
        /// Название первого параметра
        /// </summary>
        public string Param1Caption
        {
            set
            {
                this.labelControl1.Text = value;
            }
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
            /*
            DataTable dataTable = DBConnection.SqlQuery.ReadData(this, string.Format("dtr_group_get 'all_view'"));
            if (dataTable != null)
            {
                this.groupLookUpEdit.Properties.DisplayMember = "group_name";
                this.groupLookUpEdit.Properties.ValueMember = "group_id";
                this.groupLookUpEdit.Properties.DataSource = dataTable;
            }
            else
            {
                //SendEvent_RecordChanged(ActionType.None, this.recordId);
            }
            */
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[] {new DataColumn("group_id", typeof(int)), new DataColumn("group_name", typeof(string))});

            dataTable.Rows.Add(new object[] { 0, "Нафтана (1,2,3,4)" });
            dataTable.Rows.Add(new object[] { 1, "Полимира (5,6,7,8)" });

            this.groupLookUpEdit.Properties.DisplayMember = "group_name";
            this.groupLookUpEdit.Properties.ValueMember = "group_id";
            this.groupLookUpEdit.Properties.DataSource = dataTable;
            this.groupLookUpEdit.ItemIndex = 0;

            //Code here
            this.dateEdit.EditValue = DateTime.Now.AddDays(-1).Date;

            Cursor.Current = currentCursor;
        }

        //загрузка рабочих данных
        private void UpdateDataOnForm()
        {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            
            ActivateControl();

            Cursor.Current = currentCursor;
        }

        //активация элементов управления на форме
        private void ActivateControl()
        {
            ;
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

            if (IsInputedDataValid() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool IsInputedDataValid()
        {
            bool isInputedDataValid = true;
            
            //проверка введёных данных
            if (isInputedDataValid == true && this.groupLookUpEdit.EditValue == null)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Задайте группу", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && this.dateEdit.EditValue == null)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Введите дату начала периода", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isInputedDataValid;
        }
        #endregion
    }
}
