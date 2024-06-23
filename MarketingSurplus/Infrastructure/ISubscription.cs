using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{
    public interface ISubscription
    {
        public Subscription GetSubscription(int userId,int CompanyId);
        public List<Subscription> GetSubscriptiones(int userId);
        public List<Subscription> GetCompanySubscription(int companyId);

        public void Save(Subscription subscription);
        public void Delete(int id);

    }
}
