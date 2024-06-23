using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{

    public interface IPayMethod
    {
        public PayMethod GetPayMethod(int id);
        public List<PayMethod> GetPayMethods();
        public void Save(PayMethod payMethod);
        public void Delete(int id);
        public void Update(PayMethod payMethod);

    }
}
