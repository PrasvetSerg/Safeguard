namespace Safeguard.BusinessForm.Messages
{
    partial class FormReportComparedPeriods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportComparedPeriods));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.actionButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.period1LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.period1BeginDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.period1EndDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.period2LabelControl = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.period2BeginDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.period2EndDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.period1BeginDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period1BeginDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period1EndDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period1EndDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.period2BeginDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period2BeginDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period2EndDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period2EndDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.actionButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.period1LabelControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.period2LabelControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 141);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // actionButton
            // 
            this.actionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.actionButton.Location = new System.Drawing.Point(92, 63);
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
            this.cancelButton.Location = new System.Drawing.Point(11, 63);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Отмена";
            // 
            // period1LabelControl
            // 
            this.period1LabelControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.period1LabelControl.Location = new System.Drawing.Point(3, 8);
            this.period1LabelControl.Name = "period1LabelControl";
            this.period1LabelControl.Size = new System.Drawing.Size(83, 13);
            this.period1LabelControl.TabIndex = 7;
            this.period1LabelControl.Text = "Первый период:";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.period1BeginDateEdit);
            this.panelControl1.Controls.Add(this.period1EndDateEdit);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(89, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(265, 30);
            this.panelControl1.TabIndex = 8;
            // 
            // period1BeginDateEdit
            // 
            this.period1BeginDateEdit.EditValue = null;
            this.period1BeginDateEdit.EnterMoveNextControl = true;
            this.period1BeginDateEdit.Location = new System.Drawing.Point(20, 5);
            this.period1BeginDateEdit.Name = "period1BeginDateEdit";
            this.period1BeginDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.period1BeginDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.period1BeginDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.period1BeginDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.period1BeginDateEdit.Size = new System.Drawing.Size(100, 20);
            this.period1BeginDateEdit.TabIndex = 0;
            // 
            // period1EndDateEdit
            // 
            this.period1EndDateEdit.EditValue = null;
            this.period1EndDateEdit.EnterMoveNextControl = true;
            this.period1EndDateEdit.Location = new System.Drawing.Point(148, 5);
            this.period1EndDateEdit.Name = "period1EndDateEdit";
            this.period1EndDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.period1EndDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.period1EndDateEdit.Size = new System.Drawing.Size(100, 20);
            this.period1EndDateEdit.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(9, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "с:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(126, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(16, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "по:";
            // 
            // period2LabelControl
            // 
            this.period2LabelControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.period2LabelControl.Location = new System.Drawing.Point(6, 38);
            this.period2LabelControl.Name = "period2LabelControl";
            this.period2LabelControl.Size = new System.Drawing.Size(80, 13);
            this.period2LabelControl.TabIndex = 7;
            this.period2LabelControl.Text = "Второй период:";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.period2BeginDateEdit);
            this.panelControl2.Controls.Add(this.period2EndDateEdit);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Location = new System.Drawing.Point(89, 30);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(265, 30);
            this.panelControl2.TabIndex = 8;
            // 
            // period2BeginDateEdit
            // 
            this.period2BeginDateEdit.EditValue = null;
            this.period2BeginDateEdit.EnterMoveNextControl = true;
            this.period2BeginDateEdit.Location = new System.Drawing.Point(20, 5);
            this.period2BeginDateEdit.Name = "period2BeginDateEdit";
            this.period2BeginDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.period2BeginDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.period2BeginDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.period2BeginDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.period2BeginDateEdit.Size = new System.Drawing.Size(100, 20);
            this.period2BeginDateEdit.TabIndex = 0;
            // 
            // period2EndDateEdit
            // 
            this.period2EndDateEdit.EditValue = null;
            this.period2EndDateEdit.EnterMoveNextControl = true;
            this.period2EndDateEdit.Location = new System.Drawing.Point(148, 5);
            this.period2EndDateEdit.Name = "period2EndDateEdit";
            this.period2EndDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.period2EndDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.period2EndDateEdit.Size = new System.Drawing.Size(100, 20);
            this.period2EndDateEdit.TabIndex = 1;
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
            // FormReportComparedPeriods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(518, 141);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReportComparedPeriods";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Данные для отчёта";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.period1BeginDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period1BeginDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period1EndDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period1EndDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.period2BeginDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period2BeginDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period2EndDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period2EndDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton actionButton;
        private DevExpress.XtraEditors.LabelControl period1LabelControl;
        private DevExpress.XtraEditors.DateEdit period1BeginDateEdit;
        private DevExpress.XtraEditors.DateEdit period1EndDateEdit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl period2LabelControl;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit period2BeginDateEdit;
        private DevExpress.XtraEditors.DateEdit period2EndDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}