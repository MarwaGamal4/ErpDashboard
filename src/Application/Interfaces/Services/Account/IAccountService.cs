using ErpDashboard.Application.Interfaces.Common;
using ErpDashboard.Application.Requests.Identity;
using ErpDashboard.Shared.Wrapper;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}