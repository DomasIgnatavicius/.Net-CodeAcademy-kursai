using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _04_First_SQL_DB.services.Migrations
{
    public partial class addedWeightBiographyNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "Persons",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Persons",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biography",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Persons");
        }
    }
}
