﻿namespace Safeguard.BusinessForm.Journals
{
    partial class FormGroupEmployeeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroupEmployeeEdit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.actionButton = new DevExpress.XtraEditors.SimpleButton();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.sequenceLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.commentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sequenceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.employeeDataSelectOutOfPlace = new Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace();
            this.groupDataSelectOutOfPlace = new Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.useFromDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.useToDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useFromDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useFromDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useToDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useToDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.actionButton, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.idTextEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameLabelControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.sequenceLabelControl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.commentTextEdit, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.sequenceTextEdit, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.employeeDataSelectOutOfPlace, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupDataSelectOutOfPlace, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.useFromDateEdit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.useToDateEdit, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 303);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(40, 183);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "&Отмена";
            // 
            // actionButton
            // 
            this.actionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.actionButton.Location = new System.Drawing.Point(121, 183);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 6;
            this.actionButton.Text = "&Сохранить";
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // idTextEdit
            // 
            this.idTextEdit.EnterMoveNextControl = true;
            this.idTextEdit.Location = new System.Drawing.Point(121, 3);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.idTextEdit.Properties.Mask.EditMask = "\\d\\d\\d";
            this.idTextEdit.Properties.ReadOnly = true;
            this.idTextEdit.Size = new System.Drawing.Size(75, 18);
            this.idTextEdit.TabIndex = 9;
            this.idTextEdit.TabStop = false;
            this.idTextEdit.ToolTip = "Внутренний номер записи";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Location = new System.Drawing.Point(63, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "ID записи:";
            // 
            // nameLabelControl
            // 
            this.nameLabelControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabelControl.Location = new System.Drawing.Point(75, 30);
            this.nameLabelControl.Name = "nameLabelControl";
            this.nameLabelControl.Size = new System.Drawing.Size(40, 13);
            this.nameLabelControl.TabIndex = 10;
            this.nameLabelControl.Text = "Группа:";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Location = new System.Drawing.Point(50, 160);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Примечание:";
            // 
            // sequenceLabelControl
            // 
            this.sequenceLabelControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sequenceLabelControl.Location = new System.Drawing.Point(3, 134);
            this.sequenceLabelControl.Name = "sequenceLabelControl";
            this.sequenceLabelControl.Size = new System.Drawing.Size(112, 13);
            this.sequenceLabelControl.TabIndex = 10;
            this.sequenceLabelControl.Text = "Последовательность:";
            this.sequenceLabelControl.Visible = false;
            // 
            // commentTextEdit
            // 
            this.commentTextEdit.EnterMoveNextControl = true;
            this.commentTextEdit.Location = new System.Drawing.Point(121, 157);
            this.commentTextEdit.Name = "commentTextEdit";
            this.commentTextEdit.Properties.Mask.EditMask = "\\d\\d\\d\\d \\d\\d \\d\\d\\d \\d";
            this.commentTextEdit.Properties.Mask.SaveLiteral = false;
            this.commentTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.commentTextEdit.Size = new System.Drawing.Size(461, 20);
            this.commentTextEdit.TabIndex = 5;
            // 
            // sequenceTextEdit
            // 
            this.sequenceTextEdit.EnterMoveNextControl = true;
            this.sequenceTextEdit.Location = new System.Drawing.Point(121, 131);
            this.sequenceTextEdit.Name = "sequenceTextEdit";
            this.sequenceTextEdit.Properties.Mask.EditMask = "\\d+";
            this.sequenceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.sequenceTextEdit.Properties.Mask.SaveLiteral = false;
            this.sequenceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.sequenceTextEdit.Size = new System.Drawing.Size(43, 20);
            this.sequenceTextEdit.TabIndex = 4;
            this.sequenceTextEdit.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(55, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Сотрудник:";
            // 
            // employeeDataSelectOutOfPlace
            // 
            this.employeeDataSelectOutOfPlace.EnterMoveNextControl = true;
            this.employeeDataSelectOutOfPlace.Location = new System.Drawing.Point(121, 53);
            this.employeeDataSelectOutOfPlace.Name = "employeeDataSelectOutOfPlace";
            this.employeeDataSelectOutOfPlace.ShownText = "";
            this.employeeDataSelectOutOfPlace.Size = new System.Drawing.Size(461, 20);
            this.employeeDataSelectOutOfPlace.TabIndex = 1;
            this.employeeDataSelectOutOfPlace.ButtonSelectClick += new Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace.DelegateButtonSelectClick(this.employeeDataSelectOutOfPlace_ButtonSelectClick);
            this.employeeDataSelectOutOfPlace.RecordIdChanged += new Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace.DelegateRecordIdChanged(this.employeeDataSelectOutOfPlace_RecordIdChanged);
            // 
            // groupDataSelectOutOfPlace
            // 
            this.groupDataSelectOutOfPlace.EnterMoveNextControl = true;
            this.groupDataSelectOutOfPlace.Location = new System.Drawing.Point(121, 27);
            this.groupDataSelectOutOfPlace.Name = "groupDataSelectOutOfPlace";
            this.groupDataSelectOutOfPlace.ShownText = "";
            this.groupDataSelectOutOfPlace.Size = new System.Drawing.Size(461, 20);
            this.groupDataSelectOutOfPlace.TabIndex = 0;
            this.groupDataSelectOutOfPlace.ButtonSelectClick += new Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace.DelegateButtonSelectClick(this.groupDataSelectOutOfPlace_ButtonSelectClick);
            this.groupDataSelectOutOfPlace.RecordIdChanged += new Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace.DelegateRecordIdChanged(this.groupDataSelectOutOfPlace_RecordIdChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Location = new System.Drawing.Point(104, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(11, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "C:";
            this.labelControl3.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Location = new System.Drawing.Point(98, 108);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(17, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "По:";
            this.labelControl5.Visible = false;
            // 
            // useFromDateEdit
            // 
            this.useFromDateEdit.EditValue = null;
            this.useFromDateEdit.Location = new System.Drawing.Point(121, 79);
            this.useFromDateEdit.Name = "useFromDateEdit";
            this.useFromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.useFromDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.useFromDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.useFromDateEdit.Size = new System.Drawing.Size(100, 20);
            this.useFromDateEdit.TabIndex = 2;
            // 
            // useToDateEdit
            // 
            this.useToDateEdit.EditValue = null;
            this.useToDateEdit.Location = new System.Drawing.Point(121, 105);
            this.useToDateEdit.Name = "useToDateEdit";
            this.useToDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.useToDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.useToDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.useToDateEdit.Size = new System.Drawing.Size(100, 20);
            this.useToDateEdit.TabIndex = 3;
            // 
            // FormGroupEmployeeEdit
            // 
            this.AcceptButton = this.actionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(648, 303);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGroupEmployeeEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useFromDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useFromDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useToDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useToDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton actionButton;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl nameLabelControl;
        private DevExpress.XtraEditors.TextEdit commentTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl sequenceLabelControl;
        private DevExpress.XtraEditors.TextEdit sequenceTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Safeguard.BusinessForm.UserControl.DataSelectOutOfPlace employeeDataSelectOutOfPlace;
        private UserControl.DataSelectOutOfPlace groupDataSelectOutOfPlace;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit useFromDateEdit;
        private DevExpress.XtraEditors.DateEdit useToDateEdit;
    }
}