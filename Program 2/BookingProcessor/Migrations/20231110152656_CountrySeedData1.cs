using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookingProcessor.Migrations
{
    /// <inheritdoc />
    public partial class CountrySeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryID", "Climate", "CountryName" },
                values: new object[,]
                {
                    { 3, "Varied", "France" },
                    { 4, "Mediterranean", "Italy" },
                    { 5, "Diverse", "Germany" },
                    { 6, "Mediterranean", "Spain" },
                    { 7, "Diverse", "USA" },
                    { 8, "Varied", "Japan" },
                    { 9, "Tropical", "Brazil" },
                    { 10, "Varied", "Canada" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 10);
        }
    }
}
