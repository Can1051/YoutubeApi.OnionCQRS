using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var fixedDate = new DateTime(2024, 1, 1); // Sabit tarih

            Category category1 = new()
            {
                Id = 1,
                Name = "Elektrik",
                Priority = 1,
                ParentId = 0,
                CreatedDate = fixedDate,
                IsDeleted = false
            };

            Category category2 = new()
            {
                Id = 2,
                Name = "Moda",
                Priority = 2,
                ParentId = 0,
                CreatedDate = fixedDate,
                IsDeleted = false
            };

            Category parent1 = new()
            {
                Id = 3,
                Name = "Bilgisayar",
                Priority = 1,
                ParentId = 1,
                CreatedDate = fixedDate,
                IsDeleted = false
            };

            Category parent2 = new()
            {
                Id = 4,
                Name = "Kadın",
                Priority = 1,
                ParentId = 2,
                CreatedDate = fixedDate,
                IsDeleted = false
            };

            builder.HasData(category1, category2, parent1, parent2);
        }
    }

}
