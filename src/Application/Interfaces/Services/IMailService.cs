using ErpDashboard.Application.Requests.Mail;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}