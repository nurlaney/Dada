using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Data.Migrations
{
    public partial class datarepairs2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "UserDatas");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "UserDatas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
