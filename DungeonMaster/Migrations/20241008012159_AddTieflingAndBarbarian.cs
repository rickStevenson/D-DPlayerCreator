using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonMaster.Migrations
{
    /// <inheritdoc />
    public partial class AddTieflingAndBarbarian : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassName" },
                values: new object[] { 6, "Barbarian" });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "RaceName" },
                values: new object[] { 5, "Tiefling" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
