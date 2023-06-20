using frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace frontend.Controllers
{
    public class CustomersController : Controller
    {
        private readonly MyAppDbContext context;
        public CustomersController(MyAppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var customers = this.context.Customers.ToList();
            return View(customers);
        }

    }
}
