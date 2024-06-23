using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;

namespace MarketingSurplus.Data
{
    public class CharityRepo : ICharity
    {
        private readonly MarketingSurplusDbContext _db;
        public CharityRepo(MarketingSurplusDbContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            var result = _db.Charities.First(p => p.Id == id);
            if (result != null)
            {
                _db.Charities.Remove(result);

                _db.SaveChanges();
            }
        }





        public bool IsExisting(string email)
        {
            bool data = _db.Charities.Any(p => p.Email == email);
            if (data == false)
            {
                return false;
            }
            return true;
        }
        public void ChangePassword(int Id, string password)
        {
            var data = _db.Charities.First(p => p.Id == Id);
            if (data != null)
            {
                data.Password = password;
                _db.SaveChanges();
            }
        }

        public Charity GetCharity(int id)
        {
            var result = _db.Charities.First(p => p.Id == id);
            if (result != null) return result;
            else return null;
        }

        public List<Charity> GetCharities()
        {
            var data = _db.Charities.ToList();
            return data;
        }

        public void Save(Charity charity)
        {
            if (charity.Id == 0)
            {
                _db.Charities.Add(charity);
                _db.SaveChanges();
            }
        }

        public void Update(Charity charity)
        {
            if (charity.Id != 0)
            {
                var entity = _db.Charities.First(t => t.Id == charity.Id);
                if (entity != null)
                {
                    entity.Name = charity.Name;
                    entity.Image = charity.Image;
                    entity.AssociationLicense = charity.AssociationLicense;
                    entity.Password = charity.Password;
                    entity.Goals = charity.Goals;
                    entity.Phone = charity.Phone;
                    entity.TargetGroup = charity.TargetGroup;
                    entity.Email = charity.Email;
                    _db.SaveChanges();
                }
            }
        }
    }
}
