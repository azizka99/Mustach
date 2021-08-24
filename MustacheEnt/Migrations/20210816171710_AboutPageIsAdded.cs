using Microsoft.EntityFrameworkCore.Migrations;

namespace MustacheEnt.Migrations
{
    public partial class AboutPageIsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    PicSrc = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Header1 = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Decr1 = table.Column<string>(type: "nvarchar(1055)", maxLength: 1055, nullable: true),
                    Header2 = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Decr2 = table.Column<string>(type: "nvarchar(1055)", maxLength: 1055, nullable: true),
                    Header3 = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Decr3 = table.Column<string>(type: "nvarchar(1055)", maxLength: 1055, nullable: true),
                    Header4 = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Decr4 = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");
        }
    }
}
