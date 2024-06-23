namespace MarketingSurplus.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public ICollection<Evalution>? Evalutions { get; set; }
    }
}
