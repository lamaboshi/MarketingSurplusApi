using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketingSurplus.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Charities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnlineImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    QRCode = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociationLicense = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAccept = table.Column<bool>(type: "bit", nullable: false),
                    Goals = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAccept = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percentage = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnlineImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewPrice = table.Column<float>(type: "real", nullable: false),
                    OldPrice = table.Column<float>(type: "real", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsExpiration = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RateNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnlineImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    QRCode = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayPal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAccept = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    OnlineImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAccept = table.Column<bool>(type: "bit", nullable: false),
                    CompanyTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_CompanyTypes_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalTable: "CompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharityId = table.Column<int>(type: "int", nullable: false),
                    OrderTypeId = table.Column<int>(type: "int", nullable: false),
                    PricePay = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donations_Charities_CharityId",
                        column: x => x.CharityId,
                        principalTable: "Charities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_OrderTypes_OrderTypeId",
                        column: x => x.OrderTypeId,
                        principalTable: "OrderTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: true),
                    IsDelivery = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayMethodId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyMethods_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyMethods_PayMethods_PayMethodId",
                        column: x => x.PayMethodId,
                        principalTable: "PayMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Favor = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyProducts_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_CompanyProducts_CompanyProductId",
                        column: x => x.CompanyProductId,
                        principalTable: "CompanyProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDonations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyProductId = table.Column<int>(type: "int", nullable: false),
                    DonationId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDonations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDonations_CompanyProducts_CompanyProductId",
                        column: x => x.CompanyProductId,
                        principalTable: "CompanyProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDonations_Donations_DonationId",
                        column: x => x.DonationId,
                        principalTable: "Donations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evalution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    RateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evalution", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evalution_Rates_RateId",
                        column: x => x.RateId,
                        principalTable: "Rates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evalution_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderProductId = table.Column<int>(type: "int", nullable: false),
                    OrderStatusId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_OrderProducts_OrderProductId",
                        column: x => x.OrderProductId,
                        principalTable: "OrderProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_OrderStatuses_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Charities",
                columns: new[] { "Id", "Address", "AssociationLicense", "Email", "Goals", "Image", "Name", "OnlineImage", "Password", "Phone", "QRCode", "TargetGroup", "isAccept" },
                values: new object[,]
                {
                    { 1, "Al Hamadanieh", "2435", "Al-Ihsan@test.com", "childern", null, "Al-Ihsan", "https://i.ibb.co/Z6GHm9w/banner.png", "Al-Ihsan789", "0215789147", null, "Rich Pepole", false },
                    { 2, "Al mohafaza", "2435", "Hand-By-Hand@test.com", "Old Pepole", null, "Hand By Hand", "https://i.ibb.co/CH67mMZ/9ba9d0086cff0ceb5155420e01fda24e.jpg", "Hand-By-Hand456", "0215117894", null, "Rich Pepole", false },
                    { 3, "Mohamad Fares Street", "2435", "Al-Noor@test.com", "childern", null, "Al-Noor", "https://i.ibb.co/7GY0Qvs/al-nour.jpg", "Al-Noor123", "021524895 ", null, "Rich Pepole", false },
                    { 4, "Al Azizeh", "2435", "George@test.com", "childern", null, "George", "https://i.ibb.co/HpFwRsc/259490784-888270292057739-1584770156068076983-n-300x378.png", "George147", "0215115827", null, "Rich Pepole", false },
                    { 5, "Al Marterni", "2435", "Namaa@test.com", "childern", null, "Namaa", "https://i.ibb.co/rwW5L3G/namma.jpg", "Namaa369", "02151174369", null, "Rich Pepole", false }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "Description", "TypeName", "isAccept" },
                values: new object[,]
                {
                    { 1, "All About Medicines", "Medicines", false },
                    { 2, "All About sports", "Sports", false },
                    { 3, "All About Clothes", "Clothes", false },
                    { 4, "All About Food", "Food", false },
                    { 5, "All About electronics", "Electronics", false },
                    { 6, "All About Perfumes", "Perfumes", false }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "DateTime", "Note", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 16, 11, 43, 8, 545, DateTimeKind.Local).AddTicks(9372), null, 1 },
                    { 2, new DateTime(2024, 7, 16, 11, 43, 8, 545, DateTimeKind.Local).AddTicks(9406), null, 2 },
                    { 3, new DateTime(2024, 7, 16, 11, 43, 8, 545, DateTimeKind.Local).AddTicks(9422), null, 3 },
                    { 4, new DateTime(2024, 7, 16, 11, 43, 8, 545, DateTimeKind.Local).AddTicks(9437), null, 4 }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name", "Percentage" },
                values: new object[,]
                {
                    { 1, "Normal", null },
                    { 2, "Donation", null },
                    { 3, "Charity Organization", null }
                });

            migrationBuilder.InsertData(
                table: "PayMethods",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cash Pay" },
                    { 2, "PayPal" },
                    { 3, "Credit Card" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateTime", "Descripation", "Expiration", "Image", "IsExpiration", "Name", "NewPrice", "OldPrice", "OnlineImage" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flamix is ​​a medicine that contains celecoxib as an active ingredient, and it is considered a non-steroidal anti-infl ammatory drug", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Newflamix", 13000f, 15000f, "https://i.ibb.co/xjS4yyL/Flamix2040020mg20film20tablete203-D.jpg" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moderate pain relief without the need for a prescription", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "New Profin", 6000f, 9000f, "https://i.ibb.co/yykJXSj/product-1.jpg" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clomiphene is used to treat some cases of infertility in women", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Newclomiphene", 13000f, 15000f, "https://i.ibb.co/kHFv6Yd/clomiphene-swiss-remedies.jpg" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Broad spectrum antibiotics", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Newthyromax", 25000f, 30000f, "https://i.ibb.co/crzLHnW/thyromaxx-50-kaps-za-normalnu-funkciju-titnja-e-bi-5fb8d11c86db5.jpg" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "To treat depression", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Newsertraline", 30000f, 33000f, "https://i.ibb.co/Fw53mry/0ceba66d9685fed081df064b3a30469b.webp" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anti-hyperglycemic", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Newmetformin", 8500f, 10000f, "https://i.ibb.co/9qMw6yK/Njm9e5-KQez-GBFw-YRja-Tkb-C-1200-80.jpg" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Size 33", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Spedrin", 13000f, 15000f, "https://i.ibb.co/my2mYtr/Hff44c1c4dc104fc19a29e4f1d8fe5b96p-jpg-720x720q50.webp" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Sportswear", 13000f, 15000f, "https://i.ibb.co/7tjQZK6/https-hypebeast-com-image-2016-06-hm-sports-performance-collection-0.jpg" },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Sportswear", 13000f, 15000f, "https://i.ibb.co/Pr32t0X/2022-1-1.jpg" },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable cotton", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Shorts", 50000f, 75000f, "https://i.ibb.co/F4zR55N/bdd3cef4-0e9b-4be4-b11a-1f45aaaee12d-thumbnail-770x770.png" },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Free Size", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Dress", 130000f, 150000f, "https://i.ibb.co/bdghtwQ/sefamerve-gri-tesettur-elbise-bwst8238-01-3316251535974586797-1-752x1152.jpg" },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "for sea", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Sport hat", 50000f, 75000f, "https://i.ibb.co/cyVGNs4/1.jpg" },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Free Size", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Bloues", 130000f, 150000f, "https://i.ibb.co/wK9h3yd/1hoxd-AGYSt-Sp9-BCyq-XWP2vc-LRky-Pz-Bz-N5n-Ga-J5ad.jpg" },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Free Size", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " pants", 135000f, 155000f, "https://i.ibb.co/Gnsr6w5/w1020-q80.jpg" },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mam jeans", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " jeans", 135000f, 155000f, "https://i.ibb.co/xYNdXJ2/4b1d26be-d7dc-4056-bc63-39e30c160b7d.jpg" },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Free Size", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Dress", 130000f, 150000f, "https://i.ibb.co/YdBdM5m/16226197718.jpg" },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Size 37", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Qandara", 13000f, 15000f, "https://i.ibb.co/w7C1nJ2/31-AJD92clx-L-AC-SY780.jpg" },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Color off white", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Wedding Suit", 13000f, 15000f, "" },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taza, hot, delicious", new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Broasted", 200000f, 250000f, "https://i.ibb.co/HPdCsJk/image.jpg" },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taza, hot, delicious", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Shawrama", 175000f, 200000f, "https://i.ibb.co/RvpbMr3/8a13a1a95c8f094fe07b6e8c218fb6c2.jpg" },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taza, hot, delicious", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Grilled Chicken", 20000f, 25000f, "https://i.ibb.co/f1k26g7/png-transparent-roast-chicken-barbecue-chicken-roasting-chicken-meat-roast-chicken-food-animals-baki.png" },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taza, hot, delicious", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Nugget", 50000f, 75000f, "https://i.ibb.co/BgtCXnq/Nuggets.gif" },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taza, hot, delicious", new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " pizza ", 200000f, 250000f, "https://i.ibb.co/YQXBmKb/66951-7.jpg" },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taza, hot, delicious", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " salmey pizza", 175000f, 200000f, "https://i.ibb.co/qrfSxXs/Q2-HGj-Nd-Babm7-S2n-FA.jpg" },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everything about the world of electronics", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Smart washing machine", 50000f, 75000f, "https://i.ibb.co/Bcg2rCQ/ae-ar-WF1702-WEU-XSG-001-Front-624-624-PNG.png" },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everything about the world of electronics", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Camera", 130000f, 150000f, "https://i.ibb.co/W3Wvh7k/2d257668b46d3cd5be228192fd02876f-fmt-pjpeg-res-Mode-bisharp-wid-354.jpg" },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everything about the world of electronics", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Mobile", 175000f, 20000f, "https://i.ibb.co/BVY7rPz/eg-galaxy-s24-s928-sm-s928bztcmea-thumb-539296161-344-344-PNG.png" },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everything about the world of electronics", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " smart watch", 130000f, 150000f, "https://i.ibb.co/VqCwH1C/61tp47u-ZRl-L-AC-UF1000-1000-QL80.jpg" },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everything about the world of electronics", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "tap", 25000f, 30000f, "https://i.ibb.co/YhFVJvr/716o8-NCsj-DL-AC-UF894-1000-QL80.jpg" },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everything about the world of electronics", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "refrigerator", 230000f, 255000f, "https://i.ibb.co/0qv7MX7/toshiba-refrigerator-no-frost-11-feet-silver-gr-ef31-s.jpg" },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Floral Perfumes", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Chanel No.5", 130000f, 150000f, "https://i.ibb.co/cCZZdrz/coco-mademoiselle-eau-de-parfum-intense-spray-3-4fl-oz-packshot-default-116660-9539148283934.png" },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oriental perfumes", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Tommy Hilfiger for Men ", 175000f, 20000f, "https://i.ibb.co/QKvKKCw/91-D0-TXi2or-L.jpg" },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Woody Perfumes", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Giorgio Armani", 130000f, 150000f, "https://i.ibb.co/k38SvS0/517wv-Qgc-H0-L-AC-UF1000-1000-QL80.jpg" },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Citrus Perfumes", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " Dolce & Gabbana Light Blue", 25000f, 30000f, "https://i.ibb.co/8P2b254/miswag-Yf-M4c-AYMy-G4-U.jpg" },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amber Perfumes", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Bvlgari Black", 230000f, 255000f, "https://i.ibb.co/X2Jhj99/Espcuc-FNv-Rg-Mn-Zucl-JFIeyq-LZ3adeu-D6-NPq-UTr44.png" },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Citrus Perfumes", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, " 212", 25000f, 30000f, "https://i.ibb.co/fCbqJ6Q/sg-Ai-Uj-PU5-RORz-Cf-PAj-QVd-K9spq-QL92cj-Q4-S5-ODmo.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "Id", "Description", "RateNumber" },
                values: new object[,]
                {
                    { 2, "Middle", 3 },
                    { 3, "Good", 4 },
                    { 4, "Very Good", 5 },
                    { 5, "Super", 7 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Age", "Email", "Image", "Name", "OnlineImage", "Password", "PayPal", "Phone", "QRCode", "UserName", "isAccept" },
                values: new object[,]
                {
                    { 1, null, 20, "lama@test.com", null, "Lama Boshi", null, "121", "Lb1267", "0964654765", null, "Lamaz", true },
                    { 2, null, 20, "Hamzeh@test.com", null, "Hamze Badinjky", null, "141", "Lb1267", "0964654765", null, "hamzehS", false },
                    { 3, null, 20, "Adam@test.com", null, "Adam Syria", null, "161", "Lb1267", "0964654765", null, "Adom", false }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CompanyTypeId", "Description", "Email", "Image", "LicenseNumber", "Name", "OnlineImage", "Password", "Phone", "TelePhone", "isAccept" },
                values: new object[,]
                {
                    { 1, "From Streat", 1, "As in 1955, when Ultra Medica started its ascent in the world of pharmaceutical industry in Syria (Sednaya) founded with emphasis activities and enthusiasm for the manufacturing and developing of life science industry", "UltraMedica@test.com", null, "242523", "Ultra Medica", "https://i.ibb.co/z4vNrPc/company-1.png", "12123", "0921423432", "4232543", false },
                    { 2, "From Streat", 1, "Newpharma is een online apotheek, een uitbreiding van een echte apotheek, gevestigd in België. We spreken ook van internet apotheek of e-apotheek.", "newpharma@test.com", null, null, "New pharma", " https://i.ibb.co/yPnHycP/company-2.png", "12123", "0921423432", "4232543", false },
                    { 3, "From Streat", 2, "Max Fashion is an Indian fashion brand under the banner of the Landmark Group in Dubai", "MAX@test.com", null, "242523", "MAX", "https://i.ibb.co/9ptGtb1/max-fashion-india-logo.jpg", "111222", "0921423432", "223554", false },
                    { 4, "From Streat", 2, "It is an Italian luxury fashion house specializing in ready-to-wear and haute couture, headquartered in Milan, Italy. Expanded to design raincoats, windbreakers, knitwear, leather goods, shoes, perfume, and accessories", "MONCLER@test.com", null, "242523", "MONCLER", "https://i.ibb.co/0fmgNQL/download.png", "6789", "0921423432", "223554", false },
                    { 5, "From Streat", 3, "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", "ZARA@test.com", null, "242523", "ZARA", "https://i.ibb.co/KXYZN1b/Zara-Logo-svg.png", "0909", "0921423432", "223554", false },
                    { 6, "From Streat", 3, "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", "ZARA@test.com", null, "242523", "LC", "https://i.ibb.co/KXYZN1b/Zara-Logo-svg.png", "0909", "0921423432", "223554", false },
                    { 7, "Louisville, KentuckyFrom Streat", 4, "Kentucky Fried Chicken or KFC is a chain of fast food restaurants that specializes primarily in fried chicken.  It is the second largest chain of fast food restaurants in the world in terms of sales after McDonald's. Kentucky Fried Chicken has nearly twenty thousand branches spread over 123 countries and territories around the world.", "KFC@test.com", null, "242523", "KFC", "https://i.ibb.co/30ggCjY/download-2.png", "5252", "0921423432", "223554", false },
                    { 8, "From Streat", 4, "Pizza Hut is an American multinational restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. They serve their signature pan pizza and other dishes including pasta, breadsticks and desserts.", "PIZZAHUT@test.com", null, "242523", "PIZZA HUT", "https://i.ibb.co/wB3sWFC/cmopany-20.png", "34345", "0921423432", "223554", false },
                    { 9, "Suwon, South Korea", 5, " Samsung Electronics is the world's largest electronics and information technology company.  Samsung Electronics is part of the Samsung Group, which is the largest conglomerate in South Korea and the global market leader with more than 60 products including semiconductors such as DRAM and flash memory, digital display devices such as liquid crystal TVs  LCD and plasma, consumer electronics such as DVD players, mobile phones, digital cameras and laser printers, household appliances such as refrigerators, microwaves and dishwashers.", "SAMSUNG@test.com", null, "242523", "SAMSUNG", "https://i.ibb.co/fNGbPdT/Samsung.png", "111222", "0921423432", "223554", false },
                    { 10, "Cupertino, California, United States", 5, "The Apple Corporation is an American multinational technology company specializing in consumer electronics, software and online services.  It is one of the top five American IT companies", "APPLE@test.com", null, "242523", "APPLE", "https://i.ibb.co/pzcm1C3/Apple.png", "77666", "0921423432", "223554", false },
                    { 11, "USA", 6, "", "Prada@test.com", null, "242004", "Prada", "https://i.ibb.co/NyNdVrN/prada.png", "88810", "002875432", "242004", false },
                    { 12, "Germany", 6, "", "Calvin_Klein@test.com", null, "203010", "Calvin Klein", "https://i.ibb.co/4pN0wbw/Calvin-Klein-Logo.png", "87000", "002100572", "203010", false }
                });

            migrationBuilder.InsertData(
                table: "Donations",
                columns: new[] { "Id", "CharityId", "OrderTypeId", "PricePay" },
                values: new object[,]
                {
                    { 1, 1, 3, 20000f },
                    { 2, 2, 2, 18000f },
                    { 3, 4, 2, 11000f },
                    { 4, 2, 3, 10000f }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Amount", "Descripation", "IsDelivery", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { 1, 10, "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", true, "Order 1", 20000f, 1 },
                    { 2, 5, "The order was placed at 2:50 and will expire after a quarter of an hour from this time", false, "Order 2", 18520f, 2 },
                    { 3, 6, "The order was placed at 4:40 and will expire after a quarter of an hour from this time", true, "Order 3", 75312f, 3 },
                    { 4, 4, "The order was placed at 3:20 and will expire after a quarter of an hour from this time", true, "Order 4", 12457f, 3 },
                    { 5, 2, "The order was placed at 1:15 and will expire after a quarter of an hour from this time", false, "Order 5", 45632f, 2 }
                });

            migrationBuilder.InsertData(
                table: "CompanyMethods",
                columns: new[] { "Id", "CompanyId", "PayMethodId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 3 },
                    { 3, 3, 2 },
                    { 4, 4, 1 },
                    { 5, 5, 3 },
                    { 6, 6, 2 },
                    { 7, 7, 2 },
                    { 8, 9, 1 },
                    { 9, 9, 1 },
                    { 10, 10, 2 },
                    { 11, 11, 3 },
                    { 12, 12, 2 },
                    { 13, 7, 1 },
                    { 14, 9, 3 },
                    { 15, 11, 3 },
                    { 16, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "CompanyProducts",
                columns: new[] { "Id", "Amount", "CompanyId", "Favor", "ProductId" },
                values: new object[,]
                {
                    { 1, 10, 1, false, 1 },
                    { 2, 10, 1, false, 2 },
                    { 3, 10, 1, false, 3 },
                    { 4, 10, 2, false, 4 },
                    { 5, 10, 2, false, 5 },
                    { 6, 10, 2, false, 6 },
                    { 7, 10, 3, false, 7 },
                    { 8, 10, 3, false, 8 },
                    { 9, 10, 3, false, 9 },
                    { 10, 10, 4, false, 10 },
                    { 11, 10, 4, false, 11 },
                    { 12, 10, 4, false, 12 },
                    { 13, 10, 5, false, 13 },
                    { 14, 10, 5, false, 14 },
                    { 15, 10, 5, false, 15 },
                    { 16, 10, 6, false, 16 },
                    { 17, 10, 6, false, 17 },
                    { 18, 10, 6, false, 18 },
                    { 19, 10, 7, false, 19 },
                    { 20, 10, 7, false, 20 },
                    { 21, 10, 7, false, 21 },
                    { 22, 10, 8, false, 22 },
                    { 23, 10, 8, false, 23 },
                    { 24, 10, 8, false, 24 },
                    { 25, 10, 9, false, 25 },
                    { 26, 10, 9, false, 26 },
                    { 27, 10, 9, false, 27 },
                    { 28, 10, 10, false, 28 },
                    { 29, 10, 10, false, 29 },
                    { 30, 10, 10, false, 30 },
                    { 31, 10, 11, false, 31 },
                    { 32, 11, 11, false, 32 },
                    { 33, 10, 11, false, 33 },
                    { 34, 10, 12, false, 34 },
                    { 35, 10, 12, false, 35 },
                    { 36, 10, 12, false, 36 }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "CompanyId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Evalution",
                columns: new[] { "Id", "RateId", "SubscriptionId" },
                values: new object[,]
                {
                    { 30, 4, 1 },
                    { 31, 5, 1 },
                    { 32, 2, 2 },
                    { 33, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "Amount", "CompanyProductId", "OrderId", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 5, 4, 3, 11000 },
                    { 2, 4, 3, 5, 120000 },
                    { 3, 9, 1, 1, 480000 },
                    { 4, 100, 2, 4, 500000 }
                });

            migrationBuilder.InsertData(
                table: "ProductDonations",
                columns: new[] { "Id", "Amount", "CompanyProductId", "DonationId", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 60000 },
                    { 2, 3, 2, 2, 70000 },
                    { 3, 2, 7, 3, 70000 },
                    { 4, 3, 5, 4, 70000 },
                    { 5, 3, 11, 1, 90000 },
                    { 6, 4, 15, 2, 70000 },
                    { 7, 9, 17, 3, 679000 },
                    { 8, 8, 20, 3, 98700 },
                    { 9, 1, 29, 3, 7000 },
                    { 10, 4, 33, 4, 70000 },
                    { 11, 1, 31, 2, 101000 },
                    { 12, 1, 34, 2, 70000 },
                    { 13, 2, 22, 3, 97000 },
                    { 14, 3, 26, 1, 120000 },
                    { 15, 1, 19, 1, 70000 }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Id", "Note", "OrderProductId", "OrderStatusId" },
                values: new object[,]
                {
                    { 10, "  Welcom to you", 4, 1 },
                    { 21, " Welcom to you", 2, 1 },
                    { 22, " Welcom to you", 2, 2 },
                    { 23, " Welcom to you", 1, 1 },
                    { 24, " Welcom to you", 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_OrderProductId",
                table: "Bills",
                column: "OrderProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_OrderStatusId",
                table: "Bills",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyMethods_CompanyId",
                table: "CompanyMethods",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyMethods_PayMethodId",
                table: "CompanyMethods",
                column: "PayMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyProducts_CompanyId",
                table: "CompanyProducts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyProducts_ProductId",
                table: "CompanyProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_CharityId",
                table: "Donations",
                column: "CharityId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_OrderTypeId",
                table: "Donations",
                column: "OrderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Evalution_RateId",
                table: "Evalution",
                column: "RateId");

            migrationBuilder.CreateIndex(
                name: "IX_Evalution_SubscriptionId",
                table: "Evalution",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_CompanyProductId",
                table: "OrderProducts",
                column: "CompanyProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDonations_CompanyProductId",
                table: "ProductDonations",
                column: "CompanyProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDonations_DonationId",
                table: "ProductDonations",
                column: "DonationId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_CompanyId",
                table: "Subscriptions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "CompanyMethods");

            migrationBuilder.DropTable(
                name: "Evalution");

            migrationBuilder.DropTable(
                name: "ProductDonations");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "PayMethods");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "CompanyProducts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Charities");

            migrationBuilder.DropTable(
                name: "OrderTypes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CompanyTypes");
        }
    }
}
