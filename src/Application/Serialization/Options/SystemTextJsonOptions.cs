using ErpDashboard.Application.Interfaces.Serialization.Options;
using System.Text.Json;

namespace ErpDashboard.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}