namespace Safeguard.BusinessForm.Messages
{
    partial class FormReportAllocationForDate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportAllocationForDate));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.currentDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.comparedWeekDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.actionButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.period1LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.period2LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.periodGraficBeginDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.periodGraficEndDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.comparedMonthDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparedWeekDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparedWeekDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodGraficBeginDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodGraficBeginDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodGraficEndDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodGraficEndDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparedMonthDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparedMonthDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.currentDateEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comparedWeekDateEdit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.actionButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.period1LabelControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.period2LabelControl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comparedMonthDateEdit, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 189);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // currentDateEdit
            // 
            this.currentDateEdit.EditValue = null;
            this.currentDateEdit.EnterMoveNextControl = true;
            this.currentDateEdit.Location = new System.Drawing.Point(147, 3);
            this.currentDateEdit.Name = "currentDateEdit";
            this.currentDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.currentDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.currentDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.currentDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.currentDateEdit.Size = new System.Drawing.Size(100, 20);
            this.currentDateEdit.TabIndex = 0;
            this.currentDateEdit.ToolTip = "Исходная дата для отображения расстановки";
            this.currentDateEdit.EditValueChanged += new System.EventHandler(this.currentDateEdit_EditValueChanged);
            // 
            // comparedWeekDateEdit
            // 
            this.comparedWeekDateEdit.EditValue = null;
            this.comparedWeekDateEdit.EnterMoveNextControl = true;
            this.comparedWeekDateEdit.Location = new System.Drawing.Point(147, 29);
            this.comparedWeekDateEdit.Name = "comparedWeekDateEdit";
            this.comparedWeekDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comparedWeekDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.comparedWeekDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.comparedWeekDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.comparedWeekDateEdit.Size = new System.Drawing.Size(100, 20);
            this.comparedWeekDateEdit.TabIndex = 0;
            this.comparedWeekDateEdit.ToolTip = "Дата недельной давности для сравнения";
            // 
            // actionButton
            // 
            this.actionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.actionButton.Location = new System.Drawing.Point(147, 117);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 2;
            this.actionButton.Text = "&Продолжить";
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(66, 117);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Отмена";
            // 
            // period1LabelControl
            // 
            this.period1LabelControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.period1LabelControl.Location = new System.Drawing.Point(64, 6);
            this.period1LabelControl.Name = "period1LabelControl";
            this.period1LabelControl.Size = new System.Drawing.Size(77, 13);
            this.period1LabelControl.TabIndex = 7;
            this.period1LabelControl.Text = "Текущая дата:";
            // 
            // period2LabelControl
            // 
            this.period2LabelControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.period2LabelControl.Location = new System.Drawing.Point(31, 89);
            this.period2LabelControl.Name = "period2LabelControl";
            this.period2LabelControl.Size = new System.Drawing.Size(110, 13);
            this.period2LabelControl.TabIndex = 7;
            this.period2LabelControl.Text = "Период для графика:";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.periodGraficBeginDateEdit);
            this.panelControl2.Controls.Add(this.periodGraficEndDateEdit);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Location = new System.Drawing.Point(147, 81);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(265, 30);
            this.panelControl2.TabIndex = 8;
            // 
            // periodGraficBeginDateEdit
            // 
            this.periodGraficBeginDateEdit.EditValue = null;
            this.periodGraficBeginDateEdit.EnterMoveNextControl = true;
            this.periodGraficBeginDateEdit.Location = new System.Drawing.Point(20, 5);
            this.periodGraficBeginDateEdit.Name = "periodGraficBeginDateEdit";
            this.periodGraficBeginDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.periodGraficBeginDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.periodGraficBeginDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.periodGraficBeginDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.periodGraficBeginDateEdit.Size = new System.Drawing.Size(100, 20);
            this.periodGraficBeginDateEdit.TabIndex = 0;
            this.periodGraficBeginDateEdit.ToolTip = "Дата начала отображения для графика";
            // 
            // periodGraficEndDateEdit
            // 
            this.periodGraficEndDateEdit.EditValue = null;
            this.periodGraficEndDateEdit.EnterMoveNextControl = true;
            this.periodGraficEndDateEdit.Location = new System.Drawing.Point(148, 5);
            this.periodGraficEndDateEdit.Name = "periodGraficEndDateEdit";
            this.periodGraficEndDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.periodGraficEndDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.periodGraficEndDateEdit.Size = new System.Drawing.Size(100, 20);
            this.periodGraficEndDateEdit.TabIndex = 1;
            this.periodGraficEndDateEdit.ToolTip = "Дата окончания отображения для графика";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(9, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "с:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(126, 8);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(16, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "по:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(10, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(131, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Месячная для сравнения:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Location = new System.Drawing.Point(3, 32);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(138, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Недельная для сравнения:";
            // 
            // comparedMonthDateEdit
            // 
            this.comparedMonthDateEdit.EditValue = null;
            this.comparedMonthDateEdit.EnterMoveNextControl = true;
            this.comparedMonthDateEdit.Location = new System.Drawing.Point(147, 55);
            this.comparedMonthDateEdit.Name = "comparedMonthDateEdit";
            this.comparedMonthDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comparedMonthDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.comparedMonthDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.comparedMonthDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.comparedMonthDateEdit.Size = new System.Drawing.Size(100, 20);
            this.comparedMonthDateEdit.TabIndex = 0;
            this.comparedMonthDateEdit.ToolTip = "Дата месячной давности для сравнения";
            // 
            // FormReportAllocationForDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(518, 189);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReportAllocationForDate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Данные для отчёта";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparedWeekDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparedWeekDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodGraficBeginDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodGraficBeginDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodGraficEndDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodGraficEndDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparedMonthDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparedMonthDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton actionButton;
        private DevExpress.XtraEditors.LabelControl period1LabelControl;
        private DevExpress.XtraEditors.DateEdit currentDateEdit;
        private DevExpress.XtraEditors.LabelControl period2LabelControl;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit periodGraficBeginDateEdit;
        private DevExpress.XtraEditors.DateEdit periodGraficEndDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit comparedWeekDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit comparedMonthDateEdit;
    }
}