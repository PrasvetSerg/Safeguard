namespace Safeguard.BusinessForm.Messages
{
    partial class FormReportMonth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportMonth));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.periodLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.actionButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.periodDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.renterDataSelectOutOfPlace = new ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace();
            this.callServiceDataSelectOutOfPlace = new ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace();
            this.ndsServiceDataSelectOutOfPlace = new ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.quartalLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.quartalImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.yearLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.yearDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartalImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.periodLabelControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.periodDateEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.renterDataSelectOutOfPlace, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.callServiceDataSelectOutOfPlace, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ndsServiceDataSelectOutOfPlace, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.actionButton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.quartalImageComboBoxEdit, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.yearDateEdit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.quartalLabelControl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.yearLabelControl, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 245);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // periodLabelControl
            // 
            this.periodLabelControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.periodLabelControl.Location = new System.Drawing.Point(53, 6);
            this.periodLabelControl.Name = "periodLabelControl";
            this.periodLabelControl.Size = new System.Drawing.Size(99, 13);
            this.periodLabelControl.TabIndex = 10;
            this.periodLabelControl.Text = "Расчётный период:";
            this.periodLabelControl.Visible = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl7.Location = new System.Drawing.Point(70, 32);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 13);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Группа аренды:";
            this.labelControl7.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(77, 159);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Отмена";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Location = new System.Drawing.Point(88, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Услуга НДС:";
            this.labelControl3.Visible = false;
            // 
            // actionButton
            // 
            this.actionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.actionButton.Location = new System.Drawing.Point(158, 159);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 4;
            this.actionButton.Text = "&Продолжить";
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(3, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(149, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Услуга повремённой оплаты:";
            this.labelControl1.Visible = false;
            // 
            // periodDateEdit
            // 
            this.periodDateEdit.EditValue = null;
            this.periodDateEdit.Location = new System.Drawing.Point(158, 3);
            this.periodDateEdit.Name = "periodDateEdit";
            this.periodDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.periodDateEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.periodDateEdit.Properties.Mask.EditMask = "MMMM yyyy";
            this.periodDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.periodDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.periodDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.periodDateEdit.Size = new System.Drawing.Size(100, 20);
            this.periodDateEdit.TabIndex = 2;
            this.periodDateEdit.Visible = false;
            this.periodDateEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.publicationDateEdit_EditValueChanging);
            // 
            // renterDataSelectOutOfPlace
            // 
            this.renterDataSelectOutOfPlace.EnterMoveNextControl = true;
            this.renterDataSelectOutOfPlace.Location = new System.Drawing.Point(158, 29);
            this.renterDataSelectOutOfPlace.Name = "renterDataSelectOutOfPlace";
            this.renterDataSelectOutOfPlace.ReadOnly = true;
            this.renterDataSelectOutOfPlace.ShownText = "";
            this.renterDataSelectOutOfPlace.Size = new System.Drawing.Size(238, 20);
            this.renterDataSelectOutOfPlace.TabIndex = 11;
            this.renterDataSelectOutOfPlace.TabStop = false;
            this.renterDataSelectOutOfPlace.Visible = false;
            // 
            // callServiceDataSelectOutOfPlace
            // 
            this.callServiceDataSelectOutOfPlace.EnterMoveNextControl = true;
            this.callServiceDataSelectOutOfPlace.Location = new System.Drawing.Point(158, 55);
            this.callServiceDataSelectOutOfPlace.Name = "callServiceDataSelectOutOfPlace";
            this.callServiceDataSelectOutOfPlace.ReadOnly = true;
            this.callServiceDataSelectOutOfPlace.ShownText = "";
            this.callServiceDataSelectOutOfPlace.Size = new System.Drawing.Size(238, 20);
            this.callServiceDataSelectOutOfPlace.TabIndex = 12;
            this.callServiceDataSelectOutOfPlace.TabStop = false;
            this.callServiceDataSelectOutOfPlace.Visible = false;
            // 
            // ndsServiceDataSelectOutOfPlace
            // 
            this.ndsServiceDataSelectOutOfPlace.EnterMoveNextControl = true;
            this.ndsServiceDataSelectOutOfPlace.Location = new System.Drawing.Point(158, 81);
            this.ndsServiceDataSelectOutOfPlace.Name = "ndsServiceDataSelectOutOfPlace";
            this.ndsServiceDataSelectOutOfPlace.ReadOnly = true;
            this.ndsServiceDataSelectOutOfPlace.ShownText = "";
            this.ndsServiceDataSelectOutOfPlace.Size = new System.Drawing.Size(238, 20);
            this.ndsServiceDataSelectOutOfPlace.TabIndex = 13;
            this.ndsServiceDataSelectOutOfPlace.TabStop = false;
            this.ndsServiceDataSelectOutOfPlace.Visible = false;
            // 
            // quartalLabelControl
            // 
            this.quartalLabelControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.quartalLabelControl.Location = new System.Drawing.Point(53, 136);
            this.quartalLabelControl.Name = "quartalLabelControl";
            this.quartalLabelControl.Size = new System.Drawing.Size(99, 13);
            this.quartalLabelControl.TabIndex = 10;
            this.quartalLabelControl.Text = "Расчётный период:";
            this.quartalLabelControl.Visible = false;
            // 
            // quartalImageComboBoxEdit
            // 
            this.quartalImageComboBoxEdit.Location = new System.Drawing.Point(158, 133);
            this.quartalImageComboBoxEdit.Name = "quartalImageComboBoxEdit";
            this.quartalImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quartalImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("1 квартал", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("2 квартал", 2, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("3 квартал", 3, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("4 квартал", 4, -1)});
            this.quartalImageComboBoxEdit.Size = new System.Drawing.Size(143, 20);
            this.quartalImageComboBoxEdit.TabIndex = 14;
            this.quartalImageComboBoxEdit.Visible = false;
            // 
            // yearLabelControl
            // 
            this.yearLabelControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.yearLabelControl.Location = new System.Drawing.Point(69, 110);
            this.yearLabelControl.Name = "yearLabelControl";
            this.yearLabelControl.Size = new System.Drawing.Size(83, 13);
            this.yearLabelControl.TabIndex = 10;
            this.yearLabelControl.Text = "Выбранный год:";
            this.yearLabelControl.Visible = false;
            // 
            // yearDateEdit
            // 
            this.yearDateEdit.EditValue = null;
            this.yearDateEdit.Location = new System.Drawing.Point(158, 107);
            this.yearDateEdit.Name = "yearDateEdit";
            this.yearDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.yearDateEdit.Properties.Mask.EditMask = "yyyy";
            this.yearDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.yearDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.yearDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.yearDateEdit.Size = new System.Drawing.Size(75, 20);
            this.yearDateEdit.TabIndex = 15;
            this.yearDateEdit.Visible = false;
            // 
            // FormReportPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(681, 245);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReportPeriod";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Данные для отчёта";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartalImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton actionButton;
        private DevExpress.XtraEditors.LabelControl periodLabelControl;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit periodDateEdit;
        private ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace renterDataSelectOutOfPlace;
        private ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace callServiceDataSelectOutOfPlace;
        private ServiceTypes.BusinessForms.UserControl.DataSelectOutOfPlace ndsServiceDataSelectOutOfPlace;
        private DevExpress.XtraEditors.ImageComboBoxEdit quartalImageComboBoxEdit;
        private DevExpress.XtraEditors.LabelControl quartalLabelControl;
        private DevExpress.XtraEditors.DateEdit yearDateEdit;
        private DevExpress.XtraEditors.LabelControl yearLabelControl;
    }
}