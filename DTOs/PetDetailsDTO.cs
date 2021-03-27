﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.DTOs
{
    public class PetDetailsDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime InShelter { get; set; }
        public string Description { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
    }
}