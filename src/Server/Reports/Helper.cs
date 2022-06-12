using ErpDashboard.Application.Models;
using System.Collections.Generic;
using ErpDashboard.Infrastructure.Contexts;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ErpDashboard.Server.Extensions;

namespace ErpDashboard.Server.Reports
{
    public class AllCustomersReport
    {

        public int Id { get; set; }
        public string CustomerName { get; set; }
        private  ERBSYSTEMContext _context;
        public bool FirstRender = true;
        public AllCustomersReport()
        {
            _context = Application.ServicesHelper.GetService<ERBSYSTEMContext>();
            CustomersList = GetAllCustomers();

        }
        public AllCustomersReport(int id , string Name)
        {
            Id = id;
            CustomerName = Name;
        }
        public List<AllCustomersReport> CustomersList { get; set; }
        public List<AllCustomersReport> GetAllCustomers()
        {
            var data = _context.TbCustomers.ToList();
            var result = data.Select(x => new AllCustomersReport(x.Id, x.CustomerName)).ToList();
            return result;
        }
    }
}
