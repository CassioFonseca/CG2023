using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CGServer.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoTesteX2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DbSetTesteXId",
                table: "SubCategorias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TesteX",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TesteX", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorias_DbSetTesteXId",
                table: "SubCategorias",
                column: "DbSetTesteXId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategorias_TesteX_DbSetTesteXId",
                table: "SubCategorias",
                column: "DbSetTesteXId",
                principalTable: "TesteX",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategorias_TesteX_DbSetTesteXId",
                table: "SubCategorias");

            migrationBuilder.DropTable(
                name: "TesteX");

            migrationBuilder.DropIndex(
                name: "IX_SubCategorias_DbSetTesteXId",
                table: "SubCategorias");

            migrationBuilder.DropColumn(
                name: "DbSetTesteXId",
                table: "SubCategorias");
        }
    }
}
