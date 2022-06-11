using DevExpress.AspNetCore.Reporting.QueryBuilder;
using DevExpress.AspNetCore.Reporting.QueryBuilder.Native.Services;
using DevExpress.AspNetCore.Reporting.ReportDesigner;
using DevExpress.AspNetCore.Reporting.ReportDesigner.Native.Services;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using DevExpress.Compatibility.System.Web;
using DevExpress.XtraReports.Web.ReportDesigner;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ErpDashboard.Server.Controllers
{
    [Route("api/[controller]")]
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
    public class ViewerController : WebDocumentViewerController
    {
        public ViewerController(IWebDocumentViewerMvcControllerService controllerService) : base(controllerService)
        {

        }

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
}
