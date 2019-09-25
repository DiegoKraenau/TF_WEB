using Microsoft.EntityFrameworkCore.Migrations;

namespace RapiSolverWeb.Migrations
{
    public partial class Init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detailServiceSupplier_servicio_ServicioIdServicio",
                table: "detailServiceSupplier");

            migrationBuilder.RenameColumn(
                name: "ServicioIdServicio",
                table: "detailServiceSupplier",
                newName: "SupplierDetailIdSupplier");

            migrationBuilder.RenameIndex(
                name: "IX_detailServiceSupplier_ServicioIdServicio",
                table: "detailServiceSupplier",
                newName: "IX_detailServiceSupplier_SupplierDetailIdSupplier");

            migrationBuilder.AddColumn<int>(
                name: "ServicioDetailIdServicio",
                table: "detailServiceSupplier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_detailServiceSupplier_ServicioDetailIdServicio",
                table: "detailServiceSupplier",
                column: "ServicioDetailIdServicio");

            migrationBuilder.AddForeignKey(
                name: "FK_detailServiceSupplier_servicio_ServicioDetailIdServicio",
                table: "detailServiceSupplier",
                column: "ServicioDetailIdServicio",
                principalTable: "servicio",
                principalColumn: "IdServicio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_detailServiceSupplier_supplier_SupplierDetailIdSupplier",
                table: "detailServiceSupplier",
                column: "SupplierDetailIdSupplier",
                principalTable: "supplier",
                principalColumn: "IdSupplier",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detailServiceSupplier_servicio_ServicioDetailIdServicio",
                table: "detailServiceSupplier");

            migrationBuilder.DropForeignKey(
                name: "FK_detailServiceSupplier_supplier_SupplierDetailIdSupplier",
                table: "detailServiceSupplier");

            migrationBuilder.DropIndex(
                name: "IX_detailServiceSupplier_ServicioDetailIdServicio",
                table: "detailServiceSupplier");

            migrationBuilder.DropColumn(
                name: "ServicioDetailIdServicio",
                table: "detailServiceSupplier");

            migrationBuilder.RenameColumn(
                name: "SupplierDetailIdSupplier",
                table: "detailServiceSupplier",
                newName: "ServicioIdServicio");

            migrationBuilder.RenameIndex(
                name: "IX_detailServiceSupplier_SupplierDetailIdSupplier",
                table: "detailServiceSupplier",
                newName: "IX_detailServiceSupplier_ServicioIdServicio");

            migrationBuilder.AddForeignKey(
                name: "FK_detailServiceSupplier_servicio_ServicioIdServicio",
                table: "detailServiceSupplier",
                column: "ServicioIdServicio",
                principalTable: "servicio",
                principalColumn: "IdServicio",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
