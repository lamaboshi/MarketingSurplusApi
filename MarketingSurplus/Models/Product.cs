namespace MarketingSurplus.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripation { get; set; }
        public float Price { get; set; }
        public DateTime Expiration { get; set; }
        public bool IsExpiration { get; set; }
        public ICollection<CompanyProduct> CompanyProducts { get; set; }
    }
}
