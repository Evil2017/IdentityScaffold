using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityScaffold.Mvc.Migrations
{
    public partial class add_realName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RealName",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RealName",
                table: "AspNetUsers");
        }
    }
}
