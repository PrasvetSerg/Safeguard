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
    public partial class DataSelectInPlace : DevExpress.XtraEditors.XtraUserControl
    {
        //визуализация в режиме только для чтения
        public enum ControlStyleInReadModeType
        {
            ButtonsDisabled,
            ButtonsInvisible,
            BorderButtonsInvisible
        }

        //количество возможных для отображения кнопок
        public enum ShownButton
        {
            None,
            Down,
            DownClear,
            All
        }

        private ControlStyleInReadModeType controlStyleInReadMode;
        private ShownButton shownButton;

        public DataSelectInPlace()
        {
            InitializeComponent();
            
            this.RecordId = -1;
            this.ControlStyleInReadMode = ControlStyleInReadModeType.BorderButtonsInvisible;
            this.shownButton = ShownButton.All;
        }

        #region Properties
        [Browsable(false)]
        [DefaultValue(-1)]
        /// <summary>
        /// Gets or sets a value that contain ID selected record.
        /// </summary>
        public int RecordId
        {
            get { return (int)this.lookUpEdit.EditValue; }
            set
            {
                this.lookUpEdit.EditValue = value;
            }
        }

        [Browsable(false)]
        /// <summary>
        /// Gets or sets a value that contain text selected record.
        /// </summary>
        public string ShownText
        {
            get { return (string)this.lookUpEdit.Text; }
        }

        /*
        // Gets the attributes for the property.
  
        AttributeCollection attributes = 
            TypeDescriptor.GetProperties(this)["MyProperty"].Attributes;
  
        // Prints the default value by retrieving the DefaultValueAttribute 
        // from the AttributeCollection. 
  
        DefaultValueAttribute myAttribute = 
            (DefaultValueAttribute)attributes[typeof(DefaultValueAttribute)];
        Console.WriteLine("The default value is: " + myAttribute.Value.ToString());
        */

        /* 
        [EditorBrowsable(EditorBrowsableState.Never)]
        
        [Description("")]
        [Category("Properties")]
        [RefreshProperties(RefreshProperties.All)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        
        [DefaultValue("")]
        [Category("Tooltip")]
        [Description("Gets or sets a regular tooltip's content.")]
        [Localizable(true)]
        */
        /// <summary>
        /// Gets or sets a regular tooltip's content.
        /// </summary>
        [Category("Properties")]
        [DefaultValue("")]
        public string ToolTip
        {
            get { return this.lookUpEdit.ToolTip; }
            set { this.lookUpEdit.ToolTip = value; }
        }

        /// <summary>
        /// Gets or sets readonly mode state.
        /// </summary>
        [Category("Properties")]
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get { return this.lookUpEdit.Properties.ReadOnly; }
            set
            {
                this.lookUpEdit.Properties.ReadOnly = value;

                //приём фокуса при переходе
                this.TabStop = !value;

                if (this.ControlStyleInReadMode == ControlStyleInReadModeType.BorderButtonsInvisible)
                {
                    //подсветка элемента
                    if (value == true)
                    {
                        this.lookUpEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                    }
                    else
                    {
                        this.lookUpEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                    }
                }

                //отображение кнопок
                if (this.ControlStyleInReadMode == ControlStyleInReadModeType.BorderButtonsInvisible
                    || this.ControlStyleInReadMode == ControlStyleInReadModeType.ButtonsInvisible)
                {
                    SetVisibleButtons(!value);
                }

                if (this.ControlStyleInReadMode == ControlStyleInReadModeType.ButtonsDisabled)
                {
                    //отображение кнопок
                    foreach (DevExpress.XtraEditors.Controls.EditorButton button in this.lookUpEdit.Properties.Buttons)
                    {
                        button.Enabled = !value;
                    }
                }
            }
        }

        //
        private void SetVisibleButtons(bool visible)
        {
            switch (this.shownButton)
            {
                case ShownButton.None:
                    foreach (DevExpress.XtraEditors.Controls.EditorButton button in this.lookUpEdit.Properties.Buttons)
                    {
                        button.Visible = false;
                    }
                    break;
                case ShownButton.Down:
                    this.lookUpEdit.Properties.Buttons[0].Visible = visible;
                    this.lookUpEdit.Properties.Buttons[1].Visible = false;
                    this.lookUpEdit.Properties.Buttons[2].Visible = false;
                    break;
                case ShownButton.DownClear:
                    this.lookUpEdit.Properties.Buttons[0].Visible = visible;
                    this.lookUpEdit.Properties.Buttons[1].Visible = false;
                    this.lookUpEdit.Properties.Buttons[2].Visible = visible;
                    break;
                case ShownButton.All:
                    foreach (DevExpress.XtraEditors.Controls.EditorButton button in this.lookUpEdit.Properties.Buttons)
                    {
                        button.Visible = visible;
                    }
                    break;
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
        /// Gets or sets a regular tooltip's content.
        /// </summary>
        [DefaultValue(ShownButton.All)]
        [Description("Отображаемые кнопки в элементе")]
        [Category("Properties")]
        public ShownButton ShowButtons
        {
            get { return this.shownButton; }
            set
            {
                this.shownButton = value;
                SetVisibleButtons(true);
            }
        }

        /*
        [Bindable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        */

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("Компонент содержащий список колонок")]
        [Category("Properties")]
        /// <summary>
        /// Коллекция колонок элемента LookUpEdit
        /// </summary>
        public DevExpress.XtraEditors.Controls.LookUpColumnInfoCollection Columns
        {
            get { return this.lookUpEdit.Properties.Columns;}
        }

        [DefaultValue("")]
        [AttributeProvider(typeof(IListSource))]
        //[RefreshProperties(RefreshProperties.Repaint)]
        [Category("Data")]
        [Description("Gets or sets the source of data displayed in the dropdown window.")]
        public object DataSource
        {
            get { return this.lookUpEdit.Properties.DataSource; }
            set { this.lookUpEdit.Properties.DataSource = value; }
        }

        [Category("Data")]
        [DefaultValue("")]
        //[Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", typeof(UITypeEditor))]
        [Description("Gets or sets the field name whose values identify dropdown rows.")]
        //[TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design")]
        public string ValueMember
        {
            get { return this.lookUpEdit.Properties.ValueMember; }
            set { this.lookUpEdit.Properties.ValueMember = value; }
        }

        //[Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", typeof(UITypeEditor))]
        //[TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design")]
        [Category("Data")]
        [Description("Gets or sets the field whose values are displayed in the edit box.")]
        [DefaultValue("")]
        public string DisplayMember
        {
            get { return this.lookUpEdit.Properties.DisplayMember; }
            set { this.lookUpEdit.Properties.DisplayMember = value; }
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
                return this.lookUpEdit.EnterMoveNextControl;
            }
            set
            {
                this.lookUpEdit.EnterMoveNextControl = value;
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
            EventSelect();
        }
        
        private void lookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            EventRecordIdChanged((int)this.lookUpEdit.EditValue);
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
                //this.ShownText = "";
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
