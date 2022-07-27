using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCatalogAPI.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItems_CatalogTypes_CataLogTypeId",
                table: "CatalogItems");

            migrationBuilder.RenameColumn(
                name: "CataLogTypeId",
                table: "CatalogItems",
                newName: "CatalogTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogItems_CataLogTypeId",
                table: "CatalogItems",
                newName: "IX_CatalogItems_CatalogTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItems_CatalogTypes_CatalogTypeId",
                table: "CatalogItems",
                column: "CatalogTypeId",
                principalTable: "CatalogTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItems_CatalogTypes_CatalogTypeId",
                table: "CatalogItems");

            migrationBuilder.RenameColumn(
                name: "CatalogTypeId",
                table: "CatalogItems",
                newName: "CataLogTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogItems_CatalogTypeId",
                table: "CatalogItems",
                newName: "IX_CatalogItems_CataLogTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItems_CatalogTypes_CataLogTypeId",
                table: "CatalogItems",
                column: "CataLogTypeId",
                principalTable: "CatalogTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
