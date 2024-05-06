using Microsoft.AspNetCore.Mvc;
using ProductModel.Models;
using OnLineShop.DB.Models;
using OnLineShop.DB;

namespace ProductModel.Controllers
{
    public class AdminController : Controller
    {
        public readonly IGetProducts listProducts;
        public readonly DatabaseContext dbContext;

        public AdminController(IGetProducts list_Products, DatabaseContext dbContext)
        {
            this.listProducts = list_Products;
            this.dbContext = dbContext;
        }

        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Roles()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View(listProducts);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            // если не прошел валидацию возвращаем на ту же вьюшку для редактирования
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            // тут сохранить продукт в product DB
            var productDB = new ProductDB
            {
               // Id = 100,
                Name = product.Name,
                Description = product.Description,
                Cost = product.Cost,
                URLImage = "gbdfsd"
            };
            dbContext.ProductDBs.Add(productDB);
            dbContext.SaveChanges();
            return View("Home/Index");
        }
    }

}
