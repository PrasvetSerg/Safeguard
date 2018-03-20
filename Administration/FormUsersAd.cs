using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace Administration
{
    public partial class FormUsersAd : DevExpress.XtraEditors.XtraForm
    {
        public FormUsersAd()
        {
            InitializeComponent();
        }

        public string GetUserDisplayName()
        {
            string identity = "LAN\\kpg";
            string displayName = String.Empty;
            PrincipalContext context;

            if (identity.Substring(0, 7).ToLower() == "polymir")
                context = new PrincipalContext(ContextType.Domain, "POLYMIR.NET");
            else
                context = new PrincipalContext(ContextType.Domain, "lan.naftan.by");
            
            UserPrincipal usr = UserPrincipal.FindByIdentity(context,
                                             IdentityType.SamAccountName,
                                             "*");
            //context.ValidateCredentials(
            //GroupPrincipal.
            using (context)
            {
                var principal = UserPrincipal.FindByIdentity(context, identity);
                displayName = principal.ToString();//principal.DisplayName;
                //var groupPrincipal = GroupPrincipal.FindByIdentity(context, "(name=*)");
            }
            
            return displayName;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserDomainName;
            string hostName = Environment.MachineName;
            //GetUserDisplayName();

            System.DirectoryServices.

            //Работает
            DirectoryEntry domain = new DirectoryEntry( "WinNT://lan.naftan.by" );
            foreach( DirectoryEntry user in domain.Children )
            {
                if (user.Name.Contains("Admin") == true)
                {
                    string groupN = user.Name;
                }
                
                if (user.Name.Contains("kpg") == true)
                {
                    string groupN = user.Name;
                }
            }









            //Не работает

            String myADSPath = "LDAP://DC=lan,DC=naftan,DC=by";


            DirectoryEntry myDirectoryEntry = new DirectoryEntry(myADSPath);

            myDirectoryEntry.Username = @"lan\kpg";
            myDirectoryEntry.Password = "";

            // Get the Child ADS objects.  Console.WriteLine("The Child ADS objects are:");

            foreach (DirectoryEntry myChildDirectoryEntry in myDirectoryEntry.Children)
            {
                string str = myChildDirectoryEntry.Path;
            }










            //не работает

            //string searchString = "tariff";

            var domainPath = "lan.naftan.by";
            var directoryEntry = new DirectoryEntry(domainPath,"LAN\\kpg",@"");
            var dirSearcher = new DirectorySearcher(directoryEntry);
            dirSearcher.SearchScope = SearchScope.Subtree;
            //dirSearcher.Filter = string.Format("(&(objectClass=user)(|(cn={0})(sn={0}*)(givenName={0})(sAMAccountName={0}*)))", searchString);
            dirSearcher.Filter = "&(objectCategory=person)(objectClass=user)";
            var searchResults = dirSearcher.FindAll();
            foreach (SearchResult sr in searchResults)
            {
                var de = sr.GetDirectoryEntry();
                //...do smth
            }

            // Строка запроса (&(objectClass=user)(|(cn={0})(sn={0}*)(givenName={0})(sAMAccountName={0}*)))
            //соответственно здесь идет поиск пользователя по свойствам cn, sn, givenName, sAMAccountName
        }

        //тест скорости появления отчёта, если он формируется не для web
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            /*
            //http://db2/ReportServer/Pages/ReportViewer.aspx?%2fBillingReports%2fmts_service_detail_report2
            Mailing.ReportingServiceProvider rsp = new Mailing.ReportingServiceProvider("/BillingReports/mts_service_detail_report2");

            //создание отчёта
            Mailing.db2.ParameterValue[] parameters = new Mailing.db2.ParameterValue[1];
            parameters[0] = new Mailing.db2.ParameterValue();
            parameters[0].Name = "monthNum";
            parameters[0].Value = "3";

            byte[] report = rsp.GetReport("EXCEL", parameters);
            System.IO.File.WriteAllBytes(@"d:\test.xls",report);
            */
        }
    }
}