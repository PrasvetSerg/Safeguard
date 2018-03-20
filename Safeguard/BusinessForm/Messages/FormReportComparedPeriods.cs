using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

using ServiceTypes;

namespace Safeguard.BusinessForm.Messages
{
    public partial class FormReportComparedPeriods : DevExpress.XtraEditors.XtraForm
    {
        public FormReportComparedPeriods()
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

        /// <summary>
        /// Название первого периода
        /// </summary>
        public string Period1Caption
        {
            set
            {
                this.period1LabelControl.Text = value;
            }
        }

        /// <summary>
        /// Название второго периода
        /// </summary>
        public string Period2Caption
        {
            set
            {
                this.period2LabelControl.Text = value;
            }
        }
        
        public DateTime Period1BeginDate
        {
            get
            {
                return this.period1BeginDateEdit.DateTime.Date;
            }
        }

        public DateTime Period1EndDate
        {
            get
            {
                return this.period1EndDateEdit.DateTime.Date;
            }
        }

        public DateTime Period2BeginDate
        {
            get
            {
                return this.period2BeginDateEdit.DateTime.Date;
            }
        }

        public DateTime Period2EndDate
        {
            get
            {
                return this.period2EndDateEdit.DateTime.Date;
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

            this.period1BeginDateEdit.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.period1EndDateEdit.EditValue = DateTime.Now.Date;
            
            this.period2BeginDateEdit.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.period2EndDateEdit.EditValue = DateTime.Now.Date;

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
            if (isInputedDataValid == true && this.period1BeginDateEdit.EditValue == null)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Введите дату начала периода", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && this.period1EndDateEdit.EditValue == null)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Введите дату окончания периода", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && this.Period1BeginDate > this.Period1EndDate)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, this.period1LabelControl.Text + " задан не верно. Дата окончания больше даты начала", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (isInputedDataValid == true && this.Period2BeginDate > this.Period2EndDate)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, this.period2LabelControl.Text + " задан не верно. Дата окончания больше даты начала", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && (this.Period1BeginDate <= this.Period2BeginDate && this.Period2BeginDate <= this.Period1EndDate
                    || this.Period1BeginDate <= this.Period2EndDate && this.Period2EndDate <= this.Period1EndDate))
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Заданные периоды пересекаются", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isInputedDataValid;
        }
        #endregion
    }
}
