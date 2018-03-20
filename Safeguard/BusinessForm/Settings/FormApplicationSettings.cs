using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Safeguard.BusinessForm.Settings
{
    public partial class FormApplicationSettings : DevExpress.XtraEditors.XtraForm
    {
        public FormApplicationSettings()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            this.serverNameTextEdit.EditValue = global::Safeguard.Properties.Settings.Default.ConnectionServerName;
            this.databaseTextEdit.EditValue = global::Safeguard.Properties.Settings.Default.ConnectionDatabaseName;
            this.loginTypeImageComboBoxEdit.EditValue = global::Safeguard.Properties.Settings.Default.UseIntegratedSecurity;

            this.settingsDirectoryTextEdit.EditValue = global::Safeguard.Properties.Settings.Default.SettingsDirectory;
        }

        //проверка параметров соединения с базой данных
        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            bool isLogon = false;

            if ((bool)loginTypeImageComboBoxEdit.EditValue == true)
            {
                string connectionString = DBConnection.SqlQuery.GenerateConnectionString(
                    (string)this.serverNameTextEdit.EditValue
                    , (string)this.databaseTextEdit.EditValue
                    , true);

                isLogon = DBConnection.SqlQuery.TestConnectionString(connectionString);
            }
            else
            {
                FormLogOn formLogOn = new FormLogOn(null);
                if (formLogOn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string connectionString = DBConnection.SqlQuery.GenerateConnectionString(
                       (string)this.serverNameTextEdit.EditValue
                       , (string)this.databaseTextEdit.EditValue
                       , (bool)this.loginTypeImageComboBoxEdit.EditValue
                       , formLogOn.UserLogIn
                       , formLogOn.UserPassword);

                    isLogon = DBConnection.SqlQuery.TestConnectionString(connectionString);
                }
            }

            if (isLogon == true)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Выполнено успешно!", "Проверка подключения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        #region Save data
        //фиксация результата изменения данных
        private void actionButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            //запись данных в базу
            if (IsInputedDataValid() == true)
            {
                if (SaveData())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(this, "Выполнить изменение не удалось. Попробуйте позже.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Проверка введёных данных
        private bool IsInputedDataValid()
        {
            bool isInputedDataValid = true;

            if (isInputedDataValid == true && this.serverNameTextEdit.EditValue.ToString().Length < 2)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Укажите сервер базы данных", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && this.databaseTextEdit.EditValue.ToString().Length < 2)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Введите имя базы данных", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isInputedDataValid == true && this.loginTypeImageComboBoxEdit.SelectedIndex == -1)
            {
                isInputedDataValid = false;
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Выберите тип авторизации", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isInputedDataValid;
        }

        //сохранение данных в базу
        private bool SaveData()
        {
            bool isSavedData = false;

            global::Safeguard.Properties.Settings.Default.ConnectionServerName = (string)this.serverNameTextEdit.EditValue;
            global::Safeguard.Properties.Settings.Default.ConnectionDatabaseName = (string)this.databaseTextEdit.EditValue;
            global::Safeguard.Properties.Settings.Default.UseIntegratedSecurity = (bool)this.loginTypeImageComboBoxEdit.EditValue;

            global::Safeguard.Properties.Settings.Default.SettingsDirectory = (string)this.settingsDirectoryTextEdit.EditValue;
        
            global::Safeguard.Properties.Settings.Default.Save();
            isSavedData = true;

            return isSavedData;
        }
        #endregion
                
    }
}