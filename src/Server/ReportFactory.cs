using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using ErpDashboard.Application.Models;
using ErpDashboard.Infrastructure.Contexts;
using ErpDashboard.Server.Reports;
using System.Collections.Generic;

namespace ErpDashboard.Server
{
    public class ReportInfo
    {
        public XtraReport Report { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
    public class ReportFactory
    {
        public readonly static List<ReportInfo> Reports = new List<ReportInfo>();

        public static XtraReport CreateReport()
        {
            var report = new XtraReport();
            var band = new DetailBand();
            band.HeightF = 200f;
            band.Controls.Add(new XRLabel()
            {
                Text = "Hello World!",
                SizeF = new System.Drawing.SizeF(410, 90),
                LocationFloat = new DevExpress.Utils.PointFloat(119, 5),
                Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold),
                Padding = new PaddingInfo(2, 2, 0, 96, System.Drawing.GraphicsUnit.Pixel)
            });
            report.Name = "TestReport";
            
            report.Bands.Add(band);
            return report;
        }
    
        static ReportFactory()
        {
            Reports.Add(new ReportInfo() { DisplayName = "My Report", Name = "MyReport", Report = CreateReport()});
            var rpt = new Sticker();
            rpt.RequestParameters = false;
            Reports.Add(new ReportInfo() { DisplayName = "Test Repoer", Name = "TestReport", Report = rpt});
            Reports.Add(new ReportInfo() { DisplayName = "Customers Repoert", Name = "CustomersReport", Report = new CustomersReport()});
           
        }
    }
}
