using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Salary34000.Migrations
{
    /// <inheritdoc />
    public partial class MaliFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationRelationStatusId",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EmploymentEndDate",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "JobGroupId",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobScore",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaritalStatus",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "MarriageDate",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MilitaryServiceId",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OccupationId",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "OldBaseSummery",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "OldHokmSummery",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "ProfessionalPathId",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "SuperCollectable",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "EducationRelationStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Coefficient = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationRelationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MilitaryServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Coefficient = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalPaths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Amount = table.Column<long>(type: "INTEGER", nullable: false),
                    Coefficient = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalPaths", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EducationRelationStatuses",
                columns: new[] { "Id", "Coefficient", "Description" },
                values: new object[,]
                {
                    { 1, 1.0, "مرتبط" },
                    { 2, 0.84999999999999998, "نیمه مرتبط" },
                    { 3, 0.69999999999999996, "غیر مرتبط" }
                });

            migrationBuilder.InsertData(
                table: "JobGroups",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "1" },
                    { 2, "2" },
                    { 3, "3" },
                    { 4, "4" },
                    { 5, "5" },
                    { 6, "6" },
                    { 7, "7" },
                    { 8, "8" },
                    { 9, "9" },
                    { 10, "10" },
                    { 11, "11" },
                    { 12, "12" },
                    { 13, "13" },
                    { 14, "14" },
                    { 15, "15" },
                    { 16, "16" },
                    { 17, "17" },
                    { 18, "18" },
                    { 19, "19" },
                    { 20, "20" },
                    { 21, "A" },
                    { 22, "B" },
                    { 23, "C" },
                    { 24, "D" },
                    { 25, "E" }
                });

            migrationBuilder.InsertData(
                table: "MilitaryServices",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "پروژه نخبه وظیفه" },
                    { 2, "در حال انجام" },
                    { 3, "کارت پایان خدمت" },
                    { 4, "کارت معافیت " },
                    { 5, "معافیت پزشکی" },
                    { 6, "معافیت تحصیلی" },
                    { 7, "معافیت دائم" },
                    { 8, "معافیت زیر پرچم" },
                    { 9, "معافیت کفالت" },
                    { 10, "معافیت موارد خاص" }
                });

            migrationBuilder.InsertData(
                table: "Occupations",
                columns: new[] { "Id", "Coefficient", "Description" },
                values: new object[,]
                {
                    { 1, 2.7999999999999998, "صف تخصصی - فنی" },
                    { 2, 2.0, "صف تخصصی - فنی 1" },
                    { 3, 1.5, "صف تخصصی - فنی 2" },
                    { 4, 1.2, "صف تخصصی - فنی 3" },
                    { 5, 2.5, "صف تخصصی - پشتیبانی" },
                    { 6, 1.7, "صف تخصصی - پشتیبانی 1" },
                    { 7, 1.25, "صف تخصصی - پشتیبانی 2" },
                    { 8, 1.2, "صف تخصصی - پشتیبانی 3" },
                    { 9, 1.1000000000000001, "ستاد تخصصی" },
                    { 10, 1.05, "ستاد پشتیبانی" },
                    { 11, 1.0, "ستاد خدماتی" }
                });

            migrationBuilder.InsertData(
                table: "ProfessionalPaths",
                columns: new[] { "Id", "Amount", "Coefficient", "Description" },
                values: new object[,]
                {
                    { 1, 33218504L, 1.0, "مدیریتی" },
                    { 2, 16609252L, 0.5, "کارشناسی" },
                    { 3, 11072835L, 0.33000000000000002, "کاردانی" },
                    { 4, 8304626L, 0.25, "کارمندی" },
                    { 5, 6643701L, 0.20000000000000001, "کارگری" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_EducationRelationStatusId",
                table: "Persons",
                column: "EducationRelationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_JobGroupId",
                table: "Persons",
                column: "JobGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MilitaryServiceId",
                table: "Persons",
                column: "MilitaryServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_OccupationId",
                table: "Persons",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ProfessionalPathId",
                table: "Persons",
                column: "ProfessionalPathId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_EducationRelationStatuses_EducationRelationStatusId",
                table: "Persons",
                column: "EducationRelationStatusId",
                principalTable: "EducationRelationStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_JobGroups_JobGroupId",
                table: "Persons",
                column: "JobGroupId",
                principalTable: "JobGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_MilitaryServices_MilitaryServiceId",
                table: "Persons",
                column: "MilitaryServiceId",
                principalTable: "MilitaryServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Occupations_OccupationId",
                table: "Persons",
                column: "OccupationId",
                principalTable: "Occupations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_ProfessionalPaths_ProfessionalPathId",
                table: "Persons",
                column: "ProfessionalPathId",
                principalTable: "ProfessionalPaths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_EducationRelationStatuses_EducationRelationStatusId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_JobGroups_JobGroupId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_MilitaryServices_MilitaryServiceId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Occupations_OccupationId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_ProfessionalPaths_ProfessionalPathId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "EducationRelationStatuses");

            migrationBuilder.DropTable(
                name: "JobGroups");

            migrationBuilder.DropTable(
                name: "MilitaryServices");

            migrationBuilder.DropTable(
                name: "Occupations");

            migrationBuilder.DropTable(
                name: "ProfessionalPaths");

            migrationBuilder.DropIndex(
                name: "IX_Persons_EducationRelationStatusId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_JobGroupId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MilitaryServiceId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_OccupationId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ProfessionalPathId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "EducationRelationStatusId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "EmploymentEndDate",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "JobGroupId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "JobScore",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MarriageDate",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MilitaryServiceId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "OccupationId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "OldBaseSummery",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "OldHokmSummery",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ProfessionalPathId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SuperCollectable",
                table: "Persons");
        }
    }
}
