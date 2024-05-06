using ProductModel.Models;
using System.Collections.Generic;

namespace ProductModel
{
    public interface IGetProducts__
    {
        public List<Product> GetProducts();
        public Product TryGetById(int IdProduct);
    }
}
