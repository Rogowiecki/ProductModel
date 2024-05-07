using Microsoft.AspNetCore.Mvc;
using OnLineShop.DB;
using ProductModel.Helpers;

namespace ProductModel.Controllers
{
    public class ProductController : Controller
    {
        public readonly IGetProducts listProductDBs;

        public ProductController(IGetProducts list_ProductDBs)
        { 
            this.listProductDBs = list_ProductDBs;
        }

        public IActionResult Index()
        {
           return View(Mapping.ListProductDBToListProduct(listProductDBs.GetProducts()));
           //return View();
        }

        public IActionResult Details(int id)
        {
            //return View(listProducts.TryGetById(id));
            return View();
        }
    }
}
