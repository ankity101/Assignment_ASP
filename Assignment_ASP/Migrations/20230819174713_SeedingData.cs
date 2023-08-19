using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment_ASP.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "friends",
                columns: new[] { "Name", "ProfileImage" },
                values: new object[,]
                {
                    { "Name1", "Photo1.jpg" },
                    { "Name10", "Photo10.jpg" },
                    { "Name100", "Photo100.jpg" },
                    { "Name11", "Photo11.jpg" },
                    { "Name12", "Photo12.jpg" },
                    { "Name13", "Photo13.jpg" },
                    { "Name14", "Photo14.jpg" },
                    { "Name15", "Photo15.jpg" },
                    { "Name16", "Photo16.jpg" },
                    { "Name17", "Photo17.jpg" },
                    { "Name18", "Photo18.jpg" },
                    { "Name19", "Photo19.jpg" },
                    { "Name2", "Photo2.jpg" },
                    { "Name20", "Photo20.jpg" },
                    { "Name21", "Photo21.jpg" },
                    { "Name22", "Photo22.jpg" },
                    { "Name23", "Photo23.jpg" },
                    { "Name24", "Photo24.jpg" },
                    { "Name25", "Photo25.jpg" },
                    { "Name26", "Photo26.jpg" },
                    { "Name27", "Photo27.jpg" },
                    { "Name28", "Photo28.jpg" },
                    { "Name29", "Photo29.jpg" },
                    { "Name3", "Photo3.jpg" },
                    { "Name30", "Photo30.jpg" },
                    { "Name31", "Photo31.jpg" },
                    { "Name32", "Photo32.jpg" },
                    { "Name33", "Photo33.jpg" },
                    { "Name34", "Photo34.jpg" },
                    { "Name35", "Photo35.jpg" },
                    { "Name36", "Photo36.jpg" },
                    { "Name37", "Photo37.jpg" },
                    { "Name38", "Photo38.jpg" },
                    { "Name39", "Photo39.jpg" },
                    { "Name4", "Photo4.jpg" },
                    { "Name40", "Photo40.jpg" },
                    { "Name41", "Photo41.jpg" },
                    { "Name42", "Photo42.jpg" },
                    { "Name43", "Photo43.jpg" },
                    { "Name44", "Photo44.jpg" },
                    { "Name45", "Photo45.jpg" },
                    { "Name46", "Photo46.jpg" },
                    { "Name47", "Photo47.jpg" },
                    { "Name48", "Photo48.jpg" },
                    { "Name49", "Photo49.jpg" },
                    { "Name5", "Photo5.jpg" },
                    { "Name50", "Photo50.jpg" },
                    { "Name51", "Photo51.jpg" },
                    { "Name52", "Photo52.jpg" },
                    { "Name53", "Photo53.jpg" },
                    { "Name54", "Photo54.jpg" },
                    { "Name55", "Photo55.jpg" },
                    { "Name56", "Photo56.jpg" },
                    { "Name57", "Photo57.jpg" },
                    { "Name58", "Photo58.jpg" },
                    { "Name59", "Photo59.jpg" },
                    { "Name6", "Photo6.jpg" },
                    { "Name60", "Photo60.jpg" },
                    { "Name61", "Photo61.jpg" },
                    { "Name62", "Photo62.jpg" },
                    { "Name63", "Photo63.jpg" },
                    { "Name64", "Photo64.jpg" },
                    { "Name65", "Photo65.jpg" },
                    { "Name66", "Photo66.jpg" },
                    { "Name67", "Photo67.jpg" },
                    { "Name68", "Photo68.jpg" },
                    { "Name69", "Photo69.jpg" },
                    { "Name7", "Photo7.jpg" },
                    { "Name70", "Photo70.jpg" },
                    { "Name71", "Photo71.jpg" },
                    { "Name72", "Photo72.jpg" },
                    { "Name73", "Photo73.jpg" },
                    { "Name74", "Photo74.jpg" },
                    { "Name75", "Photo75.jpg" },
                    { "Name76", "Photo76.jpg" },
                    { "Name77", "Photo77.jpg" },
                    { "Name78", "Photo78.jpg" },
                    { "Name79", "Photo79.jpg" },
                    { "Name8", "Photo8.jpg" },
                    { "Name80", "Photo80.jpg" },
                    { "Name81", "Photo81.jpg" },
                    { "Name82", "Photo82.jpg" },
                    { "Name83", "Photo83.jpg" },
                    { "Name84", "Photo84.jpg" },
                    { "Name85", "Photo85.jpg" },
                    { "Name86", "Photo86.jpg" },
                    { "Name87", "Photo87.jpg" },
                    { "Name88", "Photo88.jpg" },
                    { "Name89", "Photo89.jpg" },
                    { "Name9", "Photo9.jpg" },
                    { "Name90", "Photo90.jpg" },
                    { "Name91", "Photo91.jpg" },
                    { "Name92", "Photo92.jpg" },
                    { "Name93", "Photo93.jpg" },
                    { "Name94", "Photo94.jpg" },
                    { "Name95", "Photo95.jpg" },
                    { "Name96", "Photo96.jpg" },
                    { "Name97", "Photo97.jpg" },
                    { "Name98", "Photo98.jpg" },
                    { "Name99", "Photo99.jpg" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserModelId", "Name", "ProfileImage" },
                values: new object[,]
                {
                    { 1, "Name1", "Photo1.jpg" },
                    { 2, "Name2", "Photo2.jpg" },
                    { 3, "Name3", "Photo3.jpg" },
                    { 4, "Name4", "Photo4.jpg" },
                    { 5, "Name5", "Photo5.jpg" },
                    { 6, "Name6", "Photo6.jpg" },
                    { 7, "Name7", "Photo7.jpg" },
                    { 8, "Name8", "Photo8.jpg" },
                    { 9, "Name9", "Photo9.jpg" },
                    { 10, "Name10", "Photo10.jpg" },
                    { 11, "Name11", "Photo11.jpg" },
                    { 12, "Name12", "Photo12.jpg" },
                    { 13, "Name13", "Photo13.jpg" },
                    { 14, "Name14", "Photo14.jpg" },
                    { 15, "Name15", "Photo15.jpg" },
                    { 16, "Name16", "Photo16.jpg" },
                    { 17, "Name17", "Photo17.jpg" },
                    { 18, "Name18", "Photo18.jpg" },
                    { 19, "Name19", "Photo19.jpg" },
                    { 20, "Name20", "Photo20.jpg" },
                    { 21, "Name21", "Photo21.jpg" },
                    { 22, "Name22", "Photo22.jpg" },
                    { 23, "Name23", "Photo23.jpg" },
                    { 24, "Name24", "Photo24.jpg" },
                    { 25, "Name25", "Photo25.jpg" },
                    { 26, "Name26", "Photo26.jpg" },
                    { 27, "Name27", "Photo27.jpg" },
                    { 28, "Name28", "Photo28.jpg" },
                    { 29, "Name29", "Photo29.jpg" },
                    { 30, "Name30", "Photo30.jpg" },
                    { 31, "Name31", "Photo31.jpg" },
                    { 32, "Name32", "Photo32.jpg" },
                    { 33, "Name33", "Photo33.jpg" },
                    { 34, "Name34", "Photo34.jpg" },
                    { 35, "Name35", "Photo35.jpg" },
                    { 36, "Name36", "Photo36.jpg" },
                    { 37, "Name37", "Photo37.jpg" },
                    { 38, "Name38", "Photo38.jpg" },
                    { 39, "Name39", "Photo39.jpg" },
                    { 40, "Name40", "Photo40.jpg" },
                    { 41, "Name41", "Photo41.jpg" },
                    { 42, "Name42", "Photo42.jpg" },
                    { 43, "Name43", "Photo43.jpg" },
                    { 44, "Name44", "Photo44.jpg" },
                    { 45, "Name45", "Photo45.jpg" },
                    { 46, "Name46", "Photo46.jpg" },
                    { 47, "Name47", "Photo47.jpg" },
                    { 48, "Name48", "Photo48.jpg" },
                    { 49, "Name49", "Photo49.jpg" },
                    { 50, "Name50", "Photo50.jpg" },
                    { 51, "Name51", "Photo51.jpg" },
                    { 52, "Name52", "Photo52.jpg" },
                    { 53, "Name53", "Photo53.jpg" },
                    { 54, "Name54", "Photo54.jpg" },
                    { 55, "Name55", "Photo55.jpg" },
                    { 56, "Name56", "Photo56.jpg" },
                    { 57, "Name57", "Photo57.jpg" },
                    { 58, "Name58", "Photo58.jpg" },
                    { 59, "Name59", "Photo59.jpg" },
                    { 60, "Name60", "Photo60.jpg" },
                    { 61, "Name61", "Photo61.jpg" },
                    { 62, "Name62", "Photo62.jpg" },
                    { 63, "Name63", "Photo63.jpg" },
                    { 64, "Name64", "Photo64.jpg" },
                    { 65, "Name65", "Photo65.jpg" },
                    { 66, "Name66", "Photo66.jpg" },
                    { 67, "Name67", "Photo67.jpg" },
                    { 68, "Name68", "Photo68.jpg" },
                    { 69, "Name69", "Photo69.jpg" },
                    { 70, "Name70", "Photo70.jpg" },
                    { 71, "Name71", "Photo71.jpg" },
                    { 72, "Name72", "Photo72.jpg" },
                    { 73, "Name73", "Photo73.jpg" },
                    { 74, "Name74", "Photo74.jpg" },
                    { 75, "Name75", "Photo75.jpg" },
                    { 76, "Name76", "Photo76.jpg" },
                    { 77, "Name77", "Photo77.jpg" },
                    { 78, "Name78", "Photo78.jpg" },
                    { 79, "Name79", "Photo79.jpg" },
                    { 80, "Name80", "Photo80.jpg" },
                    { 81, "Name81", "Photo81.jpg" },
                    { 82, "Name82", "Photo82.jpg" },
                    { 83, "Name83", "Photo83.jpg" },
                    { 84, "Name84", "Photo84.jpg" },
                    { 85, "Name85", "Photo85.jpg" },
                    { 86, "Name86", "Photo86.jpg" },
                    { 87, "Name87", "Photo87.jpg" },
                    { 88, "Name88", "Photo88.jpg" },
                    { 89, "Name89", "Photo89.jpg" },
                    { 90, "Name90", "Photo90.jpg" },
                    { 91, "Name91", "Photo91.jpg" },
                    { 92, "Name92", "Photo92.jpg" },
                    { 93, "Name93", "Photo93.jpg" },
                    { 94, "Name94", "Photo94.jpg" },
                    { 95, "Name95", "Photo95.jpg" },
                    { 96, "Name96", "Photo96.jpg" },
                    { 97, "Name97", "Photo97.jpg" },
                    { 98, "Name98", "Photo98.jpg" },
                    { 99, "Name99", "Photo99.jpg" },
                    { 100, "Name100", "Photo100.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name1");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name10");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name100");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name11");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name12");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name13");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name14");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name15");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name16");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name17");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name18");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name19");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name2");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name20");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name21");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name22");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name23");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name24");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name25");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name26");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name27");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name28");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name29");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name3");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name30");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name31");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name32");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name33");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name34");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name35");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name36");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name37");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name38");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name39");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name4");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name40");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name41");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name42");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name43");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name44");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name45");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name46");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name47");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name48");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name49");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name5");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name50");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name51");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name52");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name53");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name54");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name55");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name56");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name57");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name58");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name59");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name6");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name60");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name61");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name62");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name63");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name64");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name65");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name66");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name67");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name68");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name69");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name7");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name70");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name71");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name72");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name73");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name74");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name75");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name76");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name77");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name78");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name79");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name8");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name80");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name81");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name82");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name83");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name84");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name85");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name86");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name87");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name88");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name89");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name9");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name90");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name91");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name92");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name93");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name94");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name95");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name96");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name97");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name98");

            migrationBuilder.DeleteData(
                table: "friends",
                keyColumn: "Name",
                keyValue: "Name99");

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserModelId",
                keyValue: 100);
        }
    }
}
