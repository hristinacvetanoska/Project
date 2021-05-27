using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeminalFileUrl",
                table: "Enrollments");

            migrationBuilder.AddColumn<string>(
                name: "SeminalUrl",
                table: "Enrollments",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeminalUrl",
                table: "Enrollments");

            migrationBuilder.AddColumn<string>(
                name: "SeminalFileUrl",
                table: "Enrollments",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }
    }
}
