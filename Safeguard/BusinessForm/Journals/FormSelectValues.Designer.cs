namespace Safeguard.BusinessForm.Journals
{
    partial class FormSelectValues
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
            this.checkedListBoxControl = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.okSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxControl
            // 
            this.checkedListBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxControl.CheckOnClick = true;
            this.checkedListBoxControl.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxControl.Name = "checkedListBoxControl";
            this.checkedListBoxControl.Size = new System.Drawing.Size(530, 193);
            this.checkedListBoxControl.TabIndex = 0;
            // 
            // okSimpleButton
            // 
            this.okSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okSimpleButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okSimpleButton.Location = new System.Drawing.Point(181, 211);
            this.okSimpleButton.Name = "okSimpleButton";
            this.okSimpleButton.Size = new System.Drawing.Size(94, 23);
            this.okSimpleButton.TabIndex = 1;
            this.okSimpleButton.Text = "Вставить";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.Location = new System.Drawing.Point(281, 211);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Отмена";
            // 
            // FormSelectValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 246);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.okSimpleButton);
            this.Controls.Add(this.checkedListBoxControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectValues";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Шаблоны ответов";
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl;
        private DevExpress.XtraEditors.SimpleButton okSimpleButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}