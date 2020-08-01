using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Data.Migrations
{
    public partial class DataRepairs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Users");

            migrationBuilder.AddColumn<DateTime>(
                name: "JoinDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "UserDatas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    AboutMe = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDatas_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSocials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FbLink = table.Column<string>(nullable: true),
                    TwitLink = table.Column<string>(nullable: true),
                    InstaLink = table.Column<string>(nullable: true),
                    GoogleLink = table.Column<string>(nullable: true),
                    PatreonLink = table.Column<string>(nullable: true),
                    DiscordLink = table.Column<string>(nullable: true),
                    YoutubeLink = table.Column<string>(nullable: true),
                    TwitchLink = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSocials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSocials_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserDatas_UserId",
                table: "UserDatas",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSocials_UserId",
                table: "UserSocials",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDatas");

            migrationBuilder.DropTable(
                name: "UserSocials");

            migrationBuilder.DropColumn(
                name: "JoinDate",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
