using Business.Abstract;
using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApıBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase //Admin controller Bootcamp'ler için CRUD işlemleri yapabilir ve User'lar için ise Ekleme,Silme ve Listeleme işlemleri yapar.
    {

        //İşlemlerimde kullanmak için DataAccess'den 2 adet field oluşturdum ve bunları constructor'da  eşledim.
        private IBootcampService _bootcampService;  
        private IUserService _userService;
       
        public AdminController(IBootcampService bootcampService,IUserService userService)
        {
            _bootcampService = bootcampService;
         
            _userService = userService; 
        }


        [HttpGet]
        public async Task<IActionResult> Get() //Bütün bootcamplerin geleceği action kısmı
        {
            var bootcamps = await _bootcampService.GetAllBootcamps();
            return Ok(bootcamps);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetBootcampById(int id) //Id'göre gelecek bootcamp'lerin action kısmı
        {
            var bootcamp = await _bootcampService.GetBootcampById(id);

            if (bootcamp != null)
            {
                return Ok(bootcamp);//200+DATA(başarılı)
            }
            return NotFound(); //404 NOT FOUND(sayfa bulunamadı)

        }

        [HttpGet]
        [Route("[action]/{name}")]
        public async Task<IActionResult> GetBootcampByName(string name) //Isme göre gelecek bootcamplerin action kısmı
        {
            var bootcamp = await _bootcampService.GetBootcampByName(name);

            if (bootcamp != null)
            {
                return Ok(bootcamp);//200+DATA(başarılı)
            }
            return NotFound(); //404 NOT FOUND(sayfa bulunamadı)

        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateBootcamp([FromBody] Bootcamp bootcamp) //Bootcamp ekleme action'ı
        {


            //var createdBootcamp = await _bootcampService.CreateBootcamp(bootcamp);
            var createdBootcamp = await _bootcampService.CreateBootcamp(bootcamp);
            return Ok(bootcamp);//başarılı
            //return CreatedAtAction("Get", new { id = createdBootcamp.BootcampId }, createdBootcamp);//201+data 



        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateBootcamp([FromBody] Bootcamp bootcamp)//Bootcamp güncelleme action'ı
        {
            if (await _bootcampService.GetBootcampById(bootcamp.BootcampId) != null) 
            {

                return Ok(await _bootcampService.UpdateBootcamp(bootcamp));

            }
            return NotFound();
        }


        [HttpDelete]   
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteBootcamp(int id)//Bootcamp silme action'ı
        {
            
            if (await _bootcampService.GetBootcampById(id)!=null)
            {

                var bootcampValue = await _bootcampService.GetBootcampById(id);
                  _bootcampService.DeleteBootcamp(bootcampValue);
                    return Ok(); //Başarılı
            }
            return NotFound();
          
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetUsers() //Bütün User'ların geleceği action
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);//Başarılı
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateUser([FromBody] User user ) //User oluşturma action'ı
        {
            var createdUser = await _userService.CreateUser(user);
            return Ok(user);//Başarılı



        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteUser(int id) //User silme action'ı
        {

            if (await _userService.GetUserById(id) != null)
            {
                await _userService.DeleteUser(id);
                return Ok();//Başarılı
            }
            return NotFound();//Sayfa bulunamadı

        }

    }




}
