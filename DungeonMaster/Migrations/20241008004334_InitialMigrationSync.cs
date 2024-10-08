using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DungeonMaster.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationSync : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterDatabase()
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Campaigns",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        CampaignName = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Campaigns", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Classes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        ClassName = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Classes", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Races",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        RaceName = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Races", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Characters",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Strength = table.Column<int>(type: "int", nullable: false),
            //        Dexterity = table.Column<int>(type: "int", nullable: false),
            //        Constitution = table.Column<int>(type: "int", nullable: false),
            //        Intelligence = table.Column<int>(type: "int", nullable: false),
            //        Wisdom = table.Column<int>(type: "int", nullable: false),
            //        Charisma = table.Column<int>(type: "int", nullable: false),
            //        Level = table.Column<int>(type: "int", nullable: false),
            //        HitPoints = table.Column<int>(type: "int", nullable: false),
            //        ProficiencyBonus = table.Column<double>(type: "double", nullable: false),
            //        Gender = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Alignment = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Money = table.Column<int>(type: "int", nullable: false),
            //        RaceId = table.Column<int>(type: "int", nullable: false),
            //        ClassId = table.Column<int>(type: "int", nullable: false),
            //        CampaignId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Characters", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Characters_Campaigns_CampaignId",
            //            column: x => x.CampaignId,
            //            principalTable: "Campaigns",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Characters_Classes_ClassId",
            //            column: x => x.ClassId,
            //            principalTable: "Classes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Characters_Races_RaceId",
            //            column: x => x.RaceId,
            //            principalTable: "Races",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.InsertData(
            //    table: "Classes",
            //    columns: new[] { "Id", "ClassName" },
            //    values: new object[,]
            //    {
            //        { 1, "Bard" },
            //        { 2, "Cleric" },
            //        { 3, "Fighter" },
            //        { 4, "Rogue" },
            //        { 5, "Wizard" }
            //    });

            //migrationBuilder.InsertData(
            //    table: "Races",
            //    columns: new[] { "Id", "RaceName" },
            //    values: new object[,]
            //    {
            //        { 1, "Dwarf" },
            //        { 2, "Elf" },
            //        { 3, "Human" },
            //        { 4, "Halfling" }
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Characters_CampaignId",
            //    table: "Characters",
            //    column: "CampaignId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Characters_ClassId",
            //    table: "Characters",
            //    column: "ClassId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Characters_RaceId",
            //    table: "Characters",
            //    column: "RaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Characters");

            //migrationBuilder.DropTable(
            //    name: "Campaigns");

            //migrationBuilder.DropTable(
            //    name: "Classes");

            //migrationBuilder.DropTable(
            //    name: "Races");
        }
    }
}
