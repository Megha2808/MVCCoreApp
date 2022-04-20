using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestMVC.DomainModels.Models;

namespace TestMVC.DomainModels.DatabaseContext
{
    public class ProductGroupConfiguration : IEntityTypeConfiguration<ProductGroup>
    {
        public void Configure(EntityTypeBuilder<ProductGroup> builder)
        {
            builder.HasIndex(x => x.GroupCode);
            builder.HasData
            (
                new ProductGroup
                {
                    Id = 1,
                    GroupCode = Guid.NewGuid(),
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    GroupDescription = "Group1 Description"
                },
                new ProductGroup
                {
                    Id = 2,
                    GroupCode = Guid.NewGuid(),
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    GroupDescription = "Group2 Description"
                },
                new ProductGroup
                {
                    Id = 3,
                    GroupCode = Guid.NewGuid(),
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    GroupDescription = "Group3 Description"
                }
            );
        }

    }
}
