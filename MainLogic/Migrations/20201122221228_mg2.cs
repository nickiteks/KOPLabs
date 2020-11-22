using Microsoft.EntityFrameworkCore.Migrations;

namespace MainLogic.Migrations
{
    public partial class mg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "noveltyUnit",
                table: "OrganizationUnit",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "noveltyUnit",
                table: "OrganizationUnit");
        }
    }
}
