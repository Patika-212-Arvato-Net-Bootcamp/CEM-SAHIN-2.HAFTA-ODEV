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
    public class BootcampRepository : IBootcampRepository //Oluşturduğum Interface'den kalıtım aldık ve implementasyon ettim
    {
        //Yapıcağım CRUD işlemlerinin kodlarını buraya yazdım
        public async  Task<Bootcamp> CreateBootcamp(Bootcamp bootcamp) //Bootcamp oluşturma kodları
        {

            using (var bootcampDbContext = new ApıDbContext())

            {
               bootcampDbContext.Bootcamps.Add(bootcamp);
             await   bootcampDbContext.SaveChangesAsync();
                return bootcamp;
            }
        }

        public async Task DeleteBootcamp(int id) //Bootcamp silme kodları
        {
            using (var bootcampDbContext = new ApıDbContext())

            {
                var deleteBootcamp = await GetBootcampById(id);
               bootcampDbContext.Bootcamps.Remove(deleteBootcamp);
               await bootcampDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Bootcamp>> GetAllBootcamps()//Bütün bootcampleri getirme kodları
        {
            using (var bootcampDbContext = new ApıDbContext())

            {
                return await bootcampDbContext.Bootcamps.ToListAsync();
            }
        }

        public async Task<Bootcamp> GetBootcampById(int id)//Id'e göre bootcamp getirme kodları
        {
            using (var bootcampDbContext = new ApıDbContext())

            {
                return await bootcampDbContext.Bootcamps.FindAsync(id);
            }
        }

        public async Task<Bootcamp> GetBootcampByName(string name)//İsme göre bootcamp getirme kodları
        {
            using (var bootcampDbContext = new ApıDbContext())

            {
                return await bootcampDbContext.Bootcamps.FirstOrDefaultAsync(x=>x.BootcampName.ToLower()==name.ToLower());
            }
        }

        public async Task<Bootcamp> UpdateBootcamp(Bootcamp bootcamp)//Bootcamp güncelleme kodları
        {
            using (var bootcampDbContext = new ApıDbContext())

            {
                bootcampDbContext.Bootcamps.Update(bootcamp);
              await  bootcampDbContext.SaveChangesAsync();
                return bootcamp;
            }

        }
    }
}
