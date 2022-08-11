using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto1.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    Senha = table.Column<string>(type: "TEXT", nullable: true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    IsAdministrador = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsProfissionalDeSaude = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsCidadao = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pontos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Endereco = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pontos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    Estoque = table.Column<int>(type: "INTEGER", nullable: false),
                    PontoDeVacinacaoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacina_Pontos_PontoDeVacinacaoId",
                        column: x => x.PontoDeVacinacaoId,
                        principalTable: "Pontos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CidadaoId = table.Column<int>(type: "INTEGER", nullable: true),
                    PontoId = table.Column<int>(type: "INTEGER", nullable: true),
                    VacinaId = table.Column<int>(type: "INTEGER", nullable: true),
                    Horario = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProfissionalResponsavelId = table.Column<int>(type: "INTEGER", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Contas_CidadaoId",
                        column: x => x.CidadaoId,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Contas_ProfissionalResponsavelId",
                        column: x => x.ProfissionalResponsavelId,
                        principalTable: "Contas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Pontos_PontoId",
                        column: x => x.PontoId,
                        principalTable: "Pontos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Vacina_VacinaId",
                        column: x => x.VacinaId,
                        principalTable: "Vacina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_CidadaoId",
                table: "Agendamentos",
                column: "CidadaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_PontoId",
                table: "Agendamentos",
                column: "PontoId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_ProfissionalResponsavelId",
                table: "Agendamentos",
                column: "ProfissionalResponsavelId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_VacinaId",
                table: "Agendamentos",
                column: "VacinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacina_PontoDeVacinacaoId",
                table: "Vacina",
                column: "PontoDeVacinacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "Vacina");

            migrationBuilder.DropTable(
                name: "Pontos");
        }
    }
}
