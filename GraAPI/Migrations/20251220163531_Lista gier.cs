using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraAPI.Migrations
{
    /// <inheritdoc />
    public partial class Listagier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WszystkieGry",
                columns: new[] { "Id", "Tag", "Tytul" },
                values: new object[,]
                {
                    { 1, "RPG", "Wiedźmin 3" },
                    { 2, "Sportowe", "FIFA 23" },
                    { 3, "RPG", "Cyberpunk 2077" },
                    { 4, "MOBA", "League of Legends" },
                    { 5, "MOBA", "Dota 2" },
                    { 6, "FPS", "Counter-Strike 2" },
                    { 7, "FPS", "Valorant" },
                    { 8, "Survival", "Minecraft" },
                    { 9, "Wyścigowe", "Forza Horizon 5" },
                    { 10, "RPG", "Elden Ring" },
                    { 11, "Strategiczne", "StarCraft II" },
                    { 12, "Strategiczne", "Age of Empires IV" },
                    { 13, "Roguelike", "Hades" },
                    { 14, "Roguelike", "Dead Cells" },
                    { 15, "FPS", "Call of Duty" },
                    { 16, "Symulator", "The Sims 4" },
                    { 17, "Sportowe", "F1 24" },
                    { 18, "RPG", "Diablo IV" },
                    { 19, "Survival", "Terraria" },
                    { 20, "FPS", "Apex Legends" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WszystkieGry",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
