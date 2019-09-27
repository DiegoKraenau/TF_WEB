using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RapiSolverWeb.Migrations
{
    public partial class Init20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detailServiceSupplier_supplier_SupplierId",
                table: "detailServiceSupplier");

            migrationBuilder.DropIndex(
                name: "IX_detailServiceSupplier_SupplierId",
                table: "detailServiceSupplier");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "detailServiceSupplier");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "detailServiceSupplier");

            migrationBuilder.AddColumn<int>(
                name: "SupplierDetailIdSupplier",
                table: "detailServiceSupplier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "reservation",
                columns: table => new
                {
                    IdReservation = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    reservationDate = table.Column<string>(nullable: true),
                    discount = table.Column<double>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    ServicioIdServicio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservation", x => x.IdReservation);
                    table.ForeignKey(
                        name: "FK_reservation_customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customer",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservation_location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "location",
                        principalColumn: "Idlocation",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservation_servicio_ServicioIdServicio",
                        column: x => x.ServicioIdServicio,
                        principalTable: "servicio",
                        principalColumn: "IdServicio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_reservation_supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "supplier",
                        principalColumn: "IdSupplier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detailServiceSupplier_SupplierDetailIdSupplier",
                table: "detailServiceSupplier",
                column: "SupplierDetailIdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_CustomerId",
                table: "reservation",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_LocationId",
                table: "reservation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_ServicioIdServicio",
                table: "reservation",
                column: "ServicioIdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_SupplierId",
                table: "reservation",
                column: "SupplierId");

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
                name: "FK_detailServiceSupplier_supplier_SupplierDetailIdSupplier",
                table: "detailServiceSupplier");

            migrationBuilder.DropTable(
                name: "reservation");

            migrationBuilder.DropIndex(
                name: "IX_detailServiceSupplier_SupplierDetailIdSupplier",
                table: "detailServiceSupplier");

            migrationBuilder.DropColumn(
                name: "SupplierDetailIdSupplier",
                table: "detailServiceSupplier");

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
        }
    }
}
