using FundacjaZawszeRazem;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<FoundHome> Homes { get; set; }

        public DbSet<RecentlyFound> Found { get; set; }
    }
}
