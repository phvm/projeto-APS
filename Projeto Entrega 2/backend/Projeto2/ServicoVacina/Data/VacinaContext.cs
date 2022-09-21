using Microsoft.EntityFrameworkCore;
using ServicoVacina.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoVacina.Data
{
    public class VacinaContext : DbContext
    {
        public VacinaContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Vacina> Vacinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Vacina>();
        }
    }
}
