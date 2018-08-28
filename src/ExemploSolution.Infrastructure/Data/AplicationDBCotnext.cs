using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");

            #region Configurações de Cliente

            modelBuilder.Entity<Cliente>().Property(e => e.Cpf)
                .HasColumnType("varchar(11)")
                .IsRequired();
            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Telefone)
                .HasColumnType("varchar(20)");

            #endregion

            #region Configurações de Contatos

            modelBuilder.Entity<Contato>().Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();
            modelBuilder.Entity<Contato>().Property(e => e.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Contato>().Property(e => e.Telefone)
                .HasColumnType("varchar(15)");

            #endregion
        }
         
    }
}
