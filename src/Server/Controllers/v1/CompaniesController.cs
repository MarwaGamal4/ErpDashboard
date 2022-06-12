using ErpDashboard.Application.Features.Companies.GetAllCompanies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ErpDashboard.Infrastructure.Contexts;
using ErpDashboard.Server.Reports;
using System.IO;
using System.Linq;
using DevExpress.Compatibility.System.Web;

namespace ErpDashboard.Server.Controllers.v1
{
    
  
    public class CompaniesController : BaseApiController<CompaniesController>
    {
        private readonly ERBSYSTEMContext _context;

        public CompaniesController(ERBSYSTEMContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Companies = await _mediator.Send(new GetAllCompaniesRequest());
            return Ok(Companies);
        }

        [HttpGet("rpt")]
        [HttpPost("rpt")]
        
        public async Task<object> getrpt(string reportUrl)
        {
            var a = new DevExpress.XtraReports.Web.WebDocumentViewer.WebDocumentViewerClientSideModelGenerator(HttpContext.RequestServices)
               .GetJsonModelScript(reportUrl, "/DXXRD");
            return new JavaScriptSerializer().Deserialize<object>(a);
        }
    }
}
