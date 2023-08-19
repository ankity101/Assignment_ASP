using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment_ASP.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataInFriendTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "friends",
                columns: new[] { "Name", "ProfileImage" },
                values: new object[,]
                {
                    { "Abhishek", "Abhishek-img.jpg" },
                    { "Ankush", "Ankush-img.jpg" },
                    { "Ayush", "Ayush-img.jpg" },
                    { "Deepak", "Deepak-img.jpg" },
                    { "Shivansh", "SHivansh-img.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Abhishek");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Ankush");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Ayush");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Deepak");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Shivansh");
        }
    }
}
