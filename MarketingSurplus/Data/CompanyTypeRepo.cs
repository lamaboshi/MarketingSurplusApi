using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;

namespace MarketingSurplus.Data
{

    public class CompanyTypeRepo : ICompanyType
    {
        public readonly MarketingSurplusDbContext _db;
        public CompanyTypeRepo(MarketingSurplusDbContext db)
        {
            _db = db;
        }
        public IQueryable<CompanyType> GetCompanyTypes => _db.CompanyTypes;
        public void Delete(int id)
        {
            var type = _db.CompanyTypes.FirstOrDefault(p => p.Id == id);
            if (type != null)
            {
                _db.CompanyTypes.Remove(type);
                _db.SaveChanges();
            }


        }
        public CompanyType GetCompanyType(int id)
        {
            var type = _db.CompanyTypes.First(p => p.Id == id);
            if (type != null)
                return type;
            else
                return null;
        }
        public void Save(CompanyType companyType)
        {
            if (companyType.Id == 0)
            {
                _db.CompanyTypes.Add(companyType);
                _db.SaveChanges();
            }

        }
        public void Update(CompanyType companyType)
        {
            var type = _db.CompanyTypes.First(p => p.Id == companyType.Id);
            if (type != null)
            {
      
                type.TypeName = companyType.TypeName;
                _db.SaveChanges();
            }
        }
        public CompanyType IsExisting(string Type, string Description)
        {
            var data = _db.CompanyTypes.FirstOrDefault(p => p.TypeName == Type && p.Description == Description);
            if (data != null)
            {
                return data;
            }
            else return null;
        }

    }
}
