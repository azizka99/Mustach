using Microsoft.EntityFrameworkCore.Migrations;

namespace MustacheEnt.Migrations
{
    public partial class IndexisUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainPicsTextBody",
                table: "Index");

            migrationBuilder.AddColumn<string>(
                name: "MainPicsTextBody1",
                table: "Index",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainPicsTextBody2",
                table: "Index",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainPicsTextBody3",
                table: "Index",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainPicsTextBody1",
                table: "Index");

            migrationBuilder.DropColumn(
                name: "MainPicsTextBody2",
                table: "Index");

            migrationBuilder.DropColumn(
                name: "MainPicsTextBody3",
                table: "Index");

            migrationBuilder.AddColumn<string>(
                name: "MainPicsTextBody",
                table: "Index",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
