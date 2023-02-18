using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Salary34000.Migrations
{
    /// <inheritdoc />
    public partial class FirstForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EmploymentDate",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EmploymentTypeId",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EmploymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EmploymentTypes",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "رسمی" },
                    { 2, "قرارداد پاره‌وقت" },
                    { 3, "قرارداد تمام‌وقت" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_EmploymentTypeId",
                table: "Persons",
                column: "EmploymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_EmploymentTypes_EmploymentTypeId",
                table: "Persons",
                column: "EmploymentTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_EmploymentTypes_EmploymentTypeId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "EmploymentTypes");

            migrationBuilder.DropIndex(
                name: "IX_Persons_EmploymentTypeId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "EmploymentDate",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "EmploymentTypeId",
                table: "Persons");
        }
    }
}
