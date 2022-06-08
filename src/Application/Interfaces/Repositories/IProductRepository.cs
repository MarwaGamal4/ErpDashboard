using System.Threading.Tasks;

namespace ErpDashboard.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<bool> IsBrandUsed(int brandId);
    }
}