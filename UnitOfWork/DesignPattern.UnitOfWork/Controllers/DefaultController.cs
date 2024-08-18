using DesignPattern.Core.Entities;
using DesignPattern.Core.Services;
using DesignPattern.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;
        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(CustomerViewModel model)
        {
            var value1 = await _customerService.GetByIdAsync(model.SenderId);
            var value2 = await _customerService.GetByIdAsync(model.Receiver);
            
            value1.CustomerBalance -= model.Amount;
            value2.CustomerBalance += model.Amount;
            
            List<Customer> modifiedCustomers = new List<Customer>()
            {
                value1,value2
            };

            await _customerService.MultiUpdateAsync(modifiedCustomers);

            return View();
        }
    }
}
