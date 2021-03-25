using Microsoft.EntityFrameworkCore.Migrations;

namespace Part01.Migrations
{
    public partial class init18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "bnk");

            migrationBuilder.CreateTable(
                name: "FluentBank",
                schema: "bnk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShomareHesab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShomareShaba = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentBank", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentBank",
                schema: "bnk");
        }
    }
}
