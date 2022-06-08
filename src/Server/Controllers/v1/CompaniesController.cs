using ErpDashboard.Application.Features.Companies.GetAllCompanies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ErpDashboard.Server.Controllers.v1
{
    
  
    public class CompaniesController : BaseApiController<CompaniesController>
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Companies = await _mediator.Send(new GetAllCompaniesRequest());
            return Ok(Companies);
        }
    }
}
