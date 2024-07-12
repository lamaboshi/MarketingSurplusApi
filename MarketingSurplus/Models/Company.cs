namespace MarketingSurplus.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[]? Image { get; set; }
        public string? OnlineImage { get; set; }
        public string Description { get; set; }
        public string TelePhone { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }
        public string? LicenseNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isAccept { get; set; }
        public int CompanyTypeId { get; set; }
        public CompanyType? CompanyType { get; set; }
        public ICollection<CompanyProduct>? CompanyProducts { get; set; }
        public ICollection<Subscription>? Subscriptions { get; set; }
        public ICollection<CompanyMethods>? CompanyMethods { get; set; }

    }
}
