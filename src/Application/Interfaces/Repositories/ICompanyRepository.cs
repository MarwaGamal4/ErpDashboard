using ErpDashboard.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Interfaces.Repositories
{
    public interface ICompanyRepository: CustomIRepositoryAsync<TbCompany,int>
    {
        bool IsCompanyNameExist();
    }
}
