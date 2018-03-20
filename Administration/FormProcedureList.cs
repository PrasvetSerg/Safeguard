using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Administration
{
    public partial class FormProcedureList : DevExpress.XtraEditors.XtraForm
    {
        private int selectedRecordId;

        public FormProcedureList(bool isSelectMode = false, int selectedRecordId = -1)
        {
            this.selectedRecordId = selectedRecordId;
            InitializeComponent();

            if (isSelectMode == true)
            {
                this.ucTariffList.RowDoubleClick += new UcProcedureList.DelegateRowDoubleClick(this.ucList_DoubleClick);
            }
        }
                
        public DevExpress.XtraBars.Docking.DockVisibility ShowRateList
        {
            get
            {
                return this.dockPanel.Visibility;
            }
            set
            {
                this.dockPanel.Visibility = value;
            }
        }

        public int SelectedRecordId
        {
            get { return selectedRecordId; }
        }

        private void ucList_DoubleClick(DataRow row, int id)
        {
            this.selectedRecordId = id;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormPhoneNumberList_Shown(object sender, EventArgs e)
        {
            this.ucTariffList.ShowList(UcProcedureList.DisplayMode.All, selectedRecordId);
            //this.ucOrganizationList.SelectRow(this.SelectedRecordId);
        }

        private void ucTariffList_FocusedRowChanged(DataRow row, int id)
        {
            this.ucRateList.ShowList(UcCommandList.DisplayMode.ByProcedureId, id);
        }
    }
}