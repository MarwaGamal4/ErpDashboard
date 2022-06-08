using ErpDashboard.Application.Interfaces.Chat;
using ErpDashboard.Application.Models.Chat;
using ErpDashboard.Application.Responses.Identity;
using ErpDashboard.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ErpDashboard.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}