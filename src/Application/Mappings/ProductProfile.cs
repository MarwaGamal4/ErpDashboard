using AutoMapper;
using ErpDashboard.Application.Features.Products.Commands.AddEdit;
using ErpDashboard.Domain.Entities.Catalog;

namespace ErpDashboard.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}