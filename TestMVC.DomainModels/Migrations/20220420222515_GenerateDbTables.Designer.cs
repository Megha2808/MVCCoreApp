// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestMVC.DomainModels.DatabaseContext;

#nullable disable

namespace TestMVC.DomainModels.Migrations
{
    [DbContext(typeof(ApplicationDatabaseContext))]
    [Migration("20220420222515_GenerateDbTables")]
    partial class GenerateDbTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TestMVC.DomainModels.Models.Agreement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("CreatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<float>("NewPrice")
                        .HasColumnType("real");

                    b.Property<int>("ProductGroupId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<Guid?>("UpdatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductGroupId");

                    b.HasIndex("ProductId");

                    b.ToTable("Agreements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5"),
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8684),
                            EffectiveDate = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8688),
                            ExpirationDate = new DateTime(2022, 9, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8689),
                            IsActive = true,
                            NewPrice = 28000f,
                            ProductGroupId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 2,
                            CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5"),
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8732),
                            EffectiveDate = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8733),
                            ExpirationDate = new DateTime(2022, 4, 25, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8735),
                            IsActive = true,
                            NewPrice = 15000f,
                            ProductGroupId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5"),
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8745),
                            EffectiveDate = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8747),
                            ExpirationDate = new DateTime(2023, 1, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8746),
                            IsActive = true,
                            NewPrice = 8000f,
                            ProductGroupId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5"),
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8749),
                            EffectiveDate = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8750),
                            ExpirationDate = new DateTime(2022, 9, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8750),
                            IsActive = true,
                            NewPrice = 28000f,
                            ProductGroupId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 5,
                            CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5"),
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8753),
                            EffectiveDate = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8753),
                            ExpirationDate = new DateTime(2022, 4, 25, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8754),
                            IsActive = true,
                            NewPrice = 15000f,
                            ProductGroupId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 6,
                            CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5"),
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8756),
                            EffectiveDate = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8758),
                            ExpirationDate = new DateTime(2023, 1, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8757),
                            IsActive = true,
                            NewPrice = 8000f,
                            ProductGroupId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedByUserId = new Guid("b74ddd14-6340-4840-95c2-db12554843e5"),
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8760),
                            EffectiveDate = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8761),
                            ExpirationDate = new DateTime(2022, 9, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8761),
                            IsActive = true,
                            NewPrice = 28000f,
                            ProductGroupId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 8,
                            CreatedByUserId = new Guid("9478d730-a5fc-4569-b260-349eb0984619"),
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8764),
                            EffectiveDate = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8765),
                            ExpirationDate = new DateTime(2022, 4, 25, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8765),
                            IsActive = true,
                            NewPrice = 15000f,
                            ProductGroupId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 9,
                            CreatedByUserId = new Guid("9478d730-a5fc-4569-b260-349eb0984619"),
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8768),
                            EffectiveDate = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8769),
                            ExpirationDate = new DateTime(2023, 1, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8768),
                            IsActive = true,
                            NewPrice = 8000f,
                            ProductGroupId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 10,
                            CreatedByUserId = new Guid("9478d730-a5fc-4569-b260-349eb0984619"),
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8771),
                            EffectiveDate = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8772),
                            ExpirationDate = new DateTime(2022, 9, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8772),
                            IsActive = true,
                            NewPrice = 28000f,
                            ProductGroupId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 11,
                            CreatedByUserId = new Guid("9478d730-a5fc-4569-b260-349eb0984619"),
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8775),
                            EffectiveDate = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8776),
                            ExpirationDate = new DateTime(2022, 4, 25, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8776),
                            IsActive = true,
                            NewPrice = 15000f,
                            ProductGroupId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 12,
                            CreatedByUserId = new Guid("9478d730-a5fc-4569-b260-349eb0984619"),
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8778),
                            EffectiveDate = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8780),
                            ExpirationDate = new DateTime(2023, 1, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8779),
                            IsActive = true,
                            NewPrice = 8000f,
                            ProductGroupId = 1,
                            ProductId = 1
                        });
                });

            modelBuilder.Entity("TestMVC.DomainModels.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6bce7c6d-17d5-4eae-b1ce-ca90ac79f67d",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "admin@gmail.com",
                            NormalizedUserName = "admin@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEHidxjWgndLLBP8JnPZMyK0VRh9tCzDDuVr+7NJ15l2l/kc0yTgHwAqSCr0jrOfhKg==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6bcc44d2-f325-44af-be76-cc51649d26d1",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "9478d730-a5fc-4569-b260-349eb0984619",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "99b088a5-d4d5-4d0c-87e5-6d99685e2992",
                            Email = "user1@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedUserName = "user1@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEMJ8wJX4bOvZBazyk9QYBDc768zQSqMASY8a3vVcQir3Hv2XDVyMOOnf16gYNnq9YA==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e05d97c9-0cde-43f4-9b17-951a7fd73ea9",
                            TwoFactorEnabled = false,
                            UserName = "User1"
                        });
                });

            modelBuilder.Entity("TestMVC.DomainModels.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductGroupId")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UpdatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductGroupId");

                    b.HasIndex("ProductNumber");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8152),
                            IsActive = true,
                            Price = 10000f,
                            ProductDescription = "Product1 Description",
                            ProductGroupId = 1,
                            ProductNumber = new Guid("cd50db33-2b0e-4b2e-ae66-02e070ade798")
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8157),
                            IsActive = true,
                            Price = 20000f,
                            ProductDescription = "Product2 Description",
                            ProductGroupId = 1,
                            ProductNumber = new Guid("dc3abad1-886c-4032-b23f-becd7463486a")
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8160),
                            IsActive = true,
                            Price = 30000f,
                            ProductDescription = "Product3 Description",
                            ProductGroupId = 1,
                            ProductNumber = new Guid("102bd093-64dd-4a75-b595-d43fe8f2bab2")
                        },
                        new
                        {
                            Id = 4,
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8163),
                            IsActive = true,
                            Price = 40000f,
                            ProductDescription = "Product3 Description",
                            ProductGroupId = 2,
                            ProductNumber = new Guid("e1dcd8ef-b484-44f7-bcba-c387a1d9d888")
                        });
                });

            modelBuilder.Entity("TestMVC.DomainModels.Models.ProductGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GroupCode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GroupDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("UpdatedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GroupCode");

                    b.ToTable("ProductGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(5400),
                            GroupCode = new Guid("21e11d9d-3d0c-4407-bad4-6d059184c023"),
                            GroupDescription = "Group1 Description",
                            IsActive = true
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(5422),
                            GroupCode = new Guid("8e3a38e6-14ad-46d7-b98f-c695a240ff22"),
                            GroupDescription = "Group2 Description",
                            IsActive = true
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTime = new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(5425),
                            GroupCode = new Guid("67bd96f2-93a4-47be-bc82-c432f35ad969"),
                            GroupDescription = "Group3 Description",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TestMVC.DomainModels.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TestMVC.DomainModels.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestMVC.DomainModels.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TestMVC.DomainModels.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestMVC.DomainModels.Models.Agreement", b =>
                {
                    b.HasOne("TestMVC.DomainModels.Models.ProductGroup", "ProductGroup")
                        .WithMany("Agreements")
                        .HasForeignKey("ProductGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestMVC.DomainModels.Models.Product", "Product")
                        .WithMany("Agreements")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductGroup");
                });

            modelBuilder.Entity("TestMVC.DomainModels.Models.Product", b =>
                {
                    b.HasOne("TestMVC.DomainModels.Models.ProductGroup", "ProductGroup")
                        .WithMany("Products")
                        .HasForeignKey("ProductGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductGroup");
                });

            modelBuilder.Entity("TestMVC.DomainModels.Models.Product", b =>
                {
                    b.Navigation("Agreements");
                });

            modelBuilder.Entity("TestMVC.DomainModels.Models.ProductGroup", b =>
                {
                    b.Navigation("Agreements");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
