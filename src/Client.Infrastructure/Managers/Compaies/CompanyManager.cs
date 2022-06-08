using ErpDashboard.Application.Features.Companies.GetAllCompanies.Dto;
using ErpDashboard.Client.Infrastructure.Extensions;
using ErpDashboard.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ErpDashboard.Client.Infrastructure.Managers.Compaies
{
    public class CompanyManager : ICompanyManager
    {
        private readonly HttpClient _httpClient;

        public CompanyManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<List<GetAllCompaniesDto>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.CompaniesEndpoints.GetAll);
            return await response.ToResult<List<GetAllCompaniesDto>>();
        }
    }
}
