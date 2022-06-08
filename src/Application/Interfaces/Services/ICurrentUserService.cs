using ErpDashboard.Application.Interfaces.Common;

namespace ErpDashboard.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
        int? CompanyID { get; }
    }
}