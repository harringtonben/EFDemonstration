using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFDemonstration.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Farm")
        {

        }

        public DbSet<Farm> Farms { get; set; }
        public DbSet<Cow> Cows { get; set; }
    }
}