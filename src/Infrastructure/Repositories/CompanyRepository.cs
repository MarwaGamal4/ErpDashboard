using ErpDashboard.Application.Interfaces.Repositories;
using ErpDashboard.Application.Models;
using ErpDashboard.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ErpDashboard.Infrastructure.Repositories
{
    public class CompanyRepository : CustomRepositoryAsync<TbCompany, int>, ICompanyRepository
    {
        private readonly ERBSYSTEMContext _dbContext;

        public CompanyRepository(ERBSYSTEMContext dbContext): base(dbContext)
        {
            _dbContext = dbContext;
        }

        public bool IsCompanyNameExist()
        {
            
            return false;
        }
    }
}
