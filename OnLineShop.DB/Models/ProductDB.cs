using System;

namespace OnLineShop.DB.Models
{
    public class ProductDB
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string URLImage { get; set; }

        public ProductDB() { }
    }
}
