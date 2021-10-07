.using Microsoft.EntityFrameworkCore.Migrations;

namespace BackTarjeta.Migrations
{
    public partial class v200 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fechaExpiracion",
                table: "TarjetaCredito",
                newName: "fechaexpiracion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fechaexpiracion",
                table: "TarjetaCredito",
                newName: "fechaExpiracion");
        }
    }
}
