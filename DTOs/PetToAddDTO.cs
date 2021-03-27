using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.DTOs
{
    public class PetToAddDTO
    {
        [Required(ErrorMessage = "Nazwa zwierzaka jest wymagana")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Data urodzenia lub przypuszczalna data urodzenia jest wymagana")]
        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        [Required(ErrorMessage = "Data przybycia do schroniska jest wymagana")]
        public DateTime InShelter { get; set; }

        [Required(ErrorMessage = "Opis jest wymagany")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Podanie gatunku jest wymagane")]
        public string Species { get; set; }

        [Required(ErrorMessage = "Podanie płci jest wymagane")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Zdjęcie jest wymagane")]
        public string Photo { get; set; }
    }
}
