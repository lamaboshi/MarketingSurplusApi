using MarketingSurplus.Dto;
using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;

namespace MarketingSurplus.Data
{
    public class AuthRepo:IAuth
    {
        private readonly MarketingSurplusDbContext _db;
        public AuthRepo(MarketingSurplusDbContext db)
        {
            _db = db;
        }
        public object? GetAuth(string email, string password)
        {
            var data = _db.Users.Where(t => t.Email == email && t.Password == password).FirstOrDefault();
            if (data != null) return new AuthDto { Data = data, Type = "user" };
            var dataComapny = _db.Companies.Where(t => t.Email == email && t.Password == password).FirstOrDefault();
            if (dataComapny != null) return new AuthDto { Data = dataComapny, Type = "comapny" };
            var dataCharity = _db.Charities.Where(t => t.Email == email && t.Password == password).FirstOrDefault();
            if (dataCharity != null) return new AuthDto { Data = dataCharity, Type = "charity" };
            return null;
        }
        public object? GetEmail(string email)
        {
            var dataUser = _db.Users.Where(p => p.Email == email).FirstOrDefault();
            if (dataUser != null)
            {
                return new IsExistingDto { Id = dataUser.Id, Type = "user" };
            }
            var dataCompany = _db.Companies.Where(p => p.Email == email).FirstOrDefault();
            if (dataCompany != null)
            {
                return new IsExistingDto { Id = dataCompany.Id, Type = "company" };
            }
            var dataCharity = _db.Charities.Where(t => t.Email == email ).FirstOrDefault();
            if (dataCharity != null)
            {
                return new IsExistingDto { Id = dataCharity.Id, Type = "charity" };
            }
            return null;
        }
    }
}
