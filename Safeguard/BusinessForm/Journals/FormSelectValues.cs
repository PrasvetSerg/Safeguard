using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Safeguard.BusinessForm.Journals
{
    public partial class FormSelectValues : DevExpress.XtraEditors.XtraForm
    {
        public FormSelectValues(List<string> values)
        {
            InitializeComponent();
            foreach (string value in values)
            {
                this.checkedListBoxControl.Items.Add(value);
            }
        }

        public string GetSelectedValues()
        {
            string result = string.Empty;

            foreach(var item in this.checkedListBoxControl.CheckedItems)
            {
                if (result != string.Empty)
                {
                    result += "; "; 
                }
                result = result + item.ToString();
            }

            return result;
        }
    }
}