using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApıBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BootcampController : ControllerBase//Bootcamp controller bootcampleri Listeleme işlemleri yapar.
    {
        //DataAccess'den bir field oluşturup constructor'da eşledim.

        private IBootcampService _bootcampService;
        private IUserService _userService;  
        public BootcampController(IBootcampService bootcampService,IUserService userService)
        {
            _bootcampService = bootcampService;
            _userService = userService; 
        }


        [HttpGet]
        public async Task<IActionResult> Get() //Bootcampler gelsin
        {
            var bootcamps = await _bootcampService.GetAllBootcamps();
            return Ok(bootcamps);//Başarılı
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetBootcampById(int id)//Id'e göre bootcamp gelsin
        {
            var bootcamp = await _bootcampService.GetBootcampById(id);

            if (bootcamp != null)
            {
                return Ok(bootcamp);//200+DATA(Başarılı)
            }
            return NotFound(); //404 NOT FOUND(Sayfa Bulunamadı)

        }

        [HttpGet]
        [Route("[action]/{name}")]
        public async Task<IActionResult> GetBootcampByName(string name)//Isme göre  bootcamp gelsin.
        {
            var btcmp = await _bootcampService.GetBootcampByName(name);

            if (btcmp != null)
            {
                return Ok(btcmp);//200+DATA(Başarılı)
            }
            return NotFound(); //404 NOT FOUND(Sayfa Bulunamadı)

        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateUser([FromBody] User user) //User oluşturma action'ı
        {
            var createdUser = await _userService.CreateUser(user);
            return Ok(user);//Başarılı



        }


      



    }
}
