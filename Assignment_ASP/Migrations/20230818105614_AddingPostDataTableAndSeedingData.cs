using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_ASP.Migrations
{
    /// <inheritdoc />
    public partial class AddingPostDataTableAndSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "postData",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postData", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "postData",
                columns: new[] { "Name", "PostImage", "ProfileImage", "Time" },
                values: new object[] { "Test", "Test-img.jpg", "Profile-test-img.jpg", "18th Aug" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "postData");
        }
    }
}
