using Microsoft.EntityFrameworkCore.Migrations;

namespace RapiSolverWeb.Migrations
{
    public partial class Init10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detailServiceSupplier_supplier_SupplierDetailIdSupplier",
                table: "detailServiceSupplier");

            migrationBuilder.DropForeignKey(
                name: "FK_servicio_serviceCategory_CategoryIdServicio",
                table: "servicio");

            migrationBuilder.DropIndex(
                name: "IX_servicio_CategoryIdServicio",
                table: "servicio");

            migrationBuilder.DropIndex(
                name: "IX_detailServiceSupplier_SupplierDetailIdSupplier",
                table: "detailServiceSupplier");

            migrationBuilder.DropColumn(
                name: "CategoryIdServicio",
                table: "servicio");

            migrationBuilder.DropColumn(
                name: "SupplierDetailIdSupplier",
                table: "detailServiceSupplier");

            migrationBuilder.RenameColumn(
                name: "IdServicio",
                table: "serviceCategory",
                newName: "IdCategory");

            migrationBuilder.AddColumn<string>(
                name: "nameCompany",
                table: "supplier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "servicio",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "detailServiceSupplier",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "detailServiceSupplier",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_servicio_CategoryId",
                table: "servicio",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_detailServiceSupplier_SupplierId",
                table: "detailServiceSupplier",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_detailServiceSupplier_supplier_SupplierId",
                table: "detailServiceSupplier",
                column: "SupplierId",
                principalTable: "supplier",
                principalColumn: "IdSupplier",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_servicio_serviceCategory_CategoryId",
                table: "servicio",
                column: "CategoryId",
                principalTable: "serviceCategory",
                principalColumn: "IdCategory",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detailServiceSupplier_supplier_SupplierId",
                table: "detailServiceSupplier");

            migrationBuilder.DropForeignKey(
                name: "FK_servicio_serviceCategory_CategoryId",
                table: "servicio");

            migrationBuilder.DropIndex(
                name: "IX_servicio_CategoryId",
                table: "servicio");

            migrationBuilder.DropIndex(
                name: "IX_detailServiceSupplier_SupplierId",
                table: "detailServiceSupplier");

            migrationBuilder.DropColumn(
                name: "nameCompany",
                table: "supplier");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "servicio");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "detailServiceSupplier");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "detailServiceSupplier");

            migrationBuilder.RenameColumn(
                name: "IdCategory",
                table: "serviceCategory",
                newName: "IdServicio");

            migrationBuilder.AddColumn<int>(
                name: "CategoryIdServicio",
                table: "servicio",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierDetailIdSupplier",
                table: "detailServiceSupplier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_servicio_CategoryIdServicio",
                table: "servicio",
                column: "CategoryIdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_detailServiceSupplier_SupplierDetailIdSupplier",
                table: "detailServiceSupplier",
                column: "SupplierDetailIdSupplier");

            migrationBuilder.AddForeignKey(
                name: "FK_detailServiceSupplier_supplier_SupplierDetailIdSupplier",
                table: "detailServiceSupplier",
                column: "SupplierDetailIdSupplier",
                principalTable: "supplier",
                principalColumn: "IdSupplier",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_servicio_serviceCategory_CategoryIdServicio",
                table: "servicio",
                column: "CategoryIdServicio",
                principalTable: "serviceCategory",
                principalColumn: "IdServicio",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
