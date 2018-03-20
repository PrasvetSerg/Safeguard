using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

using ServiceTypes;

namespace Safeguard.BusinessForm.Messages
{
    public partial class FormReportCalcDate : DevExpress.XtraEditors.XtraForm
    {
        public FormReportCalcDate()
        {
            InitializeComponent();
        }

        #region Properties
        
        public DateTime CalcDate
        {
            get
            {
                return this.periodBeginDateEdit.DateTime.Date;
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
        /// Название параметра
        /// </summary>
        public string CalcDateCaption
        {
            set
            {
                this.calcDateLabelControl.Text = value;
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

            return isInputedDataValid;
        }
        #endregion
    }
}
