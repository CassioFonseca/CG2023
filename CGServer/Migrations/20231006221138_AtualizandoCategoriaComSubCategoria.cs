using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CGServer.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoCategoriaComSubCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "SubCategorias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorias_CategoriaId",
                table: "SubCategorias",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategorias_Categorias_CategoriaId",
                table: "SubCategorias",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategorias_Categorias_CategoriaId",
                table: "SubCategorias");

            migrationBuilder.DropIndex(
                name: "IX_SubCategorias_CategoriaId",
                table: "SubCategorias");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "SubCategorias");
        }
    }
}
