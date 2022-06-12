using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpDashboard.Application
{
    public static class ServicesHelper
    {
        public static ServiceProvider provider;

        
        public static T GetService<T>()
        {

            return (T)provider.GetService(typeof(T));
        }
    }
}
