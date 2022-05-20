using ASP_MVC_Exo_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Exo_01.Controllers
{
    public class ProductController : Controller
    {

        #region Static Data
        private IEnumerable<Product> _Products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Pomme",
                Description = "Un kilo de pomme rouge",
                Price = 2.50,
                Reference = "PoRouge01"
            },
            new Product()
            {
                Id = 2,
                Name = "Banane",
                Description = "Un kilo de banane",
                Price = 5,
                Reference = "Banana42",
                Discount= 15
            },
            new Product()
            {
                Id = 3,
                Name = "Kiwi",
                Description = "Kiwi a la piece",
                Price = 0.99,
                Reference = "ZeKiwi"
            },
            new Product()
            {
                Id = 4,
                Name = "Tomate",
                Description = "Un kilo de tomate",
                Price = 3.95,
                Reference = "TomateLuxe",
                Discount = 40
            }
        };
        #endregion

        public IActionResult Index()
        {
            IEnumerable<Product> products = _Products.OrderBy(p => p.Name);

            return View(products);
        }

        [Route("/Product/Detail/{id}")]
        public IActionResult Detail(int id)  
        { 
            Product jacky = _Products.SingleOrDefault(p => p.Id == id);

            if(jacky is null)
            {
                return NotFound();
            }

            return View(jacky);
        }
    }
}
