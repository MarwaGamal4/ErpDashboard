using System;

namespace ErpDashboard.Application.Interfaces.Services
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}