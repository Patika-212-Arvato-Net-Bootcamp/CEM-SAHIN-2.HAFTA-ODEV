using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBootcampService//İş katmanı için CRUD işlemlerinin gerçekleştirilmesi için  Interface tanımladım
    {
      Task<List<Bootcamp>> GetAllBootcamps(); //Bütün bootcampler gelsin
        Task<Bootcamp> GetBootcampById(int id);//Id'e göre bootcamp gelsin
        Task<Bootcamp> GetBootcampByName(string name);//Isme göre bootcamp gelsin
        Task<Bootcamp> CreateBootcamp(Bootcamp bootcamp);//Bootcamp eklesin
        Task<Bootcamp> UpdateBootcamp(Bootcamp bootcamp);//Bootcamp guncellesin
        Task DeleteBootcamp(Bootcamp bootcamp);//Bootcamp silsin
            
            

    }
}
