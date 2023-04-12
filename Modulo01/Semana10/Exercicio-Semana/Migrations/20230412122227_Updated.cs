using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercicio_Semana.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CARROS_ID_MARCA",
                table: "CARROS",
                column: "ID_MARCA");

            migrationBuilder.AddForeignKey(
                name: "FK_CARROS_MARCAS_ID_MARCA",
                table: "CARROS",
                column: "ID_MARCA",
                principalTable: "MARCAS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CARROS_MARCAS_ID_MARCA",
                table: "CARROS");

            migrationBuilder.DropIndex(
                name: "IX_CARROS_ID_MARCA",
                table: "CARROS");
        }
    }
}
