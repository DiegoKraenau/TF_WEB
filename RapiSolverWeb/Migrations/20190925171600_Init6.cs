using Microsoft.EntityFrameworkCore.Migrations;

namespace RapiSolverWeb.Migrations
{
    public partial class Init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdServicio",
                table: "detailServiceSupplier",
                newName: "IdDetalleServiceSupplier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdDetalleServiceSupplier",
                table: "detailServiceSupplier",
                newName: "IdServicio");
        }
    }
}
