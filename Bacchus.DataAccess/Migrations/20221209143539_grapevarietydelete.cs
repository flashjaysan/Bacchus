using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bacchus.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class grapevarietydelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_GrapeVarieties_GrapeVarietyId",
                table: "Wines");

            migrationBuilder.DropTable(
                name: "GrapeVarieties");

            migrationBuilder.DropIndex(
                name: "IX_Wines_GrapeVarietyId",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "GrapeVarietyId",
                table: "Wines");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "SupplierWineEntity",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "SupplierWineEntity");

            migrationBuilder.AddColumn<int>(
                name: "GrapeVarietyId",
                table: "Wines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GrapeVarieties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrapeVarieties", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wines_GrapeVarietyId",
                table: "Wines",
                column: "GrapeVarietyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_GrapeVarieties_GrapeVarietyId",
                table: "Wines",
                column: "GrapeVarietyId",
                principalTable: "GrapeVarieties",
                principalColumn: "Id");
        }
    }
}
