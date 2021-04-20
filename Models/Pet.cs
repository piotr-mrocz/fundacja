using System;

namespace FundacjaZawszeRazem
{
    public class Pet
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
        public DateTime InShelter { get; set; }
        public string Description { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
    }
}
