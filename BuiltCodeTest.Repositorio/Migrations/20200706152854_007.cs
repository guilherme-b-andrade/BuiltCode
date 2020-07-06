using Microsoft.EntityFrameworkCore.Migrations;

namespace BuiltCodeTest.Repository.Migrations
{
    public partial class _007 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Crm",
                table: "Doctors",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Crm",
                table: "Doctors",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
