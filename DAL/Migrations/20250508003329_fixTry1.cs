using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EA.DAL.Migrations
{
    /// <inheritdoc />
    public partial class fixTry1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsComponent_CategoryComponent_CategoryId",
                table: "ProductsComponent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsComponent",
                table: "ProductsComponent");

            migrationBuilder.RenameTable(
                name: "ProductsComponent",
                newName: "ProductsComponents");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsComponent_CategoryId",
                table: "ProductsComponents",
                newName: "IX_ProductsComponents_CategoryId");

            migrationBuilder.AddColumn<Guid>(
                name: "IndexComponentId",
                table: "IndexComponents",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsComponents",
                table: "ProductsComponents",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_IndexComponents_IndexComponentId",
                table: "IndexComponents",
                column: "IndexComponentId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndexComponents_IndexComponents_IndexComponentId",
                table: "IndexComponents",
                column: "IndexComponentId",
                principalTable: "IndexComponents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsComponents_CategoryComponent_CategoryId",
                table: "ProductsComponents",
                column: "CategoryId",
                principalTable: "CategoryComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndexComponents_IndexComponents_IndexComponentId",
                table: "IndexComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsComponents_CategoryComponent_CategoryId",
                table: "ProductsComponents");

            migrationBuilder.DropIndex(
                name: "IX_IndexComponents_IndexComponentId",
                table: "IndexComponents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsComponents",
                table: "ProductsComponents");

            migrationBuilder.DropColumn(
                name: "IndexComponentId",
                table: "IndexComponents");

            migrationBuilder.RenameTable(
                name: "ProductsComponents",
                newName: "ProductsComponent");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsComponents_CategoryId",
                table: "ProductsComponent",
                newName: "IX_ProductsComponent_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsComponent",
                table: "ProductsComponent",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsComponent_CategoryComponent_CategoryId",
                table: "ProductsComponent",
                column: "CategoryId",
                principalTable: "CategoryComponent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
