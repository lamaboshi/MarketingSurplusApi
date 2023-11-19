namespace MarketingSurplus.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string LicenseNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CompanyTypeId { get; set; }
        public CompanyType CompanyType { get; set; }
        public ICollection<CompanyProduct> CompanyProducts { get; set; }
        public ICollection<UserCompany> UserCompanies { get; set; }

    }
}
