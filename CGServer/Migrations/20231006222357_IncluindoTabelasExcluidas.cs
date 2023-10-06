using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CGServer.Migrations
{
    /// <inheritdoc />
    public partial class IncluindoTabelasExcluidas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Lancamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FavorecidoId",
                table: "Lancamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Lancamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstituicaoId",
                table: "Lancamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModalidadeId",
                table: "Lancamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PagadorId",
                table: "Lancamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoriaId",
                table: "Lancamentos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Favorecidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorecidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instituicoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modalidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pagadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategorias_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_CategoriaId",
                table: "Lancamentos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_FavorecidoId",
                table: "Lancamentos",
                column: "FavorecidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_FornecedorId",
                table: "Lancamentos",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_InstituicaoId",
                table: "Lancamentos",
                column: "InstituicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_ModalidadeId",
                table: "Lancamentos",
                column: "ModalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_PagadorId",
                table: "Lancamentos",
                column: "PagadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamentos_SubCategoriaId",
                table: "Lancamentos",
                column: "SubCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorias_CategoriaId",
                table: "SubCategorias",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Categorias_CategoriaId",
                table: "Lancamentos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Favorecidos_FavorecidoId",
                table: "Lancamentos",
                column: "FavorecidoId",
                principalTable: "Favorecidos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Fornecedores_FornecedorId",
                table: "Lancamentos",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Instituicoes_InstituicaoId",
                table: "Lancamentos",
                column: "InstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Modalidades_ModalidadeId",
                table: "Lancamentos",
                column: "ModalidadeId",
                principalTable: "Modalidades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Pagadores_PagadorId",
                table: "Lancamentos",
                column: "PagadorId",
                principalTable: "Pagadores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_SubCategorias_SubCategoriaId",
                table: "Lancamentos",
                column: "SubCategoriaId",
                principalTable: "SubCategorias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Categorias_CategoriaId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Favorecidos_FavorecidoId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Fornecedores_FornecedorId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Instituicoes_InstituicaoId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Modalidades_ModalidadeId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Pagadores_PagadorId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_SubCategorias_SubCategoriaId",
                table: "Lancamentos");

            migrationBuilder.DropTable(
                name: "Favorecidos");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "Instituicoes");

            migrationBuilder.DropTable(
                name: "Modalidades");

            migrationBuilder.DropTable(
                name: "Pagadores");

            migrationBuilder.DropTable(
                name: "SubCategorias");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Lancamentos_CategoriaId",
                table: "Lancamentos");

            migrationBuilder.DropIndex(
                name: "IX_Lancamentos_FavorecidoId",
                table: "Lancamentos");

            migrationBuilder.DropIndex(
                name: "IX_Lancamentos_FornecedorId",
                table: "Lancamentos");

            migrationBuilder.DropIndex(
                name: "IX_Lancamentos_InstituicaoId",
                table: "Lancamentos");

            migrationBuilder.DropIndex(
                name: "IX_Lancamentos_ModalidadeId",
                table: "Lancamentos");

            migrationBuilder.DropIndex(
                name: "IX_Lancamentos_PagadorId",
                table: "Lancamentos");

            migrationBuilder.DropIndex(
                name: "IX_Lancamentos_SubCategoriaId",
                table: "Lancamentos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Lancamentos");

            migrationBuilder.DropColumn(
                name: "FavorecidoId",
                table: "Lancamentos");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Lancamentos");

            migrationBuilder.DropColumn(
                name: "InstituicaoId",
                table: "Lancamentos");

            migrationBuilder.DropColumn(
                name: "ModalidadeId",
                table: "Lancamentos");

            migrationBuilder.DropColumn(
                name: "PagadorId",
                table: "Lancamentos");

            migrationBuilder.DropColumn(
                name: "SubCategoriaId",
                table: "Lancamentos");
        }
    }
}
