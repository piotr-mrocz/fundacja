using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.DTOs
{
    public class RecentlyFoundListDTO
    {
        public int Id { get; set; }
        public DateTime DateFound { get; set; }
        public string Photo { get; set; }
    }
}
