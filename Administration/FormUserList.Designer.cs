namespace Administration
{
    partial class FormUserList
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
            this.ucUserList = new Administration.UcUserList();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucGroupUserList = new Administration.UcUserGroupList();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucUserList
            // 
            this.ucUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserList.Location = new System.Drawing.Point(0, 0);
            this.ucUserList.Name = "ucUserList";
            this.ucUserList.ShowFindPanel = false;
            this.ucUserList.Size = new System.Drawing.Size(698, 267);
            this.ucUserList.TabIndex = 0;
            this.ucUserList.FocusedRowChanged += new Administration.UcUserList.DelegateFocuseRowChanged(this.ucGroupList_FocusedRowChanged);
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel1.ID = new System.Guid("2a674493-31dd-453b-9cf9-929c21365df2");
            this.dockPanel1.Location = new System.Drawing.Point(0, 267);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 259);
            this.dockPanel1.Size = new System.Drawing.Size(698, 259);
            this.dockPanel1.Text = "Группы пользователя";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.ucGroupUserList);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(690, 232);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // ucGroupUserList
            // 
            this.ucGroupUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGroupUserList.Location = new System.Drawing.Point(0, 0);
            this.ucGroupUserList.Name = "ucGroupUserList";
            this.ucGroupUserList.SearchingText = null;
            this.ucGroupUserList.Size = new System.Drawing.Size(690, 232);
            this.ucGroupUserList.TabIndex = 0;
            // 
            // FormUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 526);
            this.Controls.Add(this.ucUserList);
            this.Controls.Add(this.dockPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пользователи";
            this.Shown += new System.EventHandler(this.FormPhoneNumberList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UcUserList ucUserList;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private UcUserGroupList ucGroupUserList;


    }
}