using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeapYear.Migrations
{
    public partial class AddIsActiveAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Person",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Person");
        }
    }
}
