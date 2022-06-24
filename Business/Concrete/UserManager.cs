using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService //Crud işlemlerinin interface'ini katılım yoluyla tanıttım ve impelemente ettim
    { //Bu kısımda DataAccess'den bir field oluşturdum ve işlemlerde bunu kullandım.
        private IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateUser(User user) //Kullanıcı ekleme kısmı
        {
            return await _userRepository.CreateUser(user);
        }

        public async Task DeleteUser(int id) //Kullanıcıyı Id'e göre veritabanından silme kısmı.Burda bootcamp'in aksine direkt bir silme işlemi uyguladım.
        {
          
            await _userRepository.DeleteUser(id);
        }

      

        public async Task<List<User>> GetAllUsers()//Bütün kullanıcları getir
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<User> GetUserById(int id)//Id'e göre kullanıcı getir.
        {

            if (id > 0)
            {
                return await _userRepository.GetUserById(id);
            }
            throw new Exception("id 1'den küçük olamaz"); //Bunu test için yazdım.
        }

        public  async   Task<User> GetUserByName(string name)//Isme göre kullanıcı getir.
        {
            return await _userRepository.GetUserByName(name);
        }

        public async Task<User> UpdateUser(User user)//Kullanıcı güncelle
        {
            return await _userRepository.UpdateUser(user);
        }
    }
}
