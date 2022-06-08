using ErpDashboard.Application.Interfaces.Common;
using ErpDashboard.Application.Requests.Identity;
using ErpDashboard.Application.Responses.Identity;
using ErpDashboard.Shared.Wrapper;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}