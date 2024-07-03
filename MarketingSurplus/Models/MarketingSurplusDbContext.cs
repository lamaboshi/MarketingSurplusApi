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

          
            modelBuilder.Entity<Company>().HasData(new Company { Id = 1, CompanyTypeId = 1, Name = "Ultra Medica", Description = "As in 1955, when Ultra Medica started its ascent in the world of pharmaceutical industry in Syria (Sednaya) founded with emphasis activities and enthusiasm for the manufacturing and developing of life science industry", Address = "From Streat", Email = "UltraMedica@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 2, CompanyTypeId = 1, Name = "New pharma", Description = "Newpharma is een online apotheek, een uitbreiding van een echte apotheek, gevestigd in België. We spreken ook van internet apotheek of e-apotheek.", Address = "From Streat", Email = "newpharma@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 3, CompanyTypeId = 1, Name = "Asia pharmacy", Description = "Asia Pharmacy is an Electrical and Electronic Manufacturing company located in 1035 S Federal Blvd Ste B, Denver, Colorado, United States.", Address = "From Streat", Email = "MAYBELLINE@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "34345" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 4, CompanyTypeId = 1, Name = "Medico ", Description = "Our pharmacist and trained assistants are available for advice on all medicines and minor ailments. We can also give you advice on how to live a healthier life and can direct you to a range of other resources if needed.", Address = "From Streat", Email = "LOREAL@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "23234", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 5, CompanyTypeId = 1, Name = "Mediathek", Description = "APOTHEKE ADHOC Webinar: Praxisrelevantes Wissen für das gesamte Apothekenteam zu brandaktuellen Fachthemen rund um Indikation, Beratung, Rezeptur und vieles mehr.", Address = "From Streat", Email = "SEPHORA@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "45456", LicenseNumber = "242523" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 6, CompanyTypeId = 2, Name = "ASIC", Description = "Asics sponsors a variety of sports associations", Address = "From Streat", Email = "Asics@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 7, CompanyTypeId = 2, Name = "ADDIDAS", Description = "Manufacturer of sports shoes and apparel. It was the largest sportswear manufacturer in Europe and the second largest after Nike in the world. Adidas products are traditionally distinguished by a three-line brand, which remains an element of the company's latest products", Address = "From Streat", Email = "ADDIDAS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 8, CompanyTypeId = 2, Name = "NIKE", Description = "The world’s largest athletic apparel company, Nike is best known for its footwear, apparel, and equipment. One of the most valuable brands among sport businesses,The company sponsors top athletes and sports teams around the world.", Address = "From Streat", Email = "NIKE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "78789", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 9, CompanyTypeId = 2, Name = "PUMA", Description = "Puma, is a German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories, which is headquartered in Herzogenaurach, Bavaria, Germany. Puma is the third largest sportswear manufacturer in the world", Address = "From Streat", Email = "PUMA@test.com", Phone = "0921423432", TelePhone = "223554", Password = "67678", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 10, CompanyTypeId = 2, Name = "REEBOK", Description = "Asics sponsors a variety of sports associations", Address = "Reebok International Limited (/ˈriːbɒk/) is an American fitness footwear and clothing manufacturer that is a part of Authentic Brands Group.", Email = "REEBOK@test.com", Phone = "0921423432", TelePhone = "223554", Password = "8989", LicenseNumber = "242523" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 11, CompanyTypeId = 3, Name = "ZARA", Description = "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", Address = "From Streat", Email = "ZARA@test.com", Phone = "0921423432", TelePhone = "223554", Password = "0909", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 12, CompanyTypeId = 3, Name = "MAX", Description = "Max Fashion is an Indian fashion brand under the banner of the Landmark Group in Dubai", Address = "From Streat", Email = "MAX@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 13, CompanyTypeId = 3, Name = "MONCLER", Description = "It is an Italian luxury fashion house specializing in ready-to-wear and haute couture, headquartered in Milan, Italy. Expanded to design raincoats, windbreakers, knitwear, leather goods, shoes, perfume, and accessories", Address = "From Streat", Email = "MONCLER@test.com", Phone = "0921423432", TelePhone = "223554", Password = "6789", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 14, CompanyTypeId = 3, Name = "LACOSTE", Description = "Lacoste S.A. is a French company. It sells clothing, footwear, sportswear, eyewear, leather goods, perfume, towels and watches", Address = "From Streat", Email = "LACOSTE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 15, CompanyTypeId = 3, Name = "BENETTON", Description = "It is one of the most famous fashion companies in the world. The group enjoys a unified identity consisting of colours, authentic fashion and quality at democratic prices", Address = "From Streat", Email = "BENETTON@test.com", Phone = "0921423432", TelePhone = "223554", Password = "9463", LicenseNumber = "242523" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 16, CompanyTypeId = 4, Name = "KFC", Description = "Kentucky Fried Chicken or KFC is a chain of fast food restaurants that specializes primarily in fried chicken.  It is the second largest chain of fast food restaurants in the world in terms of sales after McDonald's. Kentucky Fried Chicken has nearly twenty thousand branches spread over 123 countries and territories around the world.", Address = "Louisville, KentuckyFrom Streat", Email = "KFC@test.com", Phone = "0921423432", TelePhone = "223554", Password = "5252", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 17, CompanyTypeId = 4, Name = "MCDONALDS", Description = "MCDONALD'S is the world's largest restaurant chain by revenue,McDonald's is best known for its hamburgers, cheeseburgers and french fries, although their menus include other items like chicken, fish, fruit, and salads", Address = "From Streat", Email = "MCDONALDS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "99999", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 18, CompanyTypeId = 4, Name = "NESTLE", Description = "Nestlé is a multinational company specializing in the production of canned foods, founded in Vevey, Switzerland.", Address = "From Streat", Email = "NESTLE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 19, CompanyTypeId = 4, Name = "STARBUCKS", Description = "STARBUCKS is a specialty coffee retailer. It roasts, markets, and retails specialty coffee. The company, through its stores, offers several blends of coffee, handcrafted beverages, merchandise, and food items", Address = "From Streat", Email = "STARBUCKS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "123122", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 20, CompanyTypeId = 4, Name = "PIZZA HUT", Description = "Pizza Hut is an American multinational restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. They serve their signature pan pizza and other dishes including pasta, breadsticks and desserts.", Address = "From Streat", Email = "PIZZAHUT@test.com", Phone = "0921423432", TelePhone = "223554", Password = "34345", LicenseNumber = "242523" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 21, CompanyTypeId = 5, Name = "SAMSUNG", Description = " Samsung Electronics is the world's largest electronics and information technology company.  Samsung Electronics is part of the Samsung Group, which is the largest conglomerate in South Korea and the global market leader with more than 60 products including semiconductors such as DRAM and flash memory, digital display devices such as liquid crystal TVs  LCD and plasma, consumer electronics such as DVD players, mobile phones, digital cameras and laser printers, household appliances such as refrigerators, microwaves and dishwashers.", Address = "Suwon, South Korea", Email = "SAMSUNG@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 22, CompanyTypeId = 5, Name = "APPLE", Description = "The Apple Corporation is an American multinational technology company specializing in consumer electronics, software and online services.  It is one of the top five American IT companies", Address = "Cupertino, California, United States", Email = "APPLE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "77666", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 23, CompanyTypeId = 5, Name = "LG", Description = "The Korean LG Group this company is the second largest holding company, producing electronics, chemicals and telecommunications products.  from 80 countries", Address = "South Korea", Email = "LG@test.com", Phone = "0921423432", TelePhone = "223554", Password = "989887", LicenseNumber = "242523" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 24, CompanyTypeId = 6, Name = "NETFLIX", Description = "Netflix is   an American entertainment company that specializes in providing live broadcasting, video-on-demand, and mail-delivery of CDs. Netflix has expanded into the production of films and television shows, and online video distribution", LicenseNumber = "242523", Address = " Los Gatos, California", Email = "NETFLIX@test.com", Phone = "0921423432", TelePhone = "223554", Password = "34567" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 25, CompanyTypeId = 6, Name = "SHAHID", Description = "Shahid is the first Arab platform to provide \"Video on Demand\" service in the Middle East, and it has been re-launched by the \"MBC\" media group.  It is worth noting that Shahid,the leading subscription video-on-demand platform, is considered the leading Arab broadcasting platform in the world and the home of original Arabic productions with world-class specifications.along with a live broadcast of a group of the most watched Arab TV channels", Address = "From Streat", LicenseNumber = "242523", Email = "SHAHID@test.com", Phone = "0921423432", TelePhone = "223554", Password = "888877" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 26, CompanyTypeId = 7, Name = "DIOR", Description = "DIOR Products Clothing, cosmetics, fashion accessories, jewelry, perfumes, watches", Address = "From Streat", Email = "DIOR@test.com", Phone = "0921423432", TelePhone = "223554", Password = "777776", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 27, CompanyTypeId = 7, Name = "CHANNEL", Description = "Chanel Its products cover clothes, fragrances, handbags and watches", Address = "From Streat", Email = "CHANNEL@test.com", Phone = "0921423432", TelePhone = "223554", Password = "333333", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 28, CompanyTypeId = 7, Name = "GUCCI", Description = "Gucci offers a range of different luxury  Shoes, ready-to-wear apparel, watches, and jewelry are the other main , however they also sell other products such as perfume and home decor", LicenseNumber = "242523", Address = "From Streat", Email = "Gucci@test.com", Phone = "0921423432", TelePhone = "223554", Password = "8888882" });


            modelBuilder.Entity<User>().HasData(new User { Id = 1, Email = "lama@test.com", Name = "Lama Boshi", UserName = "Lamaz", Phone = "0964654765", Age = 20, Password = "121", PayPal = "Lb1267",isAccept=true });
            modelBuilder.Entity<User>().HasData(new User { Id = 2, Email = "Hamzeh@test.com", Name = "Hamze Badinjky", UserName = "hamzehS", Phone = "0964654765", Age = 20, Password = "141", PayPal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 3, Email = "Adam@test.com", Name = "Adam Syria", UserName = "Adom", Phone = "0964654765", Age = 20, Password = "161", PayPal = "Lb1267" });


            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 1, TypeName = "Medicines", Description = "All About Medicines", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 2, TypeName = "Sports", Description = "All About sports", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 3, TypeName = "Clothes", Description = "All About Clothes", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 4, TypeName = "Food", Description = "All About Food", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 5, TypeName = "Electronics", Description = "All About electronics", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 6, TypeName = "Platforms", Description = "All About Movies & Series", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 7, TypeName = "Perfumes", Description = "All About Perfumes", });



            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 1, CompanyId = 1, UserId = 1, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 2, CompanyId = 2, UserId = 1, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 3, CompanyId = 2, UserId = 3, });

            modelBuilder.Entity<OrderType>().HasData(new OrderType { Id = 1, Name = "Normal", });
            modelBuilder.Entity<OrderType>().HasData(new OrderType { Id = 2, Name = "Donation", });
            modelBuilder.Entity<OrderType>().HasData(new OrderType { Id = 3, Name = "Charity Organization", });

            modelBuilder.Entity<PayMethod>().HasData(new PayMethod { Id = 1, Name = "Cash Pay", });
            modelBuilder.Entity<PayMethod>().HasData(new PayMethod { Id = 2, Name = "PayPal", });
            modelBuilder.Entity<PayMethod>().HasData(new PayMethod { Id = 3, Name = "Credit Card", });



            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 1, Name = "Al-Ihsan", Phone = "0215789147", Address = "Al Hamadanieh", Email = "Al-Ihsan@test.com", Password = "Al-Ihsan789", Goals = "childern", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 2, Name = "Hand By Hand", Phone = "0215117894", Address = "Al mohafaza", Email = "Hand-By-Hand@test.com", Password = "Hand-By-Hand456", Goals = "Old Pepole", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 3, Name = "Al-Noor", Phone = "021524895 ", Address = "Mohamad Fares Street", Email = "Al-Noor@test.com", Password = "Al-Noor123", Goals = "childern", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 4, Name = "George", Phone = "0215115827", Address = "Al Azizeh", Email = "George@test.com", Password = "George147", Goals = "childern", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 5, Name = "Namaa", Phone = "02151174369", Address = "Al Marterni", Email = "Namaa@test.com", Password = "Namaa369", Goals = "childern", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });

            modelBuilder.Entity<Product>().HasData(new Product { Id = 1, Name = "Rice", Descripation = "Each wrapped bag contains one kilo of good quality Egyptian rice", OldPrice=20000,NewPrice = 15000, Expiration = new DateTime(2025, 2, 2), IsExpiration = false, });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 2, Name = "Broasted Chicken", Descripation = "The weight of each raw chicken ranges between 1.7 kg and 2.2 kg. The meat is halal.", OldPrice=30000,NewPrice = 21000, Expiration = new DateTime(2024, 2, 5), IsExpiration = false, });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 3, Name = "Paracetamol", Descripation = "Each paracetamol tablet contains 500 mg of acetamol, which reduces fever and relieves pain.", OldPrice=70000,NewPrice = 50000, Expiration = new DateTime(2025, 8, 8), IsExpiration = false, });

            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct { Id = 1, Amount = 4, CompanyId = 16, ProductId = 1 });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct { Id = 2, Amount = 2, CompanyId = 17, ProductId = 1 });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct { Id = 3, Amount = 10, CompanyId = 1, ProductId = 3 });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct { Id = 4, Amount = 2, CompanyId = 18, ProductId = 2 });

            modelBuilder.Entity<Donation>().HasData(new Donation { Id = 1, CharityId = 1, OrderTypeId = 3, CompanyProductId = 2, PricePay = 20000, });
            modelBuilder.Entity<Donation>().HasData(new Donation { Id = 2, CharityId = 2, OrderTypeId = 2, CompanyProductId = 1, PricePay = 18000, });
            modelBuilder.Entity<Donation>().HasData(new Donation { Id = 3, CharityId = 4, OrderTypeId = 2, CompanyProductId = 3, PricePay = 11000, });
            modelBuilder.Entity<Donation>().HasData(new Donation { Id = 4, CharityId = 2, OrderTypeId = 3, CompanyProductId = 3, PricePay = 10000, });

            modelBuilder.Entity<Order>().HasData(new Order { Id = 1, Name = "Order 1", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Amount = 10, Price = 20000, IsDelivery = true, PayMethodId = 1, UserId = 1, });
            modelBuilder.Entity<Order>().HasData(new Order { Id = 2, Name = "Order 2", Descripation = "The order was placed at 2:50 and will expire after a quarter of an hour from this time", Amount = 5, Price = 18520, IsDelivery = false, PayMethodId = 1, UserId = 2, });
            modelBuilder.Entity<Order>().HasData(new Order { Id = 3, Name = "Order 3", Descripation = "The order was placed at 4:40 and will expire after a quarter of an hour from this time", Amount = 6, Price = 75312, IsDelivery = true, PayMethodId = 2, UserId = 3, });
            modelBuilder.Entity<Order>().HasData(new Order { Id = 4, Name = "Order 4", Descripation = "The order was placed at 3:20 and will expire after a quarter of an hour from this time", Amount = 4, Price = 12457, IsDelivery = true, PayMethodId = 2, UserId = 3, });
            modelBuilder.Entity<Order>().HasData(new Order { Id = 5, Name = "Order 5", Descripation = "The order was placed at 1:15 and will expire after a quarter of an hour from this time", Amount = 2, Price = 45632, IsDelivery = false, PayMethodId = 3, UserId = 2, });


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



        }
    }
}
