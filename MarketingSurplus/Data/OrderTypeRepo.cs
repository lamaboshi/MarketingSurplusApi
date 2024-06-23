
using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;

namespace MarketingSurplus.Data
{
    public class OrderTypeRepo : IOrderType
    {
        public readonly MarketingSurplusDbContext _db;
        public OrderTypeRepo(MarketingSurplusDbContext db)
        {
            _db = db;
        }
        public void Delete(int id)
        {
            var type = _db.OrderTypes.FirstOrDefault(p => p.Id == id);
            if (type != null)
            {
                _db.OrderTypes.Remove(type);
                _db.SaveChanges();
            }
        }

        public OrderType GetOrderType(int id)
        {
            var type = _db.OrderTypes.First(p => p.Id == id);
            if (type != null)
                return type;
            else
                return null;
        }

        public List<OrderType> GetOrderTypes()
        {
            var data = _db.OrderTypes.ToList();
            return data;
        }

        public void Save(OrderType orderType)
        {
            if (orderType.Id == 0)
            {
                _db.OrderTypes.Add(orderType);
                _db.SaveChanges();
            }
        }

        public void Update(OrderType orderType)
        {
            var type = _db.OrderTypes.First(p => p.Id == orderType.Id);
            if (type != null)
            {

                type.Name = orderType.Name;
                _db.SaveChanges();
            }
        }
    }
}
