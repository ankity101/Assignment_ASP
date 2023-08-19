using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_ASP.Migrations
{
    /// <inheritdoc />
    public partial class AddingManyToManyRelationshipUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_friends_FriendListName",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_FriendListName",
                table: "users");

            migrationBuilder.DropColumn(
                name: "FriendListName",
                table: "users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FriendListName",
                table: "users",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_FriendListName",
                table: "users",
                column: "FriendListName");

            migrationBuilder.AddForeignKey(
                name: "FK_users_friends_FriendListName",
                table: "users",
                column: "FriendListName",
                principalTable: "friends",
                principalColumn: "Name");
        }
    }
}
