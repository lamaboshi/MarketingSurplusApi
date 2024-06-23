namespace MarketingSurplus.Models
{
    public class Rate
    {
        public int Id { get; set; }
        public int RateNumber { get; set; }
        public string Description{ get; set; }
        public ICollection<Evalution>? Evalutions { get; set; }
    }
}
