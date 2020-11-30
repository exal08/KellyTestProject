using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KellyTestProject.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimeVisit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Раздел 1" },
                    { 2, "Раздел 2" },
                    { 3, "Раздел 3" },
                    { 4, "Раздел 4" },
                    { 5, "Раздел 5" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Patronymic", "Surname" },
                values: new object[,]
                {
                    { 10, "Имя5", "Отчество5", "Фамилия5" },
                    { 9, "Имя4", "Отчество4", "Фамилия4" },
                    { 8, "Имя3", "Отчество3", "Фамилия3" },
                    { 7, "Имя2", "Отчество2", "Фамилия2" },
                    { 6, "Имя1", "Отчество1", "Фамилия1" },
                    { 4, "Александр", "Александрович", "Александров" },
                    { 11, "Имя6", "Отчество6", "Фамилия6" },
                    { 3, "Семён", "Семёныч", "Смирнов" },
                    { 2, "Пётр", "Петрович", "Петров" },
                    { 1, "Иван", "Иванович", "Иванов" },
                    { 5, "Максим", "Максимы", "Максимов" },
                    { 12, "Имя7", "Отчество7", "Фамилия7" }
                });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "DateTimeVisit", "SectionId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 9, 11, 20, 28, 16, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 138, new DateTime(2018, 2, 17, 7, 57, 22, 0, DateTimeKind.Unspecified), 5, 9 },
                    { 139, new DateTime(2021, 8, 28, 9, 24, 47, 0, DateTimeKind.Unspecified), 5, 9 },
                    { 140, new DateTime(2019, 1, 18, 5, 41, 17, 0, DateTimeKind.Unspecified), 5, 9 },
                    { 141, new DateTime(2021, 7, 5, 0, 10, 21, 0, DateTimeKind.Unspecified), 5, 9 },
                    { 20, new DateTime(2019, 12, 24, 3, 19, 30, 0, DateTimeKind.Unspecified), 1, 10 },
                    { 21, new DateTime(2020, 6, 28, 20, 46, 56, 0, DateTimeKind.Unspecified), 1, 10 },
                    { 137, new DateTime(2021, 10, 26, 22, 35, 1, 0, DateTimeKind.Unspecified), 5, 9 },
                    { 22, new DateTime(2017, 6, 23, 15, 30, 44, 0, DateTimeKind.Unspecified), 1, 10 },
                    { 45, new DateTime(2020, 9, 29, 0, 38, 4, 0, DateTimeKind.Unspecified), 2, 10 },
                    { 46, new DateTime(2019, 2, 22, 17, 38, 25, 0, DateTimeKind.Unspecified), 2, 10 },
                    { 47, new DateTime(2019, 7, 24, 16, 10, 17, 0, DateTimeKind.Unspecified), 2, 10 },
                    { 48, new DateTime(2017, 4, 11, 22, 52, 39, 0, DateTimeKind.Unspecified), 2, 10 },
                    { 49, new DateTime(2020, 3, 4, 9, 5, 57, 0, DateTimeKind.Unspecified), 2, 10 },
                    { 79, new DateTime(2021, 8, 17, 23, 26, 2, 0, DateTimeKind.Unspecified), 3, 10 },
                    { 23, new DateTime(2020, 12, 1, 16, 8, 11, 0, DateTimeKind.Unspecified), 1, 10 },
                    { 78, new DateTime(2020, 5, 17, 13, 44, 45, 0, DateTimeKind.Unspecified), 3, 9 },
                    { 77, new DateTime(2020, 6, 15, 21, 42, 51, 0, DateTimeKind.Unspecified), 3, 9 },
                    { 76, new DateTime(2017, 7, 25, 7, 51, 25, 0, DateTimeKind.Unspecified), 3, 9 },
                    { 15, new DateTime(2018, 12, 30, 19, 19, 7, 0, DateTimeKind.Unspecified), 1, 8 },
                    { 16, new DateTime(2017, 4, 16, 10, 16, 1, 0, DateTimeKind.Unspecified), 1, 8 },
                    { 40, new DateTime(2021, 1, 6, 17, 53, 32, 0, DateTimeKind.Unspecified), 2, 8 },
                    { 41, new DateTime(2021, 8, 23, 5, 35, 26, 0, DateTimeKind.Unspecified), 2, 8 },
                    { 74, new DateTime(2019, 3, 10, 9, 24, 1, 0, DateTimeKind.Unspecified), 3, 8 },
                    { 75, new DateTime(2018, 3, 26, 11, 56, 37, 0, DateTimeKind.Unspecified), 3, 8 },
                    { 134, new DateTime(2020, 3, 16, 7, 41, 56, 0, DateTimeKind.Unspecified), 5, 8 },
                    { 135, new DateTime(2017, 7, 21, 6, 22, 2, 0, DateTimeKind.Unspecified), 5, 8 },
                    { 136, new DateTime(2020, 7, 19, 10, 34, 57, 0, DateTimeKind.Unspecified), 5, 8 },
                    { 17, new DateTime(2019, 3, 14, 17, 6, 16, 0, DateTimeKind.Unspecified), 1, 9 },
                    { 18, new DateTime(2017, 7, 5, 23, 13, 38, 0, DateTimeKind.Unspecified), 1, 9 },
                    { 19, new DateTime(2020, 6, 21, 14, 5, 0, 0, DateTimeKind.Unspecified), 1, 9 },
                    { 42, new DateTime(2018, 9, 28, 2, 7, 4, 0, DateTimeKind.Unspecified), 2, 9 },
                    { 43, new DateTime(2018, 10, 1, 7, 0, 26, 0, DateTimeKind.Unspecified), 2, 9 },
                    { 44, new DateTime(2020, 5, 8, 16, 36, 59, 0, DateTimeKind.Unspecified), 2, 9 },
                    { 80, new DateTime(2020, 12, 9, 13, 42, 16, 0, DateTimeKind.Unspecified), 3, 10 },
                    { 81, new DateTime(2021, 3, 21, 9, 29, 27, 0, DateTimeKind.Unspecified), 3, 10 },
                    { 106, new DateTime(2020, 12, 24, 19, 36, 40, 0, DateTimeKind.Unspecified), 4, 10 },
                    { 107, new DateTime(2020, 2, 23, 3, 31, 18, 0, DateTimeKind.Unspecified), 4, 10 },
                    { 110, new DateTime(2021, 8, 1, 0, 52, 45, 0, DateTimeKind.Unspecified), 4, 11 },
                    { 111, new DateTime(2017, 6, 20, 9, 40, 46, 0, DateTimeKind.Unspecified), 4, 11 },
                    { 112, new DateTime(2020, 12, 21, 11, 51, 41, 0, DateTimeKind.Unspecified), 4, 11 },
                    { 145, new DateTime(2018, 3, 15, 4, 34, 33, 0, DateTimeKind.Unspecified), 5, 11 }
                });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "DateTimeVisit", "SectionId", "UserId" },
                values: new object[,]
                {
                    { 146, new DateTime(2018, 10, 8, 9, 48, 13, 0, DateTimeKind.Unspecified), 5, 11 },
                    { 147, new DateTime(2018, 11, 5, 4, 32, 48, 0, DateTimeKind.Unspecified), 5, 11 },
                    { 29, new DateTime(2020, 3, 7, 13, 24, 37, 0, DateTimeKind.Unspecified), 1, 12 },
                    { 30, new DateTime(2020, 4, 12, 22, 15, 46, 0, DateTimeKind.Unspecified), 1, 12 },
                    { 31, new DateTime(2019, 1, 23, 22, 24, 46, 0, DateTimeKind.Unspecified), 1, 12 },
                    { 53, new DateTime(2017, 7, 19, 5, 40, 54, 0, DateTimeKind.Unspecified), 2, 12 },
                    { 54, new DateTime(2020, 4, 2, 0, 31, 4, 0, DateTimeKind.Unspecified), 2, 12 },
                    { 88, new DateTime(2017, 7, 10, 18, 47, 26, 0, DateTimeKind.Unspecified), 3, 12 },
                    { 113, new DateTime(2018, 1, 27, 16, 15, 21, 0, DateTimeKind.Unspecified), 4, 12 },
                    { 114, new DateTime(2018, 12, 7, 7, 50, 3, 0, DateTimeKind.Unspecified), 4, 12 },
                    { 115, new DateTime(2019, 5, 4, 15, 5, 17, 0, DateTimeKind.Unspecified), 4, 12 },
                    { 109, new DateTime(2017, 11, 30, 2, 47, 0, 0, DateTimeKind.Unspecified), 4, 11 },
                    { 133, new DateTime(2017, 12, 9, 6, 13, 27, 0, DateTimeKind.Unspecified), 5, 7 },
                    { 87, new DateTime(2020, 3, 6, 18, 12, 28, 0, DateTimeKind.Unspecified), 3, 11 },
                    { 85, new DateTime(2018, 2, 16, 12, 5, 24, 0, DateTimeKind.Unspecified), 3, 11 },
                    { 108, new DateTime(2018, 2, 2, 9, 28, 26, 0, DateTimeKind.Unspecified), 4, 10 },
                    { 142, new DateTime(2017, 11, 27, 22, 56, 35, 0, DateTimeKind.Unspecified), 5, 10 },
                    { 143, new DateTime(2020, 7, 3, 5, 12, 59, 0, DateTimeKind.Unspecified), 5, 10 },
                    { 144, new DateTime(2019, 4, 28, 18, 7, 24, 0, DateTimeKind.Unspecified), 5, 10 },
                    { 24, new DateTime(2021, 6, 21, 11, 52, 33, 0, DateTimeKind.Unspecified), 1, 11 },
                    { 25, new DateTime(2019, 4, 9, 18, 8, 7, 0, DateTimeKind.Unspecified), 1, 11 },
                    { 26, new DateTime(2020, 12, 21, 11, 28, 11, 0, DateTimeKind.Unspecified), 1, 11 },
                    { 27, new DateTime(2020, 9, 9, 8, 49, 2, 0, DateTimeKind.Unspecified), 1, 11 },
                    { 28, new DateTime(2017, 8, 4, 10, 3, 42, 0, DateTimeKind.Unspecified), 1, 11 },
                    { 50, new DateTime(2018, 2, 19, 9, 54, 2, 0, DateTimeKind.Unspecified), 2, 11 },
                    { 51, new DateTime(2017, 12, 19, 23, 22, 55, 0, DateTimeKind.Unspecified), 2, 11 },
                    { 52, new DateTime(2018, 12, 10, 20, 7, 12, 0, DateTimeKind.Unspecified), 2, 11 },
                    { 82, new DateTime(2018, 3, 22, 23, 9, 56, 0, DateTimeKind.Unspecified), 3, 11 },
                    { 83, new DateTime(2017, 3, 24, 14, 10, 19, 0, DateTimeKind.Unspecified), 3, 11 },
                    { 84, new DateTime(2017, 11, 10, 17, 42, 8, 0, DateTimeKind.Unspecified), 3, 11 },
                    { 86, new DateTime(2021, 11, 6, 14, 29, 6, 0, DateTimeKind.Unspecified), 3, 11 },
                    { 148, new DateTime(2017, 10, 7, 0, 34, 18, 0, DateTimeKind.Unspecified), 5, 12 },
                    { 132, new DateTime(2018, 4, 18, 2, 12, 55, 0, DateTimeKind.Unspecified), 5, 7 },
                    { 130, new DateTime(2020, 3, 18, 2, 28, 40, 0, DateTimeKind.Unspecified), 5, 7 },
                    { 92, new DateTime(2021, 2, 7, 7, 35, 36, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 120, new DateTime(2017, 12, 18, 7, 48, 9, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 121, new DateTime(2019, 11, 16, 3, 53, 3, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 63, new DateTime(2019, 9, 18, 16, 11, 24, 0, DateTimeKind.Unspecified), 3, 4 },
                    { 64, new DateTime(2020, 8, 3, 11, 29, 30, 0, DateTimeKind.Unspecified), 3, 4 },
                    { 65, new DateTime(2017, 1, 30, 8, 5, 42, 0, DateTimeKind.Unspecified), 3, 4 },
                    { 62, new DateTime(2019, 8, 15, 21, 7, 29, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 66, new DateTime(2019, 4, 28, 8, 54, 58, 0, DateTimeKind.Unspecified), 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "DateTimeVisit", "SectionId", "UserId" },
                values: new object[,]
                {
                    { 94, new DateTime(2019, 9, 12, 9, 27, 7, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 95, new DateTime(2021, 8, 18, 18, 28, 47, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 96, new DateTime(2018, 10, 1, 21, 40, 30, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 122, new DateTime(2019, 12, 20, 5, 42, 17, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 3, new DateTime(2019, 7, 17, 1, 9, 50, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 4, new DateTime(2017, 7, 8, 12, 16, 20, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 93, new DateTime(2019, 12, 21, 18, 12, 48, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 61, new DateTime(2020, 4, 12, 12, 36, 17, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 60, new DateTime(2019, 10, 1, 10, 22, 10, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 119, new DateTime(2017, 4, 9, 12, 36, 39, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 55, new DateTime(2018, 5, 2, 18, 31, 37, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 56, new DateTime(2017, 2, 11, 18, 10, 4, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 2, new DateTime(2019, 8, 21, 15, 19, 30, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 32, new DateTime(2021, 12, 1, 10, 41, 49, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 33, new DateTime(2017, 1, 18, 5, 7, 58, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 34, new DateTime(2018, 8, 14, 10, 7, 39, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 57, new DateTime(2020, 7, 14, 11, 23, 52, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 58, new DateTime(2019, 11, 19, 3, 29, 50, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 59, new DateTime(2018, 1, 23, 8, 20, 46, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 89, new DateTime(2020, 2, 5, 5, 48, 35, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 90, new DateTime(2020, 11, 11, 1, 3, 46, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 91, new DateTime(2018, 11, 5, 7, 27, 21, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 116, new DateTime(2018, 11, 14, 2, 39, 54, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 117, new DateTime(2017, 3, 15, 20, 9, 44, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 118, new DateTime(2018, 8, 1, 12, 42, 49, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 5, new DateTime(2019, 12, 28, 9, 38, 48, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 6, new DateTime(2020, 2, 27, 8, 13, 46, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 7, new DateTime(2021, 5, 26, 18, 58, 39, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 8, new DateTime(2018, 1, 1, 17, 24, 27, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 71, new DateTime(2018, 11, 7, 1, 37, 42, 0, DateTimeKind.Unspecified), 3, 6 },
                    { 101, new DateTime(2019, 4, 12, 21, 32, 47, 0, DateTimeKind.Unspecified), 4, 6 },
                    { 102, new DateTime(2021, 7, 27, 12, 7, 2, 0, DateTimeKind.Unspecified), 4, 6 },
                    { 103, new DateTime(2021, 3, 20, 14, 46, 29, 0, DateTimeKind.Unspecified), 4, 6 },
                    { 128, new DateTime(2020, 10, 21, 10, 33, 53, 0, DateTimeKind.Unspecified), 5, 6 },
                    { 129, new DateTime(2018, 5, 16, 5, 8, 47, 0, DateTimeKind.Unspecified), 5, 6 },
                    { 13, new DateTime(2021, 9, 10, 14, 10, 54, 0, DateTimeKind.Unspecified), 1, 7 },
                    { 14, new DateTime(2018, 4, 21, 14, 7, 28, 0, DateTimeKind.Unspecified), 1, 7 },
                    { 37, new DateTime(2019, 3, 3, 21, 52, 53, 0, DateTimeKind.Unspecified), 2, 7 },
                    { 38, new DateTime(2017, 3, 19, 13, 20, 1, 0, DateTimeKind.Unspecified), 2, 7 },
                    { 39, new DateTime(2018, 9, 19, 6, 37, 44, 0, DateTimeKind.Unspecified), 2, 7 },
                    { 72, new DateTime(2017, 10, 19, 17, 58, 49, 0, DateTimeKind.Unspecified), 3, 7 },
                    { 73, new DateTime(2019, 8, 10, 6, 48, 27, 0, DateTimeKind.Unspecified), 3, 7 }
                });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "DateTimeVisit", "SectionId", "UserId" },
                values: new object[,]
                {
                    { 104, new DateTime(2020, 11, 29, 19, 24, 30, 0, DateTimeKind.Unspecified), 4, 7 },
                    { 105, new DateTime(2020, 1, 7, 21, 30, 53, 0, DateTimeKind.Unspecified), 4, 7 },
                    { 70, new DateTime(2021, 3, 29, 3, 53, 0, 0, DateTimeKind.Unspecified), 3, 6 },
                    { 131, new DateTime(2018, 7, 14, 21, 55, 46, 0, DateTimeKind.Unspecified), 5, 7 },
                    { 69, new DateTime(2021, 12, 15, 22, 18, 43, 0, DateTimeKind.Unspecified), 3, 6 },
                    { 11, new DateTime(2020, 6, 5, 5, 23, 14, 0, DateTimeKind.Unspecified), 1, 6 },
                    { 9, new DateTime(2020, 2, 21, 21, 33, 43, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 35, new DateTime(2017, 3, 31, 5, 1, 18, 0, DateTimeKind.Unspecified), 2, 5 },
                    { 36, new DateTime(2018, 7, 25, 5, 38, 40, 0, DateTimeKind.Unspecified), 2, 5 },
                    { 67, new DateTime(2021, 9, 5, 10, 18, 11, 0, DateTimeKind.Unspecified), 3, 5 },
                    { 68, new DateTime(2018, 11, 20, 17, 15, 48, 0, DateTimeKind.Unspecified), 3, 5 },
                    { 97, new DateTime(2019, 11, 4, 23, 7, 13, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 98, new DateTime(2017, 12, 22, 8, 42, 29, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 99, new DateTime(2018, 3, 2, 20, 43, 50, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 100, new DateTime(2021, 3, 25, 5, 56, 39, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 123, new DateTime(2018, 8, 9, 1, 39, 46, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 124, new DateTime(2021, 11, 27, 10, 28, 30, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 125, new DateTime(2018, 2, 16, 9, 37, 12, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 126, new DateTime(2017, 8, 24, 7, 14, 39, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 127, new DateTime(2018, 9, 22, 11, 58, 34, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 10, new DateTime(2021, 4, 28, 17, 18, 54, 0, DateTimeKind.Unspecified), 1, 6 },
                    { 12, new DateTime(2017, 12, 30, 1, 12, 35, 0, DateTimeKind.Unspecified), 1, 6 },
                    { 149, new DateTime(2021, 2, 2, 7, 34, 23, 0, DateTimeKind.Unspecified), 5, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visits_SectionId",
                table: "Visits",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_UserId",
                table: "Visits",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
