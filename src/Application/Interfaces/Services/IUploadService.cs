using ErpDashboard.Application.Requests;

namespace ErpDashboard.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}