using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BootcampManager : IBootcampService //Crud işlemlerinin interface'ini katılım yoluyla tanıttım ve impelemente ettim
    {

        //Bu kısımda DataAccess'den bir field oluşturdum ve işlemlerde bunu kullandım.
        private IBootcampRepository _bootcampRepository;

        public BootcampManager(IBootcampRepository bootcampRepository) 
        {
            _bootcampRepository = bootcampRepository;
        }

        public async Task< Bootcamp> CreateBootcamp(Bootcamp bootcamp) // Bootcamp ekleme kısmı
        {
          return await _bootcampRepository.CreateBootcamp(bootcamp);    
        }

        public async Task DeleteBootcamp(Bootcamp bootcamp)// Bootcamp silme kısmı
        {
             bootcamp.Deleted = true;
             bootcamp.Active = false;
           await _bootcampRepository.UpdateBootcamp(bootcamp);// Bootcamp'i güncelleme işlemi ile silinen bootcamp'i false çekiyoruz.
        }

        public async Task<List<Bootcamp>> GetAllBootcamps() //Bütün bootcamp'ler gelsin
        {
            return await _bootcampRepository.GetAllBootcamps();
        }

        public async Task<Bootcamp> GetBootcampById(int id) //ID'e göre bootcamp gelsin
        {
            if (id>0)
            {
                return await _bootcampRepository.GetBootcampById(id);
            }
            throw new Exception("id 1'den küçük olamaz");
        }

        public async Task<Bootcamp> GetBootcampByName(string name)//İsme göre bootcamp gelsin
        {
            return await _bootcampRepository.GetBootcampByName(name); 
        }

        public async Task<Bootcamp> UpdateBootcamp(Bootcamp bootcamp)//Bootcamp güncellensin
        {
            return await _bootcampRepository.UpdateBootcamp(bootcamp);
        }
    }
}
