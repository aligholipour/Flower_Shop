using Microsoft.EntityFrameworkCore.Migrations;

namespace Flower_Shop.Migrations
{
    public partial class Add_Property_Flower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Flowers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "Flowers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Flowers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Flowers");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Flowers");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Flowers");
        }
    }
}
