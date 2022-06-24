using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bootcamp//Bootcamps adınnda olusacak tablo adı ve içerikleri
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BootcampId { get; set; }
        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz")]
        public string BootcampName { get; set; }
        [Required(ErrorMessage = "Lütfen bu alanı doldurunuz")]
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedDate { get; set; }
      
        


    }
}
