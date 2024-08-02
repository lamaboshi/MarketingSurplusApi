namespace MarketingSurplus.Models
{
    public class PayMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isAccept { get; set; }
        public ICollection<CompanyMethods>? CompanyMethods { get; set; }

    }
}
