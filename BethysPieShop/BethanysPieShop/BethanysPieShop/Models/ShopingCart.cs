
using BethanysPieShop.Migrations;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class ShopingCart : IShoppingCart
    {
        private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;   
        public string? ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShopingCart(BethanysPieShopDbContext bethanysPieShopDbContext)
        {
            _bethanysPieShopDbContext = bethanysPieShopDbContext;
        }
       
        public static ShopingCart GetCart(IServiceProvider services) // This method wasn't there in the Interface because its a statis method
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            if (session == null)
            {
                throw new Exception("Session is not available");
            }
            BethanysPieShopDbContext context = services.GetService<BethanysPieShopDbContext>()?? throw new Exception("Error initializing");
            string cartId = session?.GetString("ShoppingCartId") ?? Guid.NewGuid().ToString();
            session?.SetString("ShoppingCartId", cartId);
            return new ShopingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Pie pie)
        {
            
            var shoppingCartItem = 
                _bethanysPieShopDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.Pie.PieId == pie.PieId && s.ShoppingCartId == ShoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Pie = pie,
                    Amount = 1
                };
                _bethanysPieShopDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }else
            {
                shoppingCartItem.Amount++;
            }
            _bethanysPieShopDbContext.SaveChanges();
        }

        public void ClearCart()
        {
            var CartItems = _bethanysPieShopDbContext
                .ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId);
            _bethanysPieShopDbContext.ShoppingCartItems.RemoveRange(CartItems);
            _bethanysPieShopDbContext.SaveChanges();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   _bethanysPieShopDbContext.ShoppingCartItems.Where(c => 
                   c.ShoppingCartId == ShoppingCartId)
                   .Include(s => s.Pie)
                   .ToList();
        }

        public decimal GetShoppingCartTotal()
        {
           var total = _bethanysPieShopDbContext.ShoppingCartItems.Where(c =>
               c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Pie.Price * c.Amount).Sum();
            return total;
        }

        public int RemoveFromCart(Pie pie)
        {
            var shoppingCartItem =
                _bethanysPieShopDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.Pie.PieId == pie.PieId && s.ShoppingCartId == ShoppingCartId);
            var localAmount = 0;
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _bethanysPieShopDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _bethanysPieShopDbContext.SaveChanges();
            return localAmount;
        }
    }
}
