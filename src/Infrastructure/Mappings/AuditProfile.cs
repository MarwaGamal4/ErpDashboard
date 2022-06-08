using AutoMapper;
using ErpDashboard.Application.Responses.Audit;
using ErpDashboard.Infrastructure.Models.Audit;

namespace ErpDashboard.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}