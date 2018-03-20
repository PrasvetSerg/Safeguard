using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Safeguard.BusinessForm.Journals.Reports
{
    public partial class ReportTalonOnDate : DevExpress.XtraReports.UI.XtraReport
    {
        readonly DateTime datetime;
        readonly int factoryId;

        public ReportTalonOnDate(DateTime datetime, int factoryId)
        {
            this.datetime = datetime;
            this.factoryId = factoryId;

            InitializeComponent();

            if (InitData() == false)
            {
                this.Dispose();
            }
        }

        private bool InitData()
        {
            bool result = true;


            DataTable dataTableDetail = DBConnection.SqlQuery.ReadData(null, string.Format("dtr_offense_get 'report_talon_on_date',{0}"
                , DBConnection.SqlQuery.ConvertToDbString(this.datetime.ToString())
                //, DBConnection.SqlQuery.ConvertToDbString(this.groupId.ToString())
                ));


            //DataTable dataTableGroup = DBConnection.SqlQuery.ReadData(null, string.Format("dtr_group_get 'by_group_id',{0}",this.groupId));

            DataTable dataTableCurrentEmployeeInfo = DBConnection.SqlQuery.ReadData(null, string.Format("dtr_employee_get @command='current_user'"));

            if (dataTableDetail == null || dataTableCurrentEmployeeInfo == null)// || dataTableGroup == null)
            {
                result = false;
            }

            if (result == true)
            {
                if(dataTableCurrentEmployeeInfo.Rows.Count == 1)
                {
                    this.reportFooterInfoLabel.Text = string.Format(this.reportFooterInfoLabel.Text, dataTableCurrentEmployeeInfo.Rows[0]["post_name"], dataTableCurrentEmployeeInfo.Rows[0]["employee_name"]);
                }
                /*
                foreach(DataRow row in dataTableDetail.Rows)
                {
                    row["offense_type_name"] = row["offense_type_name"].ToString() + Environment.NewLine + row["offense_comment"].ToString();
                    row["kpp_name"] = ((DateTime)row["offense_datetime"]).ToString("dd.MM.yyyy") + Environment.NewLine + ((DateTime)row["offense_datetime"]).ToString("HH:mm") + Environment.NewLine + row["kpp_name"].ToString();
                    row["employee_name"] = row["post_name"].ToString() + Environment.NewLine + row["employee_name"].ToString();
                }
                */
                DataView view = new DataView(dataTableDetail, this.factoryId == 0 ? "group_id < 5" : "group_id > 4", "", DataViewRowState.CurrentRows);
                this.DataSource = view;

                this.Groups.GroupFields.Add(new GroupField("group_name", XRColumnSortOrder.Ascending));
                this.groupCell.DataBindings.Add("Text", view, "group_name");

                this.Detail.SortFields.AddRange(new GroupField[] { new GroupField("kpp_name", XRColumnSortOrder.Ascending), new GroupField("talon_number", XRColumnSortOrder.Ascending) });

                this.reportTitleInfoLabel.Text = string.Format(this.reportTitleInfoLabel.Text, this.datetime.ToString("dd.MM.yyyy"));//, dataTableGroup.Rows[0]["group_name"]);
                this.talonCell.DataBindings.Add("Text", view, "talon_number");
                this.kppCell.DataBindings.Add("Text", view, "kpp_name");
                this.employeeCell.DataBindings.Add("Text", view, "employee_name");
            }

            return result;
        }
    }
}
