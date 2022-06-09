using Microsoft.EntityFrameworkCore.Migrations;

namespace ErpDashboard.Infrastructure.Migrations
{
    public partial class AddUserMaping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SystemUserId",
                schema: "Identity",
                table: "Users",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SystemUserId",
                schema: "Identity",
                table: "Users");
        }
    }
}
