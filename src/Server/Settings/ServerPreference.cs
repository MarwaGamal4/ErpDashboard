using ErpDashboard.Shared.Constants.Localization;
using ErpDashboard.Shared.Settings;
using System.Linq;

namespace ErpDashboard.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}