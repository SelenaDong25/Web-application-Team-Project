using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSD412ProjectGroup00000100.Data.Migrations
{
    public partial class BaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Polls",
                columns: table => new
                {
                    PollId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    State = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polls", x => new { x.UserId, x.PollId });
                    table.ForeignKey(
                        name: "FK_Polls_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    PollId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => new { x.ItemId, x.UserId, x.PollId });
                    table.ForeignKey(
                        name: "FK_Items_Polls_UserId_PollId",
                        columns: x => new { x.UserId, x.PollId },
                        principalTable: "Polls",
                        principalColumns: new[] { "UserId", "PollId" });
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    PollId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    VoterId = table.Column<string>(nullable: false),
                    VoteDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => new { x.ItemId, x.UserId, x.PollId, x.VoterId });
                    table.ForeignKey(
                        name: "FK_Votes_AspNetUsers_VoterId",
                        column: x => x.VoterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Votes_Items_ItemId_UserId_PollId",
                        columns: x => new { x.ItemId, x.UserId, x.PollId },
                        principalTable: "Items",
                        principalColumns: new[] { "ItemId", "UserId", "PollId" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_UserId_PollId",
                table: "Items",
                columns: new[] { "UserId", "PollId" });

            migrationBuilder.CreateIndex(
                name: "IX_Votes_VoterId",
                table: "Votes",
                column: "VoterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Polls");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
