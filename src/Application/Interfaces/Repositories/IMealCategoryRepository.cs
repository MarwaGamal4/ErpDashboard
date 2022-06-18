using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpDashboard.Application.Interfaces.Repositories
{
    internal interface IMealCategoryRepository
    {
        Task<bool> IsMealCatUsed(int MealCatId);
    }
}
