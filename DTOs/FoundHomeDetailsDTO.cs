using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.DTOs
{
    public class FoundHomeDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public DateTime Adopted { get; set; }
        public string Description {get; set;}
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }

    }
}
