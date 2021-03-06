using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Safeguard.BusinessForm.Journals.Reports
{
    public partial class ReportGeneralFromToDatetime : DevExpress.XtraReports.UI.XtraReport
    {
        readonly DateTime fromDatetime;
        readonly DateTime toDatetime;
        int groupId;

        public ReportGeneralFromToDatetime(DateTime fromDatetime, DateTime toDatetime, int groupId = -1)
        {
            this.fromDatetime = fromDatetime;
            this.toDatetime = toDatetime;
            this.groupId = groupId;

            InitializeComponent();

            if (InitData() == false)
            {
                this.Dispose();
            }
        }

        private bool InitData()
        {
            bool result = true;

            DataTable dataTableGroup = DBConnection.SqlQuery.ReadData(null, string.Format("dtr_group_get 'by_group_id',{0}",this.groupId));
            DataTable dataTableHeader = DBConnection.SqlQuery.ReadData(null, string.Format("dtr_offense_type_get 'all_view'"));
            DataTable dataTableDetail = (this.groupId > 0 ? 
                   DBConnection.SqlQuery.ReadData(null, string.Format("dtr_offense_get 'general_report_for_period_by_group', {0},{1},{2}"
                   , DBConnection.SqlQuery.ConvertToDbString(this.fromDatetime.ToString())
                   , DBConnection.SqlQuery.ConvertToDbString(this.toDatetime.ToString())
                   , this.groupId
                   )) : 
                   DBConnection.SqlQuery.ReadData(null, string.Format("dtr_offense_get 'general_report_for_period', {0},{1}"
                   , DBConnection.SqlQuery.ConvertToDbString(this.fromDatetime.ToString())
                   , DBConnection.SqlQuery.ConvertToDbString(this.toDatetime.ToString())
                   ))
                   );
            DataTable dataTableCurrentEmployeeInfo = DBConnection.SqlQuery.ReadData(null, string.Format("dtr_employee_get @command='current_user'"));

            if (dataTableDetail == null || dataTableCurrentEmployeeInfo == null || dataTableHeader == null)
            {
                result = false;
            }

            if (result == true)
            {
                if (this.groupId > 0 && dataTableGroup.Rows.Count == 1)
                {
                    this.reportTitleLabel.Text = string.Format(this.reportTitleLabel.Text, dataTableGroup.Rows[0]["group_name"]);
                }
                else 
                {
                    this.reportTitleLabel.Text = string.Format(this.reportTitleLabel.Text, "���� �����");
                }

                if(dataTableCurrentEmployeeInfo.Rows.Count == 1)
                {
                    this.reportFooterInfoLabel.Text = string.Format(this.reportFooterInfoLabel.Text, dataTableCurrentEmployeeInfo.Rows[0]["post_name"], dataTableCurrentEmployeeInfo.Rows[0]["employee_name"]);
                }

                for (int i = 0; i < 17; i++)
                {
                    this.xrTableRow4.Cells[i + 2].Text = dataTableHeader.Select("is_deleted_record=0", "sequence")[i]["offense_type_name"].ToString();
                }
                /*
                foreach (DataRow row in dataTableHeader.Rows)
                {
                    foreach(DevExpress.XtraReports.UI.XRTableCell cell in this.xrTableRow4.Cells)
                    {
                        if (cell.Name == "Cell" + row["offense_type_id"].ToString())
                        {
                            cell.Text = row["offense_type_name"].ToString();
                        }
                    }
                }
                */

                this.DataSource = dataTableDetail;
                this.Detail.SortFields.Add(new GroupField("offense_datetime", XRColumnSortOrder.Ascending));

                this.reportTitleInfoLabel.Text = string.Format(this.reportTitleInfoLabel.Text, this.fromDatetime.ToString("dd.MM.yyyy"), this.toDatetime.ToString("dd.MM.yyyy"));
                
                this.employeeCell.DataBindings.Add("Text", dataTableDetail, "employee_name");

                for (int i = 0; i < 21; i++)
                {
                    this.xrTableRow3.Cells[i + 2].DataBindings.Add("Text", dataTableDetail, dataTableDetail.Columns[i].ColumnName);
                    this.xrTableRow1.Cells[i + 1].DataBindings.Add("Text", dataTableDetail, dataTableDetail.Columns[i].ColumnName);
                }
                /*
                this.valueCell1.DataBindings.Add("Text", dataTableDetail, "type1");
                this.valueCell2.DataBindings.Add("Text", dataTableDetail, "type2");
                this.valueCell3.DataBindings.Add("Text", dataTableDetail, "type3");
                this.valueCell4.DataBindings.Add("Text", dataTableDetail, "type4");
                this.valueCell5.DataBindings.Add("Text", dataTableDetail, "type5");
                this.valueCell6.DataBindings.Add("Text", dataTableDetail, "type6");
                this.valueCell7.DataBindings.Add("Text", dataTableDetail, "type7");
                this.valueCell8.DataBindings.Add("Text", dataTableDetail, "type8");
                this.valueCell9.DataBindings.Add("Text", dataTableDetail, "type9");
                this.valueCell10.DataBindings.Add("Text", dataTableDetail, "type10");
                this.valueCell11.DataBindings.Add("Text", dataTableDetail, "type11");
                this.valueCell12.DataBindings.Add("Text", dataTableDetail, "type12");
                this.valueCell13.DataBindings.Add("Text", dataTableDetail, "type13");
                this.valueCell14.DataBindings.Add("Text", dataTableDetail, "type14");
                this.valueCell15.DataBindings.Add("Text", dataTableDetail, "type15");
                this.valueCell16.DataBindings.Add("Text", dataTableDetail, "type16");
                this.valueCell17.DataBindings.Add("Text", dataTableDetail, "type17");
                
                this.valueCell17.DataBindings.Add("Text", dataTableDetail, "act12");
                this.valueCell17.DataBindings.Add("Text", dataTableDetail, "total_act");
                this.valueCell20.DataBindings.Add("Text", dataTableDetail, "total_sum");
                */
            }

            return result;
        }
    }
}
