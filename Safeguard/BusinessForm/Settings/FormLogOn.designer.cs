namespace Safeguard.BusinessForm.Settings
{
    partial class FormLogOn
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbLogins = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.actionButton = new DevExpress.XtraEditors.SimpleButton();
            this.rememberPasswordCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.rememberPasswordCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(36, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(41, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин:";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(29, 47);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(48, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Пароль:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbLogins
            // 
            this.cbLogins.DisplayMember = "Pash;Admin";
            this.cbLogins.FormattingEnabled = true;
            this.cbLogins.Location = new System.Drawing.Point(83, 13);
            this.cbLogins.Name = "cbLogins";
            this.cbLogins.Size = new System.Drawing.Size(204, 21);
            this.cbLogins.TabIndex = 0;
            this.cbLogins.ValueMember = "Pash;Admin";
            this.cbLogins.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveFocesToNextControl);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(83, 44);
            this.tbPassword.MaxLength = 16;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(204, 21);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveFocesToNextControl);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(164, 100);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(83, 100);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 2;
            this.actionButton.Text = "OK";
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // rememberPasswordCheckEdit
            // 
            this.rememberPasswordCheckEdit.Location = new System.Drawing.Point(100, 71);
            this.rememberPasswordCheckEdit.Name = "rememberPasswordCheckEdit";
            this.rememberPasswordCheckEdit.Properties.Caption = "запомнить пароль";
            this.rememberPasswordCheckEdit.Size = new System.Drawing.Size(139, 19);
            this.rememberPasswordCheckEdit.TabIndex = 4;
            // 
            // FormLogOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 135);
            this.Controls.Add(this.rememberPasswordCheckEdit);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.cbLogins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogOn";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вход в программу";
            ((System.ComponentModel.ISupportInitialize)(this.rememberPasswordCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLogins;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton actionButton;
        private DevExpress.XtraEditors.CheckEdit rememberPasswordCheckEdit;
    }
}