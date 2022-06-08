using ErpDashboard.Application.Interfaces.Repositories;
using ErpDashboard.Domain.Entities.Misc;

namespace ErpDashboard.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}