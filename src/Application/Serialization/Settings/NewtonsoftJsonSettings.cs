
using ErpDashboard.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace ErpDashboard.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}