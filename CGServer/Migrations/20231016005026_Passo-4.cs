using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CGServer.Migrations
{
    /// <inheritdoc />
    public partial class Passo4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Lancamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_CategoriaId",
                table: "Lancamentos",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Categorias_CategoriaId",
                table: "Lancamentos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Categorias_CategoriaId",
                table: "Lancamentos");

            migrationBuilder.DropIndex(
                name: "IX_Lancamentos_CategoriaId",
                table: "Lancamentos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Lancamentos");
        }
    }
}
