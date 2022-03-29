using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _Net_Lab3_Shanshan.Migrations
{
    public partial class FavouriteColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavouriteColor",
                table: "User",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavouriteColor",
                table: "User");
        }
    }
}
