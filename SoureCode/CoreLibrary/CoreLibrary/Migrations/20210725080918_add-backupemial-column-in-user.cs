using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreLibrary.Migrations
{
    public partial class addbackupemialcolumninuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackupEmail",
                table: "AspNetUsers",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackupEmail",
                table: "AspNetUsers");
        }
    }
}
