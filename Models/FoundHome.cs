using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem
{
    public class FoundHome
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Age
        {
            get
            {
                string age = Helpers.Helper.CalculateAge(DateOfBirth);
                return age;
            }
        }
        public string Description {get; set;}
        public DateTime Adopted { get; set; }
        public string Species { get; set; }
         public string Gender { get; set; }
        public string Photo { get; set; }
    }
}
