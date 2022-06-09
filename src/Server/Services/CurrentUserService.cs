using ErpDashboard.Application.Interfaces.Services;
using ErpDashboard.Infrastructure.Contexts;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ErpDashboard.Server.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            httpContextAccessor.HttpContext?.Request.Headers.TryGetValue("Company",out var CompanyId);
            if (int.TryParse(CompanyId,out var Commid))
            {
                CompanyID = Commid;
            }
            if (int.TryParse(httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Actor), out var sysId))
            {
                SystemUserId = int.Parse(httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Actor));
            }
            Claims = httpContextAccessor.HttpContext?.User?.Claims.AsEnumerable().Select(item => new KeyValuePair<string, string>(item.Type, item.Value)).ToList();
        }

        public string UserId { get; }
        public List<KeyValuePair<string, string>> Claims { get; set; }

        public int? CompanyID { get; }

        public int? SystemUserId { get; set; }
    }
}