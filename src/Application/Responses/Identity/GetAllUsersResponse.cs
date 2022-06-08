using System.Collections.Generic;

namespace ErpDashboard.Application.Responses.Identity
{
    public class GetAllUsersResponse
    {
        public IEnumerable<UserResponse> Users { get; set; }
    }
}