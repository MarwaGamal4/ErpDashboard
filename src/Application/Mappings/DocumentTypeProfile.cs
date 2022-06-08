using AutoMapper;
using ErpDashboard.Application.Features.DocumentTypes.Commands.AddEdit;
using ErpDashboard.Application.Features.DocumentTypes.Queries.GetAll;
using ErpDashboard.Application.Features.DocumentTypes.Queries.GetById;
using ErpDashboard.Domain.Entities.Misc;

namespace ErpDashboard.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}