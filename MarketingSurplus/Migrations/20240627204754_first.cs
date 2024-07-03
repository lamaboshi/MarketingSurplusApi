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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    PayMethodId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_PayMethods_PayMethodId",
                        column: x => x.PayMethodId,
                        principalTable: "PayMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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
                name: "Donations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharityId = table.Column<int>(type: "int", nullable: false),
                    OrderTypeId = table.Column<int>(type: "int", nullable: false),
                    CompanyProductId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Donations_CompanyProducts_CompanyProductId",
                        column: x => x.CompanyProductId,
                        principalTable: "CompanyProducts",
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
                columns: new[] { "Id", "Address", "AssociationLicense", "Email", "Goals", "Image", "Name", "Password", "Phone", "QRCode", "TargetGroup", "isAccept" },
                values: new object[,]
                {
                    { 1, "Al Hamadanieh", "2435", "Al-Ihsan@test.com", "childern", null, "Al-Ihsan", "Al-Ihsan789", "0215789147", null, "Rich Pepole", false },
                    { 2, "Al mohafaza", "2435", "Hand-By-Hand@test.com", "Old Pepole", null, "Hand By Hand", "Hand-By-Hand456", "0215117894", null, "Rich Pepole", false },
                    { 3, "Mohamad Fares Street", "2435", "Al-Noor@test.com", "childern", null, "Al-Noor", "Al-Noor123", "021524895 ", null, "Rich Pepole", false },
                    { 4, "Al Azizeh", "2435", "George@test.com", "childern", null, "George", "George147", "0215115827", null, "Rich Pepole", false },
                    { 5, "Al Marterni", "2435", "Namaa@test.com", "childern", null, "Namaa", "Namaa369", "02151174369", null, "Rich Pepole", false }
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
                    { 6, "All About Movies & Series", "Platforms", false },
                    { 7, "All About Perfumes", "Perfumes", false }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "DateTime", "Note", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 27, 23, 47, 54, 86, DateTimeKind.Local).AddTicks(2171), null, 1 },
                    { 2, new DateTime(2024, 6, 27, 23, 47, 54, 86, DateTimeKind.Local).AddTicks(2199), null, 2 },
                    { 3, new DateTime(2024, 6, 27, 23, 47, 54, 86, DateTimeKind.Local).AddTicks(2215), null, 3 },
                    { 4, new DateTime(2024, 6, 27, 23, 47, 54, 86, DateTimeKind.Local).AddTicks(2230), null, 4 }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Normal" },
                    { 2, "Donation" },
                    { 3, "Charity Organization" }
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
                columns: new[] { "Id", "DateTime", "Descripation", "Expiration", "IsExpiration", "Name", "NewPrice", "OldPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Each wrapped bag contains one kilo of good quality Egyptian rice", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Rice", 15000f, 20000f },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The weight of each raw chicken ranges between 1.7 kg and 2.2 kg. The meat is halal.", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Broasted Chicken", 21000f, 30000f },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Each paracetamol tablet contains 500 mg of acetamol, which reduces fever and relieves pain.", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Paracetamol", 50000f, 70000f }
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
                columns: new[] { "Id", "Address", "Age", "Email", "Image", "Name", "Password", "PayPal", "Phone", "QRCode", "UserName", "isAccept" },
                values: new object[,]
                {
                    { 1, null, 20, "lama@test.com", null, "Lama Boshi", "121", "Lb1267", "0964654765", null, "Lamaz", true },
                    { 2, null, 20, "Hamzeh@test.com", null, "Hamze Badinjky", "141", "Lb1267", "0964654765", null, "hamzehS", false },
                    { 3, null, 20, "Adam@test.com", null, "Adam Syria", "161", "Lb1267", "0964654765", null, "Adom", false }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CompanyTypeId", "Description", "Email", "Image", "LicenseNumber", "Name", "Password", "Phone", "TelePhone", "isAccept" },
                values: new object[,]
                {
                    { 1, "From Streat", 1, "As in 1955, when Ultra Medica started its ascent in the world of pharmaceutical industry in Syria (Sednaya) founded with emphasis activities and enthusiasm for the manufacturing and developing of life science industry", "UltraMedica@test.com", null, "242523", "Ultra Medica", "12123", "0921423432", "4232543", false },
                    { 2, "From Streat", 1, "Newpharma is een online apotheek, een uitbreiding van een echte apotheek, gevestigd in België. We spreken ook van internet apotheek of e-apotheek.", "newpharma@test.com", null, null, "New pharma", "12123", "0921423432", "4232543", false },
                    { 3, "From Streat", 1, "Asia Pharmacy is an Electrical and Electronic Manufacturing company located in 1035 S Federal Blvd Ste B, Denver, Colorado, United States.", "MAYBELLINE@test.com", null, null, "Asia pharmacy", "34345", "0921423432", "4232543", false },
                    { 4, "From Streat", 1, "Our pharmacist and trained assistants are available for advice on all medicines and minor ailments. We can also give you advice on how to live a healthier life and can direct you to a range of other resources if needed.", "LOREAL@test.com", null, "242523", "Medico ", "23234", "0921423432", "4232543", false },
                    { 5, "From Streat", 1, "APOTHEKE ADHOC Webinar: Praxisrelevantes Wissen für das gesamte Apothekenteam zu brandaktuellen Fachthemen rund um Indikation, Beratung, Rezeptur und vieles mehr.", "SEPHORA@test.com", null, "242523", "Mediathek", "45456", "0921423432", "4232543", false },
                    { 6, "From Streat", 2, "Asics sponsors a variety of sports associations", "Asics@test.com", null, "242523", "ASIC", "111222", "0921423432", "223554", false },
                    { 7, "From Streat", 2, "Manufacturer of sports shoes and apparel. It was the largest sportswear manufacturer in Europe and the second largest after Nike in the world. Adidas products are traditionally distinguished by a three-line brand, which remains an element of the company's latest products", "ADDIDAS@test.com", null, "242523", "ADDIDAS", "111222", "0921423432", "223554", false },
                    { 8, "From Streat", 2, "The world’s largest athletic apparel company, Nike is best known for its footwear, apparel, and equipment. One of the most valuable brands among sport businesses,The company sponsors top athletes and sports teams around the world.", "NIKE@test.com", null, "242523", "NIKE", "78789", "0921423432", "223554", false },
                    { 9, "From Streat", 2, "Puma, is a German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories, which is headquartered in Herzogenaurach, Bavaria, Germany. Puma is the third largest sportswear manufacturer in the world", "PUMA@test.com", null, "242523", "PUMA", "67678", "0921423432", "223554", false },
                    { 10, "Reebok International Limited (/ˈriːbɒk/) is an American fitness footwear and clothing manufacturer that is a part of Authentic Brands Group.", 2, "Asics sponsors a variety of sports associations", "REEBOK@test.com", null, "242523", "REEBOK", "8989", "0921423432", "223554", false },
                    { 11, "From Streat", 3, "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", "ZARA@test.com", null, "242523", "ZARA", "0909", "0921423432", "223554", false },
                    { 12, "From Streat", 3, "Max Fashion is an Indian fashion brand under the banner of the Landmark Group in Dubai", "MAX@test.com", null, "242523", "MAX", "111222", "0921423432", "223554", false },
                    { 13, "From Streat", 3, "It is an Italian luxury fashion house specializing in ready-to-wear and haute couture, headquartered in Milan, Italy. Expanded to design raincoats, windbreakers, knitwear, leather goods, shoes, perfume, and accessories", "MONCLER@test.com", null, "242523", "MONCLER", "6789", "0921423432", "223554", false },
                    { 14, "From Streat", 3, "Lacoste S.A. is a French company. It sells clothing, footwear, sportswear, eyewear, leather goods, perfume, towels and watches", "LACOSTE@test.com", null, "242523", "LACOSTE", "111222", "0921423432", "223554", false },
                    { 15, "From Streat", 3, "It is one of the most famous fashion companies in the world. The group enjoys a unified identity consisting of colours, authentic fashion and quality at democratic prices", "BENETTON@test.com", null, "242523", "BENETTON", "9463", "0921423432", "223554", false },
                    { 16, "Louisville, KentuckyFrom Streat", 4, "Kentucky Fried Chicken or KFC is a chain of fast food restaurants that specializes primarily in fried chicken.  It is the second largest chain of fast food restaurants in the world in terms of sales after McDonald's. Kentucky Fried Chicken has nearly twenty thousand branches spread over 123 countries and territories around the world.", "KFC@test.com", null, "242523", "KFC", "5252", "0921423432", "223554", false },
                    { 17, "From Streat", 4, "MCDONALD'S is the world's largest restaurant chain by revenue,McDonald's is best known for its hamburgers, cheeseburgers and french fries, although their menus include other items like chicken, fish, fruit, and salads", "MCDONALDS@test.com", null, "242523", "MCDONALDS", "99999", "0921423432", "223554", false },
                    { 18, "From Streat", 4, "Nestlé is a multinational company specializing in the production of canned foods, founded in Vevey, Switzerland.", "NESTLE@test.com", null, null, "NESTLE", "111222", "0921423432", "223554", false },
                    { 19, "From Streat", 4, "STARBUCKS is a specialty coffee retailer. It roasts, markets, and retails specialty coffee. The company, through its stores, offers several blends of coffee, handcrafted beverages, merchandise, and food items", "STARBUCKS@test.com", null, "242523", "STARBUCKS", "123122", "0921423432", "223554", false },
                    { 20, "From Streat", 4, "Pizza Hut is an American multinational restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. They serve their signature pan pizza and other dishes including pasta, breadsticks and desserts.", "PIZZAHUT@test.com", null, "242523", "PIZZA HUT", "34345", "0921423432", "223554", false },
                    { 21, "Suwon, South Korea", 5, " Samsung Electronics is the world's largest electronics and information technology company.  Samsung Electronics is part of the Samsung Group, which is the largest conglomerate in South Korea and the global market leader with more than 60 products including semiconductors such as DRAM and flash memory, digital display devices such as liquid crystal TVs  LCD and plasma, consumer electronics such as DVD players, mobile phones, digital cameras and laser printers, household appliances such as refrigerators, microwaves and dishwashers.", "SAMSUNG@test.com", null, "242523", "SAMSUNG", "111222", "0921423432", "223554", false },
                    { 22, "Cupertino, California, United States", 5, "The Apple Corporation is an American multinational technology company specializing in consumer electronics, software and online services.  It is one of the top five American IT companies", "APPLE@test.com", null, "242523", "APPLE", "77666", "0921423432", "223554", false },
                    { 23, "South Korea", 5, "The Korean LG Group this company is the second largest holding company, producing electronics, chemicals and telecommunications products.  from 80 countries", "LG@test.com", null, "242523", "LG", "989887", "0921423432", "223554", false },
                    { 24, " Los Gatos, California", 6, "Netflix is   an American entertainment company that specializes in providing live broadcasting, video-on-demand, and mail-delivery of CDs. Netflix has expanded into the production of films and television shows, and online video distribution", "NETFLIX@test.com", null, "242523", "NETFLIX", "34567", "0921423432", "223554", false },
                    { 25, "From Streat", 6, "Shahid is the first Arab platform to provide \"Video on Demand\" service in the Middle East, and it has been re-launched by the \"MBC\" media group.  It is worth noting that Shahid,the leading subscription video-on-demand platform, is considered the leading Arab broadcasting platform in the world and the home of original Arabic productions with world-class specifications.along with a live broadcast of a group of the most watched Arab TV channels", "SHAHID@test.com", null, "242523", "SHAHID", "888877", "0921423432", "223554", false },
                    { 26, "From Streat", 7, "DIOR Products Clothing, cosmetics, fashion accessories, jewelry, perfumes, watches", "DIOR@test.com", null, "242523", "DIOR", "777776", "0921423432", "223554", false },
                    { 27, "From Streat", 7, "Chanel Its products cover clothes, fragrances, handbags and watches", "CHANNEL@test.com", null, "242523", "CHANNEL", "333333", "0921423432", "223554", false },
                    { 28, "From Streat", 7, "Gucci offers a range of different luxury  Shoes, ready-to-wear apparel, watches, and jewelry are the other main , however they also sell other products such as perfume and home decor", "Gucci@test.com", null, "242523", "GUCCI", "8888882", "0921423432", "223554", false }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Amount", "Descripation", "IsDelivery", "Name", "PayMethodId", "Price", "UserId" },
                values: new object[,]
                {
                    { 1, 10, "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", true, "Order 1", 1, 20000f, 1 },
                    { 2, 5, "The order was placed at 2:50 and will expire after a quarter of an hour from this time", false, "Order 2", 1, 18520f, 2 },
                    { 3, 6, "The order was placed at 4:40 and will expire after a quarter of an hour from this time", true, "Order 3", 2, 75312f, 3 },
                    { 4, 4, "The order was placed at 3:20 and will expire after a quarter of an hour from this time", true, "Order 4", 2, 12457f, 3 },
                    { 5, 2, "The order was placed at 1:15 and will expire after a quarter of an hour from this time", false, "Order 5", 3, 45632f, 2 }
                });

            migrationBuilder.InsertData(
                table: "CompanyProducts",
                columns: new[] { "Id", "Amount", "CompanyId", "Favor", "ProductId" },
                values: new object[,]
                {
                    { 1, 4, 16, false, 1 },
                    { 2, 2, 17, false, 1 },
                    { 3, 10, 1, false, 3 },
                    { 4, 2, 18, false, 2 }
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
                table: "Donations",
                columns: new[] { "Id", "CharityId", "CompanyProductId", "OrderTypeId", "PricePay" },
                values: new object[,]
                {
                    { 1, 1, 2, 3, 20000f },
                    { 2, 2, 1, 2, 18000f },
                    { 3, 4, 3, 2, 11000f },
                    { 4, 2, 3, 3, 10000f }
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
                name: "IX_Donations_CompanyProductId",
                table: "Donations",
                column: "CompanyProductId");

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
                name: "IX_Orders_PayMethodId",
                table: "Orders",
                column: "PayMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

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
                name: "Donations");

            migrationBuilder.DropTable(
                name: "Evalution");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "Charities");

            migrationBuilder.DropTable(
                name: "OrderTypes");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "CompanyProducts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PayMethods");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CompanyTypes");
        }
    }
}
