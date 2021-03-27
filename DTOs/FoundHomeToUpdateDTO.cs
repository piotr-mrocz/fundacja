using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.DTOs
{
    public class FoundHomeToUpdateDTO
    {
        [Required(ErrorMessage = "Data adopcji jest wymagana")]
        public DateTime Adopted { get; set; }

        [Required(ErrorMessage = "Zdjęcie jest wymagane")]
        public string Photo { get; set; }
    }
}
