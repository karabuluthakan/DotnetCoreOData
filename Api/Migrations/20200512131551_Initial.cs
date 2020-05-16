using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "continentals",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_continentals", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "regions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    continental_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regions", x => x.id);
                    table.ForeignKey(
                        name: "FK_regions_continentals_continental_id",
                        column: x => x.continental_id,
                        principalTable: "continentals",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    region_id = table.Column<int>(nullable: false),
                    alpha_2_code = table.Column<string>(nullable: true),
                    alpha_3_code = table.Column<string>(nullable: true),
                    un_code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.id);
                    table.ForeignKey(
                        name: "FK_countries_regions_region_id",
                        column: x => x.region_id,
                        principalTable: "regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    country_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.id);
                    table.ForeignKey(
                        name: "FK_cities_countries_country_id",
                        column: x => x.country_id,
                        principalTable: "countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "continentals",
                columns: new[] { "id", "created_date", "name" },
                values: new object[] { 1, new DateTime(2020, 5, 12, 13, 15, 51, 483, DateTimeKind.Utc).AddTicks(9790), "Africa" });

            migrationBuilder.InsertData(
                table: "continentals",
                columns: new[] { "id", "created_date", "name" },
                values: new object[] { 2, new DateTime(2020, 5, 12, 13, 15, 51, 484, DateTimeKind.Utc).AddTicks(427), "Americas" });

            migrationBuilder.InsertData(
                table: "continentals",
                columns: new[] { "id", "created_date", "name" },
                values: new object[] { 3, new DateTime(2020, 5, 12, 13, 15, 51, 484, DateTimeKind.Utc).AddTicks(448), "Antarctica" });

            migrationBuilder.InsertData(
                table: "continentals",
                columns: new[] { "id", "created_date", "name" },
                values: new object[] { 4, new DateTime(2020, 5, 12, 13, 15, 51, 484, DateTimeKind.Utc).AddTicks(450), "Asia" });

            migrationBuilder.InsertData(
                table: "continentals",
                columns: new[] { "id", "created_date", "name" },
                values: new object[] { 5, new DateTime(2020, 5, 12, 13, 15, 51, 484, DateTimeKind.Utc).AddTicks(451), "Europe" });

            migrationBuilder.InsertData(
                table: "continentals",
                columns: new[] { "id", "created_date", "name" },
                values: new object[] { 6, new DateTime(2020, 5, 12, 13, 15, 51, 484, DateTimeKind.Utc).AddTicks(451), "Oceania" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 1, 1, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(360), "Central Africa" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 22, 5, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(693), "Southern Europe" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 21, 5, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(692), "South West Europe" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 20, 5, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(691), "South East Europe" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 19, 5, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(690), "Northern Europe" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 18, 5, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(689), "Eastern Europe" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 17, 5, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(688), "Central Europe" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 16, 4, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(687), "South West Asia" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 15, 4, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(686), "South Asia" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 14, 4, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(685), "Northern Asia" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 13, 4, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(684), "East Asia" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 12, 4, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(683), "Central Asia" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 11, 3, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(682), "Atlantic Ocean" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 10, 2, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(681), "West Indies" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 9, 2, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(680), "South America" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 8, 2, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(679), "North America" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 7, 2, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(678), "Central America" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 6, 1, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(677), "Western Africa" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 5, 1, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(675), "Southern Africa" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 4, 1, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(675), "Northern Africa" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 3, 1, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(673), "Indian Ocean" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 2, 1, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(662), "Eastern Africa" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 23, 5, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(694), "Western Europe" });

            migrationBuilder.InsertData(
                table: "regions",
                columns: new[] { "id", "continental_id", "created_date", "name" },
                values: new object[] { 24, 6, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(695), "Pacific" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 108, "BI", "BDI", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(1277), "Burundi", 1, "108" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 48, "BH", "BHR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2472), "Bahrain", 16, "048" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 196, "CY", "CYP", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2473), "Cyprus", 16, "196" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 268, "GE", "GEO", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2474), "Georgia", 16, "268" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 376, "IL", "ISR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2475), "Israel", 16, "376" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 364, "IR", "IRN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2476), "Iran, Islamic Republic of", 16, "364" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 368, "IQ", "IRQ", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2478), "Iraq", 16, "368" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 400, "JO", "JOR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2479), "Jordan", 16, "400" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 414, "KW", "KWT", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2480), "Kuwait", 16, "414" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 422, "LB", "LBN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2482), "Lebanon", 16, "422" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 512, "OM", "OMN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2483), "Oman", 16, "512" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 634, "QA", "QAT", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2484), "Qatar", 16, "634" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 682, "SA", "SAU", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2485), "Saudi Arabia", 16, "682" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 760, "SY", "SYR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2486), "Syrian Arab Republic (Syria)", 16, "760" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 792, "TR", "TUR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2488), "Turkey", 16, "792" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 887, "YE", "YEM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2489), "Yemen", 16, "887" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 40, "AT", "AUT", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2490), "Austria", 17, "040" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 203, "CZ", "CZE", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2491), "Czech Republic", 17, "203" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 348, "HU", "HUN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2492), "Hungary", 17, "348" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 703, "SK", "SVK", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2493), "Slovakia", 17, "703" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 438, "LI", "LIE", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2494), "Liechtenstein", 17, "438" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 756, "CH", "CHE", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2496), "Switzerland", 17, "756" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 112, "BY", "BLR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2497), "Belarus", 18, "112" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 233, "EE", "EST", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2498), "Estonia", 18, "233" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 428, "LV", "LVA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2499), "Latvia", 18, "428" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 440, "LT", "LTU", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2500), "Lithuania", 18, "440" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 51, "AM", "ARM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2471), "Armenia", 16, "051" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 498, "MD", "MDA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2501), "Moldova, Republic of", 18, "498" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 31, "AZ", "AZE", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2470), "Azerbaijan", 16, "031" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 704, "VN", "VNM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2467), "Vietnam", 15, "704" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 446, "MO", "MAC", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2406), "Macao, SAR China", 13, "446" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 158, "TW", "TWN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2407), "Taiwan, Republic of China", 13, "158" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 496, "MN", "MNG", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2409), "Mongolia", 14, "496" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 643, "RU", "RUS", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2410), "Russian Federation", 14, "643" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 4, "AF", "AFG", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2411), "Afghanistan", 15, "004" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 50, "BD", "BGD", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2412), "Bangladesh", 15, "050" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 64, "BT", "BTN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2413), "Bhutan", 15, "064" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 144, "LK", "LKA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2415), "Sri Lanka", 15, "144" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 356, "IN", "IND", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2416), "India", 15, "356" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 86, "IO", "IOT", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2417), "British Indian Ocean Territory", 15, "086" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 462, "MV", "MDV", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2449), "Maldives", 15, "462" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 524, "NP", "NPL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2450), "Nepal", 15, "524" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 586, "PK", "PAK", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2452), "Pakistan", 15, "586" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 104, "MM", "MMR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2453), "Myanmar", 15, "104" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 96, "BN", "BRN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2454), "Brunei Darussalam", 15, "096" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 116, "KH", "KHM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2455), "Cambodia", 15, "116" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 166, "CC", "CCK", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2456), "Cocos (Keeling) Islands", 15, "166" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 360, "ID", "IDN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2458), "Indonesia", 15, "360" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 162, "CX", "CXR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2459), "Christmas Island", 15, "162" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 418, "LA", "LAO", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2460), "Lao PDR", 15, "418" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 458, "MY", "MYS", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2461), "Malaysia", 15, "458" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 608, "PH", "PHL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2462), "Philippines", 15, "608" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 702, "SG", "SGP", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2464), "Singapore", 15, "702" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 764, "TH", "THA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2465), "Thailand", 15, "764" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 626, "TL", "TLS", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2466), "Timor-Leste", 15, "626" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 784, "AE", "ARE", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2468), "United Arab Emirates", 16, "784" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 616, "PL", "POL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2503), "Poland", 18, "616" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 804, "UA", "UKR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2504), "Ukraine", 18, "804" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 248, "AX", "ALA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2505), "Åland Islands", 19, "248" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 833, "IM", "IMN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2553), "Isle of Man", 23, "833" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 832, "JE", "JEY", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2556), "Jersey", 23, "832" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 442, "LU", "LUX", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2557), "Luxembourg", 23, "442" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 492, "MC", "MCO", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2558), "Monaco", 23, "492" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 528, "NL", "NLD", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2559), "Netherlands", 23, "528" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 36, "AU", "AUS", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2561), "Australia", 24, "036" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 90, "SB", "SLB", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2562), "Solomon Islands", 24, "090" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 184, "CK", "COK", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2563), "Cook Islands", 24, "184" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 242, "FJ", "FJI", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2567), "Fiji", 24, "242" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 583, "FM", "FSM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2568), "Micronesia, Federated States of", 24, "583" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 258, "PF", "PYF", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2569), "French Polynesia", 24, "258" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 296, "KI", "KIR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2570), "Kiribati", 24, "296" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 540, "NC", "NCL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2571), "New Caledonia", 24, "540" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 570, "NU", "NIU", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2573), "Niue", 24, "570" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 574, "NF", "NFK", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2574), "Norfolk Island", 24, "574" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 548, "VU", "VUT", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2575), "Vanuatu", 24, "548" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 520, "NR", "NRU", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2576), "Nauru", 24, "520" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 554, "NZ", "NZL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2577), "New Zealand", 24, "554" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 612, "PN", "PCN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2578), "Pitcairn Islands", 24, "612" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 598, "PG", "PNG", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2579), "Papua New Guinea", 24, "598" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 585, "PW", "PLW", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2585), "Palau", 24, "585" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 584, "MH", "MHL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2586), "Marshall Islands", 24, "584" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 772, "TK", "TKL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2587), "Tokelau", 24, "772" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 776, "TO", "TON", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2588), "Tonga", 24, "776" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 798, "TV", "TUV", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2619), "Tuvalu", 24, "798" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 276, "DE", "DEU", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2552), "Germany", 23, "276" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 826, "GB", "GBR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2551), "United Kingdom", 23, "826" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 250, "FR", "FRA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2550), "France", 23, "250" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 372, "IE", "IRL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2548), "Ireland", 23, "372" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 208, "DK", "DNK", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2506), "Denmark", 19, "208" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 246, "FI", "FIN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2512), "Finland", 19, "246" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 234, "FO", "FRO", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2513), "Faroe Islands", 19, "234" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 352, "IS", "ISL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2515), "Iceland", 19, "352" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 744, "SJ", "SJM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2516), "Svalbard and Jan Mayen Islands", 19, "744" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 578, "NO", "NOR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2517), "Norway", 19, "578" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 752, "SE", "SWE", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2518), "Sweden", 19, "752" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 8, "AL", "ALB", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2520), "Albania", 20, "008" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 70, "BA", "BIH", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2521), "Bosnia and Herzegovina", 20, "070" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 100, "BG", "BGR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2523), "Bulgaria", 20, "100" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 300, "GR", "GRC", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2524), "Greece", 20, "300" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 191, "HR", "HRV", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2525), "Croatia", 20, "191" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 410, "KR", "KOR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2404), "Korea, South", 13, "410" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 383, "XK", "XKX", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2529), "Kosovo", 20, "383" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 807, "MK", "MKD", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2531), "Macedonia, Republic of", 20, "807" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 688, "RS", "SRB", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2532), "Serbia", 20, "688" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 642, "RO", "ROU", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2537), "Romania", 20, "642" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 705, "SI", "SVN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2538), "Slovenia", 20, "705" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 20, "AD", "AND", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2539), "Andorra", 21, "020" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 292, "GI", "GIB", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2540), "Gibraltar", 21, "292" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 620, "PT", "PRT", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2541), "Portugal", 21, "620" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 724, "ES", "ESP", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2543), "Spain", 21, "724" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 380, "IT", "ITA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2544), "Italy", 22, "380" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 470, "MT", "MLT", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2545), "Malta", 22, "470" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 674, "SM", "SMR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2546), "San Marino", 22, "674" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 56, "BE", "BEL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2547), "Belgium", 23, "056" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 499, "ME", "MNE", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2530), "Montenegro", 20, "499" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 876, "WF", "WLF", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2620), "Wallis and Futuna Islands", 24, "876" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 408, "KP", "PRK", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2403), "Korea, North", 13, "408" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 344, "HK", "HKG", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2401), "Hong Kong, SAR China", 13, "344" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 454, "MW", "MWI", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2300), "Malawi", 5, "454" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 508, "MZ", "MOZ", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2301), "Mozambique", 5, "508" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 710, "ZA", "ZAF", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2302), "South Africa", 5, "710" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 516, "NA", "NAM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2303), "Namibia", 5, "516" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 748, "SZ", "SWZ", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2305), "Swaziland", 5, "748" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 894, "ZM", "ZMB", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2306), "Zambia", 5, "894" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 716, "ZW", "ZWE", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2307), "Zimbabwe", 5, "716" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 204, "BJ", "BEN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2308), "Benin", 6, "204" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 120, "CM", "CMR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2309), "Cameroon", 6, "120" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 132, "CV", "CPV", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2311), "Cape Verde", 6, "132" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 226, "GQ", "GNQ", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2312), "Equatorial Guinea", 6, "226" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 270, "GM", "GMB", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2313), "Gambia, The", 6, "270" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 266, "GA", "GAB", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2314), "Gabon", 6, "266" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 288, "GH", "GHA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2315), "Ghana", 6, "288" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 324, "GN", "GIN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2317), "Guinea", 6, "324" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 384, "CI", "CIV", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2319), "Cote d'Ivoire", 6, "384" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 430, "LR", "LBR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2320), "Liberia", 6, "430" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 466, "ML", "MLI", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2321), "Mali", 6, "466" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 478, "MR", "MRT", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2322), "Mauritania", 6, "478" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 562, "NE", "NER", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2323), "Niger", 6, "562" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 566, "NG", "NGA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2324), "Nigeria", 6, "566" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 624, "GW", "GNB", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2326), "Guinea-Bissau", 6, "624" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 686, "SN", "SEN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2327), "Senegal", 6, "686" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 694, "SL", "SLE", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2328), "Sierra Leone", 6, "694" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 768, "TG", "TGO", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2329), "Togo", 6, "768" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 426, "LS", "LSO", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2299), "Lesotho", 5, "426" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 678, "ST", "STP", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2330), "Sao Tome and Principe", 6, "678" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 72, "BW", "BWA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2297), "Botswana", 5, "072" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 732, "EH", "ESH", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2294), "Western Sahara", 4, "732" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 148, "TD", "TCD", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2154), "Chad", 1, "148" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 178, "CG", "COG", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2191), "Congo, Republic of the", 1, "178" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 180, "CD", "COD", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2193), "Congo, Democratic Republic of the", 1, "180" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 140, "CF", "CAF", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2194), "Central African Republic", 1, "140" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 646, "RW", "RWA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2195), "Rwanda", 1, "646" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 262, "DJ", "DJI", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2197), "Djibouti", 2, "262" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 232, "ER", "ERI", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2201), "Eritrea", 2, "232" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 231, "ET", "ETH", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2203), "Ethiopia", 2, "231" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 404, "KE", "KEN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2204), "Kenya", 2, "404" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 706, "SO", "SOM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2205), "Somalia", 2, "706" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 728, "SS", "SSD", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2206), "South Sudan", 2, "728" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 834, "TZ", "TZA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2208), "Tanzania, United Republic of", 2, "834" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 800, "UG", "UGA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2209), "Uganda", 2, "800" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 174, "KM", "COM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2210), "Comoros", 3, "174" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 450, "MG", "MDG", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2211), "Madagascar", 3, "450" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 175, "YT", "MYT", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2212), "Mayotte", 3, "175" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 480, "MU", "MUS", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2214), "Mauritius", 3, "480" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 638, "RE", "REU", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2215), "Réunion", 3, "638" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 690, "SC", "SYC", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2216), "Seychelles", 3, "690" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 12, "DZ", "DZA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2217), "Algeria", 4, "012" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 818, "EG", "EGY", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2218), "Egypt", 4, "818" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 434, "LY", "LBY", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2220), "Libya", 4, "434" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 504, "MA", "MAR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2221), "Morocco", 4, "504" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 736, "SD", "SDN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2222), "Sudan", 4, "736" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 788, "TN", "TUN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2223), "Tunisia", 4, "788" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 24, "AO", "AGO", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2296), "Angola", 5, "024" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 854, "BF", "BFA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2331), "Burkina Faso", 6, "854" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 84, "BZ", "BLZ", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2332), "Belize", 7, "084" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 188, "CR", "CRI", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2334), "Costa Rica", 7, "188" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 136, "KY", "CYM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2372), "Cayman Islands", 10, "136" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 192, "CU", "CUB", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2373), "Cuba", 10, "192" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 212, "DM", "DMA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2374), "Dominica", 10, "212" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 214, "DO", "DOM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2375), "Dominican Republic", 10, "214" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 308, "GD", "GRD", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2376), "Grenada", 10, "308" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 312, "GP", "GLP", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2377), "Guadeloupe", 10, "312" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 332, "HT", "HTI", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2379), "Haiti", 10, "332" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 388, "JM", "JAM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2380), "Jamaica", 10, "388" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 474, "MQ", "MTQ", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2381), "Martinique", 10, "474" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 500, "MS", "MSR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2382), "Montserrat", 10, "500" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 663, "MF", "MAF", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2383), "Saint-Martin (French part)", 10, "663" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 659, "KN", "KNA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2385), "Saint Kitts and Nevis", 10, "659" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 662, "LC", "LCA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2386), "Saint Lucia", 10, "662" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 780, "TT", "TTO", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2387), "Trinidad and Tobago", 10, "780" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 796, "TC", "TCA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2388), "Turks and Caicos Islands", 10, "796" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 670, "VC", "VCT", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2389), "Saint Vincent and the Grenadines", 10, "670" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 92, "VG", "VGB", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2390), "British Virgin Islands", 10, "092" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 654, "SH", "SHN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2392), "Saint Helena", 11, "654" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 239, "GS", "SGS", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2393), "South Georgia and the South Sandwich Islands", 11, "239" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 417, "KG", "KGZ", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2394), "Kyrgyzstan", 12, "417" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 398, "KZ", "KAZ", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2395), "Kazakhstan", 12, "398" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 762, "TJ", "TJK", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2396), "Tajikistan", 12, "762" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 795, "TM", "TKM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2397), "Turkmenistan", 12, "795" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 860, "UZ", "UZB", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2399), "Uzbekistan", 12, "860" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 156, "CN", "CHN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2400), "China", 13, "156" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 44, "BS", "BHS", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2370), "Bahamas, The", 10, "044" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 60, "BM", "BMU", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2369), "Bermuda", 10, "060" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 52, "BB", "BRB", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2368), "Barbados", 10, "052" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 660, "AI", "AIA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2367), "Anguilla", 10, "660" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 222, "SV", "SLV", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2335), "El Salvador", 7, "222" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 320, "GT", "GTM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2337), "Guatemala", 7, "320" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 340, "HN", "HND", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2338), "Honduras", 7, "340" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 484, "MX", "MEX", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2339), "Mexico", 7, "484" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 558, "NI", "NIC", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2341), "Nicaragua", 7, "558" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 591, "PA", "PAN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2342), "Panama", 7, "591" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 124, "CA", "CAN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2343), "Canada", 8, "124" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 304, "GL", "GRL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2344), "Greenland", 8, "304" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 666, "PM", "SPM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2345), "Saint Pierre and Miquelon", 8, "666" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 840, "US", "USA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2347), "United States of America", 8, "840" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 32, "AR", "ARG", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2348), "Argentina", 9, "032" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 68, "BO", "BOL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2350), "Bolivia", 9, "068" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 392, "JP", "JPN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2402), "Japan", 13, "392" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 76, "BR", "BRA", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2351), "Brazil", 9, "076" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 170, "CO", "COL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2353), "Colombia", 9, "170" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 218, "EC", "ECU", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2354), "Ecuador", 9, "218" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 254, "GF", "GUF", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2355), "French Guiana", 9, "254" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 238, "FK", "FLK", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2356), "Falkland Islands (Islas Malvinas)", 9, "238" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 328, "GY", "GUY", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2358), "Guyana", 9, "328" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 740, "SR", "SUR", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2359), "Suriname", 9, "740" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 600, "PY", "PRY", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2360), "Paraguay", 9, "600" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 604, "PE", "PER", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2361), "Peru", 9, "604" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 858, "UY", "URY", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2362), "Uruguay", 9, "858" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 862, "VE", "VEN", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2363), "Venezuela (Bolivarian Republic)", 9, "862" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 533, "AW", "ABW", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2365), "Aruba", 10, "533" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 28, "AG", "ATG", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2366), "Antigua and Barbuda", 10, "028" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 152, "CL", "CHL", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2352), "Chile", 9, "152" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "id", "alpha_2_code", "alpha_3_code", "created_date", "name", "region_id", "un_code" },
                values: new object[] { 882, "WS", "WSM", new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(2622), "Samoa", 24, "882" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 82, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3486), "Alabama" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 46, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3451), "Kastamonu" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 45, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3450), "Kars" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 44, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3449), "Karaman" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 43, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3448), "Karabük" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 42, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3409), "Kahramanmaraş" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 41, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3408), "İzmir" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 40, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3407), "İstanbul" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 39, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3406), "Isparta" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 38, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3405), "Iğdır" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 37, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3404), "Hatay" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 36, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3404), "Hakkâri" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 35, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3403), "Gümüşhane" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 34, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3402), "Giresun" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 33, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3401), "Gaziantep" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 32, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3400), "Eskişehir" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 31, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3399), "Erzurum" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 30, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3398), "Erzincan" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 29, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3397), "Elazığ" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 28, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3396), "Edirne" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 27, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3395), "Düzce" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 26, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3394), "Diyarbakır" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 25, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3393), "Denizli" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 24, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3392), "Çorum" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 23, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3391), "Çankırı" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 22, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3390), "Çanakkale" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 21, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3389), "Bursa" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 20, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3388), "Burdur" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 19, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3387), "Bolu" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 18, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3386), "Bitlis" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 47, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3452), "Kayseri" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 17, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3385), "Bingöl" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 48, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3453), "Kilis" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 50, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3455), "Kırklareli" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 79, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3483), "Yalova" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 78, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3482), "Van" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 77, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3481), "Uşak" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 76, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3481), "Tunceli" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 75, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3480), "Trabzon" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 74, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3479), "Tokat" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 73, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3478), "Tekirdağ" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 72, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3477), "Sivas" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 71, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3476), "Şırnak" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 70, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3475), "Sinop" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 69, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3474), "Siirt" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 68, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3473), "Şanlıurfa" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 67, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3472), "Samsun" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 66, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3471), "Sakarya" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 65, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3470), "Rize" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 64, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3469), "Osmaniye" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 63, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3468), "Ordu" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 62, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3467), "Niğde" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 61, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3466), "Nevşehir" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 60, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3465), "Muş" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 59, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3464), "Muğla" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 58, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3463), "Mersin" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 57, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3462), "Mardin" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 56, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3461), "Manisa" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 55, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3460), "Malatya" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 54, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3459), "Kütahya" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 53, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3458), "Konya" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 52, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3457), "Kocaeli" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 51, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3456), "Kırşehir" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 49, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3454), "Kırıkkale" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 16, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3384), "Bilecik" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 15, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3383), "Bayburt" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 14, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3382), "Batman" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 111, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3515), "New Jersey" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 110, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3514), "New Hampshire" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 109, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3513), "Nevada" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 108, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3512), "Nebraska" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 107, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3511), "Montana" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 106, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3510), "Missouri" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 105, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3509), "Mississippi" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 104, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3508), "Minnesota" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 103, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3507), "Michigan" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 102, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3506), "Massachusetts" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 101, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3505), "Maryland" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 100, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3504), "Maine" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 99, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3503), "Louisiana" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 98, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3502), "Kentucky" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 97, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3501), "Kansas" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 96, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3500), "Iowa" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 95, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3499), "Indiana" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 94, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3498), "Illinois" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 93, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3497), "Idaho" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 92, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3496), "Hawaii" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 91, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3495), "Georgia" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 90, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3494), "Florida" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 89, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3493), "Delaware" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 88, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3492), "Connecticut" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 87, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3491), "Colorado" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 86, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3490), "California" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 85, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3489), "Arkansas" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 84, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3489), "Arizona" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 83, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3488), "Alaska" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 112, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3516), "New Mexico" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 113, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3517), "New York" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 114, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3518), "North Carolina" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 115, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3519), "North Dakota" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 13, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3381), "Bartın" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 12, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3380), "Balıkesir" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 11, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3379), "Aydın" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 10, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3378), "Artvin" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 9, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3377), "Ardahan" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 8, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3376), "Antalya" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 7, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3375), "Ankara" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 6, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3374), "Amasya" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 5, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3373), "Aksaray" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 4, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3372), "Ağrı" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 3, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3371), "Afyonkarahisar" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 2, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3345), "Adıyaman" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 1, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3115), "Adana" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 132, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3535), "Wyoming" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 80, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3484), "Yozgat" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 131, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3534), "Wisconsin" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 129, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3532), "Washington, D.C." });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 128, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3531), "Washington" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 127, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3530), "Virginia" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 126, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3529), "Vermont" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 125, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3528), "Utah" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 124, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3527), "Texas" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 123, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3526), "Tennessee" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 122, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3525), "South Dakota" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 121, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3524), "South Carolina" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 120, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3523), "Rhode Island" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 119, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3522), "Pennsylvania" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 118, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3521), "Oregon" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 117, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3520), "Oklahoma" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 116, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3520), "Ohio" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 130, 840, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3533), "West Virginia" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "id", "country_id", "created_date", "name" },
                values: new object[] { 81, 792, new DateTime(2020, 5, 12, 13, 15, 51, 485, DateTimeKind.Utc).AddTicks(3485), "Zonguldak" });

            migrationBuilder.CreateIndex(
                name: "IX_cities_country_id",
                table: "cities",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_countries_region_id",
                table: "countries",
                column: "region_id");

            migrationBuilder.CreateIndex(
                name: "IX_regions_continental_id",
                table: "regions",
                column: "continental_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "regions");

            migrationBuilder.DropTable(
                name: "continentals");
        }
    }
}
