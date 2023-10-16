using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CGServer.Migrations
{
    /// <inheritdoc />
    public partial class _16102 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FavorecidoId",
                table: "Lancamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Lancamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstituicaoId",
                table: "Lancamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModalidadeId",
                table: "Lancamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagadorId",
                table: "Lancamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoriaId",
                table: "Lancamentos",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Favorecidos_FavorecidoId",
                table: "Lancamentos",
                column: "FavorecidoId",
                principalTable: "Favorecidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Modalidades_ModalidadeId",
                table: "Lancamentos",
                column: "ModalidadeId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_Pagadores_PagadorId",
                table: "Lancamentos",
                column: "PagadorId",
                principalTable: "Pagadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
