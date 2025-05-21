using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var fixedDate = new DateTime(2024, 1, 1);

            Product product1 = new()
            {
                Id = 1,
                Title = "Rustic Concrete Shirt",
                Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                BrandId = 1,
                Price = 196.52m,
                Discount = 2.55m,
                CreatedDate = fixedDate,
                IsDeleted = false
            };

            Product product2 = new()
            {
                Id = 2,
                Title = "Incredible Frozen Tuna",
                Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                BrandId = 3,
                Price = 247.22m,
                Discount = 0.94m,
                CreatedDate = fixedDate,
                IsDeleted = false
            };

            builder.HasData(product1, product2);
        }
    }


}
