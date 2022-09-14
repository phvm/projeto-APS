using Microsoft.EntityFrameworkCore;
using Projeto1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<PontoDeVacinacao> Pontos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }

        public DbSet<Vacina> Vacinas { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Cidadao>();

            builder.Entity<ProfissionalDeSaude>();

            builder.Entity<Administrador>();

            builder.Entity<Agendamento>()
                .HasOne(a => a.Cidadao)
                .WithMany();

            builder.Entity<Agendamento>()
                .HasOne(a => a.Ponto)
                .WithMany();

            builder.Entity<Agendamento>()
                .HasOne(a => a.Vacina)
                .WithMany();

            builder.Entity<Agendamento>()
                .HasOne(a => a.ProfissionalResponsavel)
                .WithMany();

            builder.Entity<PontoDeVacinacao>()
                .HasMany(p => p.Estoques)
                .WithOne();
        }
    }
}
