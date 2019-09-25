using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RapiSolverWeb.Migrations
{
    public partial class Init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    IdCustomer = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    lastname = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 50, nullable: false),
                    phone = table.Column<string>(maxLength: 10, nullable: false),
                    age = table.Column<int>(maxLength: 80, nullable: false),
                    password = table.Column<string>(maxLength: 50, nullable: false),
                    gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.IdCustomer);
                });

            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    Idlocation = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    country = table.Column<string>(maxLength: 50, nullable: false),
                    city = table.Column<string>(maxLength: 50, nullable: false),
                    state = table.Column<string>(maxLength: 50, nullable: false),
                    address = table.Column<string>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.Idlocation);
                });

            migrationBuilder.CreateTable(
                name: "serviceCategory",
                columns: table => new
                {
                    IdServicio = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceCategory", x => x.IdServicio);
                });

            migrationBuilder.CreateTable(
                name: "supplier",
                columns: table => new
                {
                    IdSupplier = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    lastname = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(maxLength: 50, nullable: false),
                    phone = table.Column<string>(maxLength: 10, nullable: false),
                    age = table.Column<int>(maxLength: 80, nullable: false),
                    password = table.Column<string>(maxLength: 50, nullable: false),
                    gender = table.Column<string>(nullable: true),
                    locationIdlocation = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier", x => x.IdSupplier);
                    table.ForeignKey(
                        name: "FK_supplier_location_locationIdlocation",
                        column: x => x.locationIdlocation,
                        principalTable: "location",
                        principalColumn: "Idlocation",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "servicio",
                columns: table => new
                {
                    IdServicio = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 50, nullable: false),
                    cost = table.Column<string>(nullable: true),
                    CategoryIdServicio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicio", x => x.IdServicio);
                    table.ForeignKey(
                        name: "FK_servicio_serviceCategory_CategoryIdServicio",
                        column: x => x.CategoryIdServicio,
                        principalTable: "serviceCategory",
                        principalColumn: "IdServicio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "detailServiceSupplier",
                columns: table => new
                {
                    IdServicio = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ServicioIdServicio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detailServiceSupplier", x => x.IdServicio);
                    table.ForeignKey(
                        name: "FK_detailServiceSupplier_servicio_ServicioIdServicio",
                        column: x => x.ServicioIdServicio,
                        principalTable: "servicio",
                        principalColumn: "IdServicio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detailServiceSupplier_ServicioIdServicio",
                table: "detailServiceSupplier",
                column: "ServicioIdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_servicio_CategoryIdServicio",
                table: "servicio",
                column: "CategoryIdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_supplier_locationIdlocation",
                table: "supplier",
                column: "locationIdlocation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "detailServiceSupplier");

            migrationBuilder.DropTable(
                name: "supplier");

            migrationBuilder.DropTable(
                name: "servicio");

            migrationBuilder.DropTable(
                name: "location");

            migrationBuilder.DropTable(
                name: "serviceCategory");

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    IdPerson = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    age = table.Column<int>(maxLength: 80, nullable: false),
                    email = table.Column<string>(maxLength: 50, nullable: false),
                    gender = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    password = table.Column<string>(maxLength: 50, nullable: false),
                    phone = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.IdPerson);
                });
        }
    }
}
