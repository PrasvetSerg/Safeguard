namespace Administration
{
    partial class FormAclList
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
            this.ucAclList = new Administration.UcAclList();
            this.SuspendLayout();
            // 
            // ucAclList
            // 
            this.ucAclList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAclList.Location = new System.Drawing.Point(0, 0);
            this.ucAclList.Name = "ucAclList";
            this.ucAclList.ShowFindPanel = false;
            this.ucAclList.Size = new System.Drawing.Size(698, 526);
            this.ucAclList.TabIndex = 0;
            this.ucAclList.FocusedRowChanged += new Administration.UcAclList.DelegateFocuseRowChanged(this.ucGroupList_FocusedRowChanged);
            // 
            // FormAclList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 526);
            this.Controls.Add(this.ucAclList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAclList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Разрешения";
            this.Shown += new System.EventHandler(this.FormPhoneNumberList_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private UcAclList ucAclList;


    }
}