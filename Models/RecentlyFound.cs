using System;

namespace FundacjaZawszeRazem
{
    public class RecentlyFound
    {
        public int Id { get; set; }
        public bool Chip { get; set; }
        public string ChipSequence { get; set; }
        public DateTime DateFound { get; set; }
        public string PlaceFound { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
    }
}
