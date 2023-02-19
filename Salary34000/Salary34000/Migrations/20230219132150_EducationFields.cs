using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Salary34000.Migrations
{
    /// <inheritdoc />
    public partial class EducationFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "EducationAverage",
                table: "Persons",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "EducationField",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EducationPlace",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Description", "Score" },
                values: new object[,]
                {
                    { 1, "زیر دیپلم", 2 },
                    { 2, "دیپلم", 4 },
                    { 3, "فوق دیپلم", 6 },
                    { 4, "کارشناسی", 8 },
                    { 5, "کارشناسی ارشد", 10 },
                    { 6, "دکتری", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_EducationId",
                table: "Persons",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Educations_EducationId",
                table: "Persons",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Educations_EducationId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Persons_EducationId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "EducationAverage",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "EducationField",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "EducationPlace",
                table: "Persons");
        }
    }
}
