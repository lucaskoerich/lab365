using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula02.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Ano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SEMANA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMes = table.Column<int>(type: "int", nullable: false),
                    Dia = table.Column<int>(type: "int", nullable: false),
                    MesModel = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEMANA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SEMANA_MES_MesModel",
                        column: x => x.MesModel,
                        principalTable: "MES",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SEMANA_MesModel",
                table: "SEMANA",
                column: "MesModel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SEMANA");

            migrationBuilder.DropTable(
                name: "MES");
        }
    }
}
