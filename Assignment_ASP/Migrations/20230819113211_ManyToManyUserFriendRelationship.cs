using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_ASP.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyUserFriendRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FriendListName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserModelId);
                    table.ForeignKey(
                        name: "FK_users_friends_FriendListName",
                        column: x => x.FriendListName,
                        principalTable: "friends",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "UserFriends",
                columns: table => new
                {
                    UserModelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFriends", x => new { x.UserModelId, x.Name });
                    table.ForeignKey(
                        name: "FK_UserFriends_friends_Name",
                        column: x => x.Name,
                        principalTable: "friends",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFriends_users_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "users",
                        principalColumn: "UserModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFriends_Name",
                table: "UserFriends",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_users_FriendListName",
                table: "users",
                column: "FriendListName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFriends");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
