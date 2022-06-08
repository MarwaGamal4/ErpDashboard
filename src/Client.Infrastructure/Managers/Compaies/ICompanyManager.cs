using ErpDashboard.Application.Features.Companies.GetAllCompanies.Dto;
using ErpDashboard.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpDashboard.Client.Infrastructure.Managers.Compaies
{
    public interface ICompanyManager : IManager
    {
        Task<IResult<List<GetAllCompaniesDto>>> GetAllAsync();
    }
}
