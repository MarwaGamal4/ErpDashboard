using ErpDashboard.Application.Features.DocumentTypes.Commands.AddEdit;
using ErpDashboard.Application.Features.DocumentTypes.Queries.GetAll;
using ErpDashboard.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ErpDashboard.Client.Infrastructure.Managers.Misc.DocumentType
{
    public interface IDocumentTypeManager : IManager
    {
        Task<IResult<List<GetAllDocumentTypesResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditDocumentTypeCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}