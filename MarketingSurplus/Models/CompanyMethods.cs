namespace MarketingSurplus.Models
{
    public class CompanyMethods
    {
        public int Id { get; set; }
        public PayMethod? PayMethod { get; set; }
        public int PayMethodId { get; set; }
        public Company? Company { get; set; }
        public int CompanyId { get; set; }
    }
}
