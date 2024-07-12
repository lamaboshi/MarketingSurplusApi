using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;

namespace MarketingSurplus.Data
{
    public class OrderRepo : IOrder
    {
        private readonly MarketingSurplusDbContext _db;
        public OrderRepo(MarketingSurplusDbContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            var result = _db.Orders.First(p => p.Id == id);
            if (result != null)
            {
                _db.Orders.Remove(result);

                _db.SaveChanges();
            }
        }





        public Order GetOrder(int id)
        {
            var result = _db.Orders.First(p => p.Id == id);
            if (result != null) return result;
            else return null;
        }

        public List<Order> GetOrders()
        {
            var data = _db.Orders.ToList();
            return data;
        }

        public List<Order> GetOrdersUser(int userId)
        {
            var allOrder =new List<Order>();
            var data = _db.Orders.Where(q => q.UserId == userId).ToList();
            foreach (var order in data)
            {
                var item = _db.OrderProducts.Where(e => e.OrderId == order.Id).ToList();
                foreach(var product in item)
                {
                    var isExit = _db.Bills.Any(t => t.OrderProductId == product.Id );
                    if (isExit)
                    {
                        allOrder.Add(order);

                    }
                }
            }

            return allOrder;
        }

        public void Save(Order order)
        {
            if (order.Id == 0)
            {
                _db.Orders.Add(order);
                _db.SaveChanges();
            }
        }

        public void Update(Order order)
        {
            if (order.Id != 0)
            {
                var entity = _db.Orders.First(t => t.Id == order.Id);
                if (entity != null)
                {
                    entity.Name = order.Name;
                    entity.Amount = order.Amount;
                    entity.Price = order.Price;
                    entity.IsDelivery = order.IsDelivery;
                    entity.UserId = order.UserId;
                    entity.Descripation = order.Descripation;
                    _db.SaveChanges();
                }
            }
        }
    }
}
