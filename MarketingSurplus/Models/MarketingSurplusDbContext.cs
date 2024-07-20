using Microsoft.EntityFrameworkCore;

namespace MarketingSurplus.Models
{
    public class MarketingSurplusDbContext : DbContext
    {
        public MarketingSurplusDbContext(DbContextOptions<MarketingSurplusDbContext> options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Charity> Charities { get; set; }
        public DbSet<CompanyProduct> CompanyProducts { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<PayMethod> PayMethods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions  { get; set; }
        public DbSet<Evalution> Evalution { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<ProductDonation> ProductDonations { get; set; }
        public DbSet<CompanyMethods> CompanyMethods { get; set; }
        //test

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
           .Ignore(c => c.CompanyProducts)
                 .Ignore(c => c.Subscriptions);
            modelBuilder.Entity<Product>()
                  .Ignore(c => c.CompanyProducts);
            modelBuilder.Entity<CompanyType>()
                .Ignore(c => c.Companies);





            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 1, TypeName = "Medicines", Description = "All About Medicines", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 2, TypeName = "Sports", Description = "All About sports", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 3, TypeName = "Clothes", Description = "All About Clothes", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 4, TypeName = "Food", Description = "All About Food", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 5, TypeName = "Electronics", Description = "All About electronics", });

            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 6, TypeName = "Perfumes", Description = "All About Perfumes", });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 1, CompanyTypeId = 1, Name = "Ultra Medica", OnlineImage = "https://i.ibb.co/z4vNrPc/company-1.png", Description = "As in 1955, when Ultra Medica started its ascent in the world of pharmaceutical industry in Syria (Sednaya) founded with emphasis activities and enthusiasm for the manufacturing and developing of life science industry", Address = "From Streat", Email = "UltraMedica@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 2, CompanyTypeId = 1, Name = "New pharma", OnlineImage = " https://i.ibb.co/yPnHycP/company-2.png", Description = "Newpharma is een online apotheek, een uitbreiding van een echte apotheek, gevestigd in België. We spreken ook van internet apotheek of e-apotheek.", Address = "From Streat", Email = "newpharma@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123" });


            modelBuilder.Entity<Company>().HasData(new Company { Id = 3, CompanyTypeId = 2, Name = "MAX", OnlineImage = "https://i.ibb.co/9ptGtb1/max-fashion-india-logo.jpg", Description = "Max Fashion is an Indian fashion brand under the banner of the Landmark Group in Dubai", Address = "From Streat", Email = "MAX@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 4, CompanyTypeId = 2, Name = "MONCLER", OnlineImage = "https://i.ibb.co/0fmgNQL/download.png", Description = "It is an Italian luxury fashion house specializing in ready-to-wear and haute couture, headquartered in Milan, Italy. Expanded to design raincoats, windbreakers, knitwear, leather goods, shoes, perfume, and accessories", Address = "From Streat", Email = "MONCLER@test.com", Phone = "0921423432", TelePhone = "223554", Password = "6789", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 5, CompanyTypeId = 3, Name = "ZARA", OnlineImage = "https://i.ibb.co/KXYZN1b/Zara-Logo-svg.png", Description = "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", Address = "From Streat", Email = "ZARA@test.com", Phone = "0921423432", TelePhone = "223554", Password = "0909", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 6, CompanyTypeId = 3, Name = "LC", OnlineImage = "https://i.ibb.co/KXYZN1b/Zara-Logo-svg.png", Description = "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", Address = "From Streat", Email = "ZARA@test.com", Phone = "0921423432", TelePhone = "223554", Password = "0909", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 7, CompanyTypeId = 4, Name = "KFC", OnlineImage = "https://i.ibb.co/30ggCjY/download-2.png", Description = "Kentucky Fried Chicken or KFC is a chain of fast food restaurants that specializes primarily in fried chicken.  It is the second largest chain of fast food restaurants in the world in terms of sales after McDonald's. Kentucky Fried Chicken has nearly twenty thousand branches spread over 123 countries and territories around the world.", Address = "Louisville, KentuckyFrom Streat", Email = "KFC@test.com", Phone = "0921423432", TelePhone = "223554", Password = "5252", LicenseNumber = "242523" }); modelBuilder.Entity<Company>().HasData(new Company { Id = 8, CompanyTypeId = 4, Name = "PIZZA HUT", OnlineImage = "https://i.ibb.co/wB3sWFC/cmopany-20.png", Description = "Pizza Hut is an American multinational restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. They serve their signature pan pizza and other dishes including pasta, breadsticks and desserts.", Address = "From Streat", Email = "PIZZAHUT@test.com", Phone = "0921423432", TelePhone = "223554", Password = "34345", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 9, CompanyTypeId = 5, Name = "SAMSUNG", OnlineImage = "https://i.ibb.co/fNGbPdT/Samsung.png", Description = " Samsung Electronics is the world's largest electronics and information technology company.  Samsung Electronics is part of the Samsung Group, which is the largest conglomerate in South Korea and the global market leader with more than 60 products including semiconductors such as DRAM and flash memory, digital display devices such as liquid crystal TVs  LCD and plasma, consumer electronics such as DVD players, mobile phones, digital cameras and laser printers, household appliances such as refrigerators, microwaves and dishwashers.", Address = "Suwon, South Korea", Email = "SAMSUNG@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 10, CompanyTypeId = 5, Name = "APPLE", OnlineImage = "https://i.ibb.co/pzcm1C3/Apple.png", Description = "The Apple Corporation is an American multinational technology company specializing in consumer electronics, software and online services.  It is one of the top five American IT companies", Address = "Cupertino, California, United States", Email = "APPLE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "77666", LicenseNumber = "242523" });

            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 11,
                CompanyTypeId = 6,
                Name = "Prada",
                OnlineImage = "https://i.ibb.co/NyNdVrN/prada.png",
                Description = "",
                Address = "USA",
                Email = "Prada@test.com",
                Phone = "002875432",
                TelePhone = "242004",
                Password = "88810",
                LicenseNumber = "242004",
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 12,
                CompanyTypeId = 6,
                Name = "Calvin Klein",
                OnlineImage = "https://i.ibb.co/4pN0wbw/Calvin-Klein-Logo.png",
                Description = "",
                Address = "Germany",
                Email = "Calvin_Klein@test.com",
                Phone = "002100572",
                TelePhone = "203010",
                Password = "87000",
                LicenseNumber = "203010",
            });

            //modelBuilder.Entity<Company>().HasData(new Company { Id = 1, CompanyTypeId = 1, Name = "Ultra Medica", OnlineImage = "https://i.ibb.co/z4vNrPc/company-1.png", Description = "As in 1955, when Ultra Medica started its ascent in the world of pharmaceutical industry in Syria (Sednaya) founded with emphasis activities and enthusiasm for the manufacturing and developing of life science industry", Address = "From Streat", Email = "UltraMedica@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123", LicenseNumber = "242523" });
            //modelBuilder.Entity<Company>().HasData(new Company { Id = 2, CompanyTypeId = 1, Name = "New pharma", OnlineImage = " https://i.ibb.co/yPnHycP/company-2.png", Description = "Newpharma is een online apotheek, een uitbreiding van een echte apotheek, gevestigd in België. We spreken ook van internet apotheek of e-apotheek.", Address = "From Streat", Email = "newpharma@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123" });
            //modelBuilder.Entity<Company>().HasData(new Company { Id = 3, CompanyTypeId = 1, Name = "Asia pharmacy", OnlineImage = "https://i.ibb.co/7kg3CCh/cmpany-3.jpg", Description = "Asia Pharmacy is an Electrical and Electronic Manufacturing company located in 1035 S Federal Blvd Ste B, Denver, Colorado, United States.", Address = "From Streat", Email = "MAYBELLINE@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "34345" });

            //modelBuilder.Entity<Company>().HasData(new Company { Id = 4, CompanyTypeId = 4, Name = "NESTLE", OnlineImage = "https://i.ibb.co/BwzvsfN/company-18.png", Description = "Nestlé is a multinational company specializing in the production of canned foods, founded in Vevey, Switzerland.", Address = "From Streat", Email = "NESTLE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            //modelBuilder.Entity<Company>().HasData(new Company { Id = 5, CompanyTypeId = 4, Name = "STARBUCKS", OnlineImage = "https://i.ibb.co/jJ1MdK5/company-19.png", Description = "STARBUCKS is a specialty coffee retailer. It roasts, markets, and retails specialty coffee. The company, through its stores, offers several blends of coffee, handcrafted beverages, merchandise, and food items", Address = "From Streat", Email = "STARBUCKS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "123122", LicenseNumber = "242523" });
            //modelBuilder.Entity<Company>().HasData(new Company { Id = 6, CompanyTypeId = 4, Name = "PIZZA HUT", OnlineImage = "https://i.ibb.co/wB3sWFC/cmopany-20.png", Description = "Pizza Hut is an American multinational restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. They serve their signature pan pizza and other dishes including pasta, breadsticks and desserts.", Address = "From Streat", Email = "PIZZAHUT@test.com", Phone = "0921423432", TelePhone = "223554", Password = "34345", LicenseNumber = "242523" });

            //modelBuilder.Entity<Company>().HasData(new Company { Id = 7, CompanyTypeId = 3, Name = "ZARA", OnlineImage = "https://i.ibb.co/KXYZN1b/Zara-Logo-svg.png", Description = "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", Address = "From Streat", Email = "ZARA@test.com", Phone = "0921423432", TelePhone = "223554", Password = "0909", LicenseNumber = "242523" });
            //modelBuilder.Entity<Company>().HasData(new Company { Id = 8, CompanyTypeId = 3, Name = "MAX", OnlineImage = "https://i.ibb.co/9ptGtb1/max-fashion-india-logo.jpg", Description = "Max Fashion is an Indian fashion brand under the banner of the Landmark Group in Dubai", Address = "From Streat", Email = "MAX@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            //modelBuilder.Entity<Company>().HasData(new Company { Id = 9, CompanyTypeId = 3, Name = "MONCLER", OnlineImage = "https://i.ibb.co/0fmgNQL/download.png", Description = "It is an Italian luxury fashion house specializing in ready-to-wear and haute couture, headquartered in Milan, Italy. Expanded to design raincoats, windbreakers, knitwear, leather goods, shoes, perfume, and accessories", Address = "From Streat", Email = "MONCLER@test.com", Phone = "0921423432", TelePhone = "223554", Password = "6789", LicenseNumber = "242523" });

            //modelBuilder.Entity<Company>().HasData(new Company { Id = 10, CompanyTypeId = 4, Name = "KFC", OnlineImage = "https://i.ibb.co/30ggCjY/download-2.png", Description = "Kentucky Fried Chicken or KFC is a chain of fast food restaurants that specializes primarily in fried chicken.  It is the second largest chain of fast food restaurants in the world in terms of sales after McDonald's. Kentucky Fried Chicken has nearly twenty thousand branches spread over 123 countries and territories around the world.", Address = "Louisville, KentuckyFrom Streat", Email = "KFC@test.com", Phone = "0921423432", TelePhone = "223554", Password = "5252", LicenseNumber = "242523" });
            //modelBuilder.Entity<Company>().HasData(new Company { Id = 11, CompanyTypeId = 4, Name = "MCDONALDS", OnlineImage = "https://i.ibb.co/KFrbLN2/Mc-Donald-s-square-2020-svg.png", Description = "MCDONALD'S is the world's largest restaurant chain by revenue,McDonald's is best known for its hamburgers, cheeseburgers and french fries, although their menus include other items like chicken, fish, fruit, and salads", Address = "From Streat", Email = "MCDONALDS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "99999", LicenseNumber = "242523" });
            //modelBuilder.Entity<Company>().HasData(new Company { Id = 12, CompanyTypeId = 4, Name = "NESTLE", OnlineImage = "https://i.ibb.co/VYRjnQS/download-1.png", Description = "Nestlé is a multinational company specializing in the production of canned foods, founded in Vevey, Switzerland.", Address = "From Streat", Email = "NESTLE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });

            //modelBuilder.Entity<Company>().HasData(new Company { Id = 13, CompanyTypeId = 5, Name = "SAMSUNG", OnlineImage = "https://i.ibb.co/fNGbPdT/Samsung.png", Description = " Samsung Electronics is the world's largest electronics and information technology company.  Samsung Electronics is part of the Samsung Group, which is the largest conglomerate in South Korea and the global market leader with more than 60 products including semiconductors such as DRAM and flash memory, digital display devices such as liquid crystal TVs  LCD and plasma, consumer electronics such as DVD players, mobile phones, digital cameras and laser printers, household appliances such as refrigerators, microwaves and dishwashers.", Address = "Suwon, South Korea", Email = "SAMSUNG@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            //modelBuilder.Entity<Company>().HasData(new Company { Id = 14, CompanyTypeId = 5, Name = "APPLE", OnlineImage = "https://i.ibb.co/pzcm1C3/Apple.png", Description = "The Apple Corporation is an American multinational technology company specializing in consumer electronics, software and online services.  It is one of the top five American IT companies", Address = "Cupertino, California, United States", Email = "APPLE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "77666", LicenseNumber = "242523" });
            //modelBuilder.Entity<Company>().HasData(new Company { Id = 15, CompanyTypeId = 5, Name = "LG", OnlineImage = "https://i.ibb.co/7kPVm4w/share-default.jpg", Description = "The Korean LG Group this company is the second largest holding company, producing electronics, chemicals and telecommunications products.  from 80 countries", Address = "South Korea", Email = "LG@test.com", Phone = "0921423432", TelePhone = "223554", Password = "989887", LicenseNumber = "242523" });

            //modelBuilder.Entity<Company>().HasData(new Company
            //{
            //    Id = 16,
            //    CompanyTypeId= 6,
            //    Name = "Prada",
            //    OnlineImage = "https://i.ibb.co/NyNdVrN/prada.png",
            //    Description = "",
            //    Address = "USA",
            //    Email = "Prada@test.com",
            //    Phone = "002875432",
            //    TelePhone = "242004",
            //    Password = "88810",
            //    LicenseNumber = "242004",
            //});
            //modelBuilder.Entity<Company>().HasData(new Company
            //{
            //    Id = 17,
            //    CompanyTypeId = 6,
            //    Name = "Calvin Klein",
            //    OnlineImage = "https://i.ibb.co/4pN0wbw/Calvin-Klein-Logo.png",
            //    Description = "",
            //    Address = "Germany",
            //    Email = "Calvin_Klein@test.com",
            //    Phone = "002100572",
            //    TelePhone = "203010",
            //    Password = "87000",
            //    LicenseNumber = "203010",
            //});
            //modelBuilder.Entity<Company>().HasData(new Company
            //{
            //    Id = 18,
            //    CompanyTypeId = 6,
            //    Name = "Dolce & Gabbana",
            //    OnlineImage = "https://i.ibb.co/ZLgbW92/Dolce-Gabbana-Logo.png",
            //    Description = "Switzerland",
            //    Address = "From Streat",
            //    Email = "D_G@test.com",
            //    Phone = "002104892",
            //    TelePhone = "20440",
            //    Password = "87480",
            //    LicenseNumber = "20440",
            //});

            modelBuilder.Entity<User>().HasData(new User { Id = 1, Email = "lama@test.com", Name = "Lama Boshi", UserName = "Lamaz", Phone = "0964654765", Age = 20, Password = "121", PayPal = "Lb1267",isAccept=true });
            modelBuilder.Entity<User>().HasData(new User { Id = 2, Email = "Hamzeh@test.com", Name = "Hamze Badinjky", UserName = "hamzehS", Phone = "0964654765", Age = 20, Password = "141", PayPal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 3, Email = "Adam@test.com", Name = "Adam Syria", UserName = "Adom", Phone = "0964654765", Age = 20, Password = "161", PayPal = "Lb1267" });



            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 1, CompanyId = 1, UserId = 1, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 2, CompanyId = 2, UserId = 1, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 3, CompanyId = 2, UserId = 3, });

            modelBuilder.Entity<OrderType>().HasData(new OrderType { Id = 1, Name = "Normal", });
            modelBuilder.Entity<OrderType>().HasData(new OrderType { Id = 2, Name = "Donation", });
            modelBuilder.Entity<OrderType>().HasData(new OrderType { Id = 3, Name = "Charity Organization", });

            modelBuilder.Entity<PayMethod>().HasData(new PayMethod { Id = 1, Name = "Cash Pay", });
            modelBuilder.Entity<PayMethod>().HasData(new PayMethod { Id = 2, Name = "PayPal", });
            modelBuilder.Entity<PayMethod>().HasData(new PayMethod { Id = 3, Name = "Credit Card", });



            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 1, Name = "Al-Ihsan", OnlineImage = "https://i.ibb.co/Z6GHm9w/banner.png", Phone = "0215789147", Address = "Al Hamadanieh", Email = "Al-Ihsan@test.com", Password = "Al-Ihsan789", Goals = "childern", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 2, Name = "Hand By Hand", OnlineImage = "https://i.ibb.co/CH67mMZ/9ba9d0086cff0ceb5155420e01fda24e.jpg", Phone = "0215117894", Address = "Al mohafaza", Email = "Hand-By-Hand@test.com", Password = "Hand-By-Hand456", Goals = "Old Pepole", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 3, Name = "Al-Noor", OnlineImage = "https://i.ibb.co/7GY0Qvs/al-nour.jpg", Phone = "021524895 ", Address = "Mohamad Fares Street", Email = "Al-Noor@test.com", Password = "Al-Noor123", Goals = "childern", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 4, Name = "George", OnlineImage = "https://i.ibb.co/HpFwRsc/259490784-888270292057739-1584770156068076983-n-300x378.png", Phone = "0215115827", Address = "Al Azizeh", Email = "George@test.com", Password = "George147", Goals = "childern", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 5, Name = "Namaa", OnlineImage = "https://i.ibb.co/rwW5L3G/namma.jpg", Phone = "02151174369", Address = "Al Marterni", Email = "Namaa@test.com", Password = "Namaa369", Goals = "childern", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });


            //medicine
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = " Newflamix",
                Descripation = "Flamix is ​​a medicine that contains celecoxib as an active ingredient, and it is considered a non-steroidal anti-infl ammatory drug",
                OldPrice = 15000,
                NewPrice = 13000,
                OnlineImage = "https://i.ibb.co/xjS4yyL/Flamix2040020mg20film20tablete203-D.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "New Profin",
                Descripation = "Moderate pain relief without the need for a prescription",
                OldPrice = 9000,
                NewPrice = 6000,
                OnlineImage = "https://i.ibb.co/yykJXSj/product-1.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Newclomiphene",
                Descripation = "Clomiphene is used to treat some cases of infertility in women",
                OldPrice = 15000,
                NewPrice = 13000,
                OnlineImage = "https://i.ibb.co/kHFv6Yd/clomiphene-swiss-remedies.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Newthyromax",
                Descripation = "Broad spectrum antibiotics",
                OldPrice = 30000,
                NewPrice = 25000,
                OnlineImage = "https://i.ibb.co/crzLHnW/thyromaxx-50-kaps-za-normalnu-funkciju-titnja-e-bi-5fb8d11c86db5.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Newsertraline",
                Descripation = "To treat depression",
                OldPrice = 33000,
                NewPrice = 30000,
                OnlineImage = "https://i.ibb.co/Fw53mry/0ceba66d9685fed081df064b3a30469b.webp",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Newmetformin",
                Descripation = "Anti-hyperglycemic",
                OldPrice = 10000,
                NewPrice = 8500,
                OnlineImage = "https://i.ibb.co/9qMw6yK/Njm9e5-KQez-GBFw-YRja-Tkb-C-1200-80.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });


            //sport
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = " Spedrin",
                Descripation = "Size 33",
                OldPrice = 15000,
                NewPrice = 13000,
                OnlineImage = "https://i.ibb.co/my2mYtr/Hff44c1c4dc104fc19a29e4f1d8fe5b96p-jpg-720x720q50.webp",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = " Sportswear",
                Descripation = "",
                OldPrice = 15000,
                NewPrice = 13000,
                OnlineImage = "https://i.ibb.co/7tjQZK6/https-hypebeast-com-image-2016-06-hm-sports-performance-collection-0.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = " Sportswear",
                Descripation = "",
                OldPrice = 15000,
                NewPrice = 13000,
                OnlineImage = "https://i.ibb.co/Pr32t0X/2022-1-1.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = " Shorts",
                Descripation = "Comfortable cotton",
                OldPrice = 75000,
                NewPrice = 50000,
                OnlineImage = "https://i.ibb.co/F4zR55N/bdd3cef4-0e9b-4be4-b11a-1f45aaaee12d-thumbnail-770x770.png",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = " Dress",
                Descripation = "Free Size",
                OldPrice = 150000,
                NewPrice = 130000,
                OnlineImage = "https://i.ibb.co/bdghtwQ/sefamerve-gri-tesettur-elbise-bwst8238-01-3316251535974586797-1-752x1152.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = " Sport hat",
                Descripation = "for sea",
                OldPrice = 75000,
                NewPrice = 50000,
                OnlineImage = "https://i.ibb.co/cyVGNs4/1.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            //Arrayed
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = " Bloues",
                Descripation = "Free Size",
                OldPrice = 150000,
                NewPrice = 130000,
                OnlineImage = "https://i.ibb.co/wK9h3yd/1hoxd-AGYSt-Sp9-BCyq-XWP2vc-LRky-Pz-Bz-N5n-Ga-J5ad.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = " pants",
                Descripation = "Free Size",
                OldPrice = 155000,
                NewPrice = 135000,
                OnlineImage = "https://i.ibb.co/Gnsr6w5/w1020-q80.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = " jeans",
                Descripation = "mam jeans",
                OldPrice = 155000,
                NewPrice = 135000,
                OnlineImage = "https://i.ibb.co/xYNdXJ2/4b1d26be-d7dc-4056-bc63-39e30c160b7d.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = " Dress",
                Descripation = "Free Size",
                OldPrice = 150000,
                NewPrice = 130000,
                OnlineImage = "https://i.ibb.co/YdBdM5m/16226197718.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = " Qandara",
                Descripation = "Size 37",
                OldPrice = 15000,
                NewPrice = 13000,
                OnlineImage = "https://i.ibb.co/w7C1nJ2/31-AJD92clx-L-AC-SY780.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = " Wedding Suit",
                Descripation = "Color off white",
                OldPrice = 15000,
                NewPrice = 13000,
                OnlineImage = "",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });

            //food
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = " Broasted",
                Descripation = "Taza, hot, delicious",
                OldPrice = 250000,
                NewPrice = 200000,
                OnlineImage = "https://i.ibb.co/HPdCsJk/image.jpg",
                Expiration = new DateTime(2024, 9, 9),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = " Shawrama",
                Descripation = "Taza, hot, delicious",
                OldPrice = 200000,
                NewPrice = 175000,
                OnlineImage = "https://i.ibb.co/RvpbMr3/8a13a1a95c8f094fe07b6e8c218fb6c2.jpg",
                Expiration = new DateTime(2024, 9, 8),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = " Grilled Chicken",
                Descripation = "Taza, hot, delicious",
                OldPrice = 25000,
                NewPrice = 20000,
                OnlineImage = "https://i.ibb.co/f1k26g7/png-transparent-roast-chicken-barbecue-chicken-roasting-chicken-meat-roast-chicken-food-animals-baki.png",
                Expiration = new DateTime(2024, 9, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = " Nugget",
                Descripation = "Taza, hot, delicious",
                OldPrice = 75000,
                NewPrice = 50000,
                OnlineImage = "https://i.ibb.co/BgtCXnq/Nuggets.gif",
                Expiration = new DateTime(2024, 9, 2),
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = " pizza ",
                Descripation = "Taza, hot, delicious",
                OldPrice = 250000,
                NewPrice = 200000,
                OnlineImage = "https://i.ibb.co/YQXBmKb/66951-7.jpg",
                Expiration = new DateTime(2024, 9, 9),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 24,
                Name = " salmey pizza",
                Descripation = "Taza, hot, delicious",
                OldPrice = 200000,
                NewPrice = 175000,
                OnlineImage = "https://i.ibb.co/qrfSxXs/Q2-HGj-Nd-Babm7-S2n-FA.jpg",
                Expiration = new DateTime(2024, 9, 8),
                IsExpiration = false,
            });
            //tecno
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 25,
                Name = " Smart washing machine",
                Descripation = "Everything about the world of electronics",
                OldPrice = 75000,
                NewPrice = 50000,
                OnlineImage = "https://i.ibb.co/Bcg2rCQ/ae-ar-WF1702-WEU-XSG-001-Front-624-624-PNG.png",
                Expiration = new DateTime(2024, 9, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 26,
                Name = " Camera",
                Descripation = "Everything about the world of electronics",
                OldPrice = 150000,
                NewPrice = 130000,
                OnlineImage = "https://i.ibb.co/W3Wvh7k/2d257668b46d3cd5be228192fd02876f-fmt-pjpeg-res-Mode-bisharp-wid-354.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 27,
                Name = " Mobile",
                Descripation = "Everything about the world of electronics",
                OldPrice = 20000,
                NewPrice = 175000,
                OnlineImage = "https://i.ibb.co/BVY7rPz/eg-galaxy-s24-s928-sm-s928bztcmea-thumb-539296161-344-344-PNG.png",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 28,
                Name = " smart watch",
                Descripation = "Everything about the world of electronics",
                OldPrice = 150000,
                NewPrice = 130000,
                OnlineImage = "https://i.ibb.co/VqCwH1C/61tp47u-ZRl-L-AC-UF1000-1000-QL80.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 29,
                Name = "tap",
                Descripation = "Everything about the world of electronics",
                OldPrice = 30000,
                NewPrice = 25000,
                OnlineImage = "https://i.ibb.co/YhFVJvr/716o8-NCsj-DL-AC-UF894-1000-QL80.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 30,
                Name = "refrigerator",
                Descripation = "Everything about the world of electronics",
                OldPrice = 255000,
                NewPrice = 230000,
                OnlineImage = "https://i.ibb.co/0qv7MX7/toshiba-refrigerator-no-frost-11-feet-silver-gr-ef31-s.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });


            //parfan
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 31,
                Name = " Chanel No.5",
                Descripation = " Floral Perfumes",
                OldPrice = 150000,
                NewPrice = 130000,
                OnlineImage = "https://i.ibb.co/cCZZdrz/coco-mademoiselle-eau-de-parfum-intense-spray-3-4fl-oz-packshot-default-116660-9539148283934.png",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 32,
                Name = " Tommy Hilfiger for Men ",
                Descripation = "Oriental perfumes",
                OldPrice = 20000,
                NewPrice = 175000,
                OnlineImage = "https://i.ibb.co/QKvKKCw/91-D0-TXi2or-L.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 33,
                Name = " Giorgio Armani",
                Descripation = "Woody Perfumes",
                OldPrice = 150000,
                NewPrice = 130000,
                OnlineImage = "https://i.ibb.co/k38SvS0/517wv-Qgc-H0-L-AC-UF1000-1000-QL80.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 34,
                Name = " Dolce & Gabbana Light Blue",
                Descripation = "Citrus Perfumes",
                OldPrice = 30000,
                NewPrice = 25000,
                OnlineImage = "https://i.ibb.co/8P2b254/miswag-Yf-M4c-AYMy-G4-U.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 35,
                Name = "Bvlgari Black",
                Descripation = "Amber Perfumes",
                OldPrice = 255000,
                NewPrice = 230000,
                OnlineImage = "https://i.ibb.co/X2Jhj99/Espcuc-FNv-Rg-Mn-Zucl-JFIeyq-LZ3adeu-D6-NPq-UTr44.png",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 36,
                Name = " 212",
                Descripation = "Citrus Perfumes",
                OldPrice = 30000,
                NewPrice = 25000,
                OnlineImage = "https://i.ibb.co/fCbqJ6Q/sg-Ai-Uj-PU5-RORz-Cf-PAj-QVd-K9spq-QL92cj-Q4-S5-ODmo.jpg",
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });


            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 1,
                Amount = 10,
                CompanyId = 1,
                ProductId = 1
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 2,
                Amount = 10,
                CompanyId = 1,
                ProductId = 2
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 3,
                Amount = 10,
                CompanyId = 1,
                ProductId = 3
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 4,
                Amount = 10,
                CompanyId = 2,
                ProductId = 4
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 5,
                Amount = 10,
                CompanyId = 2,
                ProductId = 5
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 6,
                Amount = 10,
                CompanyId = 2,
                ProductId = 6
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 7,
                Amount = 10,
                CompanyId = 3,
                ProductId = 7
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 8,
                Amount = 10,
                CompanyId = 3,
                ProductId = 8
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 9,
                Amount = 10,
                CompanyId = 3,
                ProductId = 9
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 10,
                Amount = 10,
                CompanyId = 4,
                ProductId = 10
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 11,
                Amount = 10,
                CompanyId = 4,
                ProductId = 11
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 12,
                Amount = 10,
                CompanyId = 4,
                ProductId = 12
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 13,
                Amount = 10,
                CompanyId = 5,
                ProductId = 13
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 14,
                Amount = 10,
                CompanyId = 5,
                ProductId = 14
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 15,
                Amount = 10,
                CompanyId = 5,
                ProductId = 15
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 16,
                Amount = 10,
                CompanyId = 6,
                ProductId = 16
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 17,
                Amount = 10,
                CompanyId = 6,
                ProductId = 17
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 18,
            Amount = 10,
                CompanyId = 6,
                ProductId = 18
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 19,
                Amount = 10,
                CompanyId = 7,
                ProductId = 19
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 20,
                Amount = 10,
                CompanyId = 7,
                ProductId = 20
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 21,
                Amount = 10,
                CompanyId = 7,
                ProductId = 21
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 22,
                Amount = 10,
                CompanyId = 8,
                ProductId = 22
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 23,
                Amount = 10,
                CompanyId = 8,
                ProductId = 23
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 24,
                Amount = 10,
                CompanyId = 8,
                ProductId = 24
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 25,
                Amount = 10,
                CompanyId = 9,
                ProductId = 25
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 26,
                Amount = 10,
                CompanyId = 9,
                ProductId = 26
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 27,
                Amount = 10,
                CompanyId = 9,
                ProductId = 27
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 28,
                Amount = 10,
                CompanyId = 10,
                ProductId = 28
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 29,
                Amount = 10,
                CompanyId = 10,
                ProductId = 29
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 30,
                Amount = 10,
                CompanyId = 10,
                ProductId = 30
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 31,
                Amount = 10,
                CompanyId = 11,
                ProductId = 31
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 32,
                Amount = 11,
                CompanyId = 11,
                ProductId = 32
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 33,
                Amount = 10,
                CompanyId = 11,
                ProductId = 33
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 34,
                Amount = 10,
                CompanyId = 12,
                ProductId = 34
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 35,
                Amount = 10,
                CompanyId = 12,
                ProductId = 35
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 36,
                Amount = 10,
                CompanyId = 12,
                ProductId = 36
            });

            modelBuilder.Entity<Donation>().HasData(new Donation { Id = 1, CharityId = 1, OrderTypeId = 3,  PricePay = 20000, });
            modelBuilder.Entity<Donation>().HasData(new Donation { Id = 2, CharityId = 2, OrderTypeId = 2,  PricePay = 18000, });
            modelBuilder.Entity<Donation>().HasData(new Donation { Id = 3, CharityId = 4, OrderTypeId = 2,  PricePay = 11000, });
            modelBuilder.Entity<Donation>().HasData(new Donation { Id = 4, CharityId = 2, OrderTypeId = 3,  PricePay = 10000, });


            modelBuilder.Entity<Order>().HasData(new Order { Id = 1, Name = "Order 1", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Amount = 10, Price = 20000, IsDelivery = true,  UserId = 1, });
            modelBuilder.Entity<Order>().HasData(new Order { Id = 2, Name = "Order 2", Descripation = "The order was placed at 2:50 and will expire after a quarter of an hour from this time", Amount = 5, Price = 18520, IsDelivery = false, UserId = 2, });
            modelBuilder.Entity<Order>().HasData(new Order { Id = 3, Name = "Order 3", Descripation = "The order was placed at 4:40 and will expire after a quarter of an hour from this time", Amount = 6, Price = 75312, IsDelivery = true,  UserId = 3, });
            modelBuilder.Entity<Order>().HasData(new Order { Id = 4, Name = "Order 4", Descripation = "The order was placed at 3:20 and will expire after a quarter of an hour from this time", Amount = 4, Price = 12457, IsDelivery = true,  UserId = 3, });
            modelBuilder.Entity<Order>().HasData(new Order { Id = 5, Name = "Order 5", Descripation = "The order was placed at 1:15 and will expire after a quarter of an hour from this time", Amount = 2, Price = 45632, IsDelivery = false,  UserId = 2, });


            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 1, CompanyProductId = 4, OrderId = 3, Amount = 5, TotalPrice = 11000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 2, CompanyProductId = 3, OrderId = 5, Amount = 4, TotalPrice = 120000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 3, CompanyProductId = 1, OrderId = 1, Amount = 9, TotalPrice = 480000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 4, CompanyProductId = 2, OrderId = 4, Amount = 100, TotalPrice = 500000, });


            modelBuilder.Entity<OrderStatus>().HasData(new OrderStatus { Id = 1, status = 1, DateTime = DateTime.Now });
            modelBuilder.Entity<OrderStatus>().HasData(new OrderStatus { Id = 2, status = 2, DateTime = DateTime.Now });
            modelBuilder.Entity<OrderStatus>().HasData(new OrderStatus { Id = 3, status = 3, DateTime = DateTime.Now });
            modelBuilder.Entity<OrderStatus>().HasData(new OrderStatus { Id = 4, status = 4, DateTime = DateTime.Now });

            modelBuilder.Entity<Bill>().HasData(new Bill { Id = 10, OrderProductId = 4, Note = "  Welcom to you", OrderStatusId = 1 });
            modelBuilder.Entity<Bill>().HasData(new Bill { Id = 21, OrderProductId = 2, Note = " Welcom to you", OrderStatusId = 1 });
            modelBuilder.Entity<Bill>().HasData(new Bill { Id = 22, OrderProductId = 2, Note = " Welcom to you", OrderStatusId = 2 });
            modelBuilder.Entity<Bill>().HasData(new Bill { Id = 23, OrderProductId = 1, Note = " Welcom to you", OrderStatusId = 1 });
            modelBuilder.Entity<Bill>().HasData(new Bill { Id = 24, OrderProductId = 3, Note = " Welcom to you", OrderStatusId = 1 });

            modelBuilder.Entity<Rate>().HasData(new Rate { Id = 2, RateNumber = 3, Description = "Middle", });
            modelBuilder.Entity<Rate>().HasData(new Rate { Id = 3, RateNumber = 4, Description = "Good", });
            modelBuilder.Entity<Rate>().HasData(new Rate { Id = 4, RateNumber = 5, Description = "Very Good", });
            modelBuilder.Entity<Rate>().HasData(new Rate { Id = 5, RateNumber = 7, Description = "Super", });

            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 30, SubscriptionId = 1, RateId = 4, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 31, SubscriptionId = 1, RateId = 5, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 32, SubscriptionId = 2, RateId = 2, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 33, SubscriptionId = 3, RateId = 3, });

            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 1, PayMethodId = 1, CompanyId = 1 });
            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 2, PayMethodId = 3, CompanyId = 2 });
            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 3, PayMethodId = 2, CompanyId = 3 });
            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 4, PayMethodId = 1, CompanyId = 4 });
            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 5, PayMethodId = 3, CompanyId = 5 });

            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods
            {
                Id = 6,
                PayMethodId = 2,
                CompanyId = 6
            });

            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 7, PayMethodId = 2, CompanyId = 7 });


            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 8, PayMethodId = 1, CompanyId = 9 });


            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 9, PayMethodId = 1, CompanyId = 9 });


            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 10, PayMethodId = 2, CompanyId = 10 });


            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 11, PayMethodId = 3, CompanyId = 11 });


            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 12, PayMethodId = 2, CompanyId = 12 });


            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 13, PayMethodId = 1, CompanyId = 7 });


            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 14, PayMethodId = 3, CompanyId = 9 });

            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 15, PayMethodId = 3, CompanyId = 11 });

            modelBuilder.Entity<CompanyMethods>().HasData(new CompanyMethods { Id = 16, PayMethodId = 1, CompanyId = 4 });

            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 1, DonationId = 1, CompanyProductId = 1, Amount = 1, TotalPrice = 60000 });
            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 2, DonationId = 2, CompanyProductId = 2, Amount = 3, TotalPrice = 70000 });
            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 3, DonationId = 3, CompanyProductId = 7, Amount = 2, TotalPrice = 70000 });
            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 4, DonationId = 4, CompanyProductId = 5, Amount = 3, TotalPrice = 70000 });
            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 5, DonationId = 1, CompanyProductId = 11, Amount = 3, TotalPrice = 90000 });

            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 6, DonationId = 2, CompanyProductId = 15, Amount = 4, TotalPrice = 70000 });


            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 7, DonationId = 3, CompanyProductId = 17, Amount = 9, TotalPrice = 679000 });


            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 8, DonationId = 3, CompanyProductId = 20, Amount = 8, TotalPrice = 98700 });


            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 9, DonationId = 3, CompanyProductId = 29, Amount = 1, TotalPrice = 7000 });


            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 10, DonationId = 4, CompanyProductId = 33, Amount = 4, TotalPrice = 70000 });

            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 11, DonationId = 2, CompanyProductId = 31, Amount = 1, TotalPrice = 101000 });

            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 12, DonationId = 2, CompanyProductId = 34, Amount = 1, TotalPrice = 70000 });


            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 13, DonationId = 3, CompanyProductId = 22, Amount = 2, TotalPrice = 97000 });

            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 14, DonationId = 1, CompanyProductId = 26, Amount = 3, TotalPrice = 120000 });


            modelBuilder.Entity<ProductDonation>().HasData(new ProductDonation { Id = 15, DonationId = 1, CompanyProductId = 19, Amount = 1, TotalPrice = 70000 });

        }
    }
}
