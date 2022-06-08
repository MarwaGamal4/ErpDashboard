using ErpDashboard.Shared.Settings;
using ErpDashboard.Shared.Wrapper;
using System.Threading.Tasks;

namespace ErpDashboard.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}