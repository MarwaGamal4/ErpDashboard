using ErpDashboard.Application.Features.Documents.Commands.AddEdit;
using ErpDashboard.Application.Features.Documents.Queries.GetAll;
using ErpDashboard.Application.Features.Documents.Queries.GetById;
using ErpDashboard.Application.Requests.Documents;
using ErpDashboard.Shared.Wrapper;
using System.Threading.Tasks;

namespace ErpDashboard.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}