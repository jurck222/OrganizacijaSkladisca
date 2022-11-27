using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web.Models;
namespace web.Data
{
    public class SkladisceContext : DbContext
    {
        public SkladisceContext(DbContextOptions<SkladisceContext> options) : base(options)
        {
        }
        public DbSet<Izdelek> Izdelki { get; set; }
        public DbSet<Skladisce> Skladisca { get; set; }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Izdelek>().ToTable("Izdelek");
            modelBuilder.Entity<Skladisce>().ToTable("Skladisce");
        }
    }
}