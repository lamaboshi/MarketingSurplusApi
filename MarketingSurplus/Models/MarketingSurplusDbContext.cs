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
        public DbSet<CompayProductOrder> CompayProductOrders { get; set; }
        public DbSet<CompayProductOrderOffer> CompayProductOrderOffers { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<PayMethod> PayMethods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCompany> UserCompanies { get; set; }
        public DbSet<UserCompanyRate> UserCompanyRates { get; set; }
        //test
    }
}
