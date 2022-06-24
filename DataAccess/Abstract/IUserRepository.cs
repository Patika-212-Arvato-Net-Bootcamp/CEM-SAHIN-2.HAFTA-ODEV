using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserRepository//User Crud işlemleri için Repository Interface'i oluşturdum
    {

        Task<List<User>> GetAllUsers();//Bütün User'lar gesin
        Task<User> GetUserById(int id);//Id'e göre user gelsin
        Task<User> GetUserByName(string name);//Isme göre user gelsin
        Task<User> CreateUser(User user);//User oluştursun
        Task DeleteUser(int id);//Id'e göre user silsin
        Task<User> UpdateUser(User user);//User güncellesin

    }
}
