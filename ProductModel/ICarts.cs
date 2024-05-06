using ProductModel.Models;

namespace ProductModel
{
    public interface ICarts
    {
        public Cart GetCart(User user);
    }
}
