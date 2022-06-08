using ErpDashboard.Application.Interfaces.Chat;
using ErpDashboard.Application.Models.Chat;
using ErpDashboard.Application.Responses.Identity;
using ErpDashboard.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}