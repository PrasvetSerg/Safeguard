using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Safeguard.BusinessForm.Settings
{
    public partial class FormLogOn : DevExpress.XtraEditors.XtraForm
    {
        public delegate bool ConfirmLoginPasswordDelegate(IWin32Window sender, string login, string password);
        ConfirmLoginPasswordDelegate ConfirmLoginPassword;

        Properties.Settings settings;

        public FormLogOn(ConfirmLoginPasswordDelegate confirmLoginPasswordDelegate)
        {
            settings = new Properties.Settings();
            InitializeComponent();


            this.rememberPasswordCheckEdit.Checked = settings.RememberPassword;
            this.rememberPasswordCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings, "RememberPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));

            ConfirmLoginPassword = confirmLoginPasswordDelegate;

            this.cbLogins.DataSource = settings.LoginsList;
            this.cbLogins.SelectedItem = settings.LoginLast;

            if (this.rememberPasswordCheckEdit.Checked)
            {
                this.tbPassword.Text = RestorePassword();
            }
        }

        public void ClearConfidentialData()
        {
            settings.LoginLast = "";
            settings.LoginsList.Clear();
            settings.RememberPassword = false;

            settings.CryptedKey = null;
            settings.CryptedVector = null;
            settings.CryptedPassword = null;

            settings.Save();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            if (this.cbLogins.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Введите логин", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.tbPassword.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Введите пароль", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                /*
            else if (ConfirmLoginPassword(this, UserLogIn, UserPassword) == false)//TODO: verifid login in db
            {
                //DevExpress.XtraEditors.XtraMessageBox.Show(this, "Incorrect password or login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                */
            else
            {
                //save user logins
                if (this.cbLogins.Items.Contains(this.cbLogins.Text) == false)
                {
                    if (settings.LoginsList == null)
                    {
                        settings.LoginsList = new System.Collections.Specialized.StringCollection();
                    }
                    settings.LoginsList.Add(this.cbLogins.Text);
                }
                settings.LoginLast = this.cbLogins.Text;

                //save user password
                if (this.rememberPasswordCheckEdit.Checked)
                {
                    SavePassword(this.tbPassword.Text);
                }
                else
                {
                    SavePassword("");
                }

                settings.Save();
                this.DialogResult = DialogResult.OK;
            }
        }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            settings.Reload();
        }

        public string UserLogIn
        {
            get { return this.cbLogins.Text; }
        }

        public string UserPassword
        {
            get { return this.tbPassword.Text; }
        }

        //
        //Crypted and save to properties password
        //
        private void SavePassword(string password)
        {
            System.Security.Cryptography.AesCryptoServiceProvider aesCryptoServiceProvider = new System.Security.Cryptography.AesCryptoServiceProvider();

            GetAesKey(aesCryptoServiceProvider);

            byte[] byteStringOpened = new byte[password.Length];
            int i = 0;
            foreach (char ch in password)
            {
                byteStringOpened[i] = (byte)ch;
                i++;
            }
            byte[] byteStringCrypted = aesCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(byteStringOpened, 0, byteStringOpened.Length);

            settings.CryptedPassword = byteStringCrypted;

            aesCryptoServiceProvider.Clear();
        }

        //
        //Get from properties and decrypted password
        //
        private string RestorePassword()
        {
            System.Security.Cryptography.AesCryptoServiceProvider aesCryptoServiceProvider = new System.Security.Cryptography.AesCryptoServiceProvider();
            //System.Security.Cryptography.Aes aesCryptoServiceProvider = System.Security.Cryptography.AesCryptoServiceProvider.Create();

            GetAesKey(aesCryptoServiceProvider);

            byte[] byteStringCrypted = (byte[])settings.CryptedPassword;
            byte[] byteStringOpened = aesCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(byteStringCrypted, 0, byteStringCrypted.Length);

            string password = "";
            foreach (byte bt in byteStringOpened)
            {
                password += (char)bt;
            }

            aesCryptoServiceProvider.Clear();

            return password;
        }

        //
        //Generate and get AES key and vector
        //
        private void GetAesKey(System.Security.Cryptography.AesCryptoServiceProvider aesCryptoServiceProvider)
        {
            //byte[] byteArray = (byte[])settings.key;//если написать короче, то выпадает ошибка у пользователя
            //if (byteArray.Length < 1)
            if (settings.CryptedKey == null)
            {
                aesCryptoServiceProvider.GenerateKey();
                aesCryptoServiceProvider.GenerateIV();
                settings.CryptedKey = (byte[])aesCryptoServiceProvider.Key;
                settings.CryptedVector = (byte[])aesCryptoServiceProvider.IV;
            }
            else
            {
                aesCryptoServiceProvider.Key = (byte[])settings.CryptedKey;
                aesCryptoServiceProvider.IV = (byte[])settings.CryptedVector;
            }
        }

        private void MoveFocesToNextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
