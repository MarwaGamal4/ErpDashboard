using ErpDashboard.Application.Features.Dashboards.Queries.GetData;
using ErpDashboard.Shared.Wrapper;
using System.Threading.Tasks;

namespace ErpDashboard.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}