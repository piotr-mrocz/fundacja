using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.DTOs
{
    public class RecentlyFoundToUpdateDTO
    {
        [Required(ErrorMessage = "Zaznaczenie obecności chipa jest wymagana")]
        public bool Chip { get; set; }
        public string ChipSequence { get; set; }
        
        [Required(ErrorMessage = "Data znalezienia jest wymagana")]
        public DateTime DateFound { get; set; }

        [Required(ErrorMessage = "Zdjęcie jest wymagane")]
        public string Photo { get; set; }

        [Required(ErrorMessage = "Miejsce znalezienia zwierzęcia jest wymagana")]
        public string PlaceFound { get; set; }

        [Required(ErrorMessage = "Miasto znalezienia zwierzęcia jest wymagana")]
        public string City { get; set; }

         public string Description { get; set; }
    }
}
