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
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationCharity> NotificationCharities { get; set; }
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


          //  FullDataSeeds.callFullData(modelBuilder);

         DataSeeds.callFullData(modelBuilder);

        }
    }
}
