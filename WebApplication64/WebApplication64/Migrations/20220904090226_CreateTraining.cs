using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication64.Migrations
{
    public partial class CreateTraining : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_employees_countryid",
                table: "employees",
                column: "countryid");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_companies_countryid",
                table: "employees",
                column: "countryid",
                principalTable: "companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_companies_countryid",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_countryid",
                table: "employees");
        }
    }
}

