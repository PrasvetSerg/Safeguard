using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Safeguard.BusinessForm.Journals.Reports
{
    public partial class ReportTest : DevExpress.XtraReports.UI.XtraReport
    {
        readonly DateTime fromDatetime;
        readonly DateTime toDatetime;

        public ReportTest(DateTime fromDatetime, DateTime toDatetime)
        {
            this.fromDatetime = fromDatetime;
            this.toDatetime = toDatetime;

            InitializeComponent();

            if (InitData() == false)
            {
                this.Dispose();
            }
        }

        private bool InitData()
        {
            bool result = true;


            DataTable dataTableDetail = DBConnection.SqlQuery.ReadData(null, string.Format("dtr_offense_get 'report_for_period', {0},{1}"
                   , DBConnection.SqlQuery.ConvertToDbString(this.fromDatetime.ToString())
                   , DBConnection.SqlQuery.ConvertToDbString(this.toDatetime.ToString())
                   ));


            DataTable dataTableCurrentEmployeeInfo = DBConnection.SqlQuery.ReadData(null, string.Format("dtr_employee_get @command='current_user'"));

            if (dataTableDetail == null || dataTableCurrentEmployeeInfo == null)
            {
                result = false;
            }

            if (result == true)
            {
                this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
                    this.xrTableRow3});

                XRTableCell newCell = new DevExpress.XtraReports.UI.XRTableCell();

                this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
                    this.nppCell,
                    this.offenseTypeCell,
                    this.offenderCell});
                this.xrTableRow3.Cells.Add(newCell);

                // 
                // offenseTypeCell
                // 
                newCell.Multiline = true;
                newCell.Name = "newCell";
                newCell.StylePriority.UseTextAlignment = false;
                newCell.Text = "newCellValue";
                newCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
                newCell.Weight = 1.5803932002528245D;

                if(dataTableCurrentEmployeeInfo.Rows.Count == 1)
                {
                    this.reportFooterInfoLabel.Text = string.Format(this.reportFooterInfoLabel.Text, dataTableCurrentEmployeeInfo.Rows[0]["post_name"], dataTableCurrentEmployeeInfo.Rows[0]["employee_name"]);
                }

                foreach(DataRow row in dataTableDetail.Rows)
                {
                    row["offense_type_name"] = row["offense_type_name"].ToString() + Environment.NewLine + row["offense_comment"].ToString();
                    row["kpp_name"] = ((DateTime)row["offense_datetime"]).ToString("dd.MM.yyyy HH:mm") + Environment.NewLine + row["kpp_name"].ToString();
                    row["employee_name"] = row["post_name"].ToString() + Environment.NewLine + row["employee_name"].ToString();
                }

                this.DataSource = dataTableDetail;
                this.Detail.SortFields.Add(new GroupField("offense_datetime", XRColumnSortOrder.Ascending));

                if (this.fromDatetime.Date == this.toDatetime.Date)
                {
                    this.reportTitleInfoLabel.Text = string.Format(this.reportTitleInfoLabel.Text, this.fromDatetime.ToString("HH:mm"), this.toDatetime.ToString("HH:mm dd.MM.yyyy"));
                }
                else
                {
                    this.reportTitleInfoLabel.Text = string.Format(this.reportTitleInfoLabel.Text, this.fromDatetime.ToString("HH:mm dd.MM.yyyy"), this.toDatetime.ToString("HH:mm dd.MM.yyyy"));
                }

                this.offenseTypeCell.DataBindings.Add("Text", dataTableDetail, "offense_type_name");
                this.offenderCell.DataBindings.Add("Text", dataTableDetail, "offender_name");
            }

            return result;
        }
    }
}
