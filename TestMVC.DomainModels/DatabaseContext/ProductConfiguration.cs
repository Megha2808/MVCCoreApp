using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestMVC.DomainModels.Models;

namespace TestMVC.DomainModels.DatabaseContext
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasIndex(x => x.ProductNumber);
            builder.HasData
            (
                new Product
                {
                    Id = 1,
                    ProductGroupId = 1,
                    ProductNumber = Guid.NewGuid(),
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    Price = 10000,
                    ProductDescription = "Product1 Description"
                },
                new Product
                {
                    Id = 2,
                    ProductGroupId = 1,
                    ProductNumber = Guid.NewGuid(),
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    Price = 20000,
                    ProductDescription = "Product2 Description"
                },
                new Product
                {
                    Id = 3,
                    ProductGroupId = 1,
                    ProductNumber = Guid.NewGuid(),
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    Price = 30000,
                    ProductDescription = "Product3 Description"
                },
                new Product
                {
                    Id = 4,
                    ProductGroupId = 2,
                    ProductNumber = Guid.NewGuid(),
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    Price = 40000,
                    ProductDescription = "Product3 Description"
                }

            );
        }

    }

}
