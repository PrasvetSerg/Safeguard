namespace Safeguard.ServiceForm
{
    partial class FormErrorLogList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormErrorLogList));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resultGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descriptionNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barTools = new DevExpress.XtraBars.Bar();
            this.refreshBarBtnItem = new DevExpress.XtraBars.BarButtonItem();
            this.addBarBtnItem = new DevExpress.XtraBars.BarButtonItem();
            this.editBarBtnItem = new DevExpress.XtraBars.BarButtonItem();
            this.archiveBarBtnItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBarBtnItem = new DevExpress.XtraBars.BarButtonItem();
            this.barMainMenu = new DevExpress.XtraBars.Bar();
            this.reportsBarSubItem = new DevExpress.XtraBars.BarSubItem();
            this.exportToExcelBarBtnItem = new DevExpress.XtraBars.BarButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.recordCountBarStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 53);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(844, 348);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idGridColumn,
            this.dateGridColumn,
            this.actionGridColumn,
            this.resultGridColumn,
            this.gridColumn1,
            this.descriptionNameGridColumn,
            this.userNameGridColumn});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.dateGridColumn, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            this.gridView.RowCountChanged += new System.EventHandler(this.gridView_RowCountChanged);
            // 
            // idGridColumn
            // 
            this.idGridColumn.Caption = "ID записи";
            this.idGridColumn.FieldName = "error_log_id";
            this.idGridColumn.Name = "idGridColumn";
            // 
            // dateGridColumn
            // 
            this.dateGridColumn.Caption = "Дата";
            this.dateGridColumn.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateGridColumn.FieldName = "error_datetime";
            this.dateGridColumn.Name = "dateGridColumn";
            this.dateGridColumn.Visible = true;
            this.dateGridColumn.VisibleIndex = 0;
            this.dateGridColumn.Width = 101;
            // 
            // actionGridColumn
            // 
            this.actionGridColumn.Caption = "Процедура";
            this.actionGridColumn.FieldName = "error_procedure";
            this.actionGridColumn.Name = "actionGridColumn";
            this.actionGridColumn.Visible = true;
            this.actionGridColumn.VisibleIndex = 1;
            this.actionGridColumn.Width = 110;
            // 
            // resultGridColumn
            // 
            this.resultGridColumn.Caption = "Уровень";
            this.resultGridColumn.FieldName = "error_severity";
            this.resultGridColumn.Name = "resultGridColumn";
            this.resultGridColumn.OptionsColumn.FixedWidth = true;
            this.resultGridColumn.Visible = true;
            this.resultGridColumn.VisibleIndex = 4;
            this.resultGridColumn.Width = 60;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Позиция";
            this.gridColumn1.FieldName = "error_state";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 56;
            // 
            // descriptionNameGridColumn
            // 
            this.descriptionNameGridColumn.Caption = "Описание";
            this.descriptionNameGridColumn.FieldName = "error_message";
            this.descriptionNameGridColumn.Name = "descriptionNameGridColumn";
            this.descriptionNameGridColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.descriptionNameGridColumn.Visible = true;
            this.descriptionNameGridColumn.VisibleIndex = 3;
            this.descriptionNameGridColumn.Width = 414;
            // 
            // userNameGridColumn
            // 
            this.userNameGridColumn.Caption = "Пользователь";
            this.userNameGridColumn.FieldName = "user_name";
            this.userNameGridColumn.Name = "userNameGridColumn";
            this.userNameGridColumn.Visible = true;
            this.userNameGridColumn.VisibleIndex = 2;
            this.userNameGridColumn.Width = 85;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Microsoft Excel Document (*.xls)|*.xls";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barTools,
            this.barMainMenu,
            this.barStatus});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Images = this.imageList;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addBarBtnItem,
            this.editBarBtnItem,
            this.refreshBarBtnItem,
            this.reportsBarSubItem,
            this.exportToExcelBarBtnItem,
            this.deleteBarBtnItem,
            this.recordCountBarStaticItem,
            this.barStaticItem1,
            this.archiveBarBtnItem});
            this.barManager.MainMenu = this.barMainMenu;
            this.barManager.MaxItemId = 11;
            this.barManager.StatusBar = this.barStatus;
            // 
            // barTools
            // 
            this.barTools.BarName = "Tools";
            this.barTools.DockCol = 0;
            this.barTools.DockRow = 1;
            this.barTools.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.refreshBarBtnItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addBarBtnItem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.editBarBtnItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.archiveBarBtnItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteBarBtnItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barTools.Text = "Tools";
            this.barTools.Visible = false;
            // 
            // refreshBarBtnItem
            // 
            this.refreshBarBtnItem.Caption = "Обновить";
            this.refreshBarBtnItem.Id = 2;
            this.refreshBarBtnItem.ImageIndex = 4;
            this.refreshBarBtnItem.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.refreshBarBtnItem.Name = "refreshBarBtnItem";
            this.refreshBarBtnItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarBtnItem_ItemClick);
            // 
            // addBarBtnItem
            // 
            this.addBarBtnItem.Caption = "Добавить";
            this.addBarBtnItem.Id = 0;
            this.addBarBtnItem.ImageIndex = 1;
            this.addBarBtnItem.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.addBarBtnItem.Name = "addBarBtnItem";
            this.addBarBtnItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBarBtnItem_ItemClick);
            // 
            // editBarBtnItem
            // 
            this.editBarBtnItem.Caption = "Изменить";
            this.editBarBtnItem.Id = 1;
            this.editBarBtnItem.ImageIndex = 2;
            this.editBarBtnItem.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.editBarBtnItem.Name = "editBarBtnItem";
            this.editBarBtnItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBarBtnItem_ItemClick);
            // 
            // archiveBarBtnItem
            // 
            this.archiveBarBtnItem.Caption = "В архив";
            this.archiveBarBtnItem.Id = 10;
            this.archiveBarBtnItem.ImageIndex = 3;
            this.archiveBarBtnItem.Name = "archiveBarBtnItem";
            this.archiveBarBtnItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.archiveBarBtnItem_ItemClick);
            // 
            // deleteBarBtnItem
            // 
            this.deleteBarBtnItem.Caption = "Удалить";
            this.deleteBarBtnItem.Id = 5;
            this.deleteBarBtnItem.ImageIndex = 3;
            this.deleteBarBtnItem.Name = "deleteBarBtnItem";
            this.deleteBarBtnItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.deleteBarBtnItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBarBtnItem_ItemClick);
            // 
            // barMainMenu
            // 
            this.barMainMenu.BarName = "Main menu";
            this.barMainMenu.DockCol = 0;
            this.barMainMenu.DockRow = 0;
            this.barMainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.reportsBarSubItem)});
            this.barMainMenu.OptionsBar.MultiLine = true;
            this.barMainMenu.OptionsBar.UseWholeRow = true;
            this.barMainMenu.Text = "Main menu";
            // 
            // reportsBarSubItem
            // 
            this.reportsBarSubItem.Caption = "Отчёты";
            this.reportsBarSubItem.Id = 3;
            this.reportsBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToExcelBarBtnItem)});
            this.reportsBarSubItem.MergeOrder = 70;
            this.reportsBarSubItem.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.reportsBarSubItem.Name = "reportsBarSubItem";
            // 
            // exportToExcelBarBtnItem
            // 
            this.exportToExcelBarBtnItem.Caption = "Экспорт в Excel";
            this.exportToExcelBarBtnItem.Id = 4;
            this.exportToExcelBarBtnItem.ImageIndex = 0;
            this.exportToExcelBarBtnItem.Name = "exportToExcelBarBtnItem";
            this.exportToExcelBarBtnItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exportToExcelBarButtonItem_ItemClick);
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Status bar";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.recordCountBarStaticItem)});
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem1.Caption = "Количество записей:";
            this.barStaticItem1.Id = 8;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // recordCountBarStaticItem
            // 
            this.recordCountBarStaticItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.recordCountBarStaticItem.Caption = "0";
            this.recordCountBarStaticItem.Id = 7;
            this.recordCountBarStaticItem.Name = "recordCountBarStaticItem";
            this.recordCountBarStaticItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(844, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 401);
            this.barDockControlBottom.Size = new System.Drawing.Size(844, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 348);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(844, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 348);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Excel.ico");
            this.imageList.Images.SetKeyName(1, "new.ico");
            this.imageList.Images.SetKeyName(2, "listEdit.ico");
            this.imageList.Images.SetKeyName(3, "delete.ico");
            this.imageList.Images.SetKeyName(4, "refresh.ico");
            // 
            // FormErrorLogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 424);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormErrorLogList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лог ошибок";
            this.Shown += new System.EventHandler(this.FormList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn actionGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn resultGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn descriptionNameGridColumn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private DevExpress.XtraGrid.Columns.GridColumn idGridColumn;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barTools;
        private DevExpress.XtraBars.BarButtonItem refreshBarBtnItem;
        private DevExpress.XtraBars.BarButtonItem addBarBtnItem;
        private DevExpress.XtraBars.BarButtonItem editBarBtnItem;
        private DevExpress.XtraBars.BarButtonItem archiveBarBtnItem;
        private DevExpress.XtraBars.BarButtonItem deleteBarBtnItem;
        private DevExpress.XtraBars.Bar barMainMenu;
        private DevExpress.XtraBars.BarSubItem reportsBarSubItem;
        private DevExpress.XtraBars.BarButtonItem exportToExcelBarBtnItem;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem recordCountBarStaticItem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ImageList imageList;
        private DevExpress.XtraGrid.Columns.GridColumn dateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn userNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}