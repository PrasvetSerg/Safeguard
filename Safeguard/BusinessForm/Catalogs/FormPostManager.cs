using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Safeguard.BusinessForm.Catalogs
{
    public partial class FormPostManager : DevExpress.XtraEditors.XtraForm
    {
        private int selectedRecordId;

        public FormPostManager(bool isSelectMode = false, int selectedRecordId = -1)
        {
            this.selectedRecordId = selectedRecordId;

            InitializeComponent();

            if (isSelectMode == true)
            {
                this.ucList.RowDoubleClick += new UserControls.UcPostList.DelegateRowDoubleClick(this.ucList_DoubleClick);
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

        private void FormPhonebookManager_Shown(object sender, EventArgs e)
        {
            this.ucList.ShowList(UserControls.UcPostList.DisplayMode.All);
        }

        private void ucObjectTree_FocusedRowChanged(DataRow row, int recordId)
        {
            //this.ucAbonentPhoneList.ShowList(UcAbonentList.DisplayMode.ByObjectId, recordId, abonentCatdIdForSelect: this.abonentCardIdForSelect);
            this.selectedRecordId = -1;
        }

        private void ucAbonentPhoneList_CardNotInObjectTree(int cardId, int newRecordId)
        {
            this.ucList.ShowList(UserControls.UcPostList.DisplayMode.All, newRecordId);
            //this.ucAbonentPhoneList.ShowList(UcAbonentPhoneList.DisplayMode.ByObject, recordId);
        }

        private void ucAbonentPhoneList_FocusedRowChanged(DataRow row, int id)
        {
            //if (this.ucAbonentPhoneNumberList.SelectedRecordId != id)
            {
                //this.ucAbonentPhoneNumberList.ShowList(UcAbonentPhoneNumberList.DisplayMode.ByAbonentCardId, id);
            }
        }
        #region User Action

        private void findBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
            using (FormAbonentList formList = new FormAbonentList())
            {
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                    this.abonentCardIdForSelect = formList.SelectedRecordId;
                    this.ucList.ShowList(UserControls.UcPostList.DisplayMode.All, formList.SelectedObjectId);
                }
            }
            */
        }

        private void helpBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //InternalWebBrowser.FormWebBrowser form = new InternalWebBrowser.FormWebBrowser("Справка по программе", "http://ivc-project.lan.naftan.by/ats/HTML-help/cross.html");
            //form.Show();
        }

        private void exportToFileBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
            if (this.ucAbonentPhoneList.ContainsFocus == true)
            {
                this.ucAbonentPhoneList.ExportToExcel();
            }
            else if (this.ucAbonentPhoneNumberList.ContainsFocus == true)
            {
                this.ucAbonentPhoneNumberList.ExportToExcel();
            }
            else */
            if (this.ucList.ContainsFocus == true)
            {
                this.ucList.ExportToExcel();
            }
        }
        #endregion
        

    }
}