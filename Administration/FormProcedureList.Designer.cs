namespace Administration
{
    partial class FormProcedureList
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
            this.ucRateList = new Administration.UcCommandList();
            this.ucTariffList = new Administration.UcProcedureList();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucRateList
            // 
            this.ucRateList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRateList.Location = new System.Drawing.Point(0, 0);
            this.ucRateList.Name = "ucRateList";
            this.ucRateList.SearchingText = null;
            this.ucRateList.Size = new System.Drawing.Size(713, 173);
            this.ucRateList.TabIndex = 1;
            // 
            // ucTariffList
            // 
            this.ucTariffList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTariffList.Location = new System.Drawing.Point(0, 0);
            this.ucTariffList.Name = "ucTariffList";
            this.ucTariffList.ShowFindPanel = false;
            this.ucTariffList.Size = new System.Drawing.Size(721, 280);
            this.ucTariffList.TabIndex = 0;
            this.ucTariffList.FocusedRowChanged += new Administration.UcProcedureList.DelegateFocuseRowChanged(this.ucTariffList_FocusedRowChanged);
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel
            // 
            this.dockPanel.Controls.Add(this.dockPanel1_Container);
            this.dockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel.ID = new System.Guid("53669400-07a7-4cb7-b64e-07fd58e3e244");
            this.dockPanel.Location = new System.Drawing.Point(0, 280);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel.Size = new System.Drawing.Size(721, 200);
            this.dockPanel.Text = "Команды в процедуре";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.ucRateList);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(713, 173);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // FormProcedureList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 480);
            this.Controls.Add(this.ucTariffList);
            this.Controls.Add(this.dockPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProcedureList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список процедур";
            this.Shown += new System.EventHandler(this.FormPhoneNumberList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UcProcedureList ucTariffList;
        private UcCommandList ucRateList;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;

    }
}