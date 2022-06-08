using AutoMapper;
using ErpDashboard.Application.Features.Brands.Commands.AddEdit;
using ErpDashboard.Application.Features.Brands.Queries.GetAll;
using ErpDashboard.Application.Features.Brands.Queries.GetById;
using ErpDashboard.Domain.Entities.Catalog;

namespace ErpDashboard.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}