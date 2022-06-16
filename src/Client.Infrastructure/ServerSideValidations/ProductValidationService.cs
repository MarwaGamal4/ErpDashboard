using ErpDashboard.Client.Infrastructure.Managers.Catalog.Product;
using ErpDashboard.Shared.ServerSideValidations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpDashboard.Client.Infrastructure.ServerSideValidations
{
    public class ProductValidationService : ProductValidationServices
    {
        private readonly IProductManager _productManager;

        public ProductValidationService(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public async  Task<bool> isNameExist(string name)
        {
            return await  _productManager.IsExist(name);
        }
    }
}
