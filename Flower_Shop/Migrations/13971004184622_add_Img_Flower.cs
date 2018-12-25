using Microsoft.EntityFrameworkCore.Migrations;

namespace Flower_Shop.Migrations
{
    public partial class add_Img_Flower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "Flowers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "Flowers");
        }
    }
}
