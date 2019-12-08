using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantServiceProvider.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RestaurantId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    BookingId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NumberOfPersons = table.Column<int>(nullable: false),
                    BookingDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    RestaurantId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("7f851c13-3f69-49e3-ba36-a008aac87a15"), "Centru", "E super central si chirica e patron", "Mamma mia" },
                    { new Guid("15f2d9d8-cd24-4956-8400-4d1e97bb3fc5"), "Tatarasi", "E super in tatarasi si patron sunt eu", "Serginio" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { new Guid("226d9502-9b5c-480f-92fe-cd6d69bc0489"), "tudormanoleasa@gmail.com", "Tudor", "Manoleasa", "parolatudormanoleasa" },
                    { new Guid("4db60556-b7ff-4833-b60d-7328a4a016d7"), "roxana.apopei@yahoo.com", "Roxana", "Apopei", "parolaroxanaapopei" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingDate", "NumberOfPersons", "ProductId", "RestaurantId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9a2bfecb-5332-479c-b5ca-4ec542a3498e"), new DateTime(2019, 12, 10, 12, 12, 12, 0, DateTimeKind.Unspecified), 3, null, new Guid("7f851c13-3f69-49e3-ba36-a008aac87a15"), new Guid("226d9502-9b5c-480f-92fe-cd6d69bc0489") },
                    { new Guid("34cad41c-19c2-4966-98e0-856e97f0b3f6"), new DateTime(2019, 10, 10, 10, 10, 10, 0, DateTimeKind.Unspecified), 5, null, new Guid("15f2d9d8-cd24-4956-8400-4d1e97bb3fc5"), new Guid("4db60556-b7ff-4833-b60d-7328a4a016d7") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BookingId", "Description", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("ba756e15-0cdf-4d50-a755-155d52c27906"), null, "Super gustoase aripioarele de la mama", "AripioareMamma", 20.5, new Guid("7f851c13-3f69-49e3-ba36-a008aac87a15") },
                    { new Guid("b0805f08-bbf5-4eb8-9f65-82d9b27e72c4"), null, "Super buna piza de la mama", "PizzaMamma", 30.5, new Guid("7f851c13-3f69-49e3-ba36-a008aac87a15") },
                    { new Guid("a4997451-d0db-4636-b320-08b68f5d468e"), null, "Cel mai bun bors din istoria tatarasi", "BorsSergio", 10.5, new Guid("15f2d9d8-cd24-4956-8400-4d1e97bb3fc5") },
                    { new Guid("8f164ff1-3854-4de7-bfda-2ab1c9d1fe58"), null, "Mamaliga goala facuta din malai si apa", "MamaligaSergio", 8.5, new Guid("15f2d9d8-cd24-4956-8400-4d1e97bb3fc5") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ProductId",
                table: "Bookings",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BookingId",
                table: "Products",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_RestaurantId",
                table: "Products",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Bookings_BookingId",
                table: "Products",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Products_ProductId",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
