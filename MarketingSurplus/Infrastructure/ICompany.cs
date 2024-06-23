using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{
    public interface ICompany
    {
        public Company GetCompany(int id);
        public List<Company> GetCompanys();
        public void Save(Company company);
        public void Update(Company company);
        public void Delete(int id);
        public bool IsExisting(string email);
        public void ChangePassword(int Id, string password);
    }
}
