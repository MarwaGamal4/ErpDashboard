using ErpDashboard.Application.Features.Companies.GetAllCompanies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ErpDashboard.Infrastructure.Contexts;
using ErpDashboard.Server.Reports;
using System.IO;
using System.Linq;
using DevExpress.Compatibility.System.Web;
using X.Paymob.CashIn;
using X.Paymob.CashIn.Models.Orders;
using X.Paymob.CashIn.Models.Payment;

namespace ErpDashboard.Server.Controllers.v1
{
    
  
    public class CompaniesController : BaseApiController<CompaniesController>
    {
        private readonly ERBSYSTEMContext _context;
        private readonly IPaymobCashInBroker _broker;
        public CompaniesController(ERBSYSTEMContext context, IPaymobCashInBroker broker)
        {
            _context = context;
            _broker = broker;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Companies = await _mediator.Send(new GetAllCompaniesRequest());
            return Ok(Companies);
        }

        [HttpGet("pay")]
        
        public async Task<object> getrpt()
        {
            var amountCents = 1000; // 10 LE
            var orderRequest = CashInCreateOrderRequest.CreateOrder(amountCents);
            var orderResponse = await _broker.CreateOrderAsync(orderRequest);

            // Request card payment key.
            var billingData = new CashInBillingData(
                firstName: "Ahmed",
                lastName: "Kamal",
                phoneNumber: "01128829358",
                email: "ahmedKamal4122@gmail.com");

            var paymentKeyRequest = new CashInPaymentKeyRequest(
                integrationId: 1,
                orderId: orderResponse.Id,
                billingData: billingData,
                amountCents: amountCents);

            var paymentKeyResponse = await _broker.RequestPaymentKeyAsync(paymentKeyRequest);

            // Create iframe src.
            return _broker.CreateIframeSrc(iframeId: "1234", token: paymentKeyResponse.PaymentKey);
        }
    }
}
