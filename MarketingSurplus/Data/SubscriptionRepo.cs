using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;

namespace MarketingSurplus.Data
{
    public class SubscriptionRepo : ISubscription
    {
        public readonly MarketingSurplusDbContext _db;
        public SubscriptionRepo(MarketingSurplusDbContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            var type = _db.Subscriptions.FirstOrDefault(p => p.Id == id);
            if (type != null)
            {
                _db.Subscriptions.Remove(type);
                _db.SaveChanges();
            }
        }

        public List<Subscription> GetCompanySubscription(int companyId)
        {
            var data = _db.Subscriptions.Where(q => q.CompanyId == companyId).ToList();
            return data;
        }

        public Subscription GetSubscription(int userId, int CompanyId)
        {
            var data = _db.Subscriptions.Where(q => q.UserId == userId&&q.CompanyId==CompanyId).FirstOrDefault();
            return data;
        }

        public List<Subscription> GetSubscriptiones(int userId)
        {
            var data = _db.Subscriptions.Where(q => q.UserId == userId).ToList();
            return data;
        }

        public void Save(Subscription subscription)
        {
            if (subscription.Id == 0)
            {
                _db.Subscriptions.Add(subscription);
                _db.SaveChanges();
            }
        }
    }
}
