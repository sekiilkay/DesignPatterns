using DesignPattern.Facade.DAL;
using DesignPattern.Facade.Facade;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class ProductController : Controller
    {
        AppDbContext context = new AppDbContext();

        [HttpGet]
        public IActionResult AddNewProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public IActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }
    }
}
