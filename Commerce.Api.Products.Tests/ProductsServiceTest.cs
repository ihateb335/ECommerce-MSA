using ECommerce.Api.Products.Db;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Api.Products.Tests
{
    public class ProductsServiceTest
    {
        [Fact]
        public void GetProductsReturnsAllProducts()
        {
            var options = new DbContextOptionsBuilder<ProductsDbContext>()
            .UseInMemoryDatabase(nameof(GetProductsReturnsAllProducts))
            .Options;

            var dbContext = new ProductsDbContext(options);

            void CreateProducts(ProductsDbContext dbContext)
            {
                for (int i = 1; i <= 10; i++)
                {
                    dbContext.Products.Add(new Product()
                    {
                        Id = i,
                        Name = Guid.NewGuid().ToString(),
                        Inventory = i + 10,
                        Price = (decimal)(i * 3.14)
                    });
                }
                dbContext.SaveChanges();
            }

            CreateProducts(dbContext);
        }
    }
}