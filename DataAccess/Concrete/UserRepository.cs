using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UserRepository : IUserRepository //Oluşturdugum Interface'i kalıtım olarak ekledim ve implementasyonunu yaptım
    {
      

        public async Task<User> CreateUser(User user) //User ekleme işlemi için kodlar
        {
            using (var userDbContext = new ApıDbContext())

            {
                userDbContext.Users.Add(user);
                await userDbContext.SaveChangesAsync();
                return user;
            }
        }

        public async Task DeleteUser(int id)//User silme işlemi için kodlar
        {
            using (var userDbContext = new ApıDbContext())

            {
                var deleteUser = await GetUserById(id);
                userDbContext.Users.Remove(deleteUser);
                await userDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<User>> GetAllUsers()//Bütün user'ları getirecek kodlar
        {
            using (var userDbContext = new ApıDbContext())

            {
                return await userDbContext.Users.ToListAsync();
            }
        }

        public async Task<User> GetUserByName(string name)//İsme göre gelecek user kodları 
        {
            using (var userDbContext = new ApıDbContext())

            {
                return await userDbContext.Users.FirstOrDefaultAsync(x => x.NameSurname.ToLower() == name.ToLower());
            }
        }

        public  async Task<User> GetUserById(int id)//Id'e göre gelecek kodlar
        {

            using (var userDbContext = new ApıDbContext())

            {
                return await userDbContext.Users.FindAsync(id);
            }
        }

        public async Task<User> UpdateUser(User user)//User güncelleme kodları
        {
            using (var userDbContext = new ApıDbContext())

            {
                userDbContext.Users.Update(user);
                userDbContext.SaveChangesAsync();
                return user;
            }
        }
    }
}
