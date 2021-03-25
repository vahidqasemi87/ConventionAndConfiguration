using Microsoft.EntityFrameworkCore.Migrations;

namespace Part01.Migrations
{
    public partial class init20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "config");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "Teachers",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "TeacherFluent",
                newName: "TeacherFluent",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Students",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "PersonFluents",
                newName: "PersonFluents",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "PersonCons",
                newName: "PersonCons",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "PersonAttributes",
                newName: "PersonAttributes",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "Car",
                newSchema: "config");

            migrationBuilder.RenameTable(
                name: "Animals",
                newName: "Animals",
                newSchema: "config");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Teachers",
                schema: "config",
                newName: "Teachers");

            migrationBuilder.RenameTable(
                name: "TeacherFluent",
                schema: "config",
                newName: "TeacherFluent");

            migrationBuilder.RenameTable(
                name: "Students",
                schema: "config",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "PersonFluents",
                schema: "config",
                newName: "PersonFluents");

            migrationBuilder.RenameTable(
                name: "PersonCons",
                schema: "config",
                newName: "PersonCons");

            migrationBuilder.RenameTable(
                name: "PersonAttributes",
                schema: "config",
                newName: "PersonAttributes");

            migrationBuilder.RenameTable(
                name: "Car",
                schema: "config",
                newName: "Car");

            migrationBuilder.RenameTable(
                name: "Animals",
                schema: "config",
                newName: "Animals");
        }
    }
}
