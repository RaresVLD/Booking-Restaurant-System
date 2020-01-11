using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantServiceProvider.Migrations
{
    public partial class InitialConfigurationFinal : Migration
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
                    { new Guid("84b88b63-64ad-4258-ac88-982ddf481033"), "Centru", "E super central si chirica e patron", "Mamma mia" },
                    { new Guid("e20cfcce-f9a7-469e-a110-d027197a6fbd"), "Tatarasi", "E super in tatarasi si patron sunt eu", "Serginio" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { new Guid("8eb22ab1-2241-4f3e-8e44-963edf012d3b"), "tudormanoleasa@gmail.com", "Tudor", "Manoleasa", "parolatudormanoleasa" },
                    { new Guid("1a456110-ced5-4cd3-8410-a96fbfa94059"), "roxana.apopei@yahoo.com", "Roxana", "Apopei", "parolaroxanaapopei" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingDate", "NumberOfPersons", "ProductId", "RestaurantId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ba32a528-0e5f-454d-98aa-588bb076099c"), new DateTime(2019, 12, 10, 12, 12, 12, 0, DateTimeKind.Unspecified), 3, null, new Guid("84b88b63-64ad-4258-ac88-982ddf481033"), new Guid("8eb22ab1-2241-4f3e-8e44-963edf012d3b") },
                    { new Guid("8dd21049-aaad-46ba-a9cd-d7721c9d72b9"), new DateTime(2019, 10, 10, 10, 10, 10, 0, DateTimeKind.Unspecified), 5, null, new Guid("e20cfcce-f9a7-469e-a110-d027197a6fbd"), new Guid("1a456110-ced5-4cd3-8410-a96fbfa94059") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BookingId", "Description", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { new Guid("7c33aefc-b842-4ffd-acea-620c198c48bb"), null, "Super gustoase aripioarele de la mama", "AripioareMamma", 20.5, new Guid("84b88b63-64ad-4258-ac88-982ddf481033") },
                    { new Guid("cde724e1-d6b3-496f-9db0-25aa25476004"), null, "Super buna piza de la mama", "PizzaMamma", 30.5, new Guid("84b88b63-64ad-4258-ac88-982ddf481033") },
                    { new Guid("b42e7f63-b2c1-407b-9234-1339e6f6b7d7"), null, "Cel mai bun bors din istoria tatarasi", "BorsSergio", 10.5, new Guid("e20cfcce-f9a7-469e-a110-d027197a6fbd") },
                    { new Guid("0a43f6d0-4be6-46c1-8af2-5d33595d46e3"), null, "Mamaliga goala facuta din malai si apa", "MamaligaSergio", 8.5, new Guid("e20cfcce-f9a7-469e-a110-d027197a6fbd") }
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
