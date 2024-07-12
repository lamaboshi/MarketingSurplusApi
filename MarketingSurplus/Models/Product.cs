namespace MarketingSurplus.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripation { get; set; }
        public string? OnlineImage { get; set; }
        public byte[]? Image { get; set; }
        public DateTime DateTime { get; set; }
        public float NewPrice { get; set; }
        public float OldPrice { get; set; }
        public DateTime Expiration { get; set; }
        public bool IsExpiration { get; set; }
        public ICollection<CompanyProduct>? CompanyProducts { get; set; }
    }
}
