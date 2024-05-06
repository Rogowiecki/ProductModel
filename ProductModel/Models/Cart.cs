using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductModel.Models
{

    public class Cart
    {
        Guid Id { get; }
        User User { get; }
        public List<CartItem> Products { get; set; }
        public decimal TotalCost { get; set; }

        public Cart(User user)
        {
            User = user;
            Products = new List<CartItem>();
        }
        public void Add(Product item)
        {
            CartItem elem = this.TryGetByIdProduct(item.Id);
            if (elem == null)
            {
                CartItem cartitem = new CartItem(item, 1);
                Products.Add(cartitem);
            }
            else
            {
                elem.Quantity += 1;
                elem.Amount = elem.Quantity * elem.Product.Cost;
            }
            TotalCost = Products.Sum(k => k.Amount);
        }

        public void DecreaseProduct(int idProduct)
        {
            CartItem elem = this.TryGetByIdProduct(idProduct);
            if (elem == null) return;
            elem.Quantity -= 1;
            elem.Amount = elem.Quantity * elem.Product.Cost;
            if (elem.Quantity == 0)
            {
                Products.Remove(elem);
            }
            TotalCost = Products.Sum(k => k.Amount);
        }

        public void Clear()
        {
            this.Products.Clear();
            this.TotalCost = 0;
        }

        public CartItem TryGetByIdProduct(int idProduct)
        {
            foreach (var elem in Products)
            {
                if (elem.Product.Id == idProduct)
                    return elem;
            }
            return null;
        }
    }
}
