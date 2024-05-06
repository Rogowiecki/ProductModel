using Microsoft.AspNetCore.Mvc;
using OnLineShop.DB;

namespace ProductModel.Controllers
{
    public class ProductController : Controller
    {
        public readonly IGetProducts listProducts;

        public ProductController(IGetProducts list_Products)
        { 
            this.listProducts = list_Products;
        }

        public IActionResult Index()
        {
           // return View(listProducts);
           return View();
        }

        public IActionResult Details(int id)
        {
            return View(listProducts.TryGetById(id));
        }
    }
}
