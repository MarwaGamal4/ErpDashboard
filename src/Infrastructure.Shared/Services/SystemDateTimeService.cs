using ErpDashboard.Application.Interfaces.Services;
using System;

namespace ErpDashboard.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}