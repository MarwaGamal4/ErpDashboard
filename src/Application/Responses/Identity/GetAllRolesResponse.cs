using System.Collections.Generic;

namespace ErpDashboard.Application.Responses.Identity
{
    public class GetAllRolesResponse
    {
        public IEnumerable<RoleResponse> Roles { get; set; }
    }
}