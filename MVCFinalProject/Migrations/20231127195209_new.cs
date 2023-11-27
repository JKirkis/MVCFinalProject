using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Developer", "Genre", "Name", "Year" },
                values: new object[,]
                {
                    { 4, "Bungie", "First-person shooter", "Halo", 2001 },
                    { 5, "Square", "Role-playing game", "Final Fantasy 7", 1997 },
                    { 6, "NicKyLarry", "First-person shooter", "Extinction", 2023 },
                    { 7, "Bioware", "Role-playing game", "Mass Effect 3", 2012 },
                    { 8, "Don't Nod", "Adventure", "Life is Strange", 2015 },
                    { 9, "LucasArts", "Adventure", "Day of the Tentacle", 1993 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9);
        }
    }
}
