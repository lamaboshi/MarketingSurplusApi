using MarketingSurplus.Models;

namespace MarketingSurplus.Dto
{
    public class SaveOrderRequestDto
    {
        public int UserId { get; set; }
        public Order Order { get; set; }
        public List<int> Ids { get; set; }
    }
}
