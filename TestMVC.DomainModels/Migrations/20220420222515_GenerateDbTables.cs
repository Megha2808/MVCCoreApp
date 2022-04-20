using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestMVC.DomainModels.Migrations
{
    public partial class GenerateDbTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ProductGroupId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductGroups_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agreements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductGroupId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NewPrice = table.Column<float>(type: "real", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agreements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agreements_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agreements_ProductGroups_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9478d730-a5fc-4569-b260-349eb0984619", 0, "99b088a5-d4d5-4d0c-87e5-6d99685e2992", "user1@gmail.com", true, true, null, null, "user1@gmail.com", "AQAAAAEAACcQAAAAEMJ8wJX4bOvZBazyk9QYBDc768zQSqMASY8a3vVcQir3Hv2XDVyMOOnf16gYNnq9YA==", "1234567890", false, "e05d97c9-0cde-43f4-9b17-951a7fd73ea9", false, "User1" },
                    { "b74ddd14-6340-4840-95c2-db12554843e5", 0, "6bce7c6d-17d5-4eae-b1ce-ca90ac79f67d", "admin@gmail.com", true, true, null, "admin@gmail.com", "admin@gmail.com", "AQAAAAEAACcQAAAAEHidxjWgndLLBP8JnPZMyK0VRh9tCzDDuVr+7NJ15l2l/kc0yTgHwAqSCr0jrOfhKg==", "1234567890", false, "6bcc44d2-f325-44af-be76-cc51649d26d1", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreatedDateTime", "GroupCode", "GroupDescription", "IsActive", "UpdatedByUserId", "UpdatedDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(5400), new Guid("21e11d9d-3d0c-4407-bad4-6d059184c023"), "Group1 Description", true, null, null },
                    { 2, new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(5422), new Guid("8e3a38e6-14ad-46d7-b98f-c695a240ff22"), "Group2 Description", true, null, null },
                    { 3, new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(5425), new Guid("67bd96f2-93a4-47be-bc82-c432f35ad969"), "Group3 Description", true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedDateTime", "IsActive", "Price", "ProductDescription", "ProductGroupId", "ProductNumber", "UpdatedByUserId", "UpdatedDateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8152), true, 10000f, "Product1 Description", 1, new Guid("cd50db33-2b0e-4b2e-ae66-02e070ade798"), null, null },
                    { 2, new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8157), true, 20000f, "Product2 Description", 1, new Guid("dc3abad1-886c-4032-b23f-becd7463486a"), null, null },
                    { 3, new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8160), true, 30000f, "Product3 Description", 1, new Guid("102bd093-64dd-4a75-b595-d43fe8f2bab2"), null, null },
                    { 4, new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8163), true, 40000f, "Product3 Description", 2, new Guid("e1dcd8ef-b484-44f7-bcba-c387a1d9d888"), null, null }
                });

            migrationBuilder.InsertData(
                table: "Agreements",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDateTime", "EffectiveDate", "ExpirationDate", "IsActive", "NewPrice", "ProductGroupId", "ProductId", "UpdatedByUserId", "UpdatedDateTime" },
                values: new object[,]
                {
                    { 1, new Guid("b74ddd14-6340-4840-95c2-db12554843e5"), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8684), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8688), new DateTime(2022, 9, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8689), true, 28000f, 1, 3, null, null },
                    { 2, new Guid("b74ddd14-6340-4840-95c2-db12554843e5"), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8732), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8733), new DateTime(2022, 4, 25, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8735), true, 15000f, 1, 2, null, null },
                    { 3, new Guid("b74ddd14-6340-4840-95c2-db12554843e5"), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8745), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8747), new DateTime(2023, 1, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8746), true, 8000f, 1, 1, null, null },
                    { 4, new Guid("b74ddd14-6340-4840-95c2-db12554843e5"), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8749), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8750), new DateTime(2022, 9, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8750), true, 28000f, 1, 3, null, null },
                    { 5, new Guid("b74ddd14-6340-4840-95c2-db12554843e5"), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8753), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8753), new DateTime(2022, 4, 25, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8754), true, 15000f, 1, 2, null, null },
                    { 6, new Guid("b74ddd14-6340-4840-95c2-db12554843e5"), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8756), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8758), new DateTime(2023, 1, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8757), true, 8000f, 1, 1, null, null },
                    { 7, new Guid("b74ddd14-6340-4840-95c2-db12554843e5"), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8760), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8761), new DateTime(2022, 9, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8761), true, 28000f, 1, 3, null, null },
                    { 8, new Guid("9478d730-a5fc-4569-b260-349eb0984619"), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8764), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8765), new DateTime(2022, 4, 25, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8765), true, 15000f, 1, 2, null, null },
                    { 9, new Guid("9478d730-a5fc-4569-b260-349eb0984619"), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8768), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8769), new DateTime(2023, 1, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8768), true, 8000f, 1, 1, null, null },
                    { 10, new Guid("9478d730-a5fc-4569-b260-349eb0984619"), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8771), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8772), new DateTime(2022, 9, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8772), true, 28000f, 1, 3, null, null },
                    { 11, new Guid("9478d730-a5fc-4569-b260-349eb0984619"), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8775), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8776), new DateTime(2022, 4, 25, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8776), true, 15000f, 1, 2, null, null },
                    { 12, new Guid("9478d730-a5fc-4569-b260-349eb0984619"), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8778), new DateTime(2022, 4, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8780), new DateTime(2023, 1, 20, 22, 25, 14, 899, DateTimeKind.Utc).AddTicks(8779), true, 8000f, 1, 1, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agreements_ProductGroupId",
                table: "Agreements",
                column: "ProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Agreements_ProductId",
                table: "Agreements",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductGroupId",
                table: "Product",
                column: "ProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductNumber",
                table: "Product",
                column: "ProductNumber");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_GroupCode",
                table: "ProductGroups",
                column: "GroupCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agreements");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ProductGroups");
        }
    }
}
