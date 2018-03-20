namespace Safeguard.BusinessForm.Settings
{
    partial class FormApplicationSettings
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.testConnectionButton = new DevExpress.XtraEditors.SimpleButton();
            this.loginTypeImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.databaseTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.serverNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.actionButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.settingsDirectoryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginTypeImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsDirectoryTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.testConnectionButton);
            this.groupControl1.Controls.Add(this.loginTypeImageComboBoxEdit);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.databaseTextEdit);
            this.groupControl1.Controls.Add(this.serverNameTextEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.MinimumSize = new System.Drawing.Size(360, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(369, 115);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Подключение к базе данных";
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Location = new System.Drawing.Point(295, 76);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(56, 21);
            this.testConnectionButton.TabIndex = 3;
            this.testConnectionButton.Text = "Тест";
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // loginTypeImageComboBoxEdit
            // 
            this.loginTypeImageComboBoxEdit.EditValue = true;
            this.loginTypeImageComboBoxEdit.EnterMoveNextControl = true;
            this.loginTypeImageComboBoxEdit.Location = new System.Drawing.Point(104, 77);
            this.loginTypeImageComboBoxEdit.Name = "loginTypeImageComboBoxEdit";
            this.loginTypeImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loginTypeImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Windows", true, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("SQL", false, -1)});
            this.loginTypeImageComboBoxEdit.Size = new System.Drawing.Size(174, 20);
            this.loginTypeImageComboBoxEdit.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Тип авторизации";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "База данных";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Сервер";
            // 
            // databaseTextEdit
            // 
            this.databaseTextEdit.EditValue = "";
            this.databaseTextEdit.EnterMoveNextControl = true;
            this.databaseTextEdit.Location = new System.Drawing.Point(104, 51);
            this.databaseTextEdit.Name = "databaseTextEdit";
            this.databaseTextEdit.Size = new System.Drawing.Size(174, 20);
            this.databaseTextEdit.TabIndex = 1;
            // 
            // serverNameTextEdit
            // 
            this.serverNameTextEdit.EditValue = "";
            this.serverNameTextEdit.EnterMoveNextControl = true;
            this.serverNameTextEdit.Location = new System.Drawing.Point(104, 25);
            this.serverNameTextEdit.Name = "serverNameTextEdit";
            this.serverNameTextEdit.Size = new System.Drawing.Size(174, 20);
            this.serverNameTextEdit.TabIndex = 0;
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(104, 298);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 0;
            this.actionButton.Text = "Сохранить";
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(194, 298);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.settingsDirectoryTextEdit);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 115);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(369, 84);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Размещение настроек";
            // 
            // settingsDirectoryTextEdit
            // 
            this.settingsDirectoryTextEdit.EditValue = "";
            this.settingsDirectoryTextEdit.EnterMoveNextControl = true;
            this.settingsDirectoryTextEdit.Location = new System.Drawing.Point(130, 25);
            this.settingsDirectoryTextEdit.Name = "settingsDirectoryTextEdit";
            this.settingsDirectoryTextEdit.Size = new System.Drawing.Size(227, 20);
            this.settingsDirectoryTextEdit.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(112, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Размещение настроек";
            // 
            // FormApplicationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 333);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormApplicationSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки программы";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginTypeImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsDirectoryTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit loginTypeImageComboBoxEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit databaseTextEdit;
        private DevExpress.XtraEditors.TextEdit serverNameTextEdit;
        private DevExpress.XtraEditors.SimpleButton testConnectionButton;
        private DevExpress.XtraEditors.SimpleButton actionButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit settingsDirectoryTextEdit;
    }
}