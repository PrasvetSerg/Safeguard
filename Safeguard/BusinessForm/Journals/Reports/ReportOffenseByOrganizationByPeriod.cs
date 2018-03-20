using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;


using System.Collections.Generic;
using System.Linq;

namespace Safeguard.BusinessForm.Journals.Reports
{
    public partial class ReportOffenseByOrganizationByPeriod : DevExpress.XtraReports.UI.XtraReport
    {
        readonly DateTime fromDatetime;
        readonly DateTime toDatetime;
        readonly int organizationId;

        public ReportOffenseByOrganizationByPeriod(DateTime fromDate, DateTime toDate, int organizationId = -1)
        {
            this.fromDatetime = fromDate;
            this.toDatetime = toDate;
            this.organizationId = organizationId;

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
                , "report_for_period"
                , DBConnection.SqlQuery.ConvertToDbString(this.fromDatetime.Date.ToString())
                , DBConnection.SqlQuery.ConvertToDbString(this.toDatetime.Date.AddDays(1).ToString())
                ));


            DataTable dataTableCurrentEmployeeInfo = DBConnection.SqlQuery.ReadData(null, string.Format("dtr_employee_get @command='current_user'"));

            if (dataTableDetail == null || dataTableCurrentEmployeeInfo == null)
            {
                result = false;
            }

            if (result == true)
            {
                this.reportTitleInfoLabel.Text = string.Format(this.reportTitleInfoLabel.Text, this.fromDatetime.ToString("dd.MM.yyyy"), this.toDatetime.ToString("dd.MM.yyyy"));
                /*
                if (this.fromDatetime.Date == this.toDatetime.Date)
                {
                    this.reportTitleInfoLabel.Text = string.Format(this.reportTitleInfoLabel.Text, this.fromDatetime.ToString("HH:mm"), this.toDatetime.ToString("HH:mm dd.MM.yyyy"));
                }
                else
                {
                    this.reportTitleInfoLabel.Text = string.Format(this.reportTitleInfoLabel.Text, this.fromDatetime.ToString("HH:mm dd.MM.yyyy"), this.toDatetime.ToString("HH:mm dd.MM.yyyy"));
                }
                */

                if(dataTableCurrentEmployeeInfo.Rows.Count == 1)
                {
                    this.reportFooterInfoLabel.Text = string.Format(this.reportFooterInfoLabel.Text, dataTableCurrentEmployeeInfo.Rows[0]["post_name"], dataTableCurrentEmployeeInfo.Rows[0]["employee_name"]);
                }


                var source = dataTableDetail.Select().Select(row => new
                {                
                    organization_id = (int)row["organization_id"],
                    organization_name = row["organization_name"].ToString(),
                    offense_datetime = row["offense_datetime"],
                    offender_name = row["offender_name"],
                    kpp_name = ((DateTime)row["offense_datetime"]).ToString("dd.MM.yyyy") + Environment.NewLine + ((DateTime)row["offense_datetime"]).ToString("HH:mm") + Environment.NewLine + row["kpp_name"].ToString(),
                    offense_comment = row["offense_type_name"].ToString() + " "/* + Environment.NewLine*/ + row["offense_comment"].ToString(),
                    offense_result = (row["act_number"] != DBNull.Value ? string.Format("Составлен акт №{0}.", row["act_number"].ToString()) + Environment.NewLine + row["offense_result"] : row["offense_result"])
                }).ToList();

                if (this.organizationId > 0)
                {
                    source = source.FindAll(x => x.organization_id == this.organizationId);
                    this.xrTable1.Visible = false;
                    if(source.Count > 0)
                    {
                        this.reportTitleLabel2.Visible = true;
                        this.reportTitleLabel2.Text = string.Format(this.reportTitleLabel2.Text, source.First().organization_name);
                    }
                }

                this.DataSource = source;

                this.OrganizationGroupHeader.GroupFields.Add(new GroupField("organization_name", XRColumnSortOrder.Ascending));
                this.organizationCell.DataBindings.Add("Text", source, "organization_name");

                this.Detail.SortFields.AddRange(new []{new GroupField("offender_name", XRColumnSortOrder.Ascending), new GroupField("offense_datetime", XRColumnSortOrder.Ascending)});

                this.offenderCell.DataBindings.Add("Text", source, "offender_name");
                this.datePlaceOffenseCell.DataBindings.Add("Text", source, "kpp_name");
                
                this.reasonCell.DataBindings.Add("Text", source, "offense_comment");
                this.resultCell.DataBindings.Add("Text", source, "offense_result");
                
                /*//тоже самое, но без link и generic                
                foreach(DataRow row in dataTableDetail.Rows)
                {
                    row["offense_comment"] = row["offense_type_name"].ToString() + " " + row["offense_comment"].ToString();
                    row["kpp_name"] = ((DateTime)row["offense_datetime"]).ToString("dd.MM.yyyy") + Environment.NewLine + ((DateTime)row["offense_datetime"]).ToString("HH:mm") + Environment.NewLine + row["kpp_name"].ToString();
                    row["employee_name"] = row["post_name"].ToString() + Environment.NewLine + row["employee_name"].ToString();

                    if (row["act_number"] != DBNull.Value)
                    {
                        row["offense_result"] = string.Format("Составлен акт №{0}.", row["act_number"].ToString()) + Environment.NewLine + row["offense_result"];
                    }
                }

                this.DataSource = dataTableDetail;

                this.OrganizationGroupHeader.GroupFields.Add(new GroupField("organization_name", XRColumnSortOrder.Ascending));
                this.organizationCell.DataBindings.Add("Text", dataTableDetail, "organization_name");

                this.Detail.SortFields.Add(new GroupField("offense_datetime", XRColumnSortOrder.Ascending));
                
                this.offenderCell.DataBindings.Add("Text", dataTableDetail, "offender_name");
                this.datePlaceOffenseCell.DataBindings.Add("Text", dataTableDetail, "kpp_name");

                this.reasonCell.DataBindings.Add("Text", dataTableDetail, "offense_comment");
                this.resultCell.DataBindings.Add("Text", dataTableDetail, "offense_result");
                */
            }

            return result;
        }
    }
}
