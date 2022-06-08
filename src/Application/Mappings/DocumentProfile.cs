using AutoMapper;
using ErpDashboard.Application.Features.Documents.Commands.AddEdit;
using ErpDashboard.Application.Features.Documents.Queries.GetById;
using ErpDashboard.Domain.Entities.Misc;

namespace ErpDashboard.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}