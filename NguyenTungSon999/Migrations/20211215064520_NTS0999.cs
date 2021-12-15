using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenTungSon999.Migrations
{
    public partial class NTS0999 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTS0999",
                columns: table => new
                {
                    NTSId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NTSName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NTSGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTS0999", x => x.NTSId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTS0999");
        }
    }
}
