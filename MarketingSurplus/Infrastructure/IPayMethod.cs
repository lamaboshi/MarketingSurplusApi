using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{

    public interface IPayMethod
    {
        public CompanyMethods GetPayMethod(int id);
        public List<CompanyMethods> GetAllPayMethod();
        public List<CompanyMethods> GetPayMethods(int companyId);
        public void Save(PayMethod payMethod, int companyId);
        public void Delete(int id);
        public void Update(CompanyMethods payMethod);

    }
}
