using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.Helpers
{
    public static class Helper
    {
        public static int CalculateAge(this DateTime birthDate)
        {
            var timeSpan = DateTime.Now - birthDate;
            int age;
            try
            {
                age = new DateTime(timeSpan.Ticks).Year - 1;
            }
            catch (Exception)
            {
                return default;
            }
            return age;
        }
    }
}
