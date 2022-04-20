using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestMVC.DomainModels.Models;

namespace TestMVC.DomainModels.DatabaseContext
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var users = new List<AppUser>();
            var adminUser = new AppUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Admin",
                Email = "admin@gmail.com",
                LockoutEnabled = true,
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                NormalizedUserName = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com"
            };

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            var hasedPassword = passwordHasher.HashPassword(adminUser, "Admin*123");
            adminUser.PasswordHash = hasedPassword;
            users.Add(adminUser);

            var user = new AppUser()
            {
                Id = "9478d730-a5fc-4569-b260-349eb0984619",
                UserName = "User1",
                Email = "user1@gmail.com",
                LockoutEnabled = true,
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                NormalizedUserName = "user1@gmail.com"
            };
            var hasedPassword1 = passwordHasher.HashPassword(user, "123");
            user.PasswordHash = hasedPassword1;
            users.Add(user);


            builder.HasData(users);
        }

    }
}
