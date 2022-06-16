using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpDashboard.Shared.ServerSideValidations.Interfaces
{
    public interface ProductValidationServices
    {
        Task<bool> isNameExist(string name);
    }
}
