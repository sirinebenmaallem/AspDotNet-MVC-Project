using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MonProjetdotNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parfum_Sweetmeat>().HasKey(am => new
            {
                am.ParfumId,
                am.SweetmeatId
            });
            modelBuilder.Entity<Parfum_Sweetmeat>().HasOne(m => m.Sweetmeat).WithMany(am => am.Parfum_Sweetmeat).HasForeignKey(m =>
                m.SweetmeatId);
            modelBuilder.Entity<Parfum_Sweetmeat>().HasOne(m => m.Parfum).WithMany(am => am.Parfum_Sweetmeat).HasForeignKey(m =>
               m.ParfumId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Parfum> Parfums { get; set; }
        public DbSet<Sweetmeat> Sweetmeats { get; set; }
        public DbSet<Parfum_Sweetmeat> Parfum_Sweetmeats { get; set; }
        public DbSet<Chef> Chefs { get; set; }

    }
}
