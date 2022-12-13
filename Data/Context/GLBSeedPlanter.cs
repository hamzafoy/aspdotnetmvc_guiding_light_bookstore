using SampleNetCoreMVC.Data.Entities;
using System.Text.Json;

namespace SampleNetCoreMVC.Data.Context
{
    public static class GLBSeedPlanter
    {
        private static readonly IWebHostEnvironment _env;

        public static void Seed(GLBContext context)
        {
            context.Database.EnsureCreated();
            if(!context.Products.Any())
            {
                //Will create seed/sample data as needed
                var filePath = "Data/libraryBooks.json";
                var jsonData = File.ReadAllText(filePath);
                var products = JsonSerializer.Deserialize<IEnumerable<Product>>(jsonData);

                context.Products.AddRange(products);

                var order = new Checkout()
                {
                    CheckoutDate = DateTime.Today,
                    CheckoutList = new List<CheckoutItem>()
                    {
                        new CheckoutItem()
                        {
                            Product = products.First(),
                            Quantity = 1
                        },
                        new CheckoutItem()
                        {
                            Product = products.Last(),
                            Quantity = 2
                        }
                    }
                };

                context.Checkouts.Add(order);

                context.SaveChanges();
            }
        }
    }
}
