using AutoMapper;
using ErpDashboard.Application.Requests.Identity;
using ErpDashboard.Application.Responses.Identity;

namespace ErpDashboard.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}