using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace storegit.Migrations
{
    public partial class dron1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewUserid",
                table: "orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NewProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Color = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewUser",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    phone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewUser", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NewOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<string>(nullable: true),
                    Userid = table.Column<int>(nullable: true),
                    Usersid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewOrder_NewUser_Userid",
                        column: x => x.Userid,
                        principalTable: "NewUser",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewOrder_Users_Usersid",
                        column: x => x.Usersid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrder",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrder", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductOrder_NewOrder_OrderId",
                        column: x => x.OrderId,
                        principalTable: "NewOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrder_NewProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "NewProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_NewUserid",
                table: "orders",
                column: "NewUserid");

            migrationBuilder.CreateIndex(
                name: "IX_NewOrder_Userid",
                table: "NewOrder",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_NewOrder_Usersid",
                table: "NewOrder",
                column: "Usersid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_OrderId",
                table: "ProductOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_ProductId",
                table: "ProductOrder",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_NewUser_NewUserid",
                table: "orders",
                column: "NewUserid",
                principalTable: "NewUser",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_NewUser_NewUserid",
                table: "orders");

            migrationBuilder.DropTable(
                name: "ProductOrder");

            migrationBuilder.DropTable(
                name: "NewOrder");

            migrationBuilder.DropTable(
                name: "NewProduct");

            migrationBuilder.DropTable(
                name: "NewUser");

            migrationBuilder.DropIndex(
                name: "IX_orders_NewUserid",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "NewUserid",
                table: "orders");
        }
    }
}
