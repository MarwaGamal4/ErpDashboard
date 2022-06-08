using ErpDashboard.Application.Interfaces.Common;
using ErpDashboard.Application.Requests.Identity;
using ErpDashboard.Application.Responses.Identity;
using ErpDashboard.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}