using Microsoft.EntityFrameworkCore.Migrations;

namespace CursoMV.Migrations
{
    public partial class TabelaProdutoerreionome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Qauntidade",
                table: "Produtos",
                newName: "Quantidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Produtos",
                newName: "Qauntidade");
        }
    }
}
