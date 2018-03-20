namespace Safeguard.BusinessForm.Catalogs.UserControls
{
    partial class UcDepartmentTree
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDepartmentTree));
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.toolsBar = new DevExpress.XtraBars.Bar();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.addHereBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.addChildBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.moveUpBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.moveDownBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.showSearchPanelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.showArchiveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.searchBar = new DevExpress.XtraBars.Bar();
            this.searchStringBarEditItem = new DevExpress.XtraBars.BarEditItem();
            this.searchStringRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.searchFromStartBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.searchNextBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.menuImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn13 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn15 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn16 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.treeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.phoneFilterPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.renterCommentLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.renterNameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchStringRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneFilterPanelControl)).BeginInit();
            this.phoneFilterPanelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "is_deleted_record";
            this.treeListColumn3.FieldName = "is_deleted_record";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.toolsBar,
            this.searchBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Images = this.menuImageCollection;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.refreshBarButtonItem,
            this.showArchiveBarButtonItem,
            this.addHereBarButtonItem,
            this.addChildBarButtonItem,
            this.moveUpBarButtonItem,
            this.moveDownBarButtonItem,
            this.deleteBarButtonItem,
            this.editBarButtonItem,
            this.showSearchPanelBarButtonItem,
            this.searchStringBarEditItem,
            this.searchFromStartBarButtonItem,
            this.searchNextBarButtonItem});
            this.barManager.MaxItemId = 14;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.searchStringRepositoryItemTextEdit});
            this.barManager.ShowFullMenus = true;
            // 
            // toolsBar
            // 
            this.toolsBar.BarName = "Tools";
            this.toolsBar.DockCol = 0;
            this.toolsBar.DockRow = 0;
            this.toolsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.toolsBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.addHereBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.addChildBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.moveUpBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.moveDownBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.showSearchPanelBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.showArchiveBarButtonItem)});
            this.toolsBar.OptionsBar.AllowQuickCustomization = false;
            this.toolsBar.OptionsBar.DrawDragBorder = false;
            this.toolsBar.OptionsBar.UseWholeRow = true;
            this.toolsBar.Text = "Tools";
            // 
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Обновить";
            this.refreshBarButtonItem.Hint = "Обновить";
            this.refreshBarButtonItem.Id = 2;
            this.refreshBarButtonItem.ImageIndex = 0;
            this.refreshBarButtonItem.Name = "refreshBarButtonItem";
            this.refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarButtonItem_ItemClick);
            // 
            // addHereBarButtonItem
            // 
            this.addHereBarButtonItem.Caption = "Добавить здесь";
            this.addHereBarButtonItem.Hint = "Добавить здесь";
            this.addHereBarButtonItem.Id = 4;
            this.addHereBarButtonItem.ImageIndex = 3;
            this.addHereBarButtonItem.Name = "addHereBarButtonItem";
            this.addHereBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.createParentBarButtonItem_ItemClick);
            // 
            // addChildBarButtonItem
            // 
            this.addChildBarButtonItem.Caption = "Добавить потомка";
            this.addChildBarButtonItem.Hint = "Добавить потомка";
            this.addChildBarButtonItem.Id = 5;
            this.addChildBarButtonItem.ImageIndex = 4;
            this.addChildBarButtonItem.Name = "addChildBarButtonItem";
            this.addChildBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.createChildBarButtonItem_ItemClick);
            // 
            // moveUpBarButtonItem
            // 
            this.moveUpBarButtonItem.Caption = "Вверх";
            this.moveUpBarButtonItem.Hint = "Уменьшить значение относительной позиции";
            this.moveUpBarButtonItem.Id = 6;
            this.moveUpBarButtonItem.ImageIndex = 6;
            this.moveUpBarButtonItem.Name = "moveUpBarButtonItem";
            this.moveUpBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.moveUpBarButtonItem_ItemClick);
            // 
            // moveDownBarButtonItem
            // 
            this.moveDownBarButtonItem.Caption = "Вниз";
            this.moveDownBarButtonItem.Hint = "Уменьшить значение относительной позиции";
            this.moveDownBarButtonItem.Id = 7;
            this.moveDownBarButtonItem.ImageIndex = 5;
            this.moveDownBarButtonItem.Name = "moveDownBarButtonItem";
            this.moveDownBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.moveDownBarButtonItem_ItemClick);
            // 
            // editBarButtonItem
            // 
            this.editBarButtonItem.Caption = "Изменить";
            this.editBarButtonItem.Hint = "Редактировать";
            this.editBarButtonItem.Id = 9;
            this.editBarButtonItem.ImageIndex = 7;
            this.editBarButtonItem.Name = "editBarButtonItem";
            this.editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBarButtonItem_ItemClick);
            // 
            // deleteBarButtonItem
            // 
            this.deleteBarButtonItem.Caption = "Удалить";
            this.deleteBarButtonItem.Hint = "Удалить";
            this.deleteBarButtonItem.Id = 8;
            this.deleteBarButtonItem.ImageIndex = 8;
            this.deleteBarButtonItem.Name = "deleteBarButtonItem";
            this.deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBarButtonItem_ItemClick);
            // 
            // showSearchPanelBarButtonItem
            // 
            this.showSearchPanelBarButtonItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.showSearchPanelBarButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.showSearchPanelBarButtonItem.Caption = "Поиск";
            this.showSearchPanelBarButtonItem.Id = 10;
            this.showSearchPanelBarButtonItem.ImageIndex = 10;
            this.showSearchPanelBarButtonItem.Name = "showSearchPanelBarButtonItem";
            this.showSearchPanelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showSearchPanelBarButtonItem_ItemClick);
            // 
            // showArchiveBarButtonItem
            // 
            this.showArchiveBarButtonItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.showArchiveBarButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.showArchiveBarButtonItem.Caption = "Отображать архивные";
            this.showArchiveBarButtonItem.Hint = "Отображать архивные";
            this.showArchiveBarButtonItem.Id = 3;
            this.showArchiveBarButtonItem.ImageIndex = 2;
            this.showArchiveBarButtonItem.Name = "showArchiveBarButtonItem";
            this.showArchiveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showArchiveBarButtonItem_ItemClick);
            // 
            // searchBar
            // 
            this.searchBar.BarName = "SearchBar";
            this.searchBar.DockCol = 0;
            this.searchBar.DockRow = 1;
            this.searchBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.searchBar.FloatLocation = new System.Drawing.Point(253, 218);
            this.searchBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.searchStringBarEditItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.searchFromStartBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.searchNextBarButtonItem)});
            this.searchBar.OptionsBar.AllowQuickCustomization = false;
            this.searchBar.OptionsBar.DrawDragBorder = false;
            this.searchBar.OptionsBar.UseWholeRow = true;
            this.searchBar.Text = "Поиск";
            // 
            // searchStringBarEditItem
            // 
            this.searchStringBarEditItem.AutoFillWidth = true;
            this.searchStringBarEditItem.Caption = "Поиск";
            this.searchStringBarEditItem.Edit = this.searchStringRepositoryItemTextEdit;
            this.searchStringBarEditItem.Id = 11;
            this.searchStringBarEditItem.Name = "searchStringBarEditItem";
            this.searchStringBarEditItem.Width = 115;
            // 
            // searchStringRepositoryItemTextEdit
            // 
            this.searchStringRepositoryItemTextEdit.AutoHeight = false;
            this.searchStringRepositoryItemTextEdit.Name = "searchStringRepositoryItemTextEdit";
            this.searchStringRepositoryItemTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchStringRepositoryItemTextEdit_KeyDown);
            // 
            // searchFromStartBarButtonItem
            // 
            this.searchFromStartBarButtonItem.Caption = "С начала";
            this.searchFromStartBarButtonItem.Id = 12;
            this.searchFromStartBarButtonItem.Name = "searchFromStartBarButtonItem";
            this.searchFromStartBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchFromStartBarButtonItem_ItemClick);
            // 
            // searchNextBarButtonItem
            // 
            this.searchNextBarButtonItem.Caption = "Далее";
            this.searchNextBarButtonItem.Id = 13;
            this.searchNextBarButtonItem.Name = "searchNextBarButtonItem";
            this.searchNextBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchNextBarButtonItem_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(300, 60);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 538);
            this.barDockControlBottom.Size = new System.Drawing.Size(300, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 478);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(300, 60);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 478);
            // 
            // menuImageCollection
            // 
            this.menuImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("menuImageCollection.ImageStream")));
            this.menuImageCollection.Images.SetKeyName(0, "refresh.ico");
            this.menuImageCollection.Images.SetKeyName(1, "1353504805_node-tree.ico");
            this.menuImageCollection.Images.SetKeyName(2, "list_white_gray_rows.ico");
            this.menuImageCollection.Images.SetKeyName(3, "node_add_parent.ico");
            this.menuImageCollection.Images.SetKeyName(4, "node_add_child.ico");
            this.menuImageCollection.Images.SetKeyName(5, "node_move_down.ico");
            this.menuImageCollection.Images.SetKeyName(6, "node_move_up.ico");
            this.menuImageCollection.Images.SetKeyName(7, "node_edit.ico");
            this.menuImageCollection.Images.SetKeyName(8, "node_delete.ico");
            this.menuImageCollection.Images.SetKeyName(9, "find_7.ico");
            this.menuImageCollection.Images.SetKeyName(10, "find_show_panel1.ico");
            // 
            // treeList
            // 
            this.treeList.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.treeList.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treeList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.treeList.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treeList.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.treeList.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn5,
            this.treeListColumn8,
            this.treeListColumn7,
            this.treeListColumn13,
            this.treeListColumn15,
            this.treeListColumn16,
            this.treeListColumn3});
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Gray;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.treeListColumn3;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = true;
            this.treeList.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition1});
            this.treeList.ImageIndexFieldName = "";
            this.treeList.KeyFieldName = "department_id";
            this.treeList.Location = new System.Drawing.Point(0, 60);
            this.treeList.MenuManager = this.barManager;
            this.treeList.Name = "treeList";
            this.treeList.OptionsBehavior.AllowIncrementalSearch = true;
            this.treeList.OptionsBehavior.Editable = false;
            this.treeList.OptionsBehavior.EnableFiltering = true;
            this.treeList.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
            this.treeList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeList.OptionsView.ShowIndicator = false;
            this.treeList.ParentFieldName = "parent_department_id";
            this.treeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.treeList.SelectImageList = this.treeImageCollection;
            this.treeList.Size = new System.Drawing.Size(300, 395);
            this.treeList.TabIndex = 17;
            this.treeList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList_FocusedNodeChanged);
            this.treeList.DoubleClick += new System.EventHandler(this.treeList_DoubleClick);
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.AppearanceCell.ForeColor = System.Drawing.Color.Silver;
            this.treeListColumn5.AppearanceCell.Options.UseForeColor = true;
            this.treeListColumn5.Caption = "Порядок";
            this.treeListColumn5.FieldName = "sequence";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.OptionsColumn.FixedWidth = true;
            this.treeListColumn5.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 1;
            this.treeListColumn5.Width = 30;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "Название";
            this.treeListColumn8.FieldName = "department_name";
            this.treeListColumn8.MinWidth = 35;
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.treeListColumn8.Visible = true;
            this.treeListColumn8.VisibleIndex = 0;
            this.treeListColumn8.Width = 251;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Примечание";
            this.treeListColumn7.FieldName = "comment";
            this.treeListColumn7.Name = "treeListColumn7";
            // 
            // treeListColumn13
            // 
            this.treeListColumn13.Caption = "publication_date";
            this.treeListColumn13.FieldName = "publication_date";
            this.treeListColumn13.Name = "treeListColumn13";
            // 
            // treeListColumn15
            // 
            this.treeListColumn15.Caption = "user_name_update";
            this.treeListColumn15.FieldName = "user_name_update";
            this.treeListColumn15.Name = "treeListColumn15";
            // 
            // treeListColumn16
            // 
            this.treeListColumn16.Caption = "datetime_update";
            this.treeListColumn16.FieldName = "datetime_update";
            this.treeListColumn16.Name = "treeListColumn16";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // treeImageCollection
            // 
            this.treeImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("treeImageCollection.ImageStream")));
            this.treeImageCollection.Images.SetKeyName(0, "WSS.ICO");
            this.treeImageCollection.Images.SetKeyName(1, "vsta.ico");
            this.treeImageCollection.Images.SetKeyName(2, "autostart_5714.ico");
            this.treeImageCollection.Images.SetKeyName(3, "needle2.ico");
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addChildBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.moveUpBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.moveDownBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteBarButtonItem)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 455);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(300, 5);
            this.splitterControl1.TabIndex = 22;
            this.splitterControl1.TabStop = false;
            // 
            // phoneFilterPanelControl
            // 
            this.phoneFilterPanelControl.Controls.Add(this.renterCommentLabelControl);
            this.phoneFilterPanelControl.Controls.Add(this.renterNameLabelControl);
            this.phoneFilterPanelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.phoneFilterPanelControl.Location = new System.Drawing.Point(0, 460);
            this.phoneFilterPanelControl.Name = "phoneFilterPanelControl";
            this.phoneFilterPanelControl.Size = new System.Drawing.Size(300, 78);
            this.phoneFilterPanelControl.TabIndex = 23;
            // 
            // renterCommentLabelControl
            // 
            this.renterCommentLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.renterCommentLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renterCommentLabelControl.Location = new System.Drawing.Point(2, 20);
            this.renterCommentLabelControl.Name = "renterCommentLabelControl";
            this.renterCommentLabelControl.Padding = new System.Windows.Forms.Padding(5);
            this.renterCommentLabelControl.Size = new System.Drawing.Size(296, 23);
            this.renterCommentLabelControl.TabIndex = 1;
            this.renterCommentLabelControl.Text = "Описание";
            // 
            // renterNameLabelControl
            // 
            this.renterNameLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.renterNameLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.renterNameLabelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.renterNameLabelControl.Location = new System.Drawing.Point(2, 2);
            this.renterNameLabelControl.Name = "renterNameLabelControl";
            this.renterNameLabelControl.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.renterNameLabelControl.Size = new System.Drawing.Size(296, 18);
            this.renterNameLabelControl.TabIndex = 0;
            this.renterNameLabelControl.Text = "Название подразделения";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "ObjectTree";
            this.saveFileDialog.Filter = "Microsoft Excel Document (*.xls)|*.xls";
            // 
            // UcDepartmentTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.phoneFilterPanelControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UcDepartmentTree";
            this.Size = new System.Drawing.Size(300, 538);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchStringRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneFilterPanelControl)).EndInit();
            this.phoneFilterPanelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar toolsBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection menuImageCollection;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem showArchiveBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem addHereBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem addChildBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem moveUpBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem moveDownBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem editBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn13;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn15;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn16;
        private DevExpress.Utils.ImageCollection treeImageCollection;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl phoneFilterPanelControl;
        private DevExpress.XtraEditors.LabelControl renterCommentLabelControl;
        private DevExpress.XtraEditors.LabelControl renterNameLabelControl;
        private DevExpress.XtraBars.BarButtonItem showSearchPanelBarButtonItem;
        private DevExpress.XtraBars.Bar searchBar;
        private DevExpress.XtraBars.BarEditItem searchStringBarEditItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit searchStringRepositoryItemTextEdit;
        private DevExpress.XtraBars.BarButtonItem searchFromStartBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem searchNextBarButtonItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
    }
}
