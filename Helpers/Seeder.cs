using FundacjaZawszeRazem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.Helpers
{
    public class Seeder
    {
        private readonly DataContext dataContext;

        public Seeder(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }

        public void Seed()
        {
            if (dataContext.Database.CanConnect())
            {
                if (!dataContext.Pets.Any())
                {
                    InsertSampleData();
                }
            }
        }

        private void InsertSampleData()
        {
            var pets = new List<Pet>
            {
                new Pet
                {
                    Name = "Max",
                    DateOfBirth = new DateTime(2016, 04, 09),
                    InShelter = new DateTime(2021, 02, 06),
                    Description = "Test",
                    Species = "Pies",
                    Gender = "Samiec",
                    Photo = "Test"
                },

                new Pet
                {
                    Name = "Elza",
                    DateOfBirth = new DateTime(2018, 08, 16),
                    InShelter = new DateTime(2020, 09, 23),
                    Description = "Test",
                    Species = "Pies",
                    Gender = "Suczka",
                    Photo = "Test"
                }
            };

            dataContext.AddRange(pets);
            dataContext.SaveChanges();

        }
    }
}
