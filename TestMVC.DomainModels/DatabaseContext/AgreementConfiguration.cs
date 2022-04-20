using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestMVC.DomainModels.Models;

namespace TestMVC.DomainModels.DatabaseContext
{
    public class AgreementConfiguration : IEntityTypeConfiguration<Agreement>
    {
        public void Configure(EntityTypeBuilder<Agreement> builder)
        {
            builder.HasData
            (
                new Agreement
                {
                    Id = 1,
                    ProductGroupId = 1,
                    ProductId = 3,
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    NewPrice = 28000,
                    EffectiveDate = DateTime.UtcNow,
                    ExpirationDate = DateTime.UtcNow.AddMonths(5)
                    ,CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5")
                },
                new Agreement
                {
                    Id = 2,
                    ProductGroupId = 1,
                    ProductId = 2,
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,                    
                    NewPrice = 15000,
                    EffectiveDate = DateTime.UtcNow,
                    ExpirationDate = DateTime.UtcNow.AddDays(5)
                     ,
                    CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5")
                },
                new Agreement
                {
                    Id = 3,
                    ProductGroupId = 1,
                    ProductId = 1,
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    NewPrice = 8000,
                    ExpirationDate = DateTime.UtcNow.AddMonths(9),
                    EffectiveDate = DateTime.UtcNow
                    ,CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5")
                },
                 new Agreement
                 {
                     Id = 4,
                     ProductGroupId = 1,
                     ProductId = 3,
                     CreatedDateTime = DateTime.UtcNow,
                     IsActive = true,
                     NewPrice = 28000,
                     EffectiveDate = DateTime.UtcNow,
                     ExpirationDate = DateTime.UtcNow.AddMonths(5),
                     CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5")
                 },
                new Agreement
                {
                    Id = 5,
                    ProductGroupId = 1,
                    ProductId = 2,
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    NewPrice = 15000,
                    EffectiveDate = DateTime.UtcNow,
                    ExpirationDate = DateTime.UtcNow.AddDays(5),
                    CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5")
                },
                new Agreement
                {
                    Id = 6,
                    ProductGroupId = 1,
                    ProductId = 1,
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    NewPrice = 8000,
                    ExpirationDate = DateTime.UtcNow.AddMonths(9),
                    EffectiveDate = DateTime.UtcNow,
                    CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5")
                },
                 new Agreement
                 {
                     Id = 7,
                     ProductGroupId = 1,
                     ProductId = 3,
                     CreatedDateTime = DateTime.UtcNow,
                     IsActive = true,
                     NewPrice = 28000,
                     EffectiveDate = DateTime.UtcNow,
                     ExpirationDate = DateTime.UtcNow.AddMonths(5),
                     CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5")
                 },
                new Agreement
                {
                    Id = 8,
                    ProductGroupId = 1,
                    ProductId = 2,
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    NewPrice = 15000,
                    EffectiveDate = DateTime.UtcNow,
                    ExpirationDate = DateTime.UtcNow.AddDays(5),
                    CreatedByUserId = new Guid("9478d730-a5fc-4569-b260-349eb0984619")
                },
                new Agreement
                {
                    Id = 9,
                    ProductGroupId = 1,
                    ProductId = 1,
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    NewPrice = 8000,
                    ExpirationDate = DateTime.UtcNow.AddMonths(9),
                    EffectiveDate = DateTime.UtcNow,
                    CreatedByUserId = new Guid("9478d730-a5fc-4569-b260-349eb0984619")
                },
                 new Agreement
                 {
                     Id = 10,
                     ProductGroupId = 1,
                     ProductId = 3,
                     CreatedDateTime = DateTime.UtcNow,
                     IsActive = true,
                     NewPrice = 28000,
                     EffectiveDate = DateTime.UtcNow,
                     ExpirationDate = DateTime.UtcNow.AddMonths(5),
                     CreatedByUserId = new Guid("9478d730-a5fc-4569-b260-349eb0984619")
                 },
                new Agreement
                {
                    Id = 11,
                    ProductGroupId = 1,
                    ProductId = 2,
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    NewPrice = 15000,
                    EffectiveDate = DateTime.UtcNow,
                    ExpirationDate = DateTime.UtcNow.AddDays(5),
                    CreatedByUserId = new Guid("9478d730-a5fc-4569-b260-349eb0984619")
                },
                new Agreement
                {
                    Id = 12,
                    ProductGroupId = 1,
                    ProductId = 1,
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true,
                    NewPrice = 8000,
                    ExpirationDate = DateTime.UtcNow.AddMonths(9),
                    EffectiveDate = DateTime.UtcNow,
                    CreatedByUserId = new Guid("9478d730-a5fc-4569-b260-349eb0984619")
                }
            );
        }

    }
}
