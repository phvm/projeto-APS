﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto1.Data;

namespace Projeto1.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220811001253_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Projeto1.Entidades.Agendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CidadaoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PontoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProfissionalResponsavelId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("VacinaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CidadaoId");

                    b.HasIndex("PontoId");

                    b.HasIndex("ProfissionalResponsavelId");

                    b.HasIndex("VacinaId");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("Projeto1.Entidades.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdministrador")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCidadao")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsProfissionalDeSaude")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("Projeto1.Entidades.PontoDeVacinacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pontos");
                });

            modelBuilder.Entity("Projeto1.Entidades.Vacina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int>("Estoque")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PontoDeVacinacaoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PontoDeVacinacaoId");

                    b.ToTable("Vacina");
                });

            modelBuilder.Entity("Projeto1.Entidades.Agendamento", b =>
                {
                    b.HasOne("Projeto1.Entidades.Conta", "Cidadao")
                        .WithMany()
                        .HasForeignKey("CidadaoId");

                    b.HasOne("Projeto1.Entidades.PontoDeVacinacao", "Ponto")
                        .WithMany()
                        .HasForeignKey("PontoId");

                    b.HasOne("Projeto1.Entidades.Conta", "ProfissionalResponsavel")
                        .WithMany()
                        .HasForeignKey("ProfissionalResponsavelId");

                    b.HasOne("Projeto1.Entidades.Vacina", "Vacina")
                        .WithMany()
                        .HasForeignKey("VacinaId");

                    b.Navigation("Cidadao");

                    b.Navigation("Ponto");

                    b.Navigation("ProfissionalResponsavel");

                    b.Navigation("Vacina");
                });

            modelBuilder.Entity("Projeto1.Entidades.Vacina", b =>
                {
                    b.HasOne("Projeto1.Entidades.PontoDeVacinacao", null)
                        .WithMany("Vacinas")
                        .HasForeignKey("PontoDeVacinacaoId");
                });

            modelBuilder.Entity("Projeto1.Entidades.PontoDeVacinacao", b =>
                {
                    b.Navigation("Vacinas");
                });
#pragma warning restore 612, 618
        }
    }
}
