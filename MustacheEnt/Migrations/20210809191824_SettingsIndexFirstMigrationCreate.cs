using Microsoft.EntityFrameworkCore.Migrations;

namespace MustacheEnt.Migrations
{
    public partial class SettingsIndexFirstMigrationCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Index",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainPicSrc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MainPicsTextTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MainPicsTextBody = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MainPicsTextButton = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    LeftPicSrc = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    LeftPicTitleText = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    CenterPicSrc = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    CenterPicTitleText = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    RightPicSrc = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    RightPicTitleText = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Index", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainLogoSrc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MainHeader = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    MainFooterText = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FooterTwitter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FooterFacebook = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FooterGoogle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FooterPrinterest = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Index");

            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
