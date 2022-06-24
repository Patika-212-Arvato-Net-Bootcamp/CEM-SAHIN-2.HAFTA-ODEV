using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User//Users adınnda olusacak tablo adı ve içerikleri
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz")]
        public string NameSurname { get; set; }
        public int BootcampId { get; set; }
    



    }
}
