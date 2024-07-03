using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{
    public interface ICharity
    {
        public Charity GetCharity(int id);
        public List<Charity> GetCharities();
        public void Save(Charity charity);
        public void Update(Charity charity);
        public void Delete(int id);
        public bool IsExisting(string email);
        public void AcceptUser(int idUser, bool accept);
        public void ChangePassword(int Id, string password);
    }
}
