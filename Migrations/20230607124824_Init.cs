﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookApp.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublishedOn = table.Column<int>(type: "int", nullable: false),
                    ISBN = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Publisher = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => new { x.BookId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_BookAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PriceOffer",
                columns: table => new
                {
                    PriceOfferId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NewPrice = table.Column<float>(type: "float", nullable: false),
                    OfferText = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceOffer", x => x.PriceOfferId);
                    table.ForeignKey(
                        name: "FK_PriceOffer_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VoterName = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "WyoTech", "" },
                    { 2, " I-CAR", "" },
                    { 3, "Solutions & Solutions", "" },
                    { 4, "Doug ", "Larue" },
                    { 5, "Randy ", "Svalina" },
                    { 6, "Gary ", "Puls" },
                    { 7, "Andrew", "A." },
                    { 8, "Rezin", "Ph.D" },
                    { 9, "Jack", "Erjavec" },
                    { 10, "Rob", "Thompson" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Description", "ISBN", "Price", "PublishedOn", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Collision Repair I", "978-1-323-00001-1", 75f, 2022, "Modern Printing", "Collision Repair I" },
                    { 2, "Collision Repair II", "978-1-323-00002-1", 60f, 2020, "Modern Printing", "Collision Repair II" },
                    { 3, "Refinishing I", "978-1-323-00003-1", 50f, 2022, "Modern Printing", "Refinishing I" },
                    { 4, "Refinishing II", "978-1-323-00004-1", 80f, 2020, "Modern Printing", "Refinishing II" },
                    { 5, "Motorsports Chassis Frabrication I", "978-1-323-39626-1", 69.4f, 2020, "Pearson Publishing", "Motorsports Chassis Frabrication I" },
                    { 6, "Motorsports Chassis Fabrication II", "978-1-323-39627-8", 76.4f, 2020, "Pearson Publishing", "Motorsports Chassis Fabrication II" },
                    { 7, "Basic Street Rod", "978-1-323-00005-1", 136.15f, 2021, "Kinkos", "Basic Street Rod" },
                    { 8, "Advanced Street Rod", "978-1-323-00006-1", 73.05f, 2022, "Kinkos", "Advanced Street Rod" },
                    { 9, "Custom Paint Book", "978-1-323-00007-1", 128.57f, 2020, "Kinkos", "Custom Paint Book" },
                    { 10, "Trim and Upholstery I", "978-1-323-00008-1", 156.5f, 2021, "Custom Print", "Trim and Upholstery I" },
                    { 11, "Trim and Upholstery II", "978-1-323-00009-1", 108.09f, 2021, "Custom Print", "Trim and Upholstery II" },
                    { 12, "Accounting and Financial Management", "978-0-134-70985-1", 166.65f, 2020, "Prentice Hall", "Accounting and Financial Management" },
                    { 13, "Computers and Business Applications", "978-0-134-70985-2", 166.65f, 2021, "Prentice Hall", "Computers and Business Applications" },
                    { 14, "Communications", "978-0-134-70985-3", 166.65f, 2021, "Prentice Hall", "Communications" },
                    { 15, "Management Concepts", "978-0-134-70985-4", 166.65f, 2020, "Prentice Hall", "Management Concepts" },
                    { 16, "Human Resources Management", "978-0-134-70985-5", 166.65f, 2021, "Prentice Hall", "Human Resources Management" },
                    { 17, "Shop Management", "978-0-134-70985-6", 166.65f, 2021, "Prentice Hall", "Shop Management" },
                    { 18, "Basic Engine Management Systems", "978-1-133-61231-5", 149.95f, 2020, "Cengage Learning", "Basic Engine Management Systems" },
                    { 19, "Drivability Diagnostics", "978-1-133-61231-6", 149.95f, 2022, "Cengage Learning", "Drivability Diagnostics" },
                    { 20, "Drivetrain Systems", "978-1-133-61231-7", 149.95f, 2020, "Cengage Learning", "Drivetrain Systems" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "AuthorId", "BookId", "Order" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 1, 2, 1 },
                    { 2, 2, 2 },
                    { 1, 3, 1 },
                    { 2, 3, 2 },
                    { 1, 4, 1 },
                    { 2, 4, 2 },
                    { 3, 5, 1 },
                    { 3, 6, 1 },
                    { 4, 7, 1 },
                    { 5, 7, 2 },
                    { 4, 8, 1 },
                    { 5, 8, 2 },
                    { 6, 9, 1 },
                    { 1, 10, 1 },
                    { 1, 11, 1 },
                    { 7, 12, 1 },
                    { 8, 12, 2 },
                    { 7, 13, 1 },
                    { 8, 13, 2 },
                    { 7, 14, 1 },
                    { 8, 14, 2 },
                    { 7, 15, 1 },
                    { 8, 15, 2 },
                    { 7, 16, 1 },
                    { 8, 16, 2 },
                    { 7, 17, 1 },
                    { 8, 17, 2 },
                    { 9, 18, 1 },
                    { 10, 18, 2 },
                    { 9, 19, 1 },
                    { 10, 19, 2 },
                    { 9, 20, 1 },
                    { 10, 20, 2 }
                });

            migrationBuilder.InsertData(
                table: "PriceOffer",
                columns: new[] { "PriceOfferId", "BookId", "NewPrice", "OfferText" },
                values: new object[,]
                {
                    { 1, 1, 26.25f, "" },
                    { 2, 2, 30f, "" },
                    { 3, 3, 25.25f, "" },
                    { 4, 4, 30f, "" },
                    { 5, 5, 24.29f, "" },
                    { 6, 6, 20.06f, "" },
                    { 7, 7, 47.65f, "" },
                    { 8, 8, 25.57f, "" },
                    { 9, 9, 45f, "" },
                    { 10, 10, 54.78f, "" },
                    { 11, 11, 37.83f, "" },
                    { 12, 12, 58.33f, "" },
                    { 13, 13, 58.33f, "" },
                    { 14, 14, 58.33f, "" },
                    { 15, 15, 58.33f, "" },
                    { 16, 16, 58.33f, "" },
                    { 17, 17, 58.33f, "" },
                    { 18, 18, 52.48f, "" },
                    { 19, 19, 52.48f, "" },
                    { 20, 20, 52.48f, "" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "BookId", "Comment", "Rating", "VoterName" },
                values: new object[,]
                {
                    { 1, 3, "Not bad", 6, "Abdellah" },
                    { 2, 18, "Not bad", 6, "Abdellah" },
                    { 3, 19, "bad", 3, "Abdellah" },
                    { 4, 20, "bad", 3, "Abdellah" },
                    { 5, 2, "good", 8, "Ali" },
                    { 6, 17, "bad", 4, "Ali" },
                    { 7, 18, "bad", 4, "Ali" },
                    { 8, 19, "good", 8, "Ali" },
                    { 9, 8, "average", 6, "Halima" },
                    { 10, 13, "average", 6, "Halima" },
                    { 11, 15, "average", 5, "Halima" },
                    { 12, 3, "", 5, "Kamal" },
                    { 13, 4, "", 5, "Kamal" },
                    { 14, 5, "average", 5, "Kamal" },
                    { 15, 6, "bad", 3, "Kamal" },
                    { 16, 10, "", 5, "Kamal" },
                    { 17, 11, "", 5, "Kamal" },
                    { 18, 15, "bad", 3, "Kamal" },
                    { 19, 16, "average", 5, "Kamal" },
                    { 20, 1, "good", 8, "Karim" },
                    { 21, 6, "average", 5, "Karim" },
                    { 22, 9, "average", 5, "Karim" },
                    { 23, 20, "good", 8, "Karim" },
                    { 24, 7, "", 8, "Laila" },
                    { 25, 13, "average", 5, "Laila" },
                    { 26, 14, "", 8, "Laila" },
                    { 27, 16, "average", 5, "Laila" },
                    { 28, 1, "Nice  Book", 9, "Mohamed" },
                    { 29, 2, "average", 6, "Mohamed" },
                    { 30, 4, "", 5, "Mohamed" },
                    { 31, 5, "average", 5, "Mohamed" },
                    { 32, 7, "average", 5, "Mohamed" },
                    { 33, 10, "average", 7, "Mohamed" },
                    { 34, 11, "bad", 4, "Mohamed" },
                    { 35, 12, "average", 5, "Mohamed" },
                    { 36, 14, "average", 5, "Mohamed" },
                    { 37, 17, "", 5, "Mohamed" },
                    { 38, 19, "Not bad", 6, "Mohamed" },
                    { 39, 20, "Nice  Book", 9, "Mohamed" },
                    { 40, 2, "good", 8, "Patrice" },
                    { 41, 3, "good", 8, "Patrice" },
                    { 42, 7, "good", 8, "Patrice" },
                    { 43, 12, "good", 8, "Patrice" },
                    { 44, 17, "average", 7, "Patrice" },
                    { 45, 18, "good", 8, "Patrice" },
                    { 46, 19, "good", 8, "Patrice" },
                    { 47, 9, "", 5, "Sabiri" },
                    { 48, 11, "good", 8, "Sabiri" },
                    { 49, 12, "", 5, "Sabiri" },
                    { 50, 16, "good", 8, "Sabiri" },
                    { 51, 4, "average", 5, "Slimani" },
                    { 52, 7, "average", 5, "Slimani" },
                    { 53, 8, "", 8, "Slimani" },
                    { 54, 9, "good", 8, "Slimani" },
                    { 55, 10, "good", 8, "Slimani" },
                    { 56, 13, "", 8, "Slimani" },
                    { 57, 14, "average", 5, "Slimani" },
                    { 58, 17, "average", 5, "Slimani" },
                    { 59, 8, "average", 5, "Yassine" },
                    { 60, 13, "average", 5, "Yassine" },
                    { 61, 14, "good", 8, "Yassine" },
                    { 62, 15, "good", 8, "Yassine" },
                    { 63, 3, "Nice  Book", 9, "Zineb" },
                    { 64, 4, "good", 9, "Zineb" },
                    { 65, 5, "Nice  Book", 9, "Zineb" },
                    { 66, 6, "average", 5, "Zineb" },
                    { 67, 15, "average", 5, "Zineb" },
                    { 68, 16, "good", 10, "Zineb" },
                    { 69, 1, "good", 10, "Ziyad" },
                    { 70, 2, "good", 10, "Ziyad" },
                    { 71, 9, "good", 9, "Ziyad" },
                    { 72, 12, "good", 9, "Ziyad" }
                });

            migrationBuilder.CreateIndex(
                name: "Index_FullName",
                table: "Author",
                columns: new[] { "FirstName", "LastName" });

            migrationBuilder.CreateIndex(
                name: "Index_BookTitle",
                table: "Book",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "Unique_ISBN_Index",
                table: "Book",
                column: "ISBN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceOffer_BookId",
                table: "PriceOffer",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Index_VoterName",
                table: "Review",
                column: "VoterName");

            migrationBuilder.CreateIndex(
                name: "IX_Review_BookId",
                table: "Review",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthor");

            migrationBuilder.DropTable(
                name: "PriceOffer");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
