﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDeEmprestimos.Migrations
{
    public partial class versao03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ValorPago",
                table: "Emprestimo",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorPago",
                table: "Emprestimo");
        }
    }
}
