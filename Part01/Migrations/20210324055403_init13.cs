using Microsoft.EntityFrameworkCore.Migrations;

namespace Part01.Migrations
{
    public partial class init13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NationalCode",
                table: "PersonFluents",
                newName: "NCode");

            migrationBuilder.AlterColumn<string>(
                name: "NCode",
                table: "PersonFluents",
                type: "NVARCHAR(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NCode",
                table: "PersonFluents",
                newName: "NationalCode");

            migrationBuilder.AlterColumn<string>(
                name: "NationalCode",
                table: "PersonFluents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(10)",
                oldNullable: true);
        }
    }
}
