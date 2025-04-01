
namespace BethanysPieShop.Models
{
    public class ShopingCart : IShopingCart
    {

        public List<ShoppingCartItem> ShoppingCartItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddToCart(Pie pie)
        {
            throw new NotImplementedException();
        }

        public void ClearCart()
        {
            throw new NotImplementedException();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            throw new NotImplementedException();
        }

        public decimal GetShoppingCartTotal()
        {
            throw new NotImplementedException();
        }

        public int RemoveFromCart(Pie pie)
        {
            throw new NotImplementedException();
        }
    }
}
