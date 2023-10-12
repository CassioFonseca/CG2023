using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CGServer.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoTesteX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategorias_Categorias_CategoriaId",
                table: "SubCategorias");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "SubCategorias",
                newName: "DbSetCategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategorias_CategoriaId",
                table: "SubCategorias",
                newName: "IX_SubCategorias_DbSetCategoriaId");

            migrationBuilder.RenameColumn(
                name: "SubCategoriaId",
                table: "Lancamentos",
                newName: "DbSetSubCategoriaId");

            migrationBuilder.RenameColumn(
                name: "PagadorId",
                table: "Lancamentos",
                newName: "DbSetPagadorId");

            migrationBuilder.RenameColumn(
                name: "ModalidadeId",
                table: "Lancamentos",
                newName: "DbSetModalidadeId");

            migrationBuilder.RenameColumn(
                name: "InstituicaoId",
                table: "Lancamentos",
                newName: "DbSetInstituicaoId");

            migrationBuilder.RenameColumn(
                name: "FornecedorId",
                table: "Lancamentos",
                newName: "DbSetFornecedorId");

            migrationBuilder.RenameColumn(
                name: "FavorecidoId",
                table: "Lancamentos",
                newName: "DbSetFavorecidoId");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Lancamentos",
                newName: "DbSetCategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_SubCategoriaId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_DbSetSubCategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_PagadorId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_DbSetPagadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_ModalidadeId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_DbSetModalidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_InstituicaoId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_DbSetInstituicaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_FornecedorId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_DbSetFornecedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_FavorecidoId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_DbSetFavorecidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_CategoriaId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_DbSetCategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Categorias_DbSetCategoriaId",
                table: "Lancamentos",
                column: "DbSetCategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Favorecidos_DbSetFavorecidoId",
                table: "Lancamentos",
                column: "DbSetFavorecidoId",
                principalTable: "Favorecidos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Fornecedores_DbSetFornecedorId",
                table: "Lancamentos",
                column: "DbSetFornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Instituicoes_DbSetInstituicaoId",
                table: "Lancamentos",
                column: "DbSetInstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Modalidades_DbSetModalidadeId",
                table: "Lancamentos",
                column: "DbSetModalidadeId",
                principalTable: "Modalidades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Pagadores_DbSetPagadorId",
                table: "Lancamentos",
                column: "DbSetPagadorId",
                principalTable: "Pagadores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_SubCategorias_DbSetSubCategoriaId",
                table: "Lancamentos",
                column: "DbSetSubCategoriaId",
                principalTable: "SubCategorias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategorias_Categorias_DbSetCategoriaId",
                table: "SubCategorias",
                column: "DbSetCategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Categorias_DbSetCategoriaId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Favorecidos_DbSetFavorecidoId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Fornecedores_DbSetFornecedorId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Instituicoes_DbSetInstituicaoId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Modalidades_DbSetModalidadeId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_Pagadores_DbSetPagadorId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_SubCategorias_DbSetSubCategoriaId",
                table: "Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategorias_Categorias_DbSetCategoriaId",
                table: "SubCategorias");

            migrationBuilder.RenameColumn(
                name: "DbSetCategoriaId",
                table: "SubCategorias",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategorias_DbSetCategoriaId",
                table: "SubCategorias",
                newName: "IX_SubCategorias_CategoriaId");

            migrationBuilder.RenameColumn(
                name: "DbSetSubCategoriaId",
                table: "Lancamentos",
                newName: "SubCategoriaId");

            migrationBuilder.RenameColumn(
                name: "DbSetPagadorId",
                table: "Lancamentos",
                newName: "PagadorId");

            migrationBuilder.RenameColumn(
                name: "DbSetModalidadeId",
                table: "Lancamentos",
                newName: "ModalidadeId");

            migrationBuilder.RenameColumn(
                name: "DbSetInstituicaoId",
                table: "Lancamentos",
                newName: "InstituicaoId");

            migrationBuilder.RenameColumn(
                name: "DbSetFornecedorId",
                table: "Lancamentos",
                newName: "FornecedorId");

            migrationBuilder.RenameColumn(
                name: "DbSetFavorecidoId",
                table: "Lancamentos",
                newName: "FavorecidoId");

            migrationBuilder.RenameColumn(
                name: "DbSetCategoriaId",
                table: "Lancamentos",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_DbSetSubCategoriaId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_SubCategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_DbSetPagadorId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_PagadorId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_DbSetModalidadeId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_ModalidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_DbSetInstituicaoId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_InstituicaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_DbSetFornecedorId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_FornecedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_DbSetFavorecidoId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_FavorecidoId");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_DbSetCategoriaId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_CategoriaId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategorias_Categorias_CategoriaId",
                table: "SubCategorias",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }
    }
}
