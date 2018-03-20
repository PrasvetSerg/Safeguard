namespace Safeguard.BusinessForm.Catalogs
{
    partial class FormKppManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKppManager));
            this.leftPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.ucList = new Safeguard.BusinessForm.Catalogs.UserControls.UcKppList();
            this.menuImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barTools = new DevExpress.XtraBars.Bar();
            this.findBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.helpBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.reportsBarSubItem = new DevExpress.XtraBars.BarSubItem();
            this.exportToFileBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanelControl)).BeginInit();
            this.leftPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanelControl
            // 
            this.leftPanelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.leftPanelControl.Controls.Add(this.ucList);
            this.leftPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanelControl.Location = new System.Drawing.Point(0, 53);
            this.leftPanelControl.Name = "leftPanelControl";
            this.leftPanelControl.Size = new System.Drawing.Size(1126, 549);
            this.leftPanelControl.TabIndex = 5;
            // 
            // ucList
            // 
            this.ucList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucList.Location = new System.Drawing.Point(0, 0);
            this.ucList.Name = "ucList";
            this.ucList.SearchingText = null;
            this.ucList.Size = new System.Drawing.Size(1126, 549);
            this.ucList.TabIndex = 0;
            this.ucList.FocusedRowChanged += new Safeguard.BusinessForm.Catalogs.UserControls.UcKppList.DelegateFocuseCardChanged(this.ucObjectTree_FocusedRowChanged);
            // 
            // menuImageCollection
            // 
            this.menuImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("menuImageCollection.ImageStream")));
            this.menuImageCollection.Images.SetKeyName(0, "find.ico");
            this.menuImageCollection.Images.SetKeyName(1, "Warning.png");
            this.menuImageCollection.Images.SetKeyName(2, "find_1r.ico");
            this.menuImageCollection.Images.SetKeyName(3, "find_1.ico");
            this.menuImageCollection.Images.SetKeyName(4, "eraser_5226.ico");
            this.menuImageCollection.Images.SetKeyName(5, "find_7.ico");
            this.menuImageCollection.Images.SetKeyName(6, "export4.ico");
            this.menuImageCollection.Images.SetKeyName(7, "export_database.ico");
            this.menuImageCollection.Images.SetKeyName(8, "email.ico");
            this.menuImageCollection.Images.SetKeyName(9, "BO_Person.png");
            this.menuImageCollection.Images.SetKeyName(10, "book_4571.ico");
            this.menuImageCollection.Images.SetKeyName(11, "book16-16.png");
            this.menuImageCollection.Images.SetKeyName(12, "help.ico");
            this.menuImageCollection.Images.SetKeyName(13, "excelreport.png");
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barTools,
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Images = this.menuImageCollection;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.findBarButtonItem,
            this.helpBarButtonItem,
            this.reportsBarSubItem,
            this.exportToFileBarButtonItem});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 21;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemRadioGroup1});
            // 
            // barTools
            // 
            this.barTools.BarName = "Tools";
            this.barTools.DockCol = 0;
            this.barTools.DockRow = 1;
            this.barTools.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.findBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.helpBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.Standard)});
            this.barTools.OptionsBar.AllowQuickCustomization = false;
            this.barTools.OptionsBar.DrawDragBorder = false;
            this.barTools.OptionsBar.UseWholeRow = true;
            this.barTools.Text = "Tools";
            this.barTools.Visible = false;
            // 
            // findBarButtonItem
            // 
            this.findBarButtonItem.Caption = "Поиск по карточкам";
            this.findBarButtonItem.Id = 4;
            this.findBarButtonItem.ImageIndex = 5;
            this.findBarButtonItem.Name = "findBarButtonItem";
            this.findBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.findBarButtonItem_ItemClick);
            // 
            // helpBarButtonItem
            // 
            this.helpBarButtonItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.helpBarButtonItem.Caption = "Помощь";
            this.helpBarButtonItem.Id = 15;
            this.helpBarButtonItem.ImageIndex = 12;
            this.helpBarButtonItem.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.helpBarButtonItem.Name = "helpBarButtonItem";
            this.helpBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.helpBarButtonItem_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.reportsBarSubItem)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // reportsBarSubItem
            // 
            this.reportsBarSubItem.Caption = "Отчёты";
            this.reportsBarSubItem.Id = 16;
            this.reportsBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.exportToFileBarButtonItem)});
            this.reportsBarSubItem.MergeOrder = 80;
            this.reportsBarSubItem.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.reportsBarSubItem.Name = "reportsBarSubItem";
            // 
            // exportToFileBarButtonItem
            // 
            this.exportToFileBarButtonItem.Caption = "Экспорт";
            this.exportToFileBarButtonItem.Id = 18;
            this.exportToFileBarButtonItem.ImageIndex = 13;
            this.exportToFileBarButtonItem.Name = "exportToFileBarButtonItem";
            this.exportToFileBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exportToFileBarButtonItem_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1126, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 602);
            this.barDockControlBottom.Size = new System.Drawing.Size(1126, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 549);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1126, 53);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 549);
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Видимость";
            this.barEditItem2.Edit = this.repositoryItemImageComboBox2;
            this.barEditItem2.Id = 7;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Width = 112;
            // 
            // FormKppManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 602);
            this.Controls.Add(this.leftPanelControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MinimizeBox = false;
            this.Name = "FormKppManager";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочники. Места задержания";
            this.Shown += new System.EventHandler(this.FormPhonebookManager_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.leftPanelControl)).EndInit();
            this.leftPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UcKppList ucList;
        private DevExpress.XtraEditors.PanelControl leftPanelControl;
        private DevExpress.Utils.ImageCollection menuImageCollection;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barTools;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraBars.BarButtonItem findBarButtonItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraBars.BarButtonItem helpBarButtonItem;
        private DevExpress.XtraBars.BarSubItem reportsBarSubItem;
        private DevExpress.XtraBars.BarButtonItem exportToFileBarButtonItem;
    }
}