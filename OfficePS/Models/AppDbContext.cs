using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OfficePS.EntityConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.Models
{
   // public class AppDbContext : DbContext
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Procedimentos> Procedimentos { get; set; }

        public DbSet<FeedBack> FeedBacks { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
            
        //    builder.ApplyConfiguration<Procedimentos>(new ProcedimentosConfig());
        //}

    }
}
