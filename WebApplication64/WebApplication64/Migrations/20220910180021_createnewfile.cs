using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication64.Migrations
{
    public partial class createnewfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_companies_countryid",
                table: "employees");

            migrationBuilder.AlterColumn<int>(
                name: "countryid",
                table: "employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_companies_countryid",
                table: "employees",
                column: "countryid",
                principalTable: "companies",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_companies_countryid",
                table: "employees");

            migrationBuilder.AlterColumn<int>(
                name: "countryid",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_companies_countryid",
                table: "employees",
                column: "countryid",
                principalTable: "companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
