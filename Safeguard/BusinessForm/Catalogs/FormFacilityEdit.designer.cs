namespace Safeguard.BusinessForm.Catalogs
{
    partial class FormFacilityEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacilityEdit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.actionButton = new DevExpress.XtraEditors.SimpleButton();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.sequenceLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.commentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sequenceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.actionButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.idTextEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTextEdit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameLabelControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.sequenceLabelControl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.commentTextEdit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.sequenceTextEdit, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 303);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(40, 105);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "&Отмена";
            // 
            // actionButton
            // 
            this.actionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.actionButton.Location = new System.Drawing.Point(121, 105);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 3;
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
            // nameTextEdit
            // 
            this.nameTextEdit.EnterMoveNextControl = true;
            this.nameTextEdit.Location = new System.Drawing.Point(121, 27);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.Mask.EditMask = "\\d\\d\\d\\d \\d\\d \\d\\d\\d \\d";
            this.nameTextEdit.Properties.Mask.SaveLiteral = false;
            this.nameTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.nameTextEdit.Size = new System.Drawing.Size(461, 20);
            this.nameTextEdit.TabIndex = 0;
            // 
            // nameLabelControl
            // 
            this.nameLabelControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabelControl.Location = new System.Drawing.Point(38, 30);
            this.nameLabelControl.Name = "nameLabelControl";
            this.nameLabelControl.Size = new System.Drawing.Size(77, 13);
            this.nameLabelControl.TabIndex = 10;
            this.nameLabelControl.Text = "Наименование:";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Location = new System.Drawing.Point(50, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Примечание:";
            // 
            // sequenceLabelControl
            // 
            this.sequenceLabelControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sequenceLabelControl.Location = new System.Drawing.Point(3, 56);
            this.sequenceLabelControl.Name = "sequenceLabelControl";
            this.sequenceLabelControl.Size = new System.Drawing.Size(112, 13);
            this.sequenceLabelControl.TabIndex = 10;
            this.sequenceLabelControl.Text = "Последовательность:";
            // 
            // commentTextEdit
            // 
            this.commentTextEdit.EnterMoveNextControl = true;
            this.commentTextEdit.Location = new System.Drawing.Point(121, 79);
            this.commentTextEdit.Name = "commentTextEdit";
            this.commentTextEdit.Properties.Mask.EditMask = "\\d\\d\\d\\d \\d\\d \\d\\d\\d \\d";
            this.commentTextEdit.Properties.Mask.SaveLiteral = false;
            this.commentTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.commentTextEdit.Size = new System.Drawing.Size(461, 20);
            this.commentTextEdit.TabIndex = 2;
            // 
            // sequenceTextEdit
            // 
            this.sequenceTextEdit.EnterMoveNextControl = true;
            this.sequenceTextEdit.Location = new System.Drawing.Point(121, 53);
            this.sequenceTextEdit.Name = "sequenceTextEdit";
            this.sequenceTextEdit.Properties.Mask.EditMask = "\\d+";
            this.sequenceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.sequenceTextEdit.Properties.Mask.SaveLiteral = false;
            this.sequenceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.sequenceTextEdit.Size = new System.Drawing.Size(43, 20);
            this.sequenceTextEdit.TabIndex = 1;
            // 
            // FormDepartmentEdit
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
            this.Name = "FormDepartmentEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceTextEdit.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit commentTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl sequenceLabelControl;
        private DevExpress.XtraEditors.TextEdit sequenceTextEdit;
    }
}