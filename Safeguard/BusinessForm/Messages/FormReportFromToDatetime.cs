using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

using ServiceTypes;

namespace Safeguard.BusinessForm.Messages
{
    public partial class FormReportFromToDatetime : DevExpress.XtraEditors.XtraForm
    {
        public FormReportFromToDatetime()
        {
            InitializeComponent();
        }

        #region Properties
        
        public DateTime FromDatetime
        {
            get
            {
                return this.periodBeginDateEdit.DateTime;
            }
        }

        public DateTime ToDatetime
        {
            get
            {
                return this.periodEndDateEdit.DateTime;
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
                this.labelControl2.Text = value;
            }
        }
        
        /// <summary>
        /// Название второго параметра
        /// </summary>
        public string Param2Caption
        {
            set
            {
                this.labelControl2.Text = value;
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

            //Code here
            this.periodBeginDateEdit.EditValue = DateTime.Now.Date;//new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.periodEndDateEdit.EditValue = DateTime.Now.Date.AddDays(1);

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
            if (isInputedDataValid == true && this.periodBeginDateEdit.EditValue == null)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Введите дату начала периода", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && this.periodEndDateEdit.EditValue == null)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Введите дату окончания периода", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && this.FromDatetime > this.ToDatetime)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Период задан не верно. Дата окончания больше даты начала", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isInputedDataValid;
        }
        #endregion
    }
}
