using Microsoft.EntityFrameworkCore;
using ServicoConta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoConta.Data
{
    public class ContaContext : DbContext
    {
        public ContaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Conta> Contas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Cidadao>();

            builder.Entity<ProfissionalDeSaude>();

            builder.Entity<Admin>();            
        }
    }
}
