using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Safeguard.BusinessForm.UserControl
{
    /// <summary>
    /// Cross element for form selector
    /// </summary>
    public partial class DataSelectOutOfPlace : DevExpress.XtraEditors.XtraUserControl
    {
        public enum ControlStyleInReadModeType
        {
            ButtonsDisabled,   
            ButtonsInvisible,   
            BorderButtonsInvisible    
        }

        private ControlStyleInReadModeType controlStyleInReadMode;
        private bool readOnly;

        public DataSelectOutOfPlace()
        {
            InitializeComponent();

            this.RecordId = -1;
            this.ShownText = null;
            this.ReadOnly = false;
            this.ControlStyleInReadMode = ControlStyleInReadModeType.BorderButtonsInvisible;
        }
        
        #region Properties
        /// <summary>
        /// Gets or sets a value that contain ID selected record.
        /// </summary>
        [Browsable(false)]
        [DefaultValue(-1)]
        public int RecordId
        {
            get { return (int)this.buttonEdit.Tag; }
            set 
            { 
                this.buttonEdit.Tag = value;
                EventRecordIdChanged(value);
            }
        }

        /// <summary>
        /// Gets or sets a value that contain text selected record.
        /// </summary>
        [Browsable(false)]
        public string ShownText
        {
            get { return (string)this.buttonEdit.Text; }
            set { this.buttonEdit.Text = value; }
        }

        /// <summary>
        /// Gets or sets a regular tooltip's content.
        /// </summary>
        [Category("Properties")]
        [DefaultValue("")]
        public string ToolTip
        {
            get { return this.buttonEdit.ToolTip; }
            set { this.buttonEdit.ToolTip = value; }
        }

        /// <summary>
        /// Gets or sets readonly mode state.
        /// </summary>
        [Category("Properties")]
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get { return this.readOnly; }//this.buttonEdit.Properties.ReadOnly; }
            set
            {
                this.readOnly = value;
                
                if (value == true)
                {
                    this.buttonEdit.BackColor = Color.FromArgb(245, 245, 247);
                }
                else
                {
                    this.buttonEdit.BackColor = Color.White;
                }
                
                //this.buttonEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                //this.buttonEdit.Properties.ReadOnly = value;

                //приём фокуса при переходе
                this.TabStop = !value;

                if (this.ControlStyleInReadMode == ControlStyleInReadModeType.BorderButtonsInvisible)
                {
                    //подсветка элемента
                    if (value == true)
                    {
                        this.buttonEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                    }
                    else
                    {
                        this.buttonEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                    }
                }
                
                //отображение кнопок
                if (this.ControlStyleInReadMode == ControlStyleInReadModeType.BorderButtonsInvisible
                    || this.ControlStyleInReadMode == ControlStyleInReadModeType.ButtonsInvisible)
                {
                    foreach (DevExpress.XtraEditors.Controls.EditorButton button in this.buttonEdit.Properties.Buttons)
                    {
                        button.Visible = !value;
                    }
                }

                if (this.ControlStyleInReadMode == ControlStyleInReadModeType.ButtonsDisabled)
                {
                    //отображение кнопок
                    foreach (DevExpress.XtraEditors.Controls.EditorButton button in this.buttonEdit.Properties.Buttons)
                    {
                        button.Enabled = !value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets a regular tooltip's content.
        /// </summary>
        [Description("Отображение бортиков и кнопок в режиме ReadOnly")]
        [Category("Properties")]
        [DefaultValue(ControlStyleInReadModeType.BorderButtonsInvisible)]
        public ControlStyleInReadModeType ControlStyleInReadMode
        {
            get { return this.controlStyleInReadMode; }
            set { this.controlStyleInReadMode = value; }
        }
        
        /// <summary>
        /// Перемещение фокуса на следующих элемент управления при нажатии кнопки Enter
        /// </summary>
        [Category("Properties")]
        [Description("Перемещение фокуса на следующих элемент управления при нажатии кнопки Enter")]
        [DefaultValue(false)]
        public bool EnterMoveNextControl
        {
            get
            {
                return this.buttonEdit.EnterMoveNextControl;
            }
            set
            {
                this.buttonEdit.EnterMoveNextControl = value;
            }
        }
        #endregion

        #region UserAction

        //обработка нажатия кнопок элемента
        private void buttonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if ((string)e.Button.Tag == "Select")
            {
                EventSelect();
            }
            else if ((string)e.Button.Tag == "Clear")
            {
                EventClear();
            }
        }

        //обработка двойного клика
        private void buttonEdit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.ReadOnly == false)
            {
                EventSelect();
            }
        }


        public delegate void DelegateButtonSelectClick(XtraUserControl control);
        public event DelegateButtonSelectClick ButtonSelectClick;

        //инициация выбора данных
        private void EventSelect()
        {
            if (ButtonSelectClick != null)
            {
                ButtonSelectClick(this);
            }
        }


        public delegate void DelegateButtonClearClick();
        public event DelegateButtonClearClick ButtonClearClick;
        
        //инициация сброса выбраных данных
        private void EventClear()
        {
            if (ButtonClearClick != null)
            {
                ButtonClearClick();
            }
            else
            {
                this.ShownText = "";
                this.RecordId = -1;
            }
        }

        
        public delegate void DelegateRecordIdChanged(XtraUserControl control, int recordId);
        public event DelegateRecordIdChanged RecordIdChanged;

        private void EventRecordIdChanged(int id)
        {
            if (RecordIdChanged != null)
            {
                RecordIdChanged(this, id);
            }
        }
        #endregion
    }
}
