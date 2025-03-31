namespace BethanysPieShop.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
          //  BethanysPieShopDbContext context =
             //   applicationBuilder.ApplicationServices.GetRequiredService<BethanysPieShopDbContext>();

            BethanysPieShopDbContext context = 
                applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BethanysPieShopDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Pies.Any())
            {
                context.AddRange
                    (
                    new Pie
                    {
                        Name = "Strawberry Pie",
                        Price = 15.95M,
                        ShortDescription = "Our famous strawberry pie!",
                        LongDescription = "Icing carrot cake jelly beans. Sweet roll candy canes fruitcake. Tiramisu candy canes",
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                        ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                        CategoryId = context.Categories.First(c => c.CategoryName == "Fruit Pies").CategoryId // Ensure valid CategoryId
                    },
                    new Pie
                    {
                        Name = "Cheese Cake",
                        Price = 18.95M,
                        ShortDescription = "Plain cheese cake. Plain pleasure.",
                        LongDescription = "Icing carrot cake jelly beans. Sweet roll candy canes fruitcake. Tiramisu candy canes",
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                        ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                        CategoryId = context.Categories.First(c => c.CategoryName == "Cheese Cakes").CategoryId // Ensure valid CategoryId
                    }
                    );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category>? categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var categoriesList = new Category[]
                    {
                            new Category { CategoryName = "Fruit Pies", CategoryDescription = "All-fruity pies" },
                            new Category { CategoryName = "Cheese Cakes", CategoryDescription = "Cheesy all the way" },
                            new Category { CategoryName = "Seasonal Pies", CategoryDescription = "Get in the mood for a seasonal pie" }
                    };
                    categories = new Dictionary<string, Category>();
                    foreach (Category category in categoriesList)
                    {
                        categories.Add(category.CategoryName, category);
                    }
                }
                return categories;
            }
        }
    }
}
