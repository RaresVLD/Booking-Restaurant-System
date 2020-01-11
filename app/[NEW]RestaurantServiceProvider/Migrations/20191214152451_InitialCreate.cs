using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantServiceProvider.Migrations
{
    public partial class InitialCreate : Migration
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
                    { new Guid("903a213a-7f14-4075-9ea4-d6fecd2b6c37"), "Bld. Tudor Vladimirescu, et.2", "Clatite americane reinventate, arome delicioase", "Panck's" },
                    { new Guid("e6f8a0ca-1c18-49ba-8965-899dde583528"), "Bld. Carol I nr.4 ", "Va asteptam intr-o ambianţă originală, cu puternice accente tradiţionale moldoveneşti si cu un meniu foarte atractiv.", "La Placinte" },
                    { new Guid("35c21d36-8a1a-4cf5-82c6-ee807c632374"), "Strada Silvestru nr. 4, Iași 700259", "Culoarea are gust.", "Oliv" },
                    { new Guid("6d6cb2e2-e68c-46ef-b598-502ecce8beca"), "3F, Strada Palas, Iași 700032", "Sophisticated and tempting restaurant. Located in the historic core of the city, near the Palace of Culture in the Palas ensemble which is \"city in the heart of the city\".Elegant interior and luxurious atmosphere.", "Fenice" },
                    { new Guid("4da203dd-e6b6-43bf-9597-55a99faeadba"), "Palas Food Court, Strada Palas 5C, Iași 700259", "Puterea gustului!", "Mado Palas" },
                    { new Guid("d16a59d6-b738-46c5-81f7-b62804d8fc38"), "Esplanada Teatrul Luceafărul, Iași 700259", "The Trumpets este locul în care, lăsănd grijile la o parte, se amplifică simțurile și deschiderea către distracție. Auzul, gustul, simțul olfactiv și cel tactil, sunt celebrate în cadrul pub-ului pentru a-ți reda buna dispoziție după ce ai petrecut o zi cu ochii în calculator, rapoarte sau facturi. Fiindcă cercetătorii britanici au descoperit că partea plină a paharului se vede cel mai bine atunci când iți aduce chelnerul următorul rând.", "The Trumpets" },
                    { new Guid("8bb5e343-4c5e-46ec-9b7a-0d1a8c56f33d"), "Strada Palat 3F, Iași 700032", "Grilling to perfection is not a goal it's a MUST!", "Chef Galerie" },
                    { new Guid("100f3c09-41ff-4a7c-971d-94efcf67c8df"), "Strada Grigore Ureche nr. 27, Iași 700044", "Legend este locul unde berea e mai rece decât ți-ai putea imagina, mâncarea este mai bună decât atunci când nu mai poți de foame, iar petrecerile sunt mai nebune decât orice-ai văzut înainte. De ce? Fiindcă trăim totul la superlativ. Despre asta este #Legend", "Legend Pub" },
                    { new Guid("20ba02d8-8115-43ae-85d6-6553b0e270ff"), "Shopping Street, Iași 700051", "Pentru că prietenii merg mână în mână cu un cocktail bun, cafeaua italiană merge perfect cu diminețile pline de soare și weekendurile nu sunt la fel fără o masă cu savori italiene alese, alături de familie, s-a creat C-House!", "C House Lounge" },
                    { new Guid("11831525-8ed3-4f5b-8029-22cb04ef2f7a"), "Strada Palas", "Construit dintr-o idee grozavă și nu liniștită, Treaz & Nu este primul local conceptual din oraș menit să-i gâdile pe iubitorii de vinuri și pasionații de cafea.Credem că pe lume există prea puțină cafea de specialitate și vinuri de calitate, pentru câte lucruri avem să ne spunem. Așa că hai să le-ncercăm pe toate!", "Treaz & Nu" },
                    { new Guid("a783b5ac-5cdf-4db6-b706-af7b4401187d"), "Strada Palas nr. 7A, Iași 700051", "Carbon a fost creat pentru a redefini experienta gastronomica.", "Carbon" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { new Guid("93bd6f45-e890-4453-8856-1e9033855137"), "tudormanoleasa@gmail.com", "Tudor", "Manoleasa", "parolatudormanoleasa" },
                    { new Guid("a25e2a4e-895c-4072-889a-58c313fd49e3"), "roxana.apopei@yahoo.com", "Roxana", "Apopei", "parolaroxanaapopei" }
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
