using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketingSurplus.Data
{
    public class RateRepo : IRate
    {
        public readonly MarketingSurplusDbContext _db;
        public RateRepo(MarketingSurplusDbContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            var type = _db.Rates.FirstOrDefault(p => p.Id == id);
            if (type != null)
            {
                _db.Rates.Remove(type);
                _db.SaveChanges();
            }
        }

        public Rate GetRate(int id)
        {
            var type = _db.Rates.First(p => p.Id == id);
            if (type != null)
                return type;
            else
                return null;
        }

        public List<Evalution> GetRates(int companyId)
        {
            var subscriptions = _db.Subscriptions.Where(r => r.CompanyId == companyId).First();
            var data = _db.Evalution.Where(p => p.SubscriptionId == subscriptions.Id).Include(t => t.Rate).Include(y => y.Subscription).ToList();
            return data;
        }

        public void Save(Rate rate,int subId)
        {
            if (rate.Id == 0)
            {
              var result=  _db.Rates.Add(rate);
                _db.SaveChanges();

                _db.Evalution.Add(new Evalution { RateId= result.Entity.Id,SubscriptionId=subId});
                _db.SaveChanges();

            }
        }

        public void Update(Rate rate)
        {
            var type = _db.Rates.First(p => p.Id == rate.Id);
            if (type != null)
            {

                type.RateNumber = rate.RateNumber;
                type.Description = rate.Description;
                _db.SaveChanges();
            }
        }
    }
}
