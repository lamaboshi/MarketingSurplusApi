using MarketingSurplus.Models;

namespace MarketingSurplus.Dto
{
    public class OrderDto
    {
        public Company Company { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public OrderProduct OrderProduct { get; set; }
        public List<Bill> Bills { get; set; }
    }
}
