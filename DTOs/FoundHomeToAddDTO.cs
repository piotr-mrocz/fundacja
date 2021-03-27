using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.DTOs
{
    public class FoundHomeToAddDTO
    {
        [Required(ErrorMessage = "Nazwa zwierzaka jest wymagana")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Data adopcji urodzenia jest wymagana")]
        public DateTime Adopted { get; set; }

        [Required(ErrorMessage = "Podanie gatunku jest wymagane")]
        public string Species { get; set; }

        [Required(ErrorMessage = "Podanie płci jest wymagane")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Zdjęcie jest wymagane")]
        public string Photo { get; set; }

    }
}
