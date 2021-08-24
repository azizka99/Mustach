using Microsoft.EntityFrameworkCore.Migrations;

namespace MustacheEnt.Migrations
{
    public partial class GalleryTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Src = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    FirstTitle = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    SecondTitle = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(155)", maxLength: 155, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galleries");
        }
    }
}
