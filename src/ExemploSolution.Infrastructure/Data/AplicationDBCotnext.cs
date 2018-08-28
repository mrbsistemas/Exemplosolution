using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ExemploSolution.AplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace ExemploSolution.Infrastructure.Data
{
  public class AplicationDBCotnext : DbContext
    {
        public AplicationDBCotnext(DbContextOptions<AplicationDBCotnext> options)
            : base(options)
        {

        }
        public DbSet<Cliente> Coientes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
        }
    }
}
