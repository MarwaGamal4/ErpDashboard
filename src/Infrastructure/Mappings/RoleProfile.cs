using AutoMapper;
using ErpDashboard.Application.Responses.Identity;
using ErpDashboard.Infrastructure.Models.Identity;

namespace ErpDashboard.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}