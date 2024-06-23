namespace MarketingSurplus.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripation { get; set; }
        public int? Amount { get; set; }
        public float? Price { get; set; }
        public bool IsDelivery { get; set; }
        public int PayMethodId { get; set; }
        public PayMethod? PayMethod { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public ICollection<OrderProduct>? OrderProducts { get; set; }
    }
}
