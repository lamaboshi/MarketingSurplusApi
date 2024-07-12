using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;

namespace MarketingSurplus.Data
{
    public class CompanyRepo : ICompany
    {
        private readonly MarketingSurplusDbContext _db;
        public CompanyRepo(MarketingSurplusDbContext db)
        {
            _db = db;
        }


        public void Delete(int id)
        {
            var result = _db.Companies.FirstOrDefault(p => p.Id == id);
            if (result != null)
            {

                _db.Companies.Remove(result);
                _db.SaveChanges();
            }
        }

        public Company GetCompany(int id)
        {
            var result = _db.Companies.First(p => p.Id == id);
            if (result != null) return result;
            else return null;
        }

        public void Save(Company company)
        {

            if (company.Id == 0)
            {
                _db.Companies.Add(company);
                _db.SaveChanges();
            }
        }

        public void Update(Company company)
        {
            if (company.Id != 0)
            {
                var companyEntity = _db.Companies.First(t => t.Id == company.Id);
                if (companyEntity != null)
                {
                    companyEntity.Name = company.Name;
                    companyEntity.Phone = company.Phone;
                    companyEntity.Email = company.Email;
                    companyEntity.TelePhone = company.TelePhone;
                    companyEntity.Address = company.Address;
                    companyEntity.Image = company.Image;
                    companyEntity.LicenseNumber = company.LicenseNumber;
                    companyEntity.Description = company.Description;
                    companyEntity.CompanyTypeId = company.CompanyTypeId;
                    _db.SaveChanges();
                }
            }
        }
        public bool IsExisting(string email)
        {
            bool data = _db.Companies.Any(p => p.Email == email);
            if (data == false)
            {
                return false;
            }
            return true;
        }
        public void ChangePassword(int Id, string password)
        {
            var data = _db.Companies.First(p => p.Id == Id);
            if (data != null)
            {
                data.Password = password;
                _db.SaveChanges();
            }

        }


        public List<Company> GetCompanys()
        {
            var data = _db.Companies.ToList();
            return data;
        }

        public void AcceptCompany(int idUser, bool accept)
        {
            if (accept)
            {
                var company = _db.Companies.Where(q => q.Id == idUser).FirstOrDefault();
                company.isAccept = true;
                _db.SaveChanges();
            }
        }
    }
}
