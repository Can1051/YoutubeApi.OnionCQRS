using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);

            Brand brand1 = new()
            {
                Id = 1,
                Name = "Elektronik",
                CreatedDate = new DateTime(2024, 01, 01),
                IsDeleted = false
            };

            Brand brand2 = new()
            {
                Id = 2,
                Name = "Giyim",
                CreatedDate = new DateTime(2024, 01, 01),
                IsDeleted = false
            };

            Brand brand3 = new()
            {
                Id = 3,
                Name = "Bahçe",
                CreatedDate = new DateTime(2024, 01, 01),
                IsDeleted = true
            };

            builder.HasData(brand1, brand2, brand3);
        }
    }

}
