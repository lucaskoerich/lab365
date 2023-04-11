using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercicio_Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SEMANA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSemana = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Conteudo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AplicadoConteudo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEMANA", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SEMANA");
        }
    }
}
