using MarketingSurplus.Models;

namespace MarketingSurplus.Infrastructure
{
    public interface IUser
    {
        public User GetUser(int id);
        public List<User> GetUsers();
        public void Save(User user);
        public void Update(User user);
        public void Delete(int id);
        public bool IsExisting(string email);
        public void ChangePassword(int Id, string password);
 }
}
