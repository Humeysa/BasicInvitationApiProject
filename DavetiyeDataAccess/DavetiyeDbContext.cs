using DavetiyeEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeDataAccess
{
    public class DavetiyeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS ; Database=DavetiyeDb ; Trusted_Connection=true ;");
        }

        public DbSet<Davetiye> Davetiye { get; set; }
    }
}
