using Microsoft.EntityFrameworkCore.Migrations;

namespace BackTarjeta.Migrations
{
    public partial class tarjeta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titular",
                table: "TarjetaCredito",
                newName: "titulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "TarjetaCredito",
                newName: "Titular");
        }
    }
}
