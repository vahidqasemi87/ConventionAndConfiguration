using Microsoft.EntityFrameworkCore.Migrations;

namespace Part01.Migrations
{
    public partial class init12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonType",
                table: "PersonFluents",
                newName: "PType");

            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "PersonFluents",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "PersonFluents");

            migrationBuilder.RenameColumn(
                name: "PType",
                table: "PersonFluents",
                newName: "PersonType");
        }
    }
}
