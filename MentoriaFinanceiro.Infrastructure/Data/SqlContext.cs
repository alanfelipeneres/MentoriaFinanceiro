using MentoriaFinanceiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MentoriaFinanceiro.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Operacao> Operacoes { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

    }
}
