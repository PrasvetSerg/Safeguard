using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ExceptionHandler
{
    public static class Handler
    {
        public static void ProcessSqlException(IWin32Window sender, SqlException exception)
        {
            if (exception.Class == 11)
            {
                if (exception.Number == 50000)
                {
                    XtraMessageBox.Show(sender, exception.Message, "Сообщите программисту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show(sender, exception.Message + "\nПроверьте имя сервера и имя базы данных", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (exception.Class == 12)
            {
                if (exception.Number == 50000)
                {
                    XtraMessageBox.Show(sender, exception.Message, "Действие ограничено установленными правилами", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (exception.Class == 14)
            {
                XtraMessageBox.Show(sender, exception.Message + "\nПроверьте логин или пароль.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (exception.Class == 20)
            {
                XtraMessageBox.Show(sender, exception.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Class" + exception.Class.ToString() + "\n" + exception.Message, "Неописанное исключение при подлючении к БД");
            }
        }

        public enum MessageName
        {
            UserNotFound,
            UserIsBlocked
        }

        public static void ShowInfoMessage(IWin32Window sender, MessageName messageName)
        {
            if (messageName == MessageName.UserNotFound)
            {
                XtraMessageBox.Show(sender, "Пользователь заблокирован или отсутствует в базе данных. Обратитесь к старшему пользователя", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (messageName == MessageName.UserIsBlocked)
            {
                XtraMessageBox.Show(sender, "Пользователь заблокирован. Обратитесь к старшиму уточнения причин и разблокировки", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
