using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;

namespace MarketingSurplus.Data
{
    public class PayMethodRepo : IPayMethod
    {
        public readonly MarketingSurplusDbContext _db;
        public PayMethodRepo(MarketingSurplusDbContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            var type = _db.PayMethods.FirstOrDefault(p => p.Id == id);
            if (type != null)
            {
                _db.PayMethods.Remove(type);
                _db.SaveChanges();
            }
        }

        public PayMethod GetPayMethod(int id)
        {
            var type = _db.PayMethods.First(p => p.Id == id);
            if (type != null)
                return type;
            else
                return null;
        }

        public List<PayMethod> GetPayMethods()
        {
             var data=_db.PayMethods.ToList();
            return data;
        }

        public void Save(PayMethod payMethod)
        {
            if (payMethod.Id == 0)
            {
                _db.PayMethods.Add(payMethod);
                _db.SaveChanges();
            }
        }

        public void Update(PayMethod payMethod)
        {
            var type = _db.PayMethods.First(p => p.Id == payMethod.Id);
            if (type != null)
            {

                type.Name = payMethod.Name;
                _db.SaveChanges();
            }
        }
    }
}
