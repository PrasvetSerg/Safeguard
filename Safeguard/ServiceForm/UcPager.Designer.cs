namespace Safeguard.ServiceForm
{
    partial class UcPager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPager));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.datetimeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.senderColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.messageColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.messageMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.newMessageMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.sendNewMessageSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barTools = new DevExpress.XtraBars.Bar();
            this.refreshBarBtnItem = new DevExpress.XtraBars.BarButtonItem();
            this.searchBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.addBarBtnItem = new DevExpress.XtraBars.BarButtonItem();
            this.editBarBtnItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBarBtnItem = new DevExpress.XtraBars.BarButtonItem();
            this.lastDayBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.lastWeekBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.lastMonthBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.allBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barMainMenu = new DevExpress.XtraBars.Bar();
            this.viewBarSubItem = new DevExpress.XtraBars.BarSubItem();
            this.viewSaveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.viewResetBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.reportsBarSubItem = new DevExpress.XtraBars.BarSubItem();
            this.exportToExcelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.recordCountBarStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.alertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.messageTypeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.helpBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageMemoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMessageMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageTypeImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 53);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.messageMemoEdit,
            this.repositoryItemRichTextEdit1});
            this.gridControl.Size = new System.Drawing.Size(695, 190);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idGridColumn,
            this.datetimeColumn,
            this.gridColumn2,
            this.senderColumn,
            this.messageColumn});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsCustomization.AllowRowSizing = true;
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridView.OptionsView.RowAutoHeight = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.PreviewFieldName = "message";
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            this.gridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_RowCellClick);
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            // 
            // idGridColumn
            // 
            this.idGridColumn.Caption = "ID-сообщения";
            this.idGridColumn.FieldName = "message_id";
            this.idGridColumn.Name = "idGridColumn";
            // 
            // datetimeColumn
            // 
            this.datetimeColumn.AppearanceCell.Options.UseTextOptions = true;
            this.datetimeColumn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.datetimeColumn.Caption = "Опубликовано";
            this.datetimeColumn.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.datetimeColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.datetimeColumn.FieldName = "datetime_update";
            this.datetimeColumn.Name = "datetimeColumn";
            this.datetimeColumn.OptionsColumn.AllowEdit = false;
            this.datetimeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.datetimeColumn.OptionsColumn.FixedWidth = true;
            this.datetimeColumn.Visible = true;
            this.datetimeColumn.VisibleIndex = 0;
            this.datetimeColumn.Width = 110;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID-пользователя";
            this.gridColumn2.FieldName = "user_id_update";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // senderColumn
            // 
            this.senderColumn.AppearanceCell.Options.UseTextOptions = true;
            this.senderColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.senderColumn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.senderColumn.Caption = "Автор";
            this.senderColumn.FieldName = "user_name_update";
            this.senderColumn.Name = "senderColumn";
            this.senderColumn.OptionsColumn.AllowEdit = false;
            this.senderColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.senderColumn.OptionsColumn.FixedWidth = true;
            this.senderColumn.Visible = true;
            this.senderColumn.VisibleIndex = 1;
            this.senderColumn.Width = 110;
            // 
            // messageColumn
            // 
            this.messageColumn.Caption = "Сообщение";
            this.messageColumn.ColumnEdit = this.messageMemoEdit;
            this.messageColumn.FieldName = "message";
            this.messageColumn.Name = "messageColumn";
            this.messageColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.messageColumn.Visible = true;
            this.messageColumn.VisibleIndex = 2;
            this.messageColumn.Width = 457;
            // 
            // messageMemoEdit
            // 
            this.messageMemoEdit.AcceptsTab = true;
            this.messageMemoEdit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.messageMemoEdit.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.messageMemoEdit.Appearance.BorderColor = System.Drawing.Color.Red;
            this.messageMemoEdit.Appearance.Options.UseBackColor = true;
            this.messageMemoEdit.Appearance.Options.UseBorderColor = true;
            this.messageMemoEdit.HideSelection = false;
            this.messageMemoEdit.Name = "messageMemoEdit";
            this.messageMemoEdit.UseParentBackground = true;
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            // 
            // newMessageMemoEdit
            // 
            this.newMessageMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newMessageMemoEdit.Location = new System.Drawing.Point(3, 5);
            this.newMessageMemoEdit.Name = "newMessageMemoEdit";
            this.newMessageMemoEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.newMessageMemoEdit.Size = new System.Drawing.Size(556, 40);
            this.newMessageMemoEdit.TabIndex = 1;
            this.newMessageMemoEdit.EditValueChanged += new System.EventHandler(this.newMessageMemoEdit_EditValueChanged);
            // 
            // sendNewMessageSimpleButton
            // 
            this.sendNewMessageSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendNewMessageSimpleButton.Location = new System.Drawing.Point(563, 4);
            this.sendNewMessageSimpleButton.Name = "sendNewMessageSimpleButton";
            this.sendNewMessageSimpleButton.Size = new System.Drawing.Size(127, 40);
            this.sendNewMessageSimpleButton.TabIndex = 0;
            this.sendNewMessageSimpleButton.Text = "Опубликовать";
            this.sendNewMessageSimpleButton.Click += new System.EventHandler(this.sendNewMessageSimpleButton_Click);
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
            this.barManager.Images = this.imageCollection;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addBarBtnItem,
            this.editBarBtnItem,
            this.refreshBarBtnItem,
            this.reportsBarSubItem,
            this.exportToExcelBarButtonItem,
            this.barStaticItem1,
            this.recordCountBarStaticItem,
            this.deleteBarBtnItem,
            this.viewBarSubItem,
            this.viewSaveBarButtonItem,
            this.viewResetBarButtonItem,
            this.searchBarButtonItem,
            this.lastDayBarButtonItem,
            this.lastWeekBarButtonItem,
            this.lastMonthBarButtonItem,
            this.allBarButtonItem,
            this.helpBarButtonItem});
            this.barManager.MainMenu = this.barMainMenu;
            this.barManager.MaxItemId = 22;
            this.barManager.StatusBar = this.barStatus;
            // 
            // barTools
            // 
            this.barTools.BarName = "Tools";
            this.barTools.DockCol = 0;
            this.barTools.DockRow = 1;
            this.barTools.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barTools.FloatLocation = new System.Drawing.Point(878, 297);
            this.barTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.refreshBarBtnItem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.searchBarButtonItem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addBarBtnItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.editBarBtnItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteBarBtnItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.lastDayBarButtonItem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.lastWeekBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.lastMonthBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.allBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.helpBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.Standard)});
            this.barTools.OptionsBar.AllowQuickCustomization = false;
            this.barTools.OptionsBar.RotateWhenVertical = false;
            this.barTools.OptionsBar.UseWholeRow = true;
            this.barTools.Text = "Tools";
            // 
            // refreshBarBtnItem
            // 
            this.refreshBarBtnItem.Caption = "Обновить";
            this.refreshBarBtnItem.Id = 2;
            this.refreshBarBtnItem.ImageIndex = 4;
            this.refreshBarBtnItem.Name = "refreshBarBtnItem";
            this.refreshBarBtnItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarBtnItem_ItemClick);
            // 
            // searchBarButtonItem
            // 
            this.searchBarButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.searchBarButtonItem.Caption = "Поиск";
            this.searchBarButtonItem.Id = 16;
            this.searchBarButtonItem.ImageIndex = 7;
            this.searchBarButtonItem.Name = "searchBarButtonItem";
            this.searchBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // addBarBtnItem
            // 
            this.addBarBtnItem.Caption = "Добавить";
            this.addBarBtnItem.Id = 0;
            this.addBarBtnItem.ImageIndex = 1;
            this.addBarBtnItem.Name = "addBarBtnItem";
            this.addBarBtnItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // editBarBtnItem
            // 
            this.editBarBtnItem.Caption = "Изменить";
            this.editBarBtnItem.Id = 1;
            this.editBarBtnItem.ImageIndex = 2;
            this.editBarBtnItem.Name = "editBarBtnItem";
            this.editBarBtnItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // deleteBarBtnItem
            // 
            this.deleteBarBtnItem.Caption = "Удалить";
            this.deleteBarBtnItem.Id = 9;
            this.deleteBarBtnItem.ImageIndex = 3;
            this.deleteBarBtnItem.Name = "deleteBarBtnItem";
            this.deleteBarBtnItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // lastDayBarButtonItem
            // 
            this.lastDayBarButtonItem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lastDayBarButtonItem.Appearance.Options.UseFont = true;
            this.lastDayBarButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.lastDayBarButtonItem.Caption = "1 день";
            this.lastDayBarButtonItem.Down = true;
            this.lastDayBarButtonItem.Id = 17;
            this.lastDayBarButtonItem.Name = "lastDayBarButtonItem";
            this.lastDayBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.lastDayBarButtonItem_ItemClick);
            // 
            // lastWeekBarButtonItem
            // 
            this.lastWeekBarButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.lastWeekBarButtonItem.Caption = "7 дней";
            this.lastWeekBarButtonItem.Id = 18;
            this.lastWeekBarButtonItem.Name = "lastWeekBarButtonItem";
            this.lastWeekBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.lastWeekBarButtonItem_ItemClick);
            // 
            // lastMonthBarButtonItem
            // 
            this.lastMonthBarButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.lastMonthBarButtonItem.Caption = "месяц";
            this.lastMonthBarButtonItem.Id = 19;
            this.lastMonthBarButtonItem.Name = "lastMonthBarButtonItem";
            this.lastMonthBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.lastMonthBarButtonItem_ItemClick);
            // 
            // allBarButtonItem
            // 
            this.allBarButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.allBarButtonItem.Caption = "Все";
            this.allBarButtonItem.Id = 20;
            this.allBarButtonItem.Name = "allBarButtonItem";
            this.allBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.allBarButtonItem_ItemClick);
            // 
            // barMainMenu
            // 
            this.barMainMenu.BarName = "Main menu";
            this.barMainMenu.DockCol = 0;
            this.barMainMenu.DockRow = 0;
            this.barMainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.viewBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.reportsBarSubItem)});
            this.barMainMenu.OptionsBar.MultiLine = true;
            this.barMainMenu.OptionsBar.UseWholeRow = true;
            this.barMainMenu.Text = "Main menu";
            this.barMainMenu.Visible = false;
            // 
            // viewBarSubItem
            // 
            this.viewBarSubItem.Caption = "&Вид";
            this.viewBarSubItem.Id = 10;
            this.viewBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.viewSaveBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.viewResetBarButtonItem)});
            this.viewBarSubItem.MergeOrder = 30;
            this.viewBarSubItem.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.viewBarSubItem.Name = "viewBarSubItem";
            // 
            // viewSaveBarButtonItem
            // 
            this.viewSaveBarButtonItem.Caption = "Сохранить";
            this.viewSaveBarButtonItem.Id = 11;
            this.viewSaveBarButtonItem.Name = "viewSaveBarButtonItem";
            // 
            // viewResetBarButtonItem
            // 
            this.viewResetBarButtonItem.Caption = "Сбросить";
            this.viewResetBarButtonItem.Id = 12;
            this.viewResetBarButtonItem.Name = "viewResetBarButtonItem";
            // 
            // reportsBarSubItem
            // 
            this.reportsBarSubItem.Caption = "Отчёты";
            this.reportsBarSubItem.Id = 3;
            this.reportsBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToExcelBarButtonItem)});
            this.reportsBarSubItem.MergeOrder = 70;
            this.reportsBarSubItem.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.reportsBarSubItem.Name = "reportsBarSubItem";
            // 
            // exportToExcelBarButtonItem
            // 
            this.exportToExcelBarButtonItem.Caption = "Экспорт в Excel";
            this.exportToExcelBarButtonItem.Id = 4;
            this.exportToExcelBarButtonItem.ImageIndex = 0;
            this.exportToExcelBarButtonItem.Name = "exportToExcelBarButtonItem";
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Status bar";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.recordCountBarStaticItem)});
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Status bar";
            this.barStatus.Visible = false;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem1.Caption = "Количество записей:";
            this.barStaticItem1.Id = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(695, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 293);
            this.barDockControlBottom.Size = new System.Drawing.Size(695, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 240);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(695, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 240);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "Excel.ico");
            this.imageCollection.Images.SetKeyName(1, "new.ico");
            this.imageCollection.Images.SetKeyName(2, "listEdit.ico");
            this.imageCollection.Images.SetKeyName(3, "delete.ico");
            this.imageCollection.Images.SetKeyName(4, "refresh.ico");
            this.imageCollection.Images.SetKeyName(5, "agt_action_success_3884.ico");
            this.imageCollection.Images.SetKeyName(6, "bookmarkred.png");
            this.imageCollection.Images.SetKeyName(7, "search_6766.ico");
            this.imageCollection.Images.SetKeyName(8, "help.ico");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.newMessageMemoEdit);
            this.panelControl1.Controls.Add(this.sendNewMessageSimpleButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 243);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(695, 50);
            this.panelControl1.TabIndex = 6;
            // 
            // alertControl
            // 
            this.alertControl.AlertClick += new DevExpress.XtraBars.Alerter.AlertClickEventHandler(this.alertControl_AlertClick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // messageTypeImageCollection
            // 
            this.messageTypeImageCollection.ImageSize = new System.Drawing.Size(24, 24);
            this.messageTypeImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("messageTypeImageCollection.ImageStream")));
            this.messageTypeImageCollection.Images.SetKeyName(0, "mail_generic2_5715.png");
            // 
            // helpBarButtonItem
            // 
            this.helpBarButtonItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.helpBarButtonItem.Caption = "Справка";
            this.helpBarButtonItem.Id = 21;
            this.helpBarButtonItem.ImageIndex = 8;
            this.helpBarButtonItem.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.helpBarButtonItem.Name = "helpBarButtonItem";
            this.helpBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.helpBarButtonItem_ItemClick);
            // 
            // UcPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UcPager";
            this.Size = new System.Drawing.Size(695, 316);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageMemoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMessageMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.messageTypeImageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit messageMemoEdit;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraEditors.MemoEdit newMessageMemoEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn datetimeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn senderColumn;
        private DevExpress.XtraGrid.Columns.GridColumn messageColumn;
        private DevExpress.XtraEditors.SimpleButton sendNewMessageSimpleButton;
        private DevExpress.XtraGrid.Columns.GridColumn idGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        public DevExpress.XtraBars.BarManager barManager;
        protected DevExpress.XtraBars.Bar barTools;
        private DevExpress.XtraBars.BarButtonItem refreshBarBtnItem;
        private DevExpress.XtraBars.BarButtonItem addBarBtnItem;
        private DevExpress.XtraBars.BarButtonItem editBarBtnItem;
        private DevExpress.XtraBars.BarButtonItem deleteBarBtnItem;
        protected DevExpress.XtraBars.Bar barMainMenu;
        private DevExpress.XtraBars.BarSubItem viewBarSubItem;
        private DevExpress.XtraBars.BarButtonItem viewSaveBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem viewResetBarButtonItem;
        private DevExpress.XtraBars.BarSubItem reportsBarSubItem;
        private DevExpress.XtraBars.BarButtonItem exportToExcelBarButtonItem;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem recordCountBarStaticItem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraBars.BarButtonItem searchBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem lastDayBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem lastWeekBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem lastMonthBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem allBarButtonItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl;
        private System.Windows.Forms.Timer timer;
        private DevExpress.Utils.ImageCollection messageTypeImageCollection;
        private DevExpress.XtraBars.BarButtonItem helpBarButtonItem;
    }
}
