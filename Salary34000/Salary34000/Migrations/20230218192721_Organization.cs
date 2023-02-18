using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Salary34000.Migrations
{
    /// <inheritdoc />
    public partial class Organization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrganizationPost",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationUnitId",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OrganizationUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationUnits", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OrganizationUnits",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "مدیریت پشتیبانی و خدمات" },
                    { 2, "حوزه مدیر عامل" },
                    { 3, "مدیریت حراست" },
                    { 4, "مدیریت تدارکات" },
                    { 5, "گروه فناوین" },
                    { 6, "گروه پایش" },
                    { 7, "گروه جم" },
                    { 8, "گروه ارگ" },
                    { 9, "گروه حافظ" },
                    { 10, "مدیریت منابع انسانی " },
                    { 11, "مدیریت مالی" },
                    { 12, "گروه بصیر" },
                    { 13, "مدیریت بازرگانی" },
                    { 14, "گروه آفاق" },
                    { 15, "مدیریت برنامه ریزی و نظارت" },
                    { 16, "گروه فناوری و شتابدهی برنا" },
                    { 17, "شیخ بهایی" },
                    { 18, "گروه پویش" },
                    { 19, "گروه ماهان" },
                    { 20, "مدیریت فاوا" },
                    { 21, "مدیریت تدارکات" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_OrganizationUnitId",
                table: "Persons",
                column: "OrganizationUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_OrganizationUnits_OrganizationUnitId",
                table: "Persons",
                column: "OrganizationUnitId",
                principalTable: "OrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_OrganizationUnits_OrganizationUnitId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "OrganizationUnits");

            migrationBuilder.DropIndex(
                name: "IX_Persons_OrganizationUnitId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "OrganizationPost",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "OrganizationUnitId",
                table: "Persons");
        }
    }
}
