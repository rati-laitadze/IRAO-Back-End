using Microsoft.EntityFrameworkCore.Migrations;

namespace IRAOProject.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    MarketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.MarketId);
                });

            migrationBuilder.CreateTable(
                name: "MarketCompanies",
                columns: table => new
                {
                    MarketId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketCompanies", x => new { x.MarketId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_MarketCompanies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarketCompanies_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "CompanyName" },
                values: new object[,]
                {
                    { 1, "company1" },
                    { 2, "company2" },
                    { 3, "company3" },
                    { 4, "company4" },
                    { 5, "company5" }
                });

            migrationBuilder.InsertData(
                table: "Markets",
                columns: new[] { "MarketId", "MarketName" },
                values: new object[,]
                {
                    { 1, "market1" },
                    { 2, "market2" },
                    { 3, "market3" }
                });

            migrationBuilder.InsertData(
                table: "MarketCompanies",
                columns: new[] { "CompanyId", "MarketId", "CompanyPrice" },
                values: new object[,]
                {
                    { 1, 1, 100.0 },
                    { 2, 1, 100.0 },
                    { 3, 1, 100.0 },
                    { 4, 1, 100.0 },
                    { 5, 1, 100.0 },
                    { 1, 2, 100.0 },
                    { 2, 2, 100.0 },
                    { 3, 2, 100.0 },
                    { 4, 2, 100.0 },
                    { 5, 2, 100.0 },
                    { 1, 3, 100.0 },
                    { 2, 3, 100.0 },
                    { 3, 3, 100.0 },
                    { 4, 3, 100.0 },
                    { 5, 3, 100.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarketCompanies_CompanyId",
                table: "MarketCompanies",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketCompanies");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Markets");
        }
    }
}
