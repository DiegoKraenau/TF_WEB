using Microsoft.EntityFrameworkCore.Migrations;

namespace RapiSolverWeb.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Persons",
                newName: "IdPerson");

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Persons",
                maxLength: 80,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Persons",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastname",
                table: "Persons",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Persons",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Persons",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Persons",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "lastname",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "IdPerson",
                table: "Persons",
                newName: "Id");
        }
    }
}
