using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _Net_Lab3_Shanshan.Migrations
{
    public partial class constellation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Constellation",
                table: "User",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Constellation",
                table: "User");
        }
    }
}
