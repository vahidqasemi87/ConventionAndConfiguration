using Microsoft.EntityFrameworkCore.Migrations;

namespace Part01.Migrations
{
    public partial class init21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShomareShaba",
                schema: "bnk",
                table: "FluentBank",
                newName: "ShShaba");

            migrationBuilder.RenameColumn(
                name: "ShomareHesab",
                schema: "bnk",
                table: "FluentBank",
                newName: "ShHesab");

            migrationBuilder.RenameColumn(
                name: "ShomareShaba",
                schema: "bnk",
                table: "AttributeBank",
                newName: "ShShaba");

            migrationBuilder.RenameColumn(
                name: "ShomareHesab",
                schema: "bnk",
                table: "AttributeBank",
                newName: "ShHesab");

            migrationBuilder.AlterColumn<string>(
                name: "ShShaba",
                schema: "bnk",
                table: "FluentBank",
                type: "NVARCHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShHesab",
                schema: "bnk",
                table: "FluentBank",
                type: "NVARCHAR(16)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShShaba",
                schema: "bnk",
                table: "AttributeBank",
                type: "NVARCHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShHesab",
                schema: "bnk",
                table: "AttributeBank",
                type: "NVARCHAR(16)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShShaba",
                schema: "bnk",
                table: "FluentBank",
                newName: "ShomareShaba");

            migrationBuilder.RenameColumn(
                name: "ShHesab",
                schema: "bnk",
                table: "FluentBank",
                newName: "ShomareHesab");

            migrationBuilder.RenameColumn(
                name: "ShShaba",
                schema: "bnk",
                table: "AttributeBank",
                newName: "ShomareShaba");

            migrationBuilder.RenameColumn(
                name: "ShHesab",
                schema: "bnk",
                table: "AttributeBank",
                newName: "ShomareHesab");

            migrationBuilder.AlterColumn<string>(
                name: "ShomareShaba",
                schema: "bnk",
                table: "FluentBank",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShomareHesab",
                schema: "bnk",
                table: "FluentBank",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(16)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShomareShaba",
                schema: "bnk",
                table: "AttributeBank",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShomareHesab",
                schema: "bnk",
                table: "AttributeBank",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(16)",
                oldNullable: true);
        }
    }
}
