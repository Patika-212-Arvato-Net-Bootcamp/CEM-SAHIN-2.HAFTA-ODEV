using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBootcampRepository //Bootcamp Crud işlemleri için Repository Interface'i oluşturdum
    {
        Task<List<Bootcamp>> GetAllBootcamps(); //Bütün bootcampler gelsin
        Task<Bootcamp> GetBootcampById(int id);//Id'e göre bottcamp gelsin
        Task<Bootcamp> GetBootcampByName(string name);//isme göre bootcamp gelsin
        Task<Bootcamp> CreateBootcamp(Bootcamp bootcamp);//Bootcamp eklesin
        Task DeleteBootcamp(int id);//Bootcamp silsin(id'e göre)
        Task<Bootcamp> UpdateBootcamp(Bootcamp bootcamp);//Bootcamp güncellesin


    }
}
