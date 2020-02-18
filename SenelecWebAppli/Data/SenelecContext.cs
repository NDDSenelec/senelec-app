using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SenelecWebAppli.Models;

namespace SenelecWebAppli.Data
{
    public class SenelecContext : DbContext
    {
        public SenelecContext (DbContextOptions<SenelecContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        

        public DbSet<SenelecWebAppli.Models.Product> Product { get; set; }
    }
}
