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
    public partial class FormGroupList : DevExpress.XtraEditors.XtraForm
    {
        private int selectedRecordId;

        public FormGroupList(bool isSelectMode = false, int selectedRecordId = -1)
        {
            this.selectedRecordId = selectedRecordId;
            InitializeComponent();

            if (isSelectMode == true)
            {
                this.ucGroupList.RowDoubleClick += new UcGroupList.DelegateRowDoubleClick(this.ucList_DoubleClick);
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
            this.ucGroupList.ShowList(UcGroupList.DisplayMode.All, selectedRecordId);
        }

        private void ucGroupList_FocusedRowChanged(DataRow row, int id)
        {
            this.ucGroupUserList.ShowList(UcUserGroupList.DisplayMode.ByGroupId, parentRecordId: id);
        }
    }
}