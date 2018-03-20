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
    public partial class FormDepartmentFacilityManager : DevExpress.XtraEditors.XtraForm
    {
        int facilityId;
        int departmentId;

        public FormDepartmentFacilityManager(bool isSelectMode = false, int selectedRecordId = -1, int objectId = -1)
        {
            this.facilityId = selectedRecordId;
            this.departmentId = objectId;
            InitializeComponent();

            if (isSelectMode == true)
            {
                this.ucList.RowDoubleClick += new UserControls.UcFacilityList.DelegateRowDoubleClick(this.ucList_DoubleClick);
            }
        }
        
        public int SelectedRecordId
        {
            get { return facilityId; }
        }

        private void ucList_DoubleClick(DataRow row, int id)
        {
            this.facilityId = id;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormPhonebookManager_Shown(object sender, EventArgs e)
        {
            if (this.departmentId < 1)
            {
                //получить objectId 
                string query = string.Format("dtr_facility_get 'by_facility_id',{0}", this.facilityId);
                DataTable dataTable = DBConnection.SqlQuery.ReadData(this, query);
                this.departmentId = (dataTable.Rows.Count == 1 ? (int)dataTable.Rows[0]["department_id"] : -1);
            }
            //this.ucTree.FocusedRowChanged -= ucObjectTree_FocusedRowChanged;
            this.ucTree.ShowList(UserControls.UcDepartmentTree.DisplayMode.All, this.departmentId);
            //this.ucList.ShowList(UserControls.UcFacilityList.DisplayMode.ByObjectId, this.facilityId, this.departmentId);
            //this.ucTree.FocusedRowChanged += ucObjectTree_FocusedRowChanged;

            //this.ucTree.ShowList(UserControls.UcDepartmentTree.DisplayMode.All);
        }

        private void ucObjectTree_FocusedRowChanged(DataRow row, int recordId)
        {
            this.ucList.ShowList(UserControls.UcFacilityList.DisplayMode.ByObjectId, recordId, this.facilityId);
            this.facilityId = -1;
        }

        private void ucAbonentPhoneList_CardNotInObjectTree(int cardId, int newObjectId)
        {
            this.ucTree.ShowList(UserControls.UcDepartmentTree.DisplayMode.All, newObjectId);
            //this.ucAbonentPhoneList.ShowList(UcAbonentPhoneList.DisplayMode.ByObject, recordId);
        }

        private void ucAbonentPhoneList_FocusedRowChanged(DataRow row, int id)
        {
            //if (this.ucAbonentPhoneNumberList.SelectedRecordId != id)
            {
                //this.ucAbonentPhoneNumberList.ShowList(UcAbonentPhoneNumberList.DisplayMode.ByAbonentCardId, id);
            }
        }
        /*
        private void ucAbonentPhoneList_RowDoubleClick(int newObjectId)
        {
            this.ucOrganizationObjectTree.ShowList(UcObjectTree.DisplayMode.All, newObjectId);
        }
        */
        #region User Action
        private void searchBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Search(this.searchTextBarEditItem.EditValue as string);
        }

        private void clearSerchBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.findBarEditItem.EditValue = "";
            ClearFound();
        }

        private void serachStringRepositoryItemTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.barManager.ActiveEditItemLink.PostEditor();//без этого в EditValue содержится значение до редактирования
                Search(this.searchTextBarEditItem.EditValue as string);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.searchTextBarEditItem.EditValue = string.Empty;
                //ClearFound();
            }
        }
        #endregion
        
        #region Поиск
        private void Search(string str)
        {
            if (str != null && str.Trim().Length > 0)
            {
                //очистка предыдущего результата поиска
                this.ucList.SearchingText = str;
                //this.ucOrganizationObjectTree.ShowList();
            }
        }

        private void ClearFound()
        {
            this.ucList.SearchingText = string.Empty;
        }

        private void findBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
            using (FormAbonentList formList = new FormAbonentList())
            {
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                    this.abonentCardIdForSelect = formList.SelectedRecordId;
                    this.ucTree.ShowList(UserControls.UcDepartmentTree.DisplayMode.All, formList.SelectedObjectId);
                }
            }
            */
        }

        private void showWrongCardBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
            using (FormAbonentList formList = new FormAbonentList(displayMode:UcAbonentList.DisplayMode.Wrong))
            {
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                    this.abonentCatdIdForSelect = formList.SelectedRecordId;
                    this.ucObjectTree.ShowList(UcObjectTree.DisplayMode.All, formList.SelectedObjectId);
                }
            }
            */
        }

        private void userListBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
            using (FormUserList formList = new FormUserList())
            {
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                }
            }
            */
        }

        private void userMessageBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*
            using (AbonentsMessenger.FormAbonentsMessenger formList = new AbonentsMessenger.FormAbonentsMessenger())
            {
                if (formList.ShowDialog(this) == DialogResult.OK)
                {
                }
            }
            */
        }
        
        private void helpBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //InternalWebBrowser.FormWebBrowser form = new InternalWebBrowser.FormWebBrowser("Справка по программе", "http://ivc-project.lan.naftan.by/ats/HTML-help/html");
            //form.Show();
        }


        private void exportToFileBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ucList.ContainsFocus == true)
            {
                this.ucList.ExportToExcel();
            }

            else if (this.ucTree.ContainsFocus == true)
            {
                this.ucTree.ExportToExcel();
            }
        }
        
        /*
        //Поиск (основной модуль)
        private string searshstrglob = "";//искомый текст для подсвета
        private void Search(string searchstr)
        {
            //поиск в объектах дерева
            if (searchstr != null && searchstr.Length > 0)
            {
                //очистка пометок предыдущего отбора
                ClearFound();
                this.treeList.CollapseAll();

                this.searshstrglob = searchstr;
                this.abonentList.SearchingText = searchstr;
                //загрузка списка объектов содержащих в карточках искомую фразу
                DataTable dtSearchState = DBConnection.SqlQuery.ReadData(null, "usp_search 'all','" + searchstr + "'", this.connectionString);

                //установка пометок отбора
                this.treeList.BeginUpdate();

                TreeListNode firstFoundNode = null;
                foreach (DataRow spravRow in this.spravDataTable.Rows)
                {
                    foreach (DataRow toSelectRow in dtSearchState.Rows)
                    {
                        if (spravRow["idOrg"].ToString() == toSelectRow["idOrg"].ToString()
                            && spravRow["idObjects"].ToString() == toSelectRow["idObjects"].ToString())
                        {
                            TreeListNode curNode = this.treeList.FindNodeByID((int)spravRow["colid"]);
                            if (curNode != null)
                            {
                                curNode.SetValue("found", "1");
                                //сохранение ссылки на первый найденый элемент
                                if (firstFoundNode == null)
                                {
                                    firstFoundNode = curNode;
                                }

                                this.treeList.SetFocusedNode(curNode);//расскрывает дерево объектов с каждым найденым элементом
                            }
                        }
                    }
                }
                //задание фокуса на первый найденный
                this.treeList.SetFocusedNode(firstFoundNode);
                this.treeList.TopVisibleNodeIndex = treeList.GetVisibleIndexByNode(firstFoundNode);//возможно не нужен

                this.treeList.EndUpdate();

                if (firstFoundNode == null)
                {
                    this.treeList.SetFocusedNode(this.treeList.Nodes[0]);
                    DevExpress.XtraEditors.XtraMessageBox.Show("Не удается найти \"" + searchstr + "\"", "Сообщение поисковой системы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        //очистка результатов поиска
        private void ClearFound()
        {
            this.searshstrglob = "";
            this.abonentList.SearchingText = null;

            this.treeList.BeginUpdate();
            for (int i = 0; i != this.treeList.Nodes.Count; i++)
            {
                SetFound(this.treeList.Nodes[i]);
            }
            this.treeList.EndUpdate();
        }

        //сброс флага найденого элемента
        private void SetFound(TreeListNode node)
        {
            if (node.GetDisplayText("found") == "1")
            {
                node.SetValue("found", "");
            }

            for (int i = 0; i != node.Nodes.Count; i++)
            {
                SetFound(node.Nodes[i]);
            }
        }
        */
        #endregion

    }
}