using Microsoft.AspNetCore.Mvc;
using ProductModel.Models;

namespace ProductModel.Controllers
{
    public class CartController : Controller
    {
        readonly IGetProducts__ products;
        ICarts carts;

        public CartController(IGetProducts__ products, ICarts carts)
        {
            this.products = products;
            this.carts = carts;
        }

        public IActionResult Index(int idProduct)
        {
            Cart cart = carts.GetCart(Constants.MD);
            return View(cart);
        }

        public IActionResult Add(int idProduct)
        {
            Cart cart = carts.GetCart(Constants.MD);
            Product item = products.TryGetById(idProduct);
            cart.Add(item);
            return RedirectToAction("Index");
        }

        public IActionResult DecreaseProduct(int idProduct)
        {
            Cart cart = carts.GetCart(Constants.MD);
            cart.DecreaseProduct(idProduct);
            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {
            Cart cart = carts.GetCart(Constants.MD);
            cart.Clear();
            return RedirectToAction("Index");
        }
    }
}
