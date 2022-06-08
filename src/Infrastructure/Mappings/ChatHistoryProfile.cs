using AutoMapper;
using ErpDashboard.Application.Interfaces.Chat;
using ErpDashboard.Application.Models.Chat;
using ErpDashboard.Infrastructure.Models.Identity;

namespace ErpDashboard.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}