using Microsoft.EntityFrameworkCore.Migrations;

namespace FundacjaZawszeRazem.Migrations
{
    public partial class ChangeAgeType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Homes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Homes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
