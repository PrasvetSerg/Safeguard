using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Safeguard.BusinessForm.Journals.Reports
{
    public partial class ReportFromToDatetime : DevExpress.XtraReports.UI.XtraReport
    {
        readonly DateTime fromDatetime;
        readonly DateTime toDatetime;
        readonly bool byUser;

        public ReportFromToDatetime(DateTime fromDatetime, DateTime toDatetime, bool byUser = false)
        {
            this.fromDatetime = fromDatetime;
            this.toDatetime = toDatetime;
            this.byUser = byUser;

            InitializeComponent();

            if (InitData() == false)
            {
                this.Dispose();
            }
        }

        private bool InitData()
        {
            bool result = true;


            DataTable dataTableDetail = DBConnection.SqlQuery.ReadData(null, string.Format("dtr_offense_get '{0}',{1},{2}"
                , (byUser == false ? "report_for_period":"report_for_period_for_user")
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
                if(dataTableCurrentEmployeeInfo.Rows.Count == 1)
                {
                    this.reportFooterInfoLabel.Text = string.Format(this.reportFooterInfoLabel.Text, dataTableCurrentEmployeeInfo.Rows[0]["post_name"], dataTableCurrentEmployeeInfo.Rows[0]["employee_name"]);
                }

                foreach(DataRow row in dataTableDetail.Rows)
                {
                    row["offense_type_name"] = row["offense_type_name"].ToString() + Environment.NewLine + row["offense_comment"].ToString();
                    row["kpp_name"] = ((DateTime)row["offense_datetime"]).ToString("dd.MM.yyyy") + Environment.NewLine + ((DateTime)row["offense_datetime"]).ToString("HH:mm") + Environment.NewLine + row["kpp_name"].ToString();
                    row["employee_name"] = row["post_name"].ToString() + Environment.NewLine + row["employee_name"].ToString();

                    if (row["act_number"] != DBNull.Value)
                    {
                        row["offense_result"] = string.Format("Составлен акт №{0}.", row["act_number"].ToString()) + Environment.NewLine + row["offense_result"];
                    }
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
                this.datePlaceOffenseCell.DataBindings.Add("Text", dataTableDetail, "kpp_name");

                this.organizationCell.DataBindings.Add("Text", dataTableDetail, "organization_name");
                this.employeeCell.DataBindings.Add("Text", dataTableDetail, "employee_name");
                this.offenseResultCell.DataBindings.Add("Text", dataTableDetail, "offense_result");
            }

            return result;
        }
    }
}
