using ErpDashboard.Application.Interfaces.Repositories;
using ErpDashboard.Domain.Entities.Catalog;

namespace ErpDashboard.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}