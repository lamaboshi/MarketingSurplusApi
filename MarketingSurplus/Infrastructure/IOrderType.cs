using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{
    public interface IOrderType
    {
        public OrderType GetOrderType(int id);
        public List<OrderType> GetOrderTypes();
        public void Save(OrderType orderType);
        public void Delete(int id);
        public void Update(OrderType orderType);

    }
}
