using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configurations
{

    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            var fixedDate = new DateTime(2024, 1, 1); // Sabit tarih

            Detail detail1 = new()
            {
                Id = 1,
                Title = "Başlık 1",
                Description = "Açıklama metni bir.",
                CategoryId = 1,
                CreatedDate = fixedDate,
                IsDeleted = false,
            };

            Detail detail2 = new()
            {
                Id = 2,
                Title = "Başlık 2",
                Description = "İkinci açıklama metni burada.",
                CategoryId = 3,
                CreatedDate = fixedDate,
                IsDeleted = true,
            };

            Detail detail3 = new()
            {
                Id = 3,
                Title = "Başlık 3",
                Description = "Üçüncü açıklama biraz daha uzun bir şey.",
                CategoryId = 4,
                CreatedDate = fixedDate,
                IsDeleted = false,
            };

            builder.HasData(detail1, detail2, detail3);
        }
    }

}
