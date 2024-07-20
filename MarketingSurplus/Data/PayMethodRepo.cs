using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.EntityFrameworkCore;

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
            var type = _db.CompanyMethods.FirstOrDefault(p => p.Id == id);
            if (type != null)
            {
                _db.CompanyMethods.Remove(type);
                _db.SaveChanges();
            }
        }

        public List<CompanyMethods> GetAllPayMethod()
        {
            var data = _db.CompanyMethods.Include(r => r.Company).Include(r => r.PayMethod).ToList();
            return data;
        }

        public CompanyMethods GetPayMethod(int id)
        {
            var type = _db.CompanyMethods.First(p => p.Id == id);
            if (type != null)
                return type;
            else
                return null;
        }

        public List<CompanyMethods> GetPayMethods(int companyId)
        {
             var data=_db.CompanyMethods.Where(p=>p.CompanyId==companyId).Include(r=>r.PayMethod).ToList();
            return data;
        }

        public void Save(PayMethod payMethod, int companyId)
        {
            if (payMethod.Id == 0)
            {
              var result=  _db.PayMethods.Add(payMethod);
                _db.SaveChanges();
                _db.CompanyMethods.Add(new CompanyMethods { CompanyId = companyId, PayMethodId = result.Entity.Id });
                _db.SaveChanges();
            }
        }

        public void Update(CompanyMethods payMethod)
        {
            var type = _db.PayMethods.First(p => p.Id == payMethod.Id);
            if (type != null)
            {

    
            }
        }
    }
}
