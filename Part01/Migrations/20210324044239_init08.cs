using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Part01.Migrations
{
    public partial class init08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "PersonFluents",
                newName: "LName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "PersonAttributes",
                newName: "LName");

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                table: "PersonFluents",
                type: "NVARCHAR(46)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "PersonAttributes",
                type: "DATETIME2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                table: "PersonAttributes",
                type: "NVARCHAR(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LName",
                table: "PersonFluents",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "LName",
                table: "PersonAttributes",
                newName: "LastName");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "PersonFluents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(46)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "PersonAttributes",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "PersonAttributes",
                type: "VARCHAR",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(5)",
                oldNullable: true);
        }
    }
}
