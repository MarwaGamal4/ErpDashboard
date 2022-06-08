using ErpDashboard.Application.Interfaces.Common;
using ErpDashboard.Application.Requests.Identity;
using ErpDashboard.Application.Responses.Identity;
using ErpDashboard.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Interfaces.Services.Identity
{
    public interface IRoleService : IService
    {
        Task<Result<List<RoleResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleResponse>> GetByIdAsync(string id);

        Task<Result<string>> SaveAsync(RoleRequest request);

        Task<Result<string>> DeleteAsync(string id);

        Task<Result<PermissionResponse>> GetAllPermissionsAsync(string roleId);

        Task<Result<string>> UpdatePermissionsAsync(PermissionRequest request);
    }
}