using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.DTOs
{
    public class RecentlyFoundToAddDTO
    {
        [Required(ErrorMessage = "Zaznaczenie obecności chipa jest wymagana")]
        public bool Chip { get; set; }
        public string ChipSequence { get; set; }

        [Required(ErrorMessage = "Data znalezienia zwierzęcia jest wymagana")]
        public DateTime DateFound { get; set; }
        
        [Required(ErrorMessage = "Miejsce znalezienia zwierzęcia jest wymagana")]
        public string PlaceFound { get; set; }
        
        [Required(ErrorMessage = "Miasto znalezienia zwierzęcia jest wymagana")]
        public string City { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Gatunek zwierzęcia jest wymagany")]
        public string Species { get; set; }

        [Required(ErrorMessage = "Płeć zwierzęcia jest wymagana")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Zdjęcie zwierzęcia jest wymagane")]
        public string Photo { get; set; }
    }
}