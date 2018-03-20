namespace Safeguard.BusinessForm.Journals.Reports
{
    partial class ReportFromToDatetime
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.nppCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.offenseTypeCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.offenderCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.datePlaceOffenseCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.organizationCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.employeeCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.offenseResultCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.reportTitleInfoLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.reportTitleLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.reportFooterInfoLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.Detail.HeightF = 19F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable3
            // 
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(1039F, 19F);
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseFont = false;
            this.xrTable3.StylePriority.UsePadding = false;
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.nppCell,
            this.offenseTypeCell,
            this.offenderCell,
            this.datePlaceOffenseCell,
            this.organizationCell,
            this.employeeCell,
            this.offenseResultCell});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // nppCell
            // 
            this.nppCell.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.nppCell.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.nppCell.Name = "nppCell";
            this.nppCell.StylePriority.UseBorders = false;
            this.nppCell.StylePriority.UseFont = false;
            this.nppCell.StylePriority.UseTextAlignment = false;
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.nppCell.Summary = xrSummary1;
            this.nppCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.nppCell.Weight = 0.22915707024774218D;
            // 
            // offenseTypeCell
            // 
            this.offenseTypeCell.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.offenseTypeCell.Multiline = true;
            this.offenseTypeCell.Name = "offenseTypeCell";
            this.offenseTypeCell.StylePriority.UseFont = false;
            this.offenseTypeCell.StylePriority.UseTextAlignment = false;
            this.offenseTypeCell.Text = "steel\r\n123";
            this.offenseTypeCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.offenseTypeCell.Weight = 1.5803932002528245D;
            // 
            // offenderCell
            // 
            this.offenderCell.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.offenderCell.Name = "offenderCell";
            this.offenderCell.StylePriority.UseFont = false;
            this.offenderCell.StylePriority.UseTextAlignment = false;
            this.offenderCell.Text = "0";
            this.offenderCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.offenderCell.Weight = 0.885019782587198D;
            // 
            // datePlaceOffenseCell
            // 
            this.datePlaceOffenseCell.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.datePlaceOffenseCell.Multiline = true;
            this.datePlaceOffenseCell.Name = "datePlaceOffenseCell";
            this.datePlaceOffenseCell.StylePriority.UseFont = false;
            this.datePlaceOffenseCell.StylePriority.UseTextAlignment = false;
            this.datePlaceOffenseCell.Text = "0";
            this.datePlaceOffenseCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.datePlaceOffenseCell.Weight = 0.75858871665604743D;
            // 
            // organizationCell
            // 
            this.organizationCell.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.organizationCell.Name = "organizationCell";
            this.organizationCell.StylePriority.UseFont = false;
            this.organizationCell.StylePriority.UseTextAlignment = false;
            this.organizationCell.Text = "0";
            this.organizationCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.organizationCell.Weight = 0.75858910249420775D;
            // 
            // employeeCell
            // 
            this.employeeCell.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.employeeCell.Multiline = true;
            this.employeeCell.Name = "employeeCell";
            this.employeeCell.StylePriority.UseFont = false;
            this.employeeCell.StylePriority.UseTextAlignment = false;
            this.employeeCell.Text = "0";
            this.employeeCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.employeeCell.Weight = 0.75858795217002717D;
            // 
            // offenseResultCell
            // 
            this.offenseResultCell.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.offenseResultCell.Multiline = true;
            this.offenseResultCell.Name = "offenseResultCell";
            this.offenseResultCell.StylePriority.UseFont = false;
            this.offenseResultCell.StylePriority.UseTextAlignment = false;
            this.offenseResultCell.Text = "0";
            this.offenseResultCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.offenseResultCell.Weight = 1.597778095008465D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 62F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrPageInfo2});
            this.BottomMargin.HeightF = 50F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(880.8866F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(158.1134F, 23F);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrPageInfo1.Visible = false;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(158.1134F, 23F);
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrPageInfo2.Visible = false;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.reportTitleInfoLabel,
            this.reportTitleLabel});
            this.ReportHeader.HeightF = 74.25F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // reportTitleInfoLabel
            // 
            this.reportTitleInfoLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.reportTitleInfoLabel.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 24.16668F);
            this.reportTitleInfoLabel.Multiline = true;
            this.reportTitleInfoLabel.Name = "reportTitleInfoLabel";
            this.reportTitleInfoLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportTitleInfoLabel.SizeF = new System.Drawing.SizeF(1039F, 24.25F);
            this.reportTitleInfoLabel.StylePriority.UseFont = false;
            this.reportTitleInfoLabel.Text = "выявленных охраной ОАО \"Нафтан\" за период с {0} до {1} г.";
            this.reportTitleInfoLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // reportTitleLabel
            // 
            this.reportTitleLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.reportTitleLabel.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 0F);
            this.reportTitleLabel.Multiline = true;
            this.reportTitleLabel.Name = "reportTitleLabel";
            this.reportTitleLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportTitleLabel.SizeF = new System.Drawing.SizeF(1039F, 24.16667F);
            this.reportTitleLabel.StylePriority.UseFont = false;
            this.reportTitleLabel.Text = "СВЕДЕНИЯ О ПРАВОНАРУШЕНИЯХ";
            this.reportTitleLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable4
            // 
            this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable4.Font = new System.Drawing.Font("Arial", 10F);
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 0F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable4.SizeF = new System.Drawing.SizeF(1039F, 50F);
            this.xrTable4.StylePriority.UseBorders = false;
            this.xrTable4.StylePriority.UseFont = false;
            this.xrTable4.StylePriority.UsePadding = false;
            this.xrTable4.StylePriority.UseTextAlignment = false;
            this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.xrTableCell1,
            this.xrTableCell6,
            this.xrTableCell2,
            this.xrTableCell5,
            this.xrTableCell11,
            this.xrTableCell3});
            this.xrTableRow4.Font = new System.Drawing.Font("Arial", 8F);
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.StylePriority.UseFont = false;
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Font = new System.Drawing.Font("Arial", 12F);
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "№\r\nп/п";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell8.Weight = 0.22915701617486356D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new System.Drawing.Font("Arial", 12F);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.Text = "Вид правонарушения";
            this.xrTableCell1.Weight = 1.5803929973608375D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Font = new System.Drawing.Font("Arial", 12F);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.Text = "ФИО нарушителя";
            this.xrTableCell6.Weight = 0.88502005047216292D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Arial", 12F);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Text = "Время и место задержания";
            this.xrTableCell2.Weight = 0.75858863382799735D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new System.Drawing.Font("Arial", 12F);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.Text = "Место работы";
            this.xrTableCell5.Weight = 0.75858859960030944D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Font = new System.Drawing.Font("Arial", 12F);
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.Text = "Задержание осуществил";
            this.xrTableCell11.Weight = 0.75858862792100235D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Font = new System.Drawing.Font("Arial", 12F);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.Text = "Принятые меры";
            this.xrTableCell3.Weight = 1.5977772334615856D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4});
            this.PageHeader.HeightF = 50F;
            this.PageHeader.Name = "PageHeader";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.reportFooterInfoLabel});
            this.ReportFooter.HeightF = 73.95834F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // reportFooterInfoLabel
            // 
            this.reportFooterInfoLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.reportFooterInfoLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 24.58334F);
            this.reportFooterInfoLabel.Multiline = true;
            this.reportFooterInfoLabel.Name = "reportFooterInfoLabel";
            this.reportFooterInfoLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.reportFooterInfoLabel.SizeF = new System.Drawing.SizeF(1039F, 24.25F);
            this.reportFooterInfoLabel.StylePriority.UseFont = false;
            this.reportFooterInfoLabel.Text = "{0}\t\t\t\t{1}";
            this.reportFooterInfoLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // formattingRule1
            // 
            this.formattingRule1.Name = "formattingRule1";
            // 
            // ReportFromToDatetime
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter});
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(100, 30, 62, 50);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "10.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell nppCell;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell offenderCell;
        private DevExpress.XtraReports.UI.XRTableCell datePlaceOffenseCell;
        private DevExpress.XtraReports.UI.XRTableCell organizationCell;
        private DevExpress.XtraReports.UI.XRTableCell employeeCell;
        private DevExpress.XtraReports.UI.XRTableCell offenseTypeCell;
        private DevExpress.XtraReports.UI.XRLabel reportTitleInfoLabel;
        private DevExpress.XtraReports.UI.XRLabel reportTitleLabel;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTableCell offenseResultCell;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel reportFooterInfoLabel;
        private DevExpress.XtraReports.UI.FormattingRule formattingRule1;
    }
}
