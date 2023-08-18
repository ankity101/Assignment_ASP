using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_ASP.Migrations
{
    /// <inheritdoc />
    public partial class AddingFriendsModelTableAndSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "friends",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_friends", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "friends",
                columns: new[] { "Name", "ProfileImage" },
                values: new object[] { "Saurabh", "Profile-img.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "friends");
        }
    }
}
