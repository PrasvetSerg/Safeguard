using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Safeguard
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //сомнительная полезность
            //Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(UIThreadException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();    
            Application.Run(new FormMain());
        }

        private static void UIThreadException(object sender, System.Threading.ThreadExceptionEventArgs t)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(t.Exception.ToString(), t.Exception.Message);
        }
    }
}
