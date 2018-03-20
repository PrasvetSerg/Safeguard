namespace Administration
{
    partial class FormCommandEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommandEdit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.renterNameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.actionButton = new DevExpress.XtraEditors.SimpleButton();
            this.displayNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.commentMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.idTextEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameTextEdit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.renterNameLabelControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.actionButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.displayNameTextEdit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.commentMemoEdit, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 245);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // idTextEdit
            // 
            this.idTextEdit.EnterMoveNextControl = true;
            this.idTextEdit.Location = new System.Drawing.Point(84, 3);
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
            this.labelControl2.Location = new System.Drawing.Point(26, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "ID записи:";
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.EnterMoveNextControl = true;
            this.nameTextEdit.Location = new System.Drawing.Point(84, 27);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.Mask.EditMask = "\\d\\d\\d\\d \\d\\d \\d\\d\\d \\d";
            this.nameTextEdit.Properties.Mask.SaveLiteral = false;
            this.nameTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.nameTextEdit.Size = new System.Drawing.Size(335, 20);
            this.nameTextEdit.TabIndex = 0;
            // 
            // renterNameLabelControl
            // 
            this.renterNameLabelControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.renterNameLabelControl.Location = new System.Drawing.Point(30, 30);
            this.renterNameLabelControl.Name = "renterNameLabelControl";
            this.renterNameLabelControl.Size = new System.Drawing.Size(48, 13);
            this.renterNameLabelControl.TabIndex = 10;
            this.renterNameLabelControl.Text = "Команда:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(3, 139);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "&Отмена";
            // 
            // actionButton
            // 
            this.actionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.actionButton.Location = new System.Drawing.Point(84, 139);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 3;
            this.actionButton.Text = "&Сохранить";
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // displayNameTextEdit
            // 
            this.displayNameTextEdit.EnterMoveNextControl = true;
            this.displayNameTextEdit.Location = new System.Drawing.Point(84, 53);
            this.displayNameTextEdit.Name = "displayNameTextEdit";
            this.displayNameTextEdit.Properties.Mask.EditMask = "\\d\\d\\d\\d \\d\\d \\d\\d\\d \\d";
            this.displayNameTextEdit.Properties.Mask.SaveLiteral = false;
            this.displayNameTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.displayNameTextEdit.Size = new System.Drawing.Size(335, 20);
            this.displayNameTextEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(26, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Название:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Location = new System.Drawing.Point(25, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Описание:";
            // 
            // commentMemoEdit
            // 
            this.commentMemoEdit.Location = new System.Drawing.Point(84, 79);
            this.commentMemoEdit.Name = "commentMemoEdit";
            this.commentMemoEdit.Size = new System.Drawing.Size(335, 54);
            this.commentMemoEdit.TabIndex = 2;
            // 
            // FormCommandEdit
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
            this.Name = "FormCommandEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование информации о процедуре";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentMemoEdit.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl renterNameLabelControl;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit displayNameTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit commentMemoEdit;
    }
}