using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeapYear.Migrations
{
    public partial class AddAttributeToLeapYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Outcome",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeOfWrite",
                table: "Person",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Outcome",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TimeOfWrite",
                table: "Person");
        }
    }
}
