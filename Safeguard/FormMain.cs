using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraReports.UI;

namespace Safeguard
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.Utils.WaitDialogForm waitDialogForm;
        int userId;

        public FormMain()
        {
            //ExceptionHandler.MessageManager.Owner = this;
            
            waitDialogForm = new DevExpress.Utils.WaitDialogForm("Выполняется загрузка программы", "Пожалуйста, подождите");
            waitDialogForm.Show();

            InitializeComponent();
            InitData();

            ActivateControl();

            waitDialogForm.Close();
        }
        
        private void FormMain_Shown(object sender, EventArgs e)
        {
            Logon();
            ActivateControl();
        }

        //Инициализация компонентов формы
        private void InitData()
        {
            //версия публикации
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                this.programVersionBarStaticItem.Caption = "v" + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }

            //папка настроек программы
            if (!System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + global::Safeguard.Properties.Settings.Default.SettingsDirectory))
            {
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + global::Safeguard.Properties.Settings.Default.SettingsDirectory);
            }

            this.defaultLookAndFeel.LookAndFeel.SkinName = DevExpress.Skins.SkinManager.Default.Skins["DevExpress Style"].SkinName;
        }

        private void ActivateControl()
        {
            if (this.userId > 0)
            {
                this.ucPager.StartTimer(18000);
                this.ucPager.ShowList(ServiceForm.UcPager.DisplayMode.LastWeek, -1);
                this.ucPager.MessageSelected += ShowSelectedMessage; //new ServiceForm.UcPager.DelegateMessageSelected(ShowSelectedMessage);
            }
        }

        #region Logon
        //подключение к базе
        private void Logon()
        {
            bool isLogon = false;

            if (global::Safeguard.Properties.Settings.Default.UseIntegratedSecurity == true)
            {
                isLogon = TryWinLogon();
            }

            if (isLogon == false)
            {
                isLogon = TrySqlLogon();
            }

            if (isLogon == true)
            {
                waitDialogForm = new DevExpress.Utils.WaitDialogForm("Выполняется вход", "Пожалуйста, подождите");

                DBConnection.SqlQuery.ReadData(null, string.Format("usp_general_log_set 'logon','{0}'", this.programVersionBarStaticItem.Caption.ToString()));

                DataTable dataTable = DBConnection.SqlQuery.ReadData(null, string.Format("dtr_acl_user_get @command='current_user'"));
                if (dataTable != null && dataTable.Rows.Count == 1)
                {
                    this.userId = (int)dataTable.Rows[0]["acl_user_id"];
                    this.loginBarEditItem.EditValue = dataTable.Rows[0]["short_name"].ToString();
                }
                else
                {
                    this.userId = -1;
                    this.loginBarEditItem.EditValue = string.Empty;
                    DevExpress.XtraEditors.XtraMessageBox.Show(this, "Такого пользователя нет в базе данных. Свяжитесь с администратором", "Проверка подключения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                waitDialogForm.Close();
            }
            else
            {
                if (this.userId < 1)
                {
                    using (Form form = new Safeguard.BusinessForm.Settings.FormApplicationSettings())
                    {
                        if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                        {
                            Logon();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
        }
        
        private bool TryWinLogon()
        {
            return TryLogon(true);
        }

        private bool TrySqlLogon()
        {
            bool isLogon = false;

            using (Safeguard.BusinessForm.Settings.FormLogOn formLogOn = new BusinessForm.Settings.FormLogOn(null))
            {
                while (formLogOn.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    if (TryLogon(false, formLogOn.UserLogIn, formLogOn.UserPassword) == true)
                    {
                        isLogon = true;
                        break;
                    }
                }
            }
            return isLogon;
        }

        private bool TryLogon(bool isIntegratedSecurity, string login = null, string password = null)
        {
            bool isLogon = false;

            string connectionString = DBConnection.SqlQuery.GenerateConnectionString(
                    global::Safeguard.Properties.Settings.Default.ConnectionServerName
                    , global::Safeguard.Properties.Settings.Default.ConnectionDatabaseName
                    , isIntegratedSecurity
                    , login
                    , password);

            if (DBConnection.SqlQuery.TestConnectionString(connectionString) == true)
            {
                DBConnection.SqlQuery.ConnectionString = connectionString;
                isLogon = true;
            }

            return isLogon;
        }
        #endregion
        
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Запись в базу факта выхода из программы
            if(this.userId > 0)
            {
                DBConnection.SqlQuery.ReadData(this, string.Format("usp_general_log_set 'logoff','{0}'", this.programVersionBarStaticItem.Caption.ToString()));
            }

            //Сохраняем состояние основного окна
            Properties.Settings settings = new Properties.Settings();
            settings.MainFormState = this.WindowState;
            settings.Save();
        }

        #region Processed menu action
        //show about box
        private void aboutBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FormAbout formAbout = new FormAbout())
            {
                formAbout.ShowDialog(this);
            }
        }

        private void helpBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Help.ShowHelp(this, "http://soft.lan.naftan.by/Safeguard/HTML-help/index.html");
        }

        private void hystoryBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Help.ShowHelp(this, "http://soft.lan.naftan.by/Safeguard/HTML-help/hystory.htm");
        }

        private void loginRepositoryItemPopupContainerEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Logon();
            ActivateControl();
        }

        //отображение настроек программы
        private void settingsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Safeguard.BusinessForm.Settings.FormApplicationSettings form = new BusinessForm.Settings.FormApplicationSettings();
            if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                //UpdateDataOnForm();
            }
        }

        /// <summary>
        /// Create and show child MDI form of reference book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowMdiForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Tag != null)
            {
                ShowMdiForm(e.Item.Tag.ToString());
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Для элемента отсутствует имя запускаемой формы mdi. " + e.Item.Name, "Ошибка");
            }
        }

        //
        private void NavBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (e.Link.Item.Tag != null)
            {
                ShowMdiForm(e.Link.Item.Tag.ToString());
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(this,"Для элемента отсутствует имя запускаемой формы mdi. " + e.Link.ItemName,"Ошибка");
            }
        }

        //открывает дочернюю форму или активирует уже открытую
        private void ShowMdiForm(string businessModulName)
        {
            Form childForm = null;            
            foreach (Form form in this.MdiChildren)
            {
                if ((string)form.Tag == businessModulName)
                {
                    childForm = form;
                    continue;
                }
            }

            if (childForm != null)
            {
                childForm.Activate();//this.ActivateMdiChild(childForm);//childForm.Show();
            }
            else
            {
                
                if (businessModulName == "")
                {
                    childForm = null;     
                }
                //секция справочников
                else if (businessModulName == "Safeguard.BusinessForm.Catalogs.FormKppManager")
                {
                    childForm = new Safeguard.BusinessForm.Catalogs.FormKppManager();
                }
                else if (businessModulName == "Safeguard.BusinessForm.Catalogs.FormOffenseTypeManager")
                {
                    childForm = new Safeguard.BusinessForm.Catalogs.FormOffenseTypeManager();
                }
                else if (businessModulName == "Safeguard.BusinessForm.Catalogs.FormOffenderManager")
                {
                    childForm = new Safeguard.BusinessForm.Catalogs.FormOffenderManager();
                }
                else if (businessModulName == "Safeguard.BusinessForm.Catalogs.FormEmployeeManager")
                {
                    childForm = new Safeguard.BusinessForm.Catalogs.FormEmployeeManager();
                }
                else if (businessModulName == "Safeguard.BusinessForm.Catalogs.FormPostManager")
                {
                    childForm = new Safeguard.BusinessForm.Catalogs.FormPostManager();
                }
                else if (businessModulName == "Safeguard.BusinessForm.Catalogs.FormGroupManager")
                {
                    childForm = new Safeguard.BusinessForm.Catalogs.FormGroupManager();
                }
                else if (businessModulName == "Safeguard.BusinessForm.Catalogs.FormOrganizationManager")
                {
                    childForm = new Safeguard.BusinessForm.Catalogs.FormOrganizationManager();
                }
                    
                //секция журналов
                else if (businessModulName == "Safeguard.BusinessForm.Journals.FormGroupEmployeeManager")
                {
                    childForm = new Safeguard.BusinessForm.Journals.FormGroupEmployeeManager();
                }
                else if (businessModulName == "Safeguard.BusinessForm.Journals.FormOffenseManager")
                {
                    childForm = new Safeguard.BusinessForm.Journals.FormOffenseManager();
                }

                //Аналитика
                else if (businessModulName == "Safeguard.BusinessForm.Reports.FormAllocationPositionStatistic")
                {
                    childForm = new Safeguard.BusinessForm.Reports.FormStatistic();
                }

                //секция просмотра логов
                else if (businessModulName == "GeneralLog")
                {
                    childForm = new ServiceForm.FormGeneralLogList();
                }
                else if (businessModulName == "ErrorLog")
                {
                    childForm = new ServiceForm.FormErrorLogList();
                }
                //секция административных функций
                else if (businessModulName == "Administration.FormGroupList")
                {
                    childForm = new Administration.FormGroupList();
                }
                else if (businessModulName == "Administration.FormProcedureList")
                {
                    childForm = new Administration.FormProcedureList();
                }
                else if (businessModulName == "Administration.FormUserList")
                {
                    childForm = new Administration.FormUserList();
                }
                else if (businessModulName == "Administration.FormAclList")
                {
                    childForm = new Administration.FormAclList();
                }

                if (childForm != null)
                {
                    childForm.Tag = businessModulName;
                    childForm.MdiParent = this;
                    childForm.Show();
                }
            }
        }
        #endregion
        private void testBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Safeguard.BusinessForm.Journals.Reports.ReportTest report = new Safeguard.BusinessForm.Journals.Reports.ReportTest(DateTime.Now.AddMonths(-1), DateTime.Now);
            if (report.IsDisposed == false)
            {
                report.ShowPreview();
            }
            /*
            Form form = new Safeguard.ServiceForm.FormTestControl();
            form.ShowDialog(this);
            */
            /*
            Form form = new Safeguard.BusinessForm.Journals.UserControls.Test2.XtraForm1();
            form.ShowDialog(this);
            */
        }

        private void showLeftPanelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.docsListDockPanel.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Hidden)
            {
                //this.docsListDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                this.docsListDockPanel.Show();
            }

            this.docsListDockPanel.Focus();
        }

        private void MergeMainMenu(DevExpress.XtraBars.BarManager barManager)
        {
            this.barMainMenu.Merge(barManager.MainMenu);
        }

        private void UnMergeMainMenu()
        {
            this.barMainMenu.UnMerge();
        }

        private void ReportLinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (e.Link.Item.Tag != null)
            {
                ShowReportForm(e.Link.Item.Tag.ToString());
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(this, "Для элемента отсутствует имя запускаемой формы mdi. " + e.Link.ItemName, "Ошибка");
            }
        }

        private void ShowReportForm(string reportName)
        {
            if (reportName == "Safeguard.BusinessForm.Journals.Reports.ReportFromToDatetime")
            {
                using (Safeguard.BusinessForm.Messages.FormReportFromToDatetime formSettings = new Safeguard.BusinessForm.Messages.FormReportFromToDatetime() {Param2Caption="до:" })
                {
                    if (formSettings.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        Safeguard.BusinessForm.Journals.Reports.ReportFromToDatetime report = new Safeguard.BusinessForm.Journals.Reports.ReportFromToDatetime(formSettings.FromDatetime,formSettings.ToDatetime);
                        if (report.IsDisposed == false)
                        {
                            report.ShowPreview();
                        }
                    }
                }
            }
            else if (reportName == "Safeguard.BusinessForm.Journals.Reports.ReportFromToDatetimeByUser")
            {
                using (Safeguard.BusinessForm.Messages.FormReportFromToDatetime formSettings = new Safeguard.BusinessForm.Messages.FormReportFromToDatetime() { Param2Caption = "до:" })
                {
                    if (formSettings.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        Safeguard.BusinessForm.Journals.Reports.ReportFromToDatetime report = new Safeguard.BusinessForm.Journals.Reports.ReportFromToDatetime(formSettings.FromDatetime, formSettings.ToDatetime, true);
                        if (report.IsDisposed == false)
                        {
                            report.ShowPreview();
                        }
                    }
                }
            }
            else if (reportName == "Safeguard.BusinessForm.Journals.Reports.ReportGeneralFromToDatetime")
            {
                using (Safeguard.BusinessForm.Messages.FormReportFromToDate formSettings = new Safeguard.BusinessForm.Messages.FormReportFromToDate())
                {
                    if (formSettings.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        Safeguard.BusinessForm.Journals.Reports.ReportGeneralFromToDatetime report = new Safeguard.BusinessForm.Journals.Reports.ReportGeneralFromToDatetime(formSettings.FromDate, formSettings.ToDate.AddDays(1).AddSeconds(-1));
                        if (report.IsDisposed == false)
                        {
                            report.ShowPreview();
                        }
                    }
                }
            }
            else if (reportName == "Safeguard.BusinessForm.Journals.Reports.ReportGeneralByGroup")
            {
                using (Safeguard.BusinessForm.Messages.FormReportFromToDate formSettings = new Safeguard.BusinessForm.Messages.FormReportFromToDate())
                {
                    if (formSettings.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        var report = new Safeguard.BusinessForm.Journals.Reports.ReportGeneralByGroup(formSettings.FromDate, formSettings.ToDate.AddDays(1).AddSeconds(-1));
                        if (report.IsDisposed == false)
                        {
                            report.ShowPreview();
                        }
                    }
                }
            }
            else if (reportName == "Safeguard.BusinessForm.Journals.Reports.ReportGeneralFromToDatetimeByGroup")
            {
                using (Safeguard.BusinessForm.Messages.FormReportFromToDateByGroup formSettings = new Safeguard.BusinessForm.Messages.FormReportFromToDateByGroup())
                {
                    if (formSettings.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        Safeguard.BusinessForm.Journals.Reports.ReportGeneralFromToDatetime report = new Safeguard.BusinessForm.Journals.Reports.ReportGeneralFromToDatetime(formSettings.FromDate, formSettings.ToDate.AddDays(1).AddSeconds(-1), formSettings.GroupId);
                        if (report.IsDisposed == false)
                        {
                            report.ShowPreview();
                        }
                    }
                }
            }
            else if (reportName == "Safeguard.BusinessForm.Journals.Reports.ReportTalonOnDate")
            {
                using (Safeguard.BusinessForm.Messages.FormReportOnDateByFactory formSettings = new Safeguard.BusinessForm.Messages.FormReportOnDateByFactory())
                {
                    if (formSettings.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        Safeguard.BusinessForm.Journals.Reports.ReportTalonOnDate report = new Safeguard.BusinessForm.Journals.Reports.ReportTalonOnDate(formSettings.Date, formSettings.FactoryId);
                        if (report.IsDisposed == false)
                        {
                            report.ShowPreview();
                        }
                    }
                }
            }
            else if (reportName == "Safeguard.BusinessForm.Journals.Reports.ReportOffenseByOrganizationByPeriod")
            {
                using (Safeguard.BusinessForm.Messages.FormReportFromToDate formSettings = new Safeguard.BusinessForm.Messages.FormReportFromToDate())
                {
                    if (formSettings.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        DevExpress.XtraReports.UI.XtraReport report = new Safeguard.BusinessForm.Journals.Reports.ReportOffenseByOrganizationByPeriod(formSettings.FromDate, formSettings.ToDate);
                        if (report.IsDisposed == false)
                        {
                            report.ShowPreview();
                        }
                    }
                }
            }
            else if (reportName == "Safeguard.BusinessForm.Journals.Reports.ReportOffenseByOrganizationByPeriodByOrganization")
            {
                using (Safeguard.BusinessForm.Messages.FormReportFromToDateByOrganization formSettings = new Safeguard.BusinessForm.Messages.FormReportFromToDateByOrganization())
                {
                    if (formSettings.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        DevExpress.XtraReports.UI.XtraReport report = new Safeguard.BusinessForm.Journals.Reports.ReportOffenseByOrganizationByPeriod(formSettings.FromDate, formSettings.ToDate, formSettings.OrganizationId);
                        if (report.IsDisposed == false)
                        {
                            report.ShowPreview();
                        }
                    }
                }
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(this, string.Format("Неверная команда \"{0}\". Сообщите разработчику", reportName), "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StartPager(int tick)
        {
            this.ucPager.StartTimer(tick);
            this.ucPager.ShowList(ServiceForm.UcPager.DisplayMode.LastWeek, -1);
            this.ucPager.MessageSelected += ShowSelectedMessage; //new ServiceForm.UcPager.DelegateMessageSelected(ShowSelectedMessage);
        }

        private void ShowSelectedMessage(int id)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            this.pagerDockPanel.Show();
            this.ucPager.SelectRow(id);
        }

        private void pagerBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pagerDockPanel.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Hidden)
            {
                //this.docsListDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                this.pagerDockPanel.Show();
            }

            this.pagerDockPanel.Focus();
        }

        private void exitBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
