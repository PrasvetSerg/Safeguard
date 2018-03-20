namespace Administration
{
    partial class FormUsersEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsersEdit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.middleNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.shortNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.actionButton = new DevExpress.XtraEditors.SimpleButton();
            this.commentMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.isBlockedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isBlockedCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.idTextEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.actionButton, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.shortNameTextEdit, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.middleNameTextEdit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.firstNameTextEdit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.loginTextEdit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lastNameTextEdit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.commentMemoEdit, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.isBlockedCheckEdit, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 255);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lastNameTextEdit
            // 
            this.lastNameTextEdit.AllowDrop = true;
            this.lastNameTextEdit.EnterMoveNextControl = true;
            this.lastNameTextEdit.Location = new System.Drawing.Point(125, 55);
            this.lastNameTextEdit.Name = "lastNameTextEdit";
            this.lastNameTextEdit.Properties.Mask.EditMask = "[А-Яа-я\\-ёЁ]+";
            this.lastNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.lastNameTextEdit.Properties.MaxLength = 50;
            this.lastNameTextEdit.Size = new System.Drawing.Size(245, 20);
            this.lastNameTextEdit.TabIndex = 1;
            this.lastNameTextEdit.EditValueChanged += new System.EventHandler(this.CreateShortName_EditValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID пользователя:";
            // 
            // idTextEdit
            // 
            this.idTextEdit.Location = new System.Drawing.Point(125, 3);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Properties.Mask.EditMask = "\\d\\d\\d\\d\\d";
            this.idTextEdit.Size = new System.Drawing.Size(54, 20);
            this.idTextEdit.TabIndex = 100;
            this.idTextEdit.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Отчество:";
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.AllowDrop = true;
            this.firstNameTextEdit.EnterMoveNextControl = true;
            this.firstNameTextEdit.Location = new System.Drawing.Point(125, 81);
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Properties.Mask.EditMask = "[А-Яа-я\\-ёЁ]+";
            this.firstNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.firstNameTextEdit.Properties.MaxLength = 50;
            this.firstNameTextEdit.Size = new System.Drawing.Size(245, 20);
            this.firstNameTextEdit.TabIndex = 2;
            this.firstNameTextEdit.EditValueChanged += new System.EventHandler(this.CreateShortName_EditValueChanged);
            // 
            // middleNameTextEdit
            // 
            this.middleNameTextEdit.AllowDrop = true;
            this.middleNameTextEdit.EnterMoveNextControl = true;
            this.middleNameTextEdit.Location = new System.Drawing.Point(125, 107);
            this.middleNameTextEdit.Name = "middleNameTextEdit";
            this.middleNameTextEdit.Properties.Mask.EditMask = "[А-Яа-я\\-ёЁ]+";
            this.middleNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.middleNameTextEdit.Properties.MaxLength = 50;
            this.middleNameTextEdit.Size = new System.Drawing.Size(245, 20);
            this.middleNameTextEdit.TabIndex = 3;
            this.middleNameTextEdit.EditValueChanged += new System.EventHandler(this.CreateShortName_EditValueChanged);
            // 
            // shortNameTextEdit
            // 
            this.shortNameTextEdit.AllowDrop = true;
            this.shortNameTextEdit.EnterMoveNextControl = true;
            this.shortNameTextEdit.Location = new System.Drawing.Point(125, 133);
            this.shortNameTextEdit.Name = "shortNameTextEdit";
            this.shortNameTextEdit.Properties.Mask.EditMask = "[А-Яа-я\\- .ёЁ]+";
            this.shortNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.shortNameTextEdit.Properties.MaxLength = 50;
            this.shortNameTextEdit.Size = new System.Drawing.Size(245, 20);
            this.shortNameTextEdit.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Кратко:";
            // 
            // actionButton
            // 
            this.actionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.actionButton.Location = new System.Drawing.Point(125, 225);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 7;
            this.actionButton.Text = "&Сохранить";
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // commentMemoEdit
            // 
            this.commentMemoEdit.Location = new System.Drawing.Point(125, 184);
            this.commentMemoEdit.Name = "commentMemoEdit";
            this.commentMemoEdit.Properties.MaxLength = 100;
            this.commentMemoEdit.Size = new System.Drawing.Size(351, 35);
            this.commentMemoEdit.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(44, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Отмена";
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.AllowDrop = true;
            this.loginTextEdit.EnterMoveNextControl = true;
            this.loginTextEdit.Location = new System.Drawing.Point(125, 29);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Properties.MaxLength = 50;
            this.loginTextEdit.Size = new System.Drawing.Size(169, 20);
            this.loginTextEdit.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Имя входа в систему:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Примечание:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tableLayoutPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(594, 259);
            this.panelControl1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Заблокирован:";
            // 
            // isBlockedCheckEdit
            // 
            this.isBlockedCheckEdit.Location = new System.Drawing.Point(125, 159);
            this.isBlockedCheckEdit.Name = "isBlockedCheckEdit";
            this.isBlockedCheckEdit.Properties.Caption = "";
            this.isBlockedCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.isBlockedCheckEdit.TabIndex = 5;
            // 
            // FormUsersEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 259);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsersEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Данные пользователя";
            this.Shown += new System.EventHandler(this.FormEdit_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isBlockedCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit lastNameTextEdit;
        private DevExpress.XtraEditors.MemoEdit commentMemoEdit;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton actionButton;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit middleNameTextEdit;
        private DevExpress.XtraEditors.TextEdit shortNameTextEdit;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.CheckEdit isBlockedCheckEdit;
    }
}