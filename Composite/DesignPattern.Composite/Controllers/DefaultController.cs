using DesignPattern.Composite.Composite;
using DesignPattern.Composite.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly AppDbContext _context;
        public DefaultController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.Include(x => x.Products).ToList();
            var values = Rekursive(categories, new Category { Name = "FirstCategory", Id = 0 }, new ProductComposite(0, "FirstComposite"));
            ViewBag.v = values;
            return View();
        }
        public ProductComposite Rekursive(List<Category> categories, Category firstCategory, ProductComposite firstComposite, ProductComposite leaf = null)
        {
            categories.Where(x => x.UpperCategoryId == firstCategory.Id).ToList().ForEach(y =>
            {
                var productComposite = new ProductComposite(y.Id, y.Name);

                y.Products.ToList().ForEach(z =>
                {
                    productComposite.Add(new ProductComponent(z.Id, z.Name));

                });

                if (leaf != null)
                {
                    leaf.Add(productComposite);
                }
                else
                {
                    firstComposite.Add(productComposite);
                }

                Rekursive(categories, y, firstComposite, productComposite);
            });

            return firstComposite;
        }
    }
}
