using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{
    public interface IOrder
    {

            public Order GetOrder(int id);
            public List<Order> GetOrders();
        public List<Order> GetOrdersUser(int userId);

        public void Save(Order order);
            public void Update(Order order);
            public void Delete(int id);
   
    }
}
