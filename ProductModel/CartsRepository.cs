using ProductModel.Models;
using System.Collections.Generic;

namespace ProductModel
{
    public class CartsRepository:ICarts
    {
        List<Cart> carts = new List<Cart>()
        {
            new Cart(Constants.MD)
        };

        public Cart GetCart(User user)
        {
            return carts[0];
        }
    }
}
