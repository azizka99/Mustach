using Microsoft.EntityFrameworkCore.Migrations;

namespace MustacheEnt.Migrations
{
    public partial class GalleryTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "Galleries",
                type: "nvarchar(1055)",
                maxLength: 1055,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(155)",
                oldMaxLength: 155,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "Galleries",
                type: "nvarchar(155)",
                maxLength: 155,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1055)",
                oldMaxLength: 1055,
                oldNullable: true);
        }
    }
}
