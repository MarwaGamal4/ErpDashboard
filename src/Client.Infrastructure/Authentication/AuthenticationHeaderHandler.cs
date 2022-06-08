using Blazored.LocalStorage;
using ErpDashboard.Shared.Constants.Storage;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace ErpDashboard.Client.Infrastructure.Authentication
{
    public class AuthenticationHeaderHandler : DelegatingHandler
    {
        private readonly ILocalStorageService localStorage;

        public AuthenticationHeaderHandler(ILocalStorageService localStorage)
            => this.localStorage = localStorage;

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            if (request.Headers.Authorization?.Scheme != "Bearer")
            {
                var savedToken = await this.localStorage.GetItemAsync<string>(StorageConstants.Local.AuthToken);

                if (!string.IsNullOrWhiteSpace(savedToken))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", savedToken);
                }
            }
            var SavedCompanyId = await this.localStorage.GetItemAsync<int?>("Company");
            if (SavedCompanyId.HasValue)
            {
                request.Headers.Add("Company", SavedCompanyId.Value.ToString());
            }
            else
            {
                request.Headers.Add("Company", string.Empty);
            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
}