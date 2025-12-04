using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendasTimeComercial.Infrastructure.Migrations;

/// <inheritdoc />
public partial class InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Vendas",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Vendedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                DataVenda = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Vendas", x => x.Id);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Vendas");
    }
}
