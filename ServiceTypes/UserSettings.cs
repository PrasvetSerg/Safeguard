using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceTypes
{
    public static class UserSettings
    {
        static string programSettingsPath;

        static UserSettings()
        {
            ProgramSettingsPath = "";
        }

        public static string ProgramSettingsPath
        {
            get{return programSettingsPath;}
            set
            {
                if (value != null && value.Length > 0)
                {
                    //выполнить проверку путь это или папка и наличие последнего слеша
                    programSettingsPath = value;
                }
                else
                {
                    programSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Safeguard\\";
                }
            }
        }


    }
}
