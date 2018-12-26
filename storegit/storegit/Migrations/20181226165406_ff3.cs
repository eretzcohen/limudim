using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace storegit.Migrations
{
    public partial class ff3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Type_of_jewelry_Type_of_jewelryid",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Type_of_jewelry");

            migrationBuilder.DropIndex(
                name: "IX_Products_Type_of_jewelryid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Type_of_jewelryid",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Type_of_jewelryid",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Type_of_jewelry",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_of_jewelry", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Type_of_jewelryid",
                table: "Products",
                column: "Type_of_jewelryid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Type_of_jewelry_Type_of_jewelryid",
                table: "Products",
                column: "Type_of_jewelryid",
                principalTable: "Type_of_jewelry",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
