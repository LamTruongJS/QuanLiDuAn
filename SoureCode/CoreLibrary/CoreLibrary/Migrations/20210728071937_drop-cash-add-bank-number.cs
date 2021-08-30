using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreLibrary.Migrations
{
    public partial class dropcashaddbanknumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cash",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "BankNumber",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankNumber",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<decimal>(
                name: "Cash",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
