using ErpDashboard.Application.Requests.Identity;
using ErpDashboard.Application.Responses.Identity;
using ErpDashboard.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ErpDashboard.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}