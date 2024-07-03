using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;

namespace MarketingSurplus.Data
{
    public class UserRepo : IUser
    {
        private readonly MarketingSurplusDbContext _db;
        public UserRepo(MarketingSurplusDbContext db)
        {
            _db = db;
        }
        public List<User> GetUsers()
        {
            var data = _db.Users.ToList();
            return data;
        }
        public void Delete(int id)
        {
            var result = _db.Users.First(p => p.Id == id);
            if (result != null)
            {
                _db.Users.Remove(result);

                _db.SaveChanges();
            }
        }

        public User GetUser(int id)
        {
            var result = _db.Users.First(p => p.Id == id);
            if (result != null) return result;
            else return null;
        }

        public void Save(User user)
        {

            if (user.Id == 0)
            {
                _db.Users.Add(user);
                _db.SaveChanges();
            }
        }

        public void Update(User user)
        {
            if (user.Id != 0)
            {
                var userEntity = _db.Users.First(t => t.Id == user.Id);
                if (userEntity != null)
                {
                    userEntity.Name = user.Name;
                    userEntity.Image = user.Image;
                    userEntity.Age = user.Age;
                    userEntity.Password = user.Password;
                    userEntity.PayPal = user.PayPal;
                    userEntity.Phone = user.Phone;
                    userEntity.UserName = user.UserName;
                    userEntity.Email = user.Email;
                    _db.SaveChanges();
                }
            }
        }
        public bool IsExisting(string email)
        {
            bool data = _db.Users.Any(p => p.Email == email);
            if (data == false)
            {
                return false;
            }
            return true;
        }
        public void ChangePassword(int Id, string password)
        {
            var data = _db.Users.First(p => p.Id == Id);
            if (data != null)
            {
                data.Password = password;
                _db.SaveChanges();
            }
        }

        public void AcceptUser(int idUser, bool accept)
        {
            if (accept)
            {
                var user = _db.Users.Where(q => q.Id == idUser).FirstOrDefault();
                user.isAccept = true;
                _db.SaveChanges();
            }
        }
    }
}
