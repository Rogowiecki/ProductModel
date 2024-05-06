using System;

namespace ProductModel.Models
{
    public class CartItem
    {
        public Guid Id { get; }
        public Product Product { get; }
        public int Quantity { get; set; }    
        public decimal Amount { get; set;  }

        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
            Amount = Quantity * Product.Cost;
            Id = Guid.NewGuid();
        }
    }
}
