using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders3.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SULEYMANPC; database=Ders3; integrated security=true");
        }
        public DbSet <Department> Departments { get; set; }
        public DbSet <Personnel> Personnels { get; set; }
        public DbSet <Admin> Admins { get; set; }

    }
}
