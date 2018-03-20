using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

using ServiceTypes;

namespace Safeguard.BusinessForm.Messages
{
    public partial class FormReportAllocationForDate : DevExpress.XtraEditors.XtraForm
    {
        public FormReportAllocationForDate()
        {
            InitializeComponent();
        }

        #region Properties

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

        public DateTime CurrentDate
        {
            get
            {
                return this.currentDateEdit.DateTime.Date;
            }
        }

        public DateTime ComparedWeekDate
        {
            get
            {
                return this.comparedWeekDateEdit.DateTime.Date;
            }
        }

        public DateTime ComparedMonthDateEdit
        {
            get
            {
                return this.comparedMonthDateEdit.DateTime.Date;
            }
        }

        public DateTime PeriodBeginDate
        {
            get
            {
                return this.periodGraficBeginDateEdit.DateTime.Date;
            }
        }

        public DateTime PeriodEndDate
        {
            get
            {
                return this.periodGraficEndDateEdit.DateTime.Date;
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

            this.currentDateEdit.EditValue = DateTime.Now.Date;
            this.comparedWeekDateEdit.EditValue = DateTime.Now.AddDays(-7);

            this.comparedMonthDateEdit.EditValue = DateTime.Now.AddDays(-7*5);//GetFirstMorningInMonthDate(DateTime.Now.AddMonths(-1));
            
            this.periodGraficBeginDateEdit.EditValue = DateTime.Now.Date.AddMonths(-6);
            this.periodGraficEndDateEdit.EditValue = DateTime.Now.Date;

            Cursor.Current = currentCursor;
        }

        /// <summary>
        /// Возвращает дату первого понедельника в указанном месяце
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime GetFirstMorningInMonthDate(DateTime date)
        {
            DateTime firstMorningInMonthDate = new DateTime(date.Date.Year, date.Date.Month, 1);

            while (firstMorningInMonthDate.DayOfWeek != DayOfWeek.Monday)
            {
                firstMorningInMonthDate = firstMorningInMonthDate.AddDays(1);
            }

            return firstMorningInMonthDate;
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
            if (isInputedDataValid == true && this.currentDateEdit.EditValue == null)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Введите дату для сравнения", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && this.CurrentDate <= this.ComparedWeekDate)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Даты для сравнения должны быть меньше текущей", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && this.CurrentDate <= this.ComparedMonthDateEdit)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Даты для сравнения должны быть меньше текущей", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (isInputedDataValid == true && this.PeriodBeginDate > this.PeriodEndDate)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, this.period2LabelControl.Text + " задан не верно. Дата окончания больше даты начала", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isInputedDataValid;
        }
        #endregion

        private void currentDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.comparedWeekDateEdit.EditValue = this.currentDateEdit.DateTime.AddDays(-7);

            this.comparedMonthDateEdit.EditValue = this.currentDateEdit.DateTime.AddDays(-7 * 5);//GetFirstMorningInMonthDate(DateTime.Now.AddMonths(-1));

            this.periodGraficBeginDateEdit.EditValue = this.currentDateEdit.DateTime.AddMonths(-6);
            this.periodGraficEndDateEdit.EditValue = this.currentDateEdit.DateTime;
        }
    }
}
