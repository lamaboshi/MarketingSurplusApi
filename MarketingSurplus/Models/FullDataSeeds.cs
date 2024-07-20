using Microsoft.EntityFrameworkCore;

namespace MarketingSurplus.Models
{
    public static class FullDataSeeds
    {

        public static void callFullData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 1, TypeName = "Medicines", Description = "All About Medicines", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 2, TypeName = "Sports", Description = "All About sports", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 3, TypeName = "Clothes", Description = "All About Clothes", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 4, TypeName = "Food", Description = "All About Food", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 5, TypeName = "Electronics", Description = "All About electronics", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 6, TypeName = "Platforms", Description = "All About Movies & Series", });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 7, TypeName = "Perfumes", Description = "All About Perfumes", });
            //comany table
            modelBuilder.Entity<Company>().HasData(new Company { Id = 1, CompanyTypeId = 1, Name = "Ultra Medica", Description = "As in 1955, when Ultra Medica started its ascent in the world of pharmaceutical industry in Syria (Sednaya) founded with emphasis activities and enthusiasm for the manufacturing and developing of life science industry", Address = "From Streat", Email = "UltraMedica@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 2, CompanyTypeId = 1, Name = "New pharma", Description = "Newpharma is een online apotheek, een uitbreiding van een echte apotheek, gevestigd in België. We spreken ook van internet apotheek of e-apotheek.", Address = "From Streat", Email = "newpharma@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 3, CompanyTypeId = 1, Name = "Asia pharmacy", Description = "Asia Pharmacy is an Electrical and Electronic Manufacturing company located in 1035 S Federal Blvd Ste B, Denver, Colorado, United States.", Address = "From Streat", Email = "MAYBELLINE@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "34345" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 4, CompanyTypeId = 1, Name = "Medico ", Description = "Our pharmacist and trained assistants are available for advice on all medicines and minor ailments. We can also give you advice on how to live a healthier life and can direct you to a range of other resources if needed.", Address = "From Streat", Email = "LOREAL@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "23234", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 5, CompanyTypeId = 1, Name = "Mediathek", Description = "APOTHEKE ADHOC Webinar: Praxisrelevantes Wissen für das gesamte Apothekenteam zu brandaktuellen Fachthemen rund um Indikation, Beratung, Rezeptur und vieles mehr.", Address = "From Streat", Email = "SEPHORA@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "45456", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 6,
                CompanyTypeId = 1,
                Name = "Novartis",
                Description = "",
                Address = "Switzerland",
                Email = "Novartis@test.com",
                Phone = "0931421402",
                TelePhone = "223845",
                Password = "1999",
                LicenseNumber = "223845"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 7,
                CompanyTypeId = 1,
                Name = "Pfizer",
                Description = "",
                Address = "Manhatten",
                Email = "Pfizer@test.com",
                Phone = "0991421402",
                TelePhone = "523845",
                Password = "1994",
                LicenseNumber = "523845"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 8,
                CompanyTypeId = 1,
                Name = "Galxo Smith Klein ",
                Description = "",
                Address = "London",
                Email = "Galxo@test.com",
                Phone = "0991496402",
                TelePhone = "525645",
                Password = "1995",
                LicenseNumber = "525645"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 9,
                CompanyTypeId = 1,
                Name = "Sanofi",
                Description = "",
                Address = "Paris",
                Email = "Sanofi@test.com",
                Phone = "0945921402",
                TelePhone = "589605",
                Password = "1996",
                LicenseNumber = "589605"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 10,
                CompanyTypeId = 1,
                Name = "Merck",
                Description = "",
                Address = "Canada",
                Email = "Merck@test.com",
                Phone = "0997350402",
                TelePhone = "523045",
                Password = "1997",
                LicenseNumber = "523045"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 11,
                CompanyTypeId = 1,
                Name = "Procter & Gamble",
                Description = "",
                Address = "USA",
                Email = "PG@test.com",
                Phone = "0991473402",
                TelePhone = "573245",
                Password = "1998",
                LicenseNumber = "573245"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 12,
                CompanyTypeId = 1,
                Name = "Ivax",
                Description = "",
                Address = "Egypt",
                Email = "Ivax@test.com",
                Phone = "0995114402",
                TelePhone = "527851",
                Password = "1991",
                LicenseNumber = "527851"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 13,
                CompanyTypeId = 1,
                Name = "Eva Pharma",
                Description = "",
                Address = "Egypt",
                Email = "Eva@test.com",
                Phone = "0997531402",
                TelePhone = "523715",
                Password = "1989",
                LicenseNumber = "523715"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 14,
                CompanyTypeId = 1,
                Name = "Johnson & Johnson",
                Description = "",
                Address = "Manhatten",
                Email = "jj@test.com",
                Phone = "0991895402",
                TelePhone = "596845",
                Password = "1969",
                LicenseNumber = "596845"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 15,
                CompanyTypeId = 1,
                Name = "Himalaya",
                Description = "",
                Address = "Bengaluru",
                Email = "Himalaya@test.com",
                Phone = "0485621402",
                TelePhone = "127845",
                Password = "1979",
                LicenseNumber = "127845"
            });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 16, CompanyTypeId = 2, Name = "ASIC", Description = "Asics sponsors a variety of sports associations", Address = "From Streat", Email = "Asics@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 17, CompanyTypeId = 2, Name = "ADDIDAS", Description = "Manufacturer of sports shoes and apparel. It was the largest sportswear manufacturer in Europe and the second largest after Nike in the world. Adidas products are traditionally distinguished by a three-line brand, which remains an element of the company's latest products", Address = "From Streat", Email = "ADDIDAS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 18, CompanyTypeId = 2, Name = "NIKE", Description = "The world’s largest athletic apparel company, Nike is best known for its footwear, apparel, and equipment. One of the most valuable brands among sport businesses,The company sponsors top athletes and sports teams around the world.", Address = "From Streat", Email = "NIKE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "78789", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 19, CompanyTypeId = 2, Name = "PUMA", Description = "Puma, is a German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories, which is headquartered in Herzogenaurach, Bavaria, Germany. Puma is the third largest sportswear manufacturer in the world", Address = "From Streat", Email = "PUMA@test.com", Phone = "0921423432", TelePhone = "223554", Password = "67678", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 20, CompanyTypeId = 2, Name = "REEBOK", Description = "Asics sponsors a variety of sports associations", Address = "Reebok International Limited (/ˈriːbɒk/) is an American fitness footwear and clothing manufacturer that is a part of Authentic Brands Group.", Email = "REEBOK@test.com", Phone = "0921423432", TelePhone = "223554", Password = "8989", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 21, CompanyTypeId = 2, Name = "Under Aarmour", Description = "", Address = "From Aleppo", Email = "UnderAarmour@test.com", Phone = "0924443432", TelePhone = "227574", Password = "111002", LicenseNumber = "240023" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 22, CompanyTypeId = 2, Name = "New Balance", Description = "", Address = "From Hama", Email = "NewBalance@test.com", Phone = "0924443433", TelePhone = "2275745", Password = "101002", LicenseNumber = "440023" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 23, CompanyTypeId = 2, Name = "Salomon", Description = "", Address = "From Homs", Email = "Salomon@test.com", Phone = "0934443433", TelePhone = "2375745", Password = "101003", LicenseNumber = "440123" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 24, CompanyTypeId = 2, Name = "Fila", Description = "", Address = "From tourkyia", Email = "Fila@test.com", Phone = "0931423432", TelePhone = "223054", Password = "199999222", LicenseNumber = "242593" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 25, CompanyTypeId = 2, Name = "Lacoste", Description = "", Address = "From latacia", Email = "Lacoste@test.com", Phone = "0931423402", TelePhone = "223045", Password = "199999222@@", LicenseNumber = "242513" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 26, CompanyTypeId = 2, Name = "Umbro", Description = "", Address = "From chaina", Email = "Umbro@test.com", Phone = "0948423402", TelePhone = "229045", Password = "199999222@*@", LicenseNumber = "242519" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 27, CompanyTypeId = 2, Name = "kappa", Description = "", Address = "From Amaan", Email = "kappa@test.com", Phone = "0948434402", TelePhone = "229745", Password = "199999222&*@", LicenseNumber = "242919" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 28, CompanyTypeId = 2, Name = "Diadora", Description = "", Address = "From Aleppo", Email = "Diadora@test.com", Phone = "0948434442", TelePhone = "229645", Password = "199999222&_@", LicenseNumber = "242999" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 29, CompanyTypeId = 2, Name = "Hummel", Description = "", Address = "From Hama", Email = "Hummel@test.com", Phone = "0948435552", TelePhone = "227745", Password = "199888222&_@", LicenseNumber = "249999" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 30, CompanyTypeId = 2, Name = "Mizuno", Description = "", Address = "From Syria", Email = "Mizuno@test.com", Phone = "0948835552", TelePhone = "224445", Password = "199888222&__@", LicenseNumber = "299999" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 31, CompanyTypeId = 3, Name = "ZARA", Description = "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", Address = "From Streat", Email = "ZARA@test.com", Phone = "0921423432", TelePhone = "223554", Password = "0909", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 32, CompanyTypeId = 3, Name = "MAX", Description = "Max Fashion is an Indian fashion brand under the banner of the Landmark Group in Dubai", Address = "From Streat", Email = "MAX@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 33, CompanyTypeId = 3, Name = "MONCLER", Description = "It is an Italian luxury fashion house specializing in ready-to-wear and haute couture, headquartered in Milan, Italy. Expanded to design raincoats, windbreakers, knitwear, leather goods, shoes, perfume, and accessories", Address = "From Streat", Email = "MONCLER@test.com", Phone = "0921423432", TelePhone = "223554", Password = "6789", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 34, CompanyTypeId = 3, Name = "LACOSTE", Description = "Lacoste S.A. is a French company. It sells clothing, footwear, sportswear, eyewear, leather goods, perfume, towels and watches", Address = "From Streat", Email = "LACOSTE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 35, CompanyTypeId = 3, Name = "BENETTON", Description = "It is one of the most famous fashion companies in the world. The group enjoys a unified identity consisting of colours, authentic fashion and quality at democratic prices", Address = "From Streat", Email = "BENETTON@test.com", Phone = "0921423432", TelePhone = "223554", Password = "9463", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 36, CompanyTypeId = 3, Name = "Balenciaga", Description = "", Address = "From chaina", Email = "Balenciaga@test.com", Phone = "09668388852", TelePhone = "233365", Password = "1998863333__+", LicenseNumber = "296339" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 37, CompanyTypeId = 3, Name = "Versace", Description = "", Address = "From chaina", Email = "Versace@test.com", Phone = "09668388812", TelePhone = "211365", Password = "19988611133__+", LicenseNumber = "296139" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 38, CompanyTypeId = 3, Name = "Prada", Description = "", Address = "From chaina", Email = "Prada@test.com", Phone = "09228388812", TelePhone = "211325", Password = "199886122223__+", LicenseNumber = "222239" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 39, CompanyTypeId = 3, Name = "Burberry", Description = "", Address = "From chaina", Email = "Burberry@test.com", Phone = "092283558332", TelePhone = "235325", Password = "199886533223__+", LicenseNumber = "225339" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 40, CompanyTypeId = 3, Name = "Valentino", Description = "", Address = "From chaina", Email = "Valentino@test.com", Phone = "0922835532", TelePhone = "285325", Password = "19988ii33223__+", LicenseNumber = "220339" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 41, CompanyTypeId = 3, Name = "Fendi", Description = "", Address = "From chaina", Email = "Fendi@test.com", Phone = "0921135532", TelePhone = "281125", Password = "19988ii31123__+", LicenseNumber = "221339" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 42, CompanyTypeId = 3, Name = "Armani", Description = "", Address = "From chaina", Email = "Armani@test.com", Phone = "0926135532", TelePhone = "286125", Password = "1998866&31123__+", LicenseNumber = "221369" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 43, CompanyTypeId = 3, Name = "Hariri", Description = "", Address = "From Syria", Email = "Hariri@test.com", Phone = "0926135532", TelePhone = "28612385", Password = "1998386&31123__+", LicenseNumber = "223869" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 44, CompanyTypeId = 3, Name = "Shadows", Description = "", Address = "From Syria", Email = "Shadowis@test.com", Phone = "0926139032", TelePhone = "28690385", Password = "1998389031123__+", LicenseNumber = "229069" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 45, CompanyTypeId = 3, Name = "Sabaya", Description = "", Address = "From chaina", Email = "Sabaya@test.com", Phone = "09228355812", TelePhone = "255325", Password = "199886555223__+", LicenseNumber = "225539" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 46, CompanyTypeId = 4, Name = "KFC", Description = "Kentucky Fried Chicken or KFC is a chain of fast food restaurants that specializes primarily in fried chicken.  It is the second largest chain of fast food restaurants in the world in terms of sales after McDonald's. Kentucky Fried Chicken has nearly twenty thousand branches spread over 123 countries and territories around the world.", Address = "Louisville, KentuckyFrom Streat", Email = "KFC@test.com", Phone = "0921423432", TelePhone = "223554", Password = "5252", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 47, CompanyTypeId = 4, Name = "MCDONALDS", Description = "MCDONALD'S is the world's largest restaurant chain by revenue,McDonald's is best known for its hamburgers, cheeseburgers and french fries, although their menus include other items like chicken, fish, fruit, and salads", Address = "From Streat", Email = "MCDONALDS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "99999", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 48, CompanyTypeId = 4, Name = "NESTLE", Description = "Nestlé is a multinational company specializing in the production of canned foods, founded in Vevey, Switzerland.", Address = "From Streat", Email = "NESTLE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 49, CompanyTypeId = 4, Name = "STARBUCKS", Description = "STARBUCKS is a specialty coffee retailer. It roasts, markets, and retails specialty coffee. The company, through its stores, offers several blends of coffee, handcrafted beverages, merchandise, and food items", Address = "From Streat", Email = "STARBUCKS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "123122", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 50, CompanyTypeId = 4, Name = "PIZZA HUT", Description = "Pizza Hut is an American multinational restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. They serve their signature pan pizza and other dishes including pasta, breadsticks and desserts.", Address = "From Streat", Email = "PIZZAHUT@test.com", Phone = "0921423432", TelePhone = "223554", Password = "34345", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 51,
                CompanyTypeId = 4,
                Name = "Burger King",
                Description = "",
                Address = "Miami",
                Email = "Burger_King@test.com",
                Phone = "092825432",
                TelePhone = "27854",
                Password = "5253",
                LicenseNumber = "27854"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 52,
                CompanyTypeId = 4,
                Name = "Giant Eagle Supermarket",
                Description = "",
                Address = "Miami",
                Email = "GES@test.com",
                Phone = "009625432",
                TelePhone = "27874",
                Password = "5257",
                LicenseNumber = "27874"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 53,
                CompanyTypeId = 4,
                Name = "Chilis Grill & Bar",
                Description = "",
                Address = "USA",
                Email = "CGB@test.com",
                Phone = "000055432",
                TelePhone = "27884",
                Password = "571",
                LicenseNumber = "27884"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 54,
                CompanyTypeId = 4,
                Name = "Domino's Pizza",
                Description = "",
                Address = "Arber",
                Email = "DP@test.com",
                Phone = "00908732",
                TelePhone = "21054",
                Password = "5053",
                LicenseNumber = "21054"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 55,
                CompanyTypeId = 4,
                Name = "Applebee's",
                Description = "",
                Address = "Miami",
                Email = "Applebee@test.com",
                Phone = "007010432",
                TelePhone = "21854",
                Password = "5283",
                LicenseNumber = "21854"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 56,
                CompanyTypeId = 4,
                Name = "Hardee's",
                Description = "",
                Address = "India",
                Email = "Hardee@test.com",
                Phone = "90007432",
                TelePhone = "17354",
                Password = "1743",
                LicenseNumber = "17354"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 57,
                CompanyTypeId = 4,
                Name = "Olive Garden",
                Description = "",
                Address = "Switzerland",
                Email = "Olive_Garden@test.com",
                Phone = "800025432",
                TelePhone = "24054",
                Password = "0001",
                LicenseNumber = "24054"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 58,
                CompanyTypeId = 4,
                Name = "Ice Bee",
                Description = "",
                Address = "Miami",
                Email = "Ice_b@test.com",
                Phone = "0860825432",
                TelePhone = "08054",
                Password = "5008",
                LicenseNumber = "08054"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 59,
                CompanyTypeId = 4,
                Name = "Hafiz Moustafa",
                Description = "",
                Address = "Turkey",
                Email = "Hafiz_Moustafa@test.com",
                Phone = "00825432",
                TelePhone = "02454",
                Password = "4256",
                LicenseNumber = "02454"
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 60,
                CompanyTypeId = 4,
                Name = "Salora",
                Description = "",
                Address = "Syria",
                Email = "Salora@test.com",
                Phone = "090000432",
                TelePhone = "10004",
                Password = "0789",
                LicenseNumber = "10004"
            });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 61, CompanyTypeId = 5, Name = "SAMSUNG", Description = " Samsung Electronics is the world's largest electronics and information technology company.  Samsung Electronics is part of the Samsung Group, which is the largest conglomerate in South Korea and the global market leader with more than 60 products including semiconductors such as DRAM and flash memory, digital display devices such as liquid crystal TVs  LCD and plasma, consumer electronics such as DVD players, mobile phones, digital cameras and laser printers, household appliances such as refrigerators, microwaves and dishwashers.", Address = "Suwon, South Korea", Email = "SAMSUNG@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 62, CompanyTypeId = 5, Name = "APPLE", Description = "The Apple Corporation is an American multinational technology company specializing in consumer electronics, software and online services.  It is one of the top five American IT companies", Address = "Cupertino, California, United States", Email = "APPLE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "77666", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 63, CompanyTypeId = 5, Name = "LG", Description = "The Korean LG Group this company is the second largest holding company, producing electronics, chemicals and telecommunications products.  from 80 countries", Address = "South Korea", Email = "LG@test.com", Phone = "0921423432", TelePhone = "223554", Password = "989887", LicenseNumber = "242523" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 64, CompanyTypeId = 5, Name = "Sony", Description = "", Address = "From Aoroba", Email = "Sony@test.com", Phone = "0966743432", TelePhone = "227774", Password = "77gg1002", LicenseNumber = "290023" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 65, CompanyTypeId = 5, Name = "Huawei", Description = "", Address = "From Aoroba", Email = "Huawei@test.com", Phone = "0962743432", TelePhone = "222774", Password = "77g2g1002", LicenseNumber = "220023" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 66, CompanyTypeId = 5, Name = "Lenovo", Description = "", Address = "From Aoroba", Email = "Lenovo@test.com", Phone = "0969043432", TelePhone = "229074", Password = "77g2g901002", LicenseNumber = "289023" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 67, CompanyTypeId = 5, Name = "Xiaomi", Description = "", Address = "From Aoroba", Email = "Xiaomi@test.com", Phone = "0968743432", TelePhone = "222874", Password = "77g2g871002", LicenseNumber = "287023" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 68, CompanyTypeId = 5, Name = "HP", Description = "", Address = "From Aoroba", Email = "HP@test.com", Phone = "0968843432", TelePhone = "222888", Password = "77g88871002", LicenseNumber = "288823" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 69, CompanyTypeId = 5, Name = "Dell", Description = "", Address = "From Aoroba", Email = "Dell@test.com", Phone = "0908843432", TelePhone = "220888", Password = "77g88801002", LicenseNumber = "288023" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 70, CompanyTypeId = 5, Name = "panasonic", Description = "", Address = "From Aoroba", Email = "panasonic@test.com", Phone = "0908843412", TelePhone = "220188", Password = "77g88801102", LicenseNumber = "281023" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 71, CompanyTypeId = 5, Name = "Tashiba", Description = "", Address = "From chaina", Email = "Tashiba@test.com", Phone = "0908844412", TelePhone = "244188", Password = "77g88801,,02", LicenseNumber = "244023" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 72, CompanyTypeId = 5, Name = "philips", Description = "", Address = "From chaina", Email = "philips@test.com", Phone = "0978844412", TelePhone = "244888", Password = "77g48801,,02", LicenseNumber = "244843" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 73, CompanyTypeId = 5, Name = "ASUS", Description = "", Address = "From chaina", Email = "ASUS@test.com", Phone = "0968844412", TelePhone = "241688", Password = "77g481601,,02", LicenseNumber = "262843" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 74, CompanyTypeId = 5, Name = "Acer", Description = "", Address = "From chaina", Email = "Acer@test.com", Phone = "0943844412", TelePhone = "431688", Password = "77g4816014302", LicenseNumber = "264343" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 75, CompanyTypeId = 5, Name = "OnePlus", Description = "", Address = "From chaina", Email = "OnePlus@test.com", Phone = "0968844222", TelePhone = "230688", Password = "77g4816090,02", LicenseNumber = "220843" });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 76,
                CompanyTypeId = 7,
                Name = "Prada",
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
                Id = 77,
                CompanyTypeId = 7,
                Name = "Calvin Klein",
                Description = "",
                Address = "Germany",
                Email = "Calvin_Klein@test.com",
                Phone = "002100572",
                TelePhone = "203010",
                Password = "87000",
                LicenseNumber = "203010",
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 78,
                CompanyTypeId = 7,
                Name = "Dolce & Gabbana",
                Description = "Switzerland",
                Address = "From Streat",
                Email = "D_G@test.com",
                Phone = "002104892",
                TelePhone = "20440",
                Password = "87480",
                LicenseNumber = "20440",
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 79,
                CompanyTypeId = 7,
                Name = "Versace",
                Description = "",
                Address = "USA",
                Email = "Versace@test.com",
                Phone = "002000572",
                TelePhone = "233310",
                Password = "87850",
                LicenseNumber = "233310",
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 80,
                CompanyTypeId = 7,
                Name = "Armani",
                Description = "",
                Address = "India",
                Email = "Armani@test.com",
                Phone = "002889572",
                TelePhone = "55510",
                Password = "89570",
                LicenseNumber = "55510",
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 81,
                CompanyTypeId = 7,
                Name = "Yves Saint Laurent",
                Description = "",
                Address = "Sweden",
                Email = "YSL@test.com",
                Phone = "0099999572",
                TelePhone = "99990",
                Password = "87850",
                LicenseNumber = "99990",
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 82,
                CompanyTypeId = 7,
                Name = "Tom Ford",
                Description = "",
                Address = "Miami",
                Email = "Tom_Ford@test.com",
                Phone = "005300572",
                TelePhone = "101010",
                Password = "89870",
                LicenseNumber = "101010",
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 83,
                CompanyTypeId = 7,
                Name = "Bvlgari",
                Description = "",
                Address = "India",
                Email = "Bvlgari@test.com",
                Phone = "009990572",
                TelePhone = "21510",
                Password = "87700",
                LicenseNumber = "21510",
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 84,
                CompanyTypeId = 7,
                Name = "Burberry",
                Description = "",
                Address = "Germany",
                Email = "Burberry@test.com",
                Phone = "991050572",
                TelePhone = "211110",
                Password = "87111",
                LicenseNumber = "211110",
            });
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 85,
                CompanyTypeId = 7,
                Name = "Marc Jacobs",
                Description = "",
                Address = "Germany",
                Email = "Marc_Jacobs@test.com",
                Phone = "991470572",
                TelePhone = "212210",
                Password = "88881",
                LicenseNumber = "212210",
            });
            //user table
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Email = "lama@test.com",
                Name = "Lama Boshi",
                UserName = "Lama Boshi",
                Phone = "0964654765",
                Age = 20,
                Password = "121",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                Email = "Hamzeh@test.com",
                Name = "Hamze Badinjky",
                UserName = "Hamze Badinjky",
                Phone = "0964654765",
                Age = 20,
                Password = "141",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 3,
                Email = "Adam@test.com",
                Name = "Adam alahmad",
                UserName = "Adam alahmad",
                Phone = "0964654765",
                Age = 20,
                Password = "161",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 4,
                Email = "tasneem@test.com",
                Name = "tasneem abo mresh",
                UserName = "tasneem abo mresh",
                Phone = "0965474093",
                Age = 23,
                Password = "111",
                PayPal = "Lb1260"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 5,
                Email = "ghazal@test.com",
                Name = "Ghazal tabakha",
                UserName = "Ghazal tabakha",
                Phone = "09606631",
                Age = 20,
                Password = "162",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 6,
                Email = "mohamad@test.com",
                Name = "mohamad dagher",
                UserName = "mohamad dagher",
                Phone = "0964654765",
                Age = 20,
                Password = "163",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 7,
                Email = "sedra@test.com",
                Name = "sedra alhoda",
                UserName = "sedra alhoda",
                Phone = "0964654765",
                Age = 30,
                Password = "164",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 8,
                Email = "nadia@test.com",
                Name = "nadia mahmoud",
                UserName = "nadia mahmoud",
                Phone = "0964654765",
                Age = 40,
                Password = "165",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 9,
                Email = "majed@test.com",
                Name = "majed alyhia",
                UserName = "majed alyhia",
                Phone = "0964654765",
                Age = 50,
                Password = "166",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 10,
                Email = "esmail@test.com",
                Name = "esmail awad",
                UserName = "esmail awad",
                Phone = "0964654765",
                Age = 25,
                Password = "167",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 11,
                Email = "hasan@test.com",
                Name = "hasan alhasan",
                UserName = "hasan alhasan",
                Phone = "0964654765",
                Age = 33,
                Password = "168",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 12,
                Email = "karim@test.com",
                Name = "karim souda",
                UserName = "karim souda",
                Phone = "0964654765",
                Age = 19,
                Password = "169",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 13,
                Email = "basel@test.com",
                Name = "basel khanawati",
                UserName = "basel khanawati",
                Phone = "0964654765",
                Age = 20,
                Password = "170",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 14,
                Email = "elham@test.com",
                Name = "elham alabeed",
                UserName = "elham alabeed",
                Phone = "0964654765",
                Age = 22,
                Password = "171",
                PayPal = "Lb1267"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 15,
                Email = "khadija@test.com",
                Name = "khadija al taha",
                UserName = "khadija al taha",
                Phone = "0964654765",
                Age = 20,
                Password = "1172",
                PayPal = "Lb1267"
            });
            //product table

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Newclomiphene",
                Descripation = "Clomiphene is used to treat some cases of infertility in women",
                OldPrice = 15000,
                NewPrice = 13000,
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
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Newamlodipine",
                Descripation = "A combination medicine to control high blood pressure",
                OldPrice = 21000,
                NewPrice = 20000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Newpenicillin",
                Descripation = "Treats bacterial infections",
                OldPrice = 11000,
                NewPrice = 11500,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Newxyline",
                Descripation = "Treats bacterial infections",
                OldPrice = 1000,
                NewPrice = 6000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Newpentozole",
                Descripation = "Reduces stomach acidity",
                OldPrice = 9000,
                NewPrice = 7500,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = " Asealol",
                Descripation = "It is used to treat mild to moderate pain",
                NewPrice = 13000,
                OldPrice = 10000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Asiacillin",
                Descripation = "Antipsychotic, treatment for schizophrenia",
                OldPrice = 20000,
                NewPrice = 19000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Aceparoxate",
                Descripation = "Treats some types of cancer",
                OldPrice = 17000,
                NewPrice = 13000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Acetaminophen",
                Descripation = "It is used to relieve pain and reduce fever",
                OldPrice = 30000,
                NewPrice = 26000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Acetaloperam",
                Descripation = "Antidepressant",
                OldPrice = 33000,
                NewPrice = 31000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Aceprofen",
                Descripation = "It is used as an analgesic, anti-inflammatory and antipyretic",
                OldPrice = 10000,
                NewPrice = 9000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Acesalicylic acid",
                Descripation = "It is used to treat dandruff, psoriasis, pigmentation and acne",
                OldPrice = 21000,
                NewPrice = 19000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Acerophyte",
                Descripation = "It stabilizes bone calcium",
                OldPrice = 11000,
                NewPrice = 10000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Acerutin",
                Descripation = "Antidepressant",
                OldPrice = 10000,
                NewPrice = 7500,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Selektine",
                Descripation = "For the treatment of degenerative arthritis and pain reliever",
                OldPrice = 9000,
                NewPrice = 8000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Carbogel",
                Descripation = "Helps relieve dry eyes",
                NewPrice = 5000,
                OldPrice = 2000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Levo Act",
                Descripation = "Alleviating the symptoms of acute sinusitis",
                OldPrice = 20000,
                NewPrice = 17000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Mozory",
                Descripation = "For temporary relief of upper respiratory symptoms",
                OldPrice = 15300,
                NewPrice = 13000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 24,
                Name = "Trafables",
                Descripation = "Diuretic and helps control blood pressure",
                OldPrice = 30000,
                NewPrice = 28000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 25,
                Name = "Alekton",
                Descripation = "It is used to treat high blood pressure",
                OldPrice = 33000,
                NewPrice = 30000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 26,
                Name = "Ultramol Cold",
                Descripation = "Pain reliever and fever reducer",
                OldPrice = 10000,
                NewPrice = 6000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 27,
                Name = "Beta fren",
                Descripation = "Ibuprofen pills inhibit prostaglandins by inhibiting the enzymes responsible for their production",
                OldPrice = 21000,
                NewPrice = 20000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 28,
                Name = "Sibal",
                Descripation = "For migraine prevention, symptomatic treatment of vestibular vertigo.",
                OldPrice = 11000,
                NewPrice = 9000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 29,
                Name = "Fulmed Plus",
                Descripation = "To treat anemia ",
                OldPrice = 10000,
                NewPrice = 7500,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 30,
                Name = "Decavitamin",
                Descripation = "General vitamins for the body",
                OldPrice = 9000,
                NewPrice = 8500,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 31,
                Name = "Sodamide",
                Descripation = "It helps eliminate fluids and lower blood pressure.",
                NewPrice = 25000,
                OldPrice = 22000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 32,
                Name = "Exozide",
                Descripation = "antibiotic",
                OldPrice = 20000,
                NewPrice = 17500,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 33,
                Name = "Deslerg",
                Descripation = "Antihistamine",
                OldPrice = 19500,
                NewPrice = 13000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 34,
                Name = "Andelol",
                Descripation = "To treat some types of heart diseases",
                OldPrice = 30000,
                NewPrice = 29000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 35,
                Name = "Mediosetron",
                Descripation = "It is used in cases of asthma and allergies",
                OldPrice = 33000,
                NewPrice = 32000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 36,
                Name = "Heallo slva",
                Descripation = "Helps treat skin ulcers",
                OldPrice = 40000,
                NewPrice = 36000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 37,
                Name = "Tamimid",
                Descripation = "Helps treat viral influenza",
                OldPrice = 11000,
                NewPrice = 10000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 38,
                Name = "Toblerikit",
                Descripation = "Treats cough",
                OldPrice = 11000,
                NewPrice = 10000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 39,
                Name = "Zarevan",
                Descripation = "To reduce the risk of stroke",
                OldPrice = 14000,
                NewPrice = 7500,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 40,
                Name = "Abili",
                Descripation = "To treat some mental and mood conditions",
                OldPrice = 9000,
                NewPrice = 8500,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 41,
                Name = "Aclasta",
                Descripation = "It is used in cases of osteoporosis",
                NewPrice = 25000,
                OldPrice = 23000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 42,
                Name = "Adelphan Acidrex",
                Descripation = "It is used in cases of high blood pressure",
                OldPrice = 30000,
                NewPrice = 26000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 43,
                Name = "Zooters",
                Descripation = "To prevent graft rejection of various types of cancer",
                OldPrice = 19500,
                NewPrice = 17000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 44,
                Name = "amturned",
                Descripation = "It is used in cases of high blood pressure",
                OldPrice = 30000,
                NewPrice = 27000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 45,
                Name = "Anafranil",
                Descripation = "It is used in cases of depressive disorder",
                OldPrice = 37000,
                NewPrice = 32000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 46,
                Name = "Arcta Nohlis",
                Descripation = "It is used in chronic obstructive pulmonary disease",
                OldPrice = 42000,
                NewPrice = 39000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 47,
                Name = "Brinaldex",
                Descripation = "It is used in cases of high blood pressure",
                OldPrice = 19000,
                NewPrice = 17000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 48,
                Name = "Clozaril",
                Descripation = "It is used for patients with schizophrenia",
                OldPrice = 11600,
                NewPrice = 10000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 49,
                Name = "Co Diovan",
                Descripation = "It is used in cases of high blood pressure",
                OldPrice = 16000,
                NewPrice = 15000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 50,
                Name = "Quartime",
                Descripation = "malaria",
                OldPrice = 9000,
                NewPrice = 6000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 51,
                Name = "Anfranil",
                Descripation = "Antidepressant",
                NewPrice = 25000,
                OldPrice = 23000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 52,
                Name = "Apramycin",
                Descripation = "Aminosic alcohol antibiotic",
                OldPrice = 30000,
                NewPrice = 26000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 53,
                Name = "Apilumab",
                Descripation = "Aminosic alcohol antibiotic",
                OldPrice = 19500,
                NewPrice = 17000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 54,
                Name = "Atorvastatin",
                Descripation = "One of the medications from a group of medications called statins, which works to reduce cholesterol production by inhibiting the action of an enzyme in the liver responsible for its production.",
                OldPrice = 30000,
                NewPrice = 27000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 55,
                Name = "Adrafinil",
                Descripation = "Nootropic",
                OldPrice = 37000,
                NewPrice = 32000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 56,
                Name = "Azithromycin",
                Descripation = "antibiotic",
                OldPrice = 42000,
                NewPrice = 39000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 57,
                Name = "Avanafil",
                Descripation = "antibiotic",
                OldPrice = 19000,
                NewPrice = 17000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 58,
                Name = "Insextin",
                Descripation = "Treating depression",
                OldPrice = 11600,
                NewPrice = 10000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 59,
                Name = "Alprazolam",
                Descripation = "It is used to treat moderate to severe anxiety disorders and panic attacks",
                OldPrice = 16000,
                NewPrice = 15000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 60,
                Name = "devomet",
                Descripation = "Antiemetic",
                OldPrice = 9000,
                NewPrice = 6000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 61,
                Name = "panadol",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 15000,
                NewPrice = 13000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 62,
                Name = "Amoxil",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 13000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 63,
                Name = "Vivatinen",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 10000,
                NewPrice = 1000,
                Expiration = new DateTime(2025, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 64,
                Name = "Lamictal",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 65,
                Name = "Seroxat",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 5, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 66,
                Name = "Zantac",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 12000,
                Expiration = new DateTime(2026, 5, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 67,
                Name = "Valtrex",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 20000,
                NewPrice = 18000,
                Expiration = new DateTime(2028, 5, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 68,
                Name = "Arvinda",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 21000,
                NewPrice = 18000,
                Expiration = new DateTime(2028, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 69,
                Name = "Retrovir",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 31000,
                NewPrice = 23000,
                Expiration = new DateTime(2027, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 70,
                Name = "Abrex",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 31000,
                NewPrice = 23000,
                Expiration = new DateTime(2027, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 71,
                Name = "Ambral",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 15000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 72,
                Name = "Lantus",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 13000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 73,
                Name = "plavix",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 10000,
                NewPrice = 1000,
                Expiration = new DateTime(2025, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 74,
                Name = "Inioval",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 75,
                Name = "Lovenox",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 5, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 76,
                Name = "Privelar",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 12000,
                Expiration = new DateTime(2026, 5, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 77,
                Name = "Optifor",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 20000,
                NewPrice = 18000,
                Expiration = new DateTime(2028, 5, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 78,
                Name = "Medroxysin",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 21000,
                NewPrice = 18000,
                Expiration = new DateTime(2028, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 79,
                Name = "Activil",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 31000,
                NewPrice = 23000,
                Expiration = new DateTime(2027, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 80,
                Name = "Neoparin",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 31000,
                NewPrice = 23000,
                Expiration = new DateTime(2027, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 81,
                Name = "Gardasil",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 15000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 82,
                Name = "Fosamax",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 13000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 83,
                Name = "Singulair",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 10000,
                NewPrice = 1000,
                Expiration = new DateTime(2025, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 84,
                Name = "lvix",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 85,
                Name = "Zetia",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 5, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 86,
                Name = "Imervid",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 12000,
                Expiration = new DateTime(2026, 5, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 87,
                Name = "Provoxal",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 20000,
                NewPrice = 18000,
                Expiration = new DateTime(2028, 5, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 88,
                Name = "Rebatol",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 21000,
                NewPrice = 18000,
                Expiration = new DateTime(2028, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 89,
                Name = "Vivera",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 31000,
                NewPrice = 23000,
                Expiration = new DateTime(2027, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 90,
                Name = "Primarin",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 31000,
                NewPrice = 23000,
                Expiration = new DateTime(2027, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 91,
                Name = "Restazin",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 15000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 92,
                Name = "Fosamax",
                Descripation = " Pain reliever,antipyretic,antiemetic, and widely used antibiotic",
                OldPrice = 13000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 93,
                Name = "Clinnex",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 10000,
                NewPrice = 1000,
                Expiration = new DateTime(2025, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 94,
                Name = "Septovil",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 95,
                Name = "Heptazin",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 5, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 96,
                Name = "profilax",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 12000,
                Expiration = new DateTime(2026, 5, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 97,
                Name = "Activilo",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 20000,
                NewPrice = 18000,
                Expiration = new DateTime(2028, 5, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 98,
                Name = "Heliofarm",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 21000,
                NewPrice = 18000,
                Expiration = new DateTime(2028, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 99,
                Name = "Modovine",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 31000,
                NewPrice = 23000,
                Expiration = new DateTime(2027, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 100,
                Name = "Invital",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 31000,
                NewPrice = 23000,
                Expiration = new DateTime(2027, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 101,
                Name = "Evax Max",
                Descripation = " Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 15000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 102,
                Name = "Evax flu",
                Descripation = " Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 13000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 103,
                Name = "Evax sync",
                Descripation = " Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 10000,
                NewPrice = 1000,
                Expiration = new DateTime(2025, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 104,
                Name = "Eva care",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 105,
                Name = "Eva Med",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 5, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 106,
                Name = "Ultrafin",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 12000,
                Expiration = new DateTime(2026, 5, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 107,
                Name = "Infinet",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 20000,
                NewPrice = 18000,
                Expiration = new DateTime(2028, 5, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 108,
                Name = "Hypertan",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 21000,
                NewPrice = 18000,
                Expiration = new DateTime(2028, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 109,
                Name = "Levitas",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 31000,
                NewPrice = 23000,
                Expiration = new DateTime(2027, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 110,
                Name = "Megacor",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 31000,
                NewPrice = 23000,
                Expiration = new DateTime(2027, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 111,
                Name = "Restazin",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 15000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 112,
                Name = "Vitafort",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 13000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 113,
                Name = "Heptazin",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 10000,
                NewPrice = 1000,
                Expiration = new DateTime(2025, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 114,
                Name = "Profilax",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 115,
                Name = "Modovine",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 5, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 116,
                Name = "Ambrien",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 12000,
                Expiration = new DateTime(2026, 5, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 117,
                Name = "Blanchet",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 20000,
                NewPrice = 18000,
                Expiration = new DateTime(2028, 5, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 118,
                Name = "Evice",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 21000,
                NewPrice = 18000,
                Expiration = new DateTime(2028, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 119,
                Name = "Gallix",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 31000,
                NewPrice = 23000,
                Expiration = new DateTime(2027, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 120,
                Name = "Lucerin",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 31000,
                NewPrice = 23000,
                Expiration = new DateTime(2027, 6, 5),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 121,
                Name = "Tivacor",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 15000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 122,
                Name = "Tivaprin",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 13000,
                NewPrice = 12000,
                Expiration = new DateTime(2025, 3, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 123,
                Name = "Tivaxin",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 10000,
                NewPrice = 1000,
                Expiration = new DateTime(2025, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 124,
                Name = "Tivasol",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 125,
                Name = "Tivamid",
                Descripation = "Pain reliever, antipyretic, antiemetic, and widely used antibiotic",
                OldPrice = 19000,
                NewPrice = 15000,
                Expiration = new DateTime(2026, 3, 7),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 126,
                Name = " Bloues",
                Descripation = "Free Size",
                OldPrice = 150000,
                NewPrice = 130000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 127,
                Name = " pants",
                Descripation = "Free Size",
                OldPrice = 155000,
                NewPrice = 135000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 128,
                Name = " Shorts",
                Descripation = "Comfortable cotton",
                OldPrice = 75000,
                NewPrice = 50000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 129,
                Name = " Spedrin",
                Descripation = "Size 33",
                OldPrice = 15000,
                NewPrice = 13000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 130,
                Name = " Sportswear",
                Descripation = "",
                OldPrice = 15000,
                NewPrice = 13000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 131,
                Name = " Dress",
                Descripation = "Free Size",
                OldPrice = 150000,
                NewPrice = 130000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 132,
                Name = " jeans",
                Descripation = "mam jeans",
                OldPrice = 155000,
                NewPrice = 135000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 133,
                Name = " Straw hat",
                Descripation = "for sea",
                OldPrice = 75000,
                NewPrice = 50000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 134,
                Name = " Scurbina",
                Descripation = "Size 37",
                OldPrice = 15000,
                NewPrice = 13000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 135,
                Name = " Wedding Suit",
                Descripation = "Color off white",
                OldPrice = 15000,
                NewPrice = 13000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 136,
                Name = " Broasted",
                Descripation = "Taza, hot, delicious",
                OldPrice = 250000,
                NewPrice = 200000,
                Expiration = new DateTime(2024, 9, 9),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 137,
                Name = " Shawrama",
                Descripation = "Taza, hot, delicious",
                OldPrice = 200000,
                NewPrice = 175000,
                Expiration = new DateTime(2024, 9, 8),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 138,
                Name = " Grilled Chicken",
                Descripation = "Taza, hot, delicious",
                OldPrice = 25000,
                NewPrice = 20000,
                Expiration = new DateTime(2024, 9, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 139,
                Name = " Nugget",
                Descripation = "Taza, hot, delicious",
                OldPrice = 75000,
                NewPrice = 50000,
                Expiration = new DateTime(2024, 9, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 140,
                Name = " LG",
                Descripation = "Everything about the world of electronics",
                OldPrice = 75000,
                NewPrice = 50000,
                Expiration = new DateTime(2024, 9, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 141,
                Name = " Sony",
                Descripation = "Everything about the world of electronics",
                OldPrice = 150000,
                NewPrice = 130000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 142,
                Name = " Sumsung",
                Descripation = "Everything about the world of electronics",
                OldPrice = 20000,
                NewPrice = 175000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 143,
                Name = " Huawei",
                Descripation = "Everything about the world of electronics",
                OldPrice = 150000,
                NewPrice = 130000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 144,
                Name = "Lenovo",
                Descripation = "Everything about the world of electronics",
                OldPrice = 30000,
                NewPrice = 25000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 145,
                Name = "Toshiba",
                Descripation = "Everything about the world of electronics",
                OldPrice = 255000,
                NewPrice = 230000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 146,
                Name = " Chanel No.5",
                Descripation = " Floral Perfumes",
                OldPrice = 150000,
                NewPrice = 130000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 147,
                Name = " Tommy Hilfiger for Men ",
                Descripation = "Oriental perfumes",
                OldPrice = 20000,
                NewPrice = 175000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 148,
                Name = " Giorgio Armani",
                Descripation = "Woody Perfumes",
                OldPrice = 150000,
                NewPrice = 130000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 149,
                Name = " Dolce & Gabbana Light Blue",
                Descripation = "Citrus Perfumes",
                OldPrice = 30000,
                NewPrice = 25000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 150,
                Name = "Bvlgari Black",
                Descripation = "Amber Perfumes",
                OldPrice = 255000,
                NewPrice = 230000,
                Expiration = new DateTime(2025, 2, 2),
                IsExpiration = false,
            });
            //companyproduct table

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
                CompanyId = 1,
                ProductId = 4
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 5,
                Amount = 10,
                CompanyId = 1,
                ProductId = 5
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 6,
                Amount = 10,
                CompanyId = 1,
                ProductId = 6
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 7,
                Amount = 10,
                CompanyId = 1,
                ProductId = 7
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 8,
                Amount = 10,
                CompanyId = 1,
                ProductId = 8
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 9,
                Amount = 10,
                CompanyId = 1,
                ProductId = 9
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 10,
                Amount = 10,
                CompanyId = 1,
                ProductId = 10
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 11,
                Amount = 10,
                CompanyId = 2,
                ProductId = 11
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 12,
                Amount = 10,
                CompanyId = 2,
                ProductId = 12
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 13,
                Amount = 10,
                CompanyId = 2,
                ProductId = 13
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 14,
                Amount = 10,
                CompanyId = 2,
                ProductId = 14
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 15,
                Amount = 10,
                CompanyId = 2,
                ProductId = 15
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 16,
                Amount = 10,
                CompanyId = 2,
                ProductId = 16
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 17,
                Amount = 10,
                CompanyId = 2,
                ProductId = 17
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 18,
                Amount = 10,
                CompanyId = 2,
                ProductId = 18
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 19,
                Amount = 10,
                CompanyId = 2,
                ProductId = 19
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 20,
                Amount = 10,
                CompanyId = 2,
                ProductId = 20
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 21,
                Amount = 10,
                CompanyId = 3,
                ProductId = 21
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 22,
                Amount = 10,
                CompanyId = 3,
                ProductId = 22
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 23,
                Amount = 10,
                CompanyId = 3,
                ProductId = 23
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 24,
                Amount = 10,
                CompanyId = 3,
                ProductId = 24
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 25,
                Amount = 10,
                CompanyId = 3,
                ProductId = 25
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 26,
                Amount = 10,
                CompanyId = 3,
                ProductId = 26
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 27,
                Amount = 10,
                CompanyId = 3,
                ProductId = 27
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 28,
                Amount = 10,
                CompanyId = 3,
                ProductId = 28
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 29,
                Amount = 10,
                CompanyId = 3,
                ProductId = 29
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 30,
                Amount = 10,
                CompanyId = 3,
                ProductId = 30
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 31,
                Amount = 10,
                CompanyId = 4,
                ProductId = 31
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 32,
                Amount = 10,
                CompanyId = 4,
                ProductId = 32
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 33,
                Amount = 10,
                CompanyId = 4,
                ProductId = 33
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 34,
                Amount = 10,
                CompanyId = 4,
                ProductId = 34
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 35,
                Amount = 10,
                CompanyId = 4,
                ProductId = 35
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 36,
                Amount = 10,
                CompanyId = 4,
                ProductId = 36
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 37,
                Amount = 10,
                CompanyId = 4,
                ProductId = 37
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 38,
                Amount = 10,
                CompanyId = 4,
                ProductId = 38
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 39,
                Amount = 10,
                CompanyId = 4,
                ProductId = 39
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 40,
                Amount = 10,
                CompanyId = 4,
                ProductId = 40
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 41,
                Amount = 10,
                CompanyId = 5,
                ProductId = 41
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 42,
                Amount = 10,
                CompanyId = 5,
                ProductId = 42
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 43,
                Amount = 10,
                CompanyId = 5,
                ProductId = 43
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 44,
                Amount = 10,
                CompanyId = 5,
                ProductId = 44
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 45,
                Amount = 10,
                CompanyId = 5,
                ProductId = 45
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 46,
                Amount = 10,
                CompanyId = 5,
                ProductId = 46
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 47,
                Amount = 10,
                CompanyId = 5,
                ProductId = 47
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 48,
                Amount = 10,
                CompanyId = 5,
                ProductId = 48
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 49,
                Amount = 10,
                CompanyId = 5,
                ProductId = 49
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 50,
                Amount = 10,
                CompanyId = 5,
                ProductId = 50
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 51,
                Amount = 10,
                CompanyId = 6,
                ProductId = 51
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 52,
                Amount = 10,
                CompanyId = 6,
                ProductId = 52
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 53,
                Amount = 10,
                CompanyId = 6,
                ProductId = 53
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 54,
                Amount = 10,
                CompanyId = 6,
                ProductId = 54
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 55,
                Amount = 10,
                CompanyId = 6,
                ProductId = 55
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 56,
                Amount = 10,
                CompanyId = 6,
                ProductId = 56
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 57,
                Amount = 10,
                CompanyId = 6,
                ProductId = 57
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 58,
                Amount = 10,
                CompanyId = 6,
                ProductId = 58
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 59,
                Amount = 10,
                CompanyId = 6,
                ProductId = 59
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 60,
                Amount = 10,
                CompanyId = 6,
                ProductId = 60
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 61,
                Amount = 10,
                CompanyId = 7,
                ProductId = 61
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 62,
                Amount = 10,
                CompanyId = 7,
                ProductId = 62
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 63,
                Amount = 63,
                CompanyId = 7,
                ProductId = 63
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 64,
                Amount = 10,
                CompanyId = 7,
                ProductId = 64
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 65,
                Amount = 10,
                CompanyId = 7,
                ProductId = 65
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 66,
                Amount = 10,
                CompanyId = 7,
                ProductId = 66
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 67,
                Amount = 10,
                CompanyId = 7,
                ProductId = 67
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 68,
                Amount = 10,
                CompanyId = 7,
                ProductId = 68
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 69,
                Amount = 10,
                CompanyId = 7,
                ProductId = 69
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 70,
                Amount = 10,
                CompanyId = 7,
                ProductId = 70
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 71,
                Amount = 10,
                CompanyId = 8,
                ProductId = 61
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 72,
                Amount = 10,
                CompanyId = 8,
                ProductId = 72
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 73,
                Amount = 10,
                CompanyId = 8,
                ProductId = 73
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 74,
                Amount = 10,
                CompanyId = 8,
                ProductId = 74
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 75,
                Amount = 10,
                CompanyId = 8,
                ProductId = 75
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 76,
                Amount = 10,
                CompanyId = 8,
                ProductId = 76
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 77,
                Amount = 10,
                CompanyId = 8,
                ProductId = 77
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 78,
                Amount = 10,
                CompanyId = 8,
                ProductId = 78
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 79,
                Amount = 10,
                CompanyId = 8,
                ProductId = 79
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 80,
                Amount = 10,
                CompanyId = 8,
                ProductId = 80
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 81,
                Amount = 10,
                CompanyId = 9,
                ProductId = 81
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 82,
                Amount = 10,
                CompanyId = 9,
                ProductId = 82
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 83,
                Amount = 10,
                CompanyId = 9,
                ProductId = 83
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 84,
                Amount = 10,
                CompanyId = 9,
                ProductId = 84
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 85,
                Amount = 10,
                CompanyId = 9,
                ProductId = 85
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 86,
                Amount = 10,
                CompanyId = 9,
                ProductId = 86
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 87,
                Amount = 10,
                CompanyId = 9,
                ProductId = 87
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 88,
                Amount = 10,
                CompanyId = 9,
                ProductId = 88
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 89,
                Amount = 10,
                CompanyId = 9,
                ProductId = 89
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 90,
                Amount = 10,
                CompanyId = 9,
                ProductId = 90
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 91,
                Amount = 10,
                CompanyId = 10,
                ProductId = 91
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 92,
                Amount = 10,
                CompanyId = 10,
                ProductId = 92
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 93,
                Amount = 10,
                CompanyId = 10,
                ProductId = 93
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 94,
                Amount = 10,
                CompanyId = 10,
                ProductId = 94
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 95,
                Amount = 10,
                CompanyId = 10,
                ProductId = 95
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 96,
                Amount = 10,
                CompanyId = 10,
                ProductId = 96
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 97,
                Amount = 10,
                CompanyId = 10,
                ProductId = 97
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 98,
                Amount = 10,
                CompanyId = 10,
                ProductId = 98
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 99,
                Amount = 10,
                CompanyId = 10,
                ProductId = 99
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 100,
                Amount = 10,
                CompanyId = 10,
                ProductId = 100
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 101,
                Amount = 10,
                CompanyId = 11,
                ProductId = 101
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 102,
                Amount = 10,
                CompanyId = 11,
                ProductId = 102
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 103,
                Amount = 10,
                CompanyId = 11,
                ProductId = 103
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 104,
                Amount = 10,
                CompanyId = 11,
                ProductId = 104
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 105,
                Amount = 10,
                CompanyId = 11,
                ProductId = 105
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 106,
                Amount = 10,
                CompanyId = 12,
                ProductId = 106
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 107,
                Amount = 10,
                CompanyId = 12,
                ProductId = 107
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 108,
                Amount = 10,
                CompanyId = 12,
                ProductId = 108
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 109,
                Amount = 10,
                CompanyId = 12,
                ProductId = 109
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 110,
                Amount = 10,
                CompanyId = 12,
                ProductId = 110
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 111,
                Amount = 10,
                CompanyId = 13,
                ProductId = 111
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 112,
                Amount = 10,
                CompanyId = 13,
                ProductId = 112
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 113,
                Amount = 10,
                CompanyId = 13,
                ProductId = 113
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 114,
                Amount = 10,
                CompanyId = 13,
                ProductId = 114
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 115,
                Amount = 10,
                CompanyId = 13,
                ProductId = 115
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 116,
                Amount = 10,
                CompanyId = 14,
                ProductId = 116
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 117,
                Amount = 10,
                CompanyId = 14,
                ProductId = 117
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 118,
                Amount = 10,
                CompanyId = 14,
                ProductId = 118
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 119,
                Amount = 10,
                CompanyId = 14,
                ProductId = 119
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 120,
                Amount = 10,
                CompanyId = 14,
                ProductId = 120
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 121,
                Amount = 10,
                CompanyId = 15,
                ProductId = 121
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 122,
                Amount = 10,
                CompanyId = 15,
                ProductId = 122
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 123,
                Amount = 10,
                CompanyId = 15,
                ProductId = 123
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 124,
                Amount = 10,
                CompanyId = 15,
                ProductId = 124
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 125,
                Amount = 10,
                CompanyId = 15,
                ProductId = 125
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 126,
                Amount = 10,
                CompanyId = 16,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 127,
                Amount = 10,
                CompanyId = 16,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 128,
                Amount = 10,
                CompanyId = 16,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 129,
                Amount = 10,
                CompanyId = 16,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 130,
                Amount = 10,
                CompanyId = 16,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 131,
                Amount = 10,
                CompanyId = 17,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 132,
                Amount = 10,
                CompanyId = 17,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 133,
                Amount = 10,
                CompanyId = 17,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 134,
                Amount = 10,
                CompanyId = 17,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 135,
                Amount = 10,
                CompanyId = 17,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 136,
                Amount = 10,
                CompanyId = 18,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 137,
                Amount = 10,
                CompanyId = 18,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 138,
                Amount = 10,
                CompanyId = 18,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 139,
                Amount = 10,
                CompanyId = 18,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 140,
                Amount = 10,
                CompanyId = 18,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 141,
                Amount = 10,
                CompanyId = 19,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 142,
                Amount = 10,
                CompanyId = 19,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 143,
                Amount = 10,
                CompanyId = 19,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 144,
                Amount = 10,
                CompanyId = 19,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 145,
                Amount = 10,
                CompanyId = 19,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 146,
                Amount = 10,
                CompanyId = 20,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 147,
                Amount = 10,
                CompanyId = 20,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 148,
                Amount = 10,
                CompanyId = 20,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 149,
                Amount = 10,
                CompanyId = 20,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 150,
                Amount = 10,
                CompanyId = 20,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 151,
                Amount = 10,
                CompanyId = 21,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 152,
                Amount = 10,
                CompanyId = 21,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 153,
                Amount = 10,
                CompanyId = 21,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 154,
                Amount = 10,
                CompanyId = 21,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 155,
                Amount = 10,
                CompanyId = 21,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 156,
                Amount = 10,
                CompanyId = 22,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 157,
                Amount = 10,
                CompanyId = 22,
                ProductId = 127
            });

            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 158,
                Amount = 10,
                CompanyId = 22,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 159,
                Amount = 10,
                CompanyId = 22,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 160,
                Amount = 10,
                CompanyId = 22,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 161,
                Amount = 10,
                CompanyId = 23,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 162,
                Amount = 10,
                CompanyId = 23,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 163,
                Amount = 10,
                CompanyId = 23,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 164,
                Amount = 10,
                CompanyId = 23,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 165,
                Amount = 10,
                CompanyId = 23,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 166,
                Amount = 10,
                CompanyId = 24,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 167,
                Amount = 10,
                CompanyId = 24,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 168,
                Amount = 10,
                CompanyId = 24,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 169,
                Amount = 10,
                CompanyId = 24,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 170,
                Amount = 10,
                CompanyId = 24,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 171,
                Amount = 10,
                CompanyId = 25,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 172,
                Amount = 10,
                CompanyId = 25,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 173,
                Amount = 10,
                CompanyId = 25,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 174,
                Amount = 10,
                CompanyId = 25,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 175,
                Amount = 10,
                CompanyId = 25,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 176,
                Amount = 10,
                CompanyId = 26,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 177,
                Amount = 10,
                CompanyId = 26,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 178,
                Amount = 10,
                CompanyId = 26,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 179,
                Amount = 10,
                CompanyId = 26,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 180,
                Amount = 10,
                CompanyId = 26,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 181,
                Amount = 10,
                CompanyId = 26,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 182,
                Amount = 10,
                CompanyId = 27,
                ProductId = 27
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 183,
                Amount = 10,
                CompanyId = 27,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 184,
                Amount = 10,
                CompanyId = 27,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 185,
                Amount = 10,
                CompanyId = 27,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 186,
                Amount = 10,
                CompanyId = 27,
                ProductId = 131
            });

            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 187,
                Amount = 10,
                CompanyId = 28,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 188,
                Amount = 10,
                CompanyId = 28,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 189,
                Amount = 10,
                CompanyId = 28,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 190,
                Amount = 10,
                CompanyId = 28,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 191,
                Amount = 10,
                CompanyId = 29,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 192,
                Amount = 10,
                CompanyId = 29,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 193,
                Amount = 10,
                CompanyId = 29,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 194,
                Amount = 10,
                CompanyId = 29,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 195,
                Amount = 10,
                CompanyId = 29,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 196,
                Amount = 10,
                CompanyId = 30,
                ProductId = 126
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 197,
                Amount = 10,
                CompanyId = 30,
                ProductId = 127
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 198,
                Amount = 10,
                CompanyId = 30,
                ProductId = 128
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 199,
                Amount = 10,
                CompanyId = 30,
                ProductId = 129
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 200,
                Amount = 10,
                CompanyId = 30,
                ProductId = 130
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 201,
                Amount = 10,
                CompanyId = 31,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 202,
                Amount = 10,
                CompanyId = 31,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 203,
                Amount = 10,
                CompanyId = 31,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 204,
                Amount = 10,
                CompanyId = 31,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 205,
                Amount = 10,
                CompanyId = 31,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 206,
                Amount = 10,
                CompanyId = 32,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 207,
                Amount = 10,
                CompanyId = 32,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 208,
                Amount = 10,
                CompanyId = 32,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 209,
                Amount = 10,
                CompanyId = 32,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 210,
                Amount = 10,
                CompanyId = 32,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 211,
                Amount = 10,
                CompanyId = 33,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 212,
                Amount = 10,
                CompanyId = 33,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 213,
                Amount = 10,
                CompanyId = 33,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 214,
                Amount = 10,
                CompanyId = 33,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 215,
                Amount = 10,
                CompanyId = 33,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 216,
                Amount = 10,
                CompanyId = 34,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 217,
                Amount = 10,
                CompanyId = 34,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 218,
                Amount = 10,
                CompanyId = 34,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 219,
                Amount = 10,
                CompanyId = 34,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 220,
                Amount = 10,
                CompanyId = 34,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 221,
                Amount = 10,
                CompanyId = 35,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 222,
                Amount = 10,
                CompanyId = 35,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 223,
                Amount = 10,
                CompanyId = 35,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 224,
                Amount = 10,
                CompanyId = 35,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 225,
                Amount = 10,
                CompanyId = 35,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 226,
                Amount = 10,
                CompanyId = 36,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 227,
                Amount = 10,
                CompanyId = 36,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 228,
                Amount = 10,
                CompanyId = 36,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 229,
                Amount = 10,
                CompanyId = 36,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 230,
                Amount = 10,
                CompanyId = 36,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 231,
                Amount = 10,
                CompanyId = 37,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 232,
                Amount = 10,
                CompanyId = 37,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 233,
                Amount = 10,
                CompanyId = 37,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 234,
                Amount = 10,
                CompanyId = 37,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 235,
                Amount = 10,
                CompanyId = 37,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 236,
                Amount = 10,
                CompanyId = 38,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 237,
                Amount = 10,
                CompanyId = 38,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 238,
                Amount = 10,
                CompanyId = 38,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 239,
                Amount = 10,
                CompanyId = 38,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 240,
                Amount = 10,
                CompanyId = 38,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 241,
                Amount = 10,
                CompanyId = 39,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 242,
                Amount = 10,
                CompanyId = 39,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 243,
                Amount = 10,
                CompanyId = 39,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 244,
                Amount = 10,
                CompanyId = 39,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 245,
                Amount = 10,
                CompanyId = 39,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 246,
                Amount = 10,
                CompanyId = 40,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 247,
                Amount = 10,
                CompanyId = 40,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 248,
                Amount = 10,
                CompanyId = 40,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 249,
                Amount = 10,
                CompanyId = 40,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 250,
                Amount = 10,
                CompanyId = 40,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 251,
                Amount = 10,
                CompanyId = 41,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 252,
                Amount = 10,
                CompanyId = 41,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 253,
                Amount = 10,
                CompanyId = 41,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 254,
                Amount = 10,
                CompanyId = 41,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 255,
                Amount = 10,
                CompanyId = 41,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 256,
                Amount = 10,
                CompanyId = 42,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 257,
                Amount = 10,
                CompanyId = 42,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 258,
                Amount = 10,
                CompanyId = 42,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 259,
                Amount = 10,
                CompanyId = 42,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 260,
                Amount = 10,
                CompanyId = 42,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 261,
                Amount = 10,
                CompanyId = 43,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 262,
                Amount = 10,
                CompanyId = 43,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 263,
                Amount = 10,
                CompanyId = 43,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 264,
                Amount = 10,
                CompanyId = 43,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 265,
                Amount = 10,
                CompanyId = 43,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 266,
                Amount = 10,
                CompanyId = 44,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 267,
                Amount = 10,
                CompanyId = 44,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 268,
                Amount = 10,
                CompanyId = 44,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 269,
                Amount = 10,
                CompanyId = 44,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 270,
                Amount = 10,
                CompanyId = 44,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 271,
                Amount = 10,
                CompanyId = 45,
                ProductId = 131
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 272,
                Amount = 10,
                CompanyId = 45,
                ProductId = 132
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 273,
                Amount = 10,
                CompanyId = 45,
                ProductId = 133
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 274,
                Amount = 10,
                CompanyId = 45,
                ProductId = 134
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 275,
                Amount = 10,
                CompanyId = 45,
                ProductId = 135
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 276,
                Amount = 10,
                CompanyId = 46,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 277,
                Amount = 10,
                CompanyId = 46,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 278,
                Amount = 10,
                CompanyId = 46,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 279,
                Amount = 10,
                CompanyId = 46,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 280,
                Amount = 10,
                CompanyId = 47,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 281,
                Amount = 10,
                CompanyId = 47,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 282,
                Amount = 10,
                CompanyId = 47,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 283,
                Amount = 10,
                CompanyId = 47,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 284,
                Amount = 10,
                CompanyId = 48,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 285,
                Amount = 10,
                CompanyId = 48,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 286,
                Amount = 10,
                CompanyId = 48,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 287,
                Amount = 10,
                CompanyId = 48,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 288,
                Amount = 10,
                CompanyId = 49,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 289,
                Amount = 10,
                CompanyId = 49,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 290,
                Amount = 10,
                CompanyId = 49,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 291,
                Amount = 10,
                CompanyId = 49,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 292,
                Amount = 10,
                CompanyId = 50,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 293,
                Amount = 10,
                CompanyId = 50,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 294,
                Amount = 10,
                CompanyId = 50,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 295,
                Amount = 10,
                CompanyId = 50,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 296,
                Amount = 10,
                CompanyId = 51,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 297,
                Amount = 10,
                CompanyId = 51,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 298,
                Amount = 10,
                CompanyId = 51,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 299,
                Amount = 10,
                CompanyId = 51,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 300,
                Amount = 10,
                CompanyId = 52,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 301,
                Amount = 10,
                CompanyId = 52,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 302,
                Amount = 10,
                CompanyId = 52,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 303,
                Amount = 10,
                CompanyId = 52,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 304,
                Amount = 10,
                CompanyId = 53,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 305,
                Amount = 10,
                CompanyId = 53,
                ProductId = 137
            });
            ; modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 306,
                Amount = 10,
                CompanyId = 53,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 307,
                Amount = 10,
                CompanyId = 53,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 308,
                Amount = 10,
                CompanyId = 54,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 309,
                Amount = 10,
                CompanyId = 54,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 310,
                Amount = 10,
                CompanyId = 54,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 311,
                Amount = 10,
                CompanyId = 54,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 312,
                Amount = 10,
                CompanyId = 55,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 313,
                Amount = 10,
                CompanyId = 55,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 314,
                Amount = 10,
                CompanyId = 55,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 315,
                Amount = 10,
                CompanyId = 55,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 316,
                Amount = 10,
                CompanyId = 56,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 317,
                Amount = 10,
                CompanyId = 56,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 318,
                Amount = 10,
                CompanyId = 56,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 319,
                Amount = 10,
                CompanyId = 56,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 320,
                Amount = 10,
                CompanyId = 57,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 321,
                Amount = 10,
                CompanyId = 57,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 322,
                Amount = 10,
                CompanyId = 57,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 323,
                Amount = 10,
                CompanyId = 57,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 324,
                Amount = 10,
                CompanyId = 58,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 325,
                Amount = 10,
                CompanyId = 58,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 326,
                Amount = 10,
                CompanyId = 58,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 327,
                Amount = 10,
                CompanyId = 58,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 328,
                Amount = 10,
                CompanyId = 59,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 329,
                Amount = 10,
                CompanyId = 59,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 330,
                Amount = 10,
                CompanyId = 59,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 331,
                Amount = 10,
                CompanyId = 59,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 332,
                Amount = 10,
                CompanyId = 60,
                ProductId = 136
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 333,
                Amount = 10,
                CompanyId = 60,
                ProductId = 137
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 334,
                Amount = 10,
                CompanyId = 60,
                ProductId = 138
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 335,
                Amount = 10,
                CompanyId = 60,
                ProductId = 139
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 336,
                Amount = 10,
                CompanyId = 61,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 337,
                Amount = 10,
                CompanyId = 61,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 338,
                Amount = 10,
                CompanyId = 61,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 339,
                Amount = 10,
                CompanyId = 61,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 340,
                Amount = 10,
                CompanyId = 61,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 341,
                Amount = 10,
                CompanyId = 61,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 342,
                Amount = 10,
                CompanyId = 62,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 343,
                Amount = 10,
                CompanyId = 62,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 344,
                Amount = 10,
                CompanyId = 62,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 345,
                Amount = 10,
                CompanyId = 62,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 346,
                Amount = 10,
                CompanyId = 62,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 347,
                Amount = 10,
                CompanyId = 62,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 348,
                Amount = 10,
                CompanyId = 63,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 349,
                Amount = 10,
                CompanyId = 63,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 350,
                Amount = 10,
                CompanyId = 63,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 351,
                Amount = 10,
                CompanyId = 63,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 352,
                Amount = 10,
                CompanyId = 63,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 353,
                Amount = 10,
                CompanyId = 63,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 354,
                Amount = 10,
                CompanyId = 64,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 355,
                Amount = 10,
                CompanyId = 64,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 356,
                Amount = 10,
                CompanyId = 64,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 357,
                Amount = 10,
                CompanyId = 64,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 358,
                Amount = 10,
                CompanyId = 64,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 359,
                Amount = 10,
                CompanyId = 64,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 360,
                Amount = 10,
                CompanyId = 65,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 361,
                Amount = 10,
                CompanyId = 65,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 362,
                Amount = 10,
                CompanyId = 65,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 363,
                Amount = 10,
                CompanyId = 65,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 364,
                Amount = 10,
                CompanyId = 65,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 365,
                Amount = 10,
                CompanyId = 65,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 366,
                Amount = 10,
                CompanyId = 66,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 367,
                Amount = 10,
                CompanyId = 66,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 368,
                Amount = 10,
                CompanyId = 66,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 369,
                Amount = 10,
                CompanyId = 66,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 370,
                Amount = 10,
                CompanyId = 66,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 371,
                Amount = 10,
                CompanyId = 66,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 372,
                Amount = 10,
                CompanyId = 67,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 373,
                Amount = 10,
                CompanyId = 67,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 374,
                Amount = 10,
                CompanyId = 67,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 375,
                Amount = 10,
                CompanyId = 67,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 376,
                Amount = 10,
                CompanyId = 67,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 377,
                Amount = 10,
                CompanyId = 67,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 378,
                Amount = 10,
                CompanyId = 68,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 379,
                Amount = 10,
                CompanyId = 68,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 380,
                Amount = 10,
                CompanyId = 68,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 381,
                Amount = 10,
                CompanyId = 68,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 382,
                Amount = 10,
                CompanyId = 68,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 383,
                Amount = 10,
                CompanyId = 68,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 384,
                Amount = 10,
                CompanyId = 69,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 385,
                Amount = 10,
                CompanyId = 69,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 386,
                Amount = 10,
                CompanyId = 69,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 387,
                Amount = 10,
                CompanyId = 69,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 388,
                Amount = 10,
                CompanyId = 69,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 389,
                Amount = 10,
                CompanyId = 69,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 390,
                Amount = 10,
                CompanyId = 70,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 391,
                Amount = 10,
                CompanyId = 70,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 392,
                Amount = 10,
                CompanyId = 70,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 393,
                Amount = 10,
                CompanyId = 70,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 394,
                Amount = 10,
                CompanyId = 70,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 395,
                Amount = 10,
                CompanyId = 70,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 396,
                Amount = 10,
                CompanyId = 71,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 397,
                Amount = 10,
                CompanyId = 71,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 398,
                Amount = 10,
                CompanyId = 71,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 399,
                Amount = 10,
                CompanyId = 71,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 400,
                Amount = 10,
                CompanyId = 71,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 401,
                Amount = 10,
                CompanyId = 71,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 402,
                Amount = 10,
                CompanyId = 72,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 403,
                Amount = 10,
                CompanyId = 72,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 404,
                Amount = 10,
                CompanyId = 72,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 405,
                Amount = 10,
                CompanyId = 72,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 406,
                Amount = 10,
                CompanyId = 72,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 407,
                Amount = 10,
                CompanyId = 72,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 408,
                Amount = 10,
                CompanyId = 73,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 409,
                Amount = 10,
                CompanyId = 73,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 410,
                Amount = 10,
                CompanyId = 73,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 411,
                Amount = 10,
                CompanyId = 73,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 412,
                Amount = 10,
                CompanyId = 73,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 413,
                Amount = 10,
                CompanyId = 73,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 414,
                Amount = 10,
                CompanyId = 74,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 415,
                Amount = 10,
                CompanyId = 74,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 416,
                Amount = 10,
                CompanyId = 74,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 417,
                Amount = 10,
                CompanyId = 74,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 418,
                Amount = 10,
                CompanyId = 74,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 419,
                Amount = 10,
                CompanyId = 74,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 420,
                Amount = 10,
                CompanyId = 75,
                ProductId = 140
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 421,
                Amount = 10,
                CompanyId = 75,
                ProductId = 141
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 422,
                Amount = 10,
                CompanyId = 75,
                ProductId = 142
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 423,
                Amount = 10,
                CompanyId = 75,
                ProductId = 143
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 424,
                Amount = 10,
                CompanyId = 75,
                ProductId = 144
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 425,
                Amount = 10,
                CompanyId = 75,
                ProductId = 145
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 426,
                Amount = 10,
                CompanyId = 76,
                ProductId = 146
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 427,
                Amount = 10,
                CompanyId = 76,
                ProductId = 147
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 428,
                Amount = 10,
                CompanyId = 76,
                ProductId = 148
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 429,
                Amount = 10,
                CompanyId = 76,
                ProductId = 149
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 430,
                Amount = 10,
                CompanyId = 76,
                ProductId = 150
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 431,
                Amount = 10,
                CompanyId = 77,
                ProductId = 146
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 432,
                Amount = 10,
                CompanyId = 77,
                ProductId = 147
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 433,
                Amount = 10,
                CompanyId = 77,
                ProductId = 148
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 434,
                Amount = 10,
                CompanyId = 77,
                ProductId = 149
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 435,
                Amount = 10,
                CompanyId = 77,
                ProductId = 150
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 436,
                Amount = 10,
                CompanyId = 78,
                ProductId = 146
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 437,
                Amount = 10,
                CompanyId = 78,
                ProductId = 147
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 438,
                Amount = 10,
                CompanyId = 78,
                ProductId = 148
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 439,
                Amount = 10,
                CompanyId = 78,
                ProductId = 149
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 440,
                Amount = 10,
                CompanyId = 78,
                ProductId = 150
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 441,
                Amount = 10,
                CompanyId = 79,
                ProductId = 146
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 442,
                Amount = 10,
                CompanyId = 79,
                ProductId = 147
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 443,
                Amount = 10,
                CompanyId = 79,
                ProductId = 148
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 444,
                Amount = 10,
                CompanyId = 79,
                ProductId = 149
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 445,
                Amount = 10,
                CompanyId = 79,
                ProductId = 150
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 446,
                Amount = 10,
                CompanyId = 80,
                ProductId = 146
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 447,
                Amount = 10,
                CompanyId = 80,
                ProductId = 147
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 448,
                Amount = 10,
                CompanyId = 80,
                ProductId = 148
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 449,
                Amount = 10,
                CompanyId = 80,
                ProductId = 149
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 450,
                Amount = 10,
                CompanyId = 80,
                ProductId = 150
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 451,
                Amount = 10,
                CompanyId = 81,
                ProductId = 146
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 452,
                Amount = 10,
                CompanyId = 81,
                ProductId = 147
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 453,
                Amount = 10,
                CompanyId = 81,
                ProductId = 148
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 454,
                Amount = 10,
                CompanyId = 81,
                ProductId = 149
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 455,
                Amount = 10,
                CompanyId = 81,
                ProductId = 150
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 456,
                Amount = 10,
                CompanyId = 82,
                ProductId = 146
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 457,
                Amount = 10,
                CompanyId = 82,
                ProductId = 147
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 458,
                Amount = 10,
                CompanyId = 82,
                ProductId = 148
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 459,
                Amount = 10,
                CompanyId = 82,
                ProductId = 149
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 460,
                Amount = 10,
                CompanyId = 82,
                ProductId = 150
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 461,
                Amount = 10,
                CompanyId = 83,
                ProductId = 146
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 462,
                Amount = 10,
                CompanyId = 83,
                ProductId = 147
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 463,
                Amount = 10,
                CompanyId = 83,
                ProductId = 148
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 464,
                Amount = 10,
                CompanyId = 83,
                ProductId = 149
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 465,
                Amount = 10,
                CompanyId = 83,
                ProductId = 150
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 466,
                Amount = 10,
                CompanyId = 84,
                ProductId = 146
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 467,
                Amount = 10,
                CompanyId = 84,
                ProductId = 147
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 468,
                Amount = 10,
                CompanyId = 84,
                ProductId = 148
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 469,
                Amount = 10,
                CompanyId = 84,
                ProductId = 149
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 470,
                Amount = 10,
                CompanyId = 84,
                ProductId = 150
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 471,
                Amount = 10,
                CompanyId = 85,
                ProductId = 146
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 472,
                Amount = 10,
                CompanyId = 85,
                ProductId = 147
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 473,
                Amount = 10,
                CompanyId = 85,
                ProductId = 148
            });
            modelBuilder.Entity<CompanyProduct>().HasData(new CompanyProduct
            {
                Id = 474,
                Amount = 10,
                CompanyId = 85,
                ProductId = 149
            });


            //ordertype table
            modelBuilder.Entity<OrderType>().HasData(new OrderType { Id = 1, Name = "Normal", });
            modelBuilder.Entity<OrderType>().HasData(new OrderType { Id = 2, Name = "Donation", });
            modelBuilder.Entity<OrderType>().HasData(new OrderType { Id = 3, Name = "Charity Organization", });
            //charity table
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 1, Name = "Al-Ihsan", Phone = "0215789147", Address = "Al Hamadanieh", Email = "Al-Ihsan@test.com", Password = "Al-Ihsan789", Goals = "childern", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 2, Name = "Hand By Hand", Phone = "0215117894", Address = "Al mohafaza", Email = "Hand-By-Hand@test.com", Password = "Hand-By-Hand456", Goals = "Old Pepole", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 3, Name = "Al-Noor", Phone = "021524895 ", Address = "Mohamad Fares Street", Email = "Al-Noor@test.com", Password = "Al-Noor123", Goals = "childern", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 4, Name = "George", Phone = "0215115827", Address = "Al Azizeh", Email = "George@test.com", Password = "George147", Goals = "childern", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            modelBuilder.Entity<Charity>().HasData(new Charity { Id = 5, Name = "Namaa", Phone = "02151174369", Address = "Al Marterni", Email = "Namaa@test.com", Password = "Namaa369", Goals = "childern", TargetGroup = "Rich Pepole", AssociationLicense = "2435" });
            //Donation table
            //modelBuilder.Entity<Donation>().HasData(new Donation { Id = 1, CharityId = 1, OrderTypeId = 3, CompanyProductId = 2, PricePay = 20000, });
            //modelBuilder.Entity<Donation>().HasData(new Donation { Id = 2, CharityId = 2, OrderTypeId = 2, CompanyProductId = 1, PricePay = 18000, });
            //modelBuilder.Entity<Donation>().HasData(new Donation { Id = 3, CharityId = 4, OrderTypeId = 2, CompanyProductId = 3, PricePay = 11000, });
            //modelBuilder.Entity<Donation>().HasData(new Donation { Id = 4, CharityId = 2, OrderTypeId = 3, CompanyProductId = 3, PricePay = 10000, });
            //PayMethod table
            modelBuilder.Entity<PayMethod>().HasData(new PayMethod { Id = 1, Name = "Cash Pay", });
            modelBuilder.Entity<PayMethod>().HasData(new PayMethod { Id = 2, Name = "PayPal", });
            modelBuilder.Entity<PayMethod>().HasData(new PayMethod { Id = 3, Name = "Credit Card", });

            //Order table
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 1, Name = "Order 1", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 20000, IsDelivery = true, PayMethodId = 1, UserId = 1, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 2, Name = "Order 2", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 15000, IsDelivery = true, PayMethodId = 1, UserId = 6, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 3, Name = "Order 3", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 20000, IsDelivery = true, PayMethodId = 2, UserId = 8, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 4, Name = "Order 4", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 200000, IsDelivery = true, PayMethodId = 3, UserId = 3, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 5, Name = "Order 5", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 5000, IsDelivery = true, PayMethodId = 1, UserId = 2, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 6, Name = "Order 6", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 30000, IsDelivery = false, PayMethodId = 1, UserId = 5, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 7, Name = "Order 7", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 20000, IsDelivery = false, PayMethodId = 2, UserId = 7, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 8, Name = "Order 8", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 70000, IsDelivery = false, PayMethodId = 2, UserId = 9, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 9, Name = "Order 9", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 60000, IsDelivery = false, PayMethodId = 3, UserId = 10, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 10, Name = "Order 10", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 20000, IsDelivery = true, PayMethodId = 3, UserId = 8, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 11, Name = "Order 11", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 25000, IsDelivery = true, PayMethodId = 1, UserId = 15, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 12, Name = "Order 12", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 60000, IsDelivery = false, PayMethodId = 2, UserId = 14, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 13, Name = "Order 13", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 80000, IsDelivery = true, PayMethodId = 3, UserId = 13, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 14, Name = "Order 14", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 100000, IsDelivery = false, PayMethodId = 2, UserId = 12, });
            //modelBuilder.Entity<Order>().HasData(new Order { Id = 15, Name = "Order 15", Descripation = "The order was placed at 3:05 and will expire after a quarter of an hour from this time ", Price = 70000, IsDelivery = true, PayMethodId = 1, UserId = 11, });
            //Subscription table
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 1, CompanyId = 1, UserId = 1, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 2, CompanyId = 2, UserId = 1, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 3, CompanyId = 2, UserId = 3, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 4, CompanyId = 1, UserId = 3, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 5, CompanyId = 7, UserId = 8, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 6, CompanyId = 3, UserId = 7, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 7, CompanyId = 9, UserId = 15, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 8, CompanyId = 10, UserId = 10, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 9, CompanyId = 11, UserId = 11, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 10, CompanyId = 4, UserId = 12, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 11, CompanyId = 13, UserId = 14, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 12, CompanyId = 5, UserId = 10, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 13, CompanyId = 7, UserId = 7, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 14, CompanyId = 8, UserId = 1, });
            modelBuilder.Entity<Subscription>().HasData(new Subscription { Id = 15, CompanyId = 15, UserId = 3, });

            //OrderProduct table
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 1, CompanyProductId = 100, OrderId = 1, Amount = 5, TotalPrice = 11000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 2, CompanyProductId = 300, OrderId = 5, Amount = 4, TotalPrice = 120000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 3, CompanyProductId = 67, OrderId = 6, Amount = 9, TotalPrice = 480000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 4, CompanyProductId = 109, OrderId = 11, Amount = 100, TotalPrice = 500000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 5, CompanyProductId = 75, OrderId = 13, Amount = 5, TotalPrice = 11000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 6, CompanyProductId = 91, OrderId = 5, Amount = 4, TotalPrice = 120000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 7, CompanyProductId = 28, OrderId = 6, Amount = 9, TotalPrice = 480000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 8, CompanyProductId = 450, OrderId = 4, Amount = 100, TotalPrice = 500000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 9, CompanyProductId = 378, OrderId = 3, Amount = 5, TotalPrice = 11000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 10, CompanyProductId = 274, OrderId = 7, Amount = 4, TotalPrice = 120000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 11, CompanyProductId = 159, OrderId = 10, Amount = 9, TotalPrice = 480000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 12, CompanyProductId = 275, OrderId = 12, Amount = 100, TotalPrice = 500000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 13, CompanyProductId = 1, OrderId = 14, Amount = 5, TotalPrice = 11000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 14, CompanyProductId = 420, OrderId = 9, Amount = 4, TotalPrice = 120000, });
            modelBuilder.Entity<OrderProduct>().HasData(new OrderProduct { Id = 15, CompanyProductId = 455, OrderId = 8, Amount = 9, TotalPrice = 480000, });

            //OrderStatus table
            modelBuilder.Entity<OrderStatus>().HasData(new OrderStatus { Id = 1, status = 1, DateTime = DateTime.Now });
            modelBuilder.Entity<OrderStatus>().HasData(new OrderStatus { Id = 2, status = 2, DateTime = DateTime.Now });
            //Bill table
            modelBuilder.Entity<Bill>().HasData(new Bill { Id = 10, OrderProductId = 4, Note = "  Welcom to you", OrderStatusId = 1 });
            modelBuilder.Entity<Bill>().HasData(new Bill { Id = 21, OrderProductId = 2, Note = " Welcom to you", OrderStatusId = 1 });
            modelBuilder.Entity<Bill>().HasData(new Bill { Id = 22, OrderProductId = 2, Note = " Welcom to you", OrderStatusId = 2 });
            modelBuilder.Entity<Bill>().HasData(new Bill { Id = 23, OrderProductId = 1, Note = " Welcom to you", OrderStatusId = 1 });
            modelBuilder.Entity<Bill>().HasData(new Bill { Id = 24, OrderProductId = 3, Note = " Welcom to you", OrderStatusId = 1 });
            //Rate table
            modelBuilder.Entity<Rate>().HasData(new Rate { Id = 1, RateNumber = 3, Description = "Middle", });
            modelBuilder.Entity<Rate>().HasData(new Rate { Id = 2, RateNumber = 4, Description = "Good", });
            modelBuilder.Entity<Rate>().HasData(new Rate { Id = 3, RateNumber = 5, Description = "Very Good", });
            modelBuilder.Entity<Rate>().HasData(new Rate { Id = 4, RateNumber = 7, Description = "Super", });
            //Evalution table
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 1, SubscriptionId = 1, RateId = 4, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 2, SubscriptionId = 2, RateId = 3, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 3, SubscriptionId = 3, RateId = 2, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 4, SubscriptionId = 4, RateId = 1, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 5, SubscriptionId = 5, RateId = 4, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 6, SubscriptionId = 6, RateId = 1, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 7, SubscriptionId = 7, RateId = 2, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 8, SubscriptionId = 8, RateId = 3, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 9, SubscriptionId = 9, RateId = 4, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 10, SubscriptionId = 10, RateId = 3, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 11, SubscriptionId = 11, RateId = 2, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 12, SubscriptionId = 12, RateId = 1, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 13, SubscriptionId = 13, RateId = 4, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 14, SubscriptionId = 14, RateId = 2, });
            modelBuilder.Entity<Evalution>().HasData(new Evalution { Id = 15, SubscriptionId = 15, RateId = 2, });
        }
    }
}
