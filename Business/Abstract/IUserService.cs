using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService//İş katmanı için CRUD işlemlerinin gerçekleştirilmesi için  Interface tanımladım
    {
        Task<List<User>> GetAllUsers();//Bütün kullanıcıları getir
        Task<User> GetUserById(int id);//Id'e göre getir
        Task<User> GetUserByName(string name);//Isme göre getir
        Task<User> CreateUser(User user);//Kullanıcı ekle
        Task<User> UpdateUser(User user);//Kullanıcı güncelle
        Task DeleteUser(int id);//Id'e göre kullanıcı sil


    }
}
