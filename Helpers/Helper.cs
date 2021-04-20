using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.Helpers
{
    public static class Helper
    {
        public static string CalculateAge(this DateTime birthDate)
        {
            var today = DateTime.Now.Date;
            var different = today - birthDate;
            string age = "";
            try 
            {
                var yearSpan = new DateTime(different.Ticks).Year - 1;

                if(yearSpan > 0)
                {
                    age = AddStringToAge_Year(yearSpan);
                    return age;
                }
                else
                {
                    var monthSpan = new DateTime(different.Ticks).Month - 1;
                    age = AddStringToAge_Month(monthSpan);
                    return age;
                }
            }
            catch (Exception)
            {
                return default;
            }
        }


        static string AddStringToAge_Year(int yearSpan)
        {
            string stringToAge = "";
            
                if (yearSpan == 1)
                {
                    stringToAge = $"{yearSpan} rok";
                }
                else if (yearSpan > 1 && yearSpan < 5 || yearSpan > 21 && yearSpan < 25)
                {
                    stringToAge = $"{yearSpan} lata";
                }
                else if (yearSpan >= 5)
                {
                    stringToAge = $"{yearSpan} lat";
                }
            return stringToAge;
        }


        static string AddStringToAge_Month(int monthSpan)
        {
            string stringToAge = "";

            if (monthSpan == 1)
            {
                stringToAge = $"{monthSpan} miesiąc";
            }
            else if (monthSpan > 1 && monthSpan < 5)
            {
                stringToAge = $"{monthSpan} miesiące";
            }
            else
            {
                stringToAge = $"{monthSpan} miesięcy";
            }

            return stringToAge;
        }
    }
}
