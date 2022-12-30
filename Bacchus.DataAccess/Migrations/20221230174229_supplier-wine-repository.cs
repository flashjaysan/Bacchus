using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bacchus.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class supplierwinerepository : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierWineEntity_Suppliers_SupplierEntityId",
                table: "SupplierWineEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierWineEntity_Suppliers_SupplierId",
                table: "SupplierWineEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierWineEntity_Wines_WineEntityId",
                table: "SupplierWineEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierWineEntity_Wines_WineId",
                table: "SupplierWineEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierWineEntity",
                table: "SupplierWineEntity");

            migrationBuilder.RenameTable(
                name: "SupplierWineEntity",
                newName: "SuppliersWines");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierWineEntity_WineId",
                table: "SuppliersWines",
                newName: "IX_SuppliersWines_WineId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierWineEntity_WineEntityId",
                table: "SuppliersWines",
                newName: "IX_SuppliersWines_WineEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierWineEntity_SupplierId",
                table: "SuppliersWines",
                newName: "IX_SuppliersWines_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_SupplierWineEntity_SupplierEntityId",
                table: "SuppliersWines",
                newName: "IX_SuppliersWines_SupplierEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuppliersWines",
                table: "SuppliersWines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SuppliersWines_Suppliers_SupplierEntityId",
                table: "SuppliersWines",
                column: "SupplierEntityId",
                principalTable: "Suppliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SuppliersWines_Suppliers_SupplierId",
                table: "SuppliersWines",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuppliersWines_Wines_WineEntityId",
                table: "SuppliersWines",
                column: "WineEntityId",
                principalTable: "Wines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SuppliersWines_Wines_WineId",
                table: "SuppliersWines",
                column: "WineId",
                principalTable: "Wines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuppliersWines_Suppliers_SupplierEntityId",
                table: "SuppliersWines");

            migrationBuilder.DropForeignKey(
                name: "FK_SuppliersWines_Suppliers_SupplierId",
                table: "SuppliersWines");

            migrationBuilder.DropForeignKey(
                name: "FK_SuppliersWines_Wines_WineEntityId",
                table: "SuppliersWines");

            migrationBuilder.DropForeignKey(
                name: "FK_SuppliersWines_Wines_WineId",
                table: "SuppliersWines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SuppliersWines",
                table: "SuppliersWines");

            migrationBuilder.RenameTable(
                name: "SuppliersWines",
                newName: "SupplierWineEntity");

            migrationBuilder.RenameIndex(
                name: "IX_SuppliersWines_WineId",
                table: "SupplierWineEntity",
                newName: "IX_SupplierWineEntity_WineId");

            migrationBuilder.RenameIndex(
                name: "IX_SuppliersWines_WineEntityId",
                table: "SupplierWineEntity",
                newName: "IX_SupplierWineEntity_WineEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_SuppliersWines_SupplierId",
                table: "SupplierWineEntity",
                newName: "IX_SupplierWineEntity_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_SuppliersWines_SupplierEntityId",
                table: "SupplierWineEntity",
                newName: "IX_SupplierWineEntity_SupplierEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierWineEntity",
                table: "SupplierWineEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierWineEntity_Suppliers_SupplierEntityId",
                table: "SupplierWineEntity",
                column: "SupplierEntityId",
                principalTable: "Suppliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierWineEntity_Suppliers_SupplierId",
                table: "SupplierWineEntity",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierWineEntity_Wines_WineEntityId",
                table: "SupplierWineEntity",
                column: "WineEntityId",
                principalTable: "Wines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierWineEntity_Wines_WineId",
                table: "SupplierWineEntity",
                column: "WineId",
                principalTable: "Wines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
