using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDeEmprestimos.Migrations
{
    public partial class versao02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantidadeParcelasPagas",
                table: "Emprestimo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeParcelasPagas",
                table: "Emprestimo");
        }
    }
}
