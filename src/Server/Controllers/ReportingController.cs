using DevExpress.AspNetCore.Reporting.QueryBuilder;
using DevExpress.AspNetCore.Reporting.QueryBuilder.Native.Services;
using DevExpress.AspNetCore.Reporting.ReportDesigner;
using DevExpress.AspNetCore.Reporting.ReportDesigner.Native.Services;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using DevExpress.Compatibility.System.Web;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.ReportDesigner;
using ErpDashboard.Server.Reports;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Web;

namespace ErpDashboard.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ReportingController : Controller
    {
        public ReportingController() { }
        [Route("[action]", Name = "getReportDesignerModel")]
        public object GetReportDesignerModel(string reportUrl)
        {
            string modelJsonScript = new ReportDesignerClientSideModelGenerator(HttpContext.RequestServices)
                .GetJsonModelScript(reportUrl, null, "/DXXRD", "/DXXRDV", "/DXQB");
            return new JavaScriptSerializer().Deserialize<object>(modelJsonScript);
        }
    }
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ViewerController : WebDocumentViewerController
    {
       
        public ViewerController(IWebDocumentViewerMvcControllerService controllerService) : base(controllerService)
        {
            
        }
        //public override Task<IActionResult> Invoke()
        //{
          
        //    //var a = new DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerClientSideModelGenerator(HttpContext.RequestServices)
        //    // .GetJsonModelScript(reportUrl, "/DXXRD");
            
        //    //return new JavaScriptSerializer().Deserialize<object>(a);

        //   // return base.Invoke();
        //}

    }
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("DXXQB")]
    public class CustomQueryBuilderController : QueryBuilderController
    {
         
        public CustomQueryBuilderController(IQueryBuilderMvcControllerService controllerService) : base(controllerService) { }
        public override Task<IActionResult> Invoke()
        {
      
            return base.Invoke();
        }
    }

    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("DXXRD")]
    public class CustomReportDesignerController : ReportDesignerController
    {
        public CustomReportDesignerController(IReportDesignerMvcControllerService controllerService) : base(controllerService) { }
        public override Task<IActionResult> Invoke()
        {
            return base.Invoke();
        }
    }

    [ApiExplorerSettings(IgnoreApi = true)]
    public class CustomReportProvider : IReportProvider
    {
        public XtraReport GetReport(string id, ReportProviderContext context)
        {
            // Parse the string with the report name and parameter values.
            string[] parts = id.Split('?');
            string reportName = parts[0];
            string parametersQueryString = parts.Length > 1 ? parts[1] : String.Empty;

            // Create a report instance.
            XtraReport report = null;

            if (reportName == "Sticker")
            {
                report = new Sticker();
            }
            else
            {
                throw new DevExpress.XtraReports.Web.ClientControls.FaultException(
                    string.Format("Could not find report '{0}'.", reportName)
                );
            }

            // Apply the parameter values to the report.
            var parameters = HttpUtility.ParseQueryString(parametersQueryString);

            foreach (string parameterName in parameters.AllKeys)
            {
                report.Parameters[parameterName].Value = Convert.ChangeType(
                    parameters.Get(parameterName), report.Parameters[parameterName].Type);
            }

            // Disable the Visible property for all report parameters
            // to hide the Parameters Panel in the viewer.
            foreach (var parameter in report.Parameters)
            {
                parameter.Visible = false;
            }

            // If you do not hide the panel, disable the report's RequestParameters property.
            // report.RequestParameters = false;

            return report;
        }
    }
}
