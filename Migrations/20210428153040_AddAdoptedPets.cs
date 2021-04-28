using Microsoft.EntityFrameworkCore.Migrations;

namespace FundacjaZawszeRazem.Migrations
{
    public partial class AddAdoptedPets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Homes",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Homes");
        }
    }
}
