using Microsoft.EntityFrameworkCore.Migrations;

namespace BuiltCodeTest.Repository.Migrations
{
    public partial class _008 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Patients",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Patients",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 11);
        }
    }
}
