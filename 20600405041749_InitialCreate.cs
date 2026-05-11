using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetroAtivos324173957.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ativos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Localizacao = table.Column<string>(type: "TEXT", nullable: false),
                    CapacidadeProducao = table.Column<double>(type: "REAL", nullable: false),
                    DataUltimaInspecao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StatusOperacional = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ativos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ativos");
        }
    }
}
