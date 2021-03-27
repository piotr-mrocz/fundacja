using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.DTOs
{
    public class PetToUpdateDTO
    {
        [Required(ErrorMessage = "Opis jest wymagany")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Zdjęcie jest wymagane")]
        public string Photo { get; set; }
    }
}
