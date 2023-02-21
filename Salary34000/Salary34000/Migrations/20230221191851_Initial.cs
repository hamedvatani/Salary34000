using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Salary34000.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "JobGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProportionIncrease = table.Column<double>(type: "REAL", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Key = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<long>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "ExperienceScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WorkExperience = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfessionalPathId = table.Column<int>(type: "INTEGER", nullable: false),
                    Score = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperienceScores_ProfessionalPaths_ProfessionalPathId",
                        column: x => x.ProfessionalPathId,
                        principalTable: "ProfessionalPaths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Grade = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfessionalPathId = table.Column<int>(type: "INTEGER", nullable: false),
                    Score = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalGroups_ProfessionalPaths_ProfessionalPathId",
                        column: x => x.ProfessionalPathId,
                        principalTable: "ProfessionalPaths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonelCode = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    NationalCode = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentNumber = table.Column<string>(type: "TEXT", nullable: false),
                    DocumentSerial = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    ChildrenCount = table.Column<int>(type: "INTEGER", nullable: false),
                    DocumentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DocumentCity = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BirthCity = table.Column<string>(type: "TEXT", nullable: false),
                    EmploymentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmploymentTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrganizationUnitId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrganizationPost = table.Column<string>(type: "TEXT", nullable: false),
                    ConsolidatedInsurance = table.Column<double>(type: "REAL", nullable: false),
                    EducationId = table.Column<int>(type: "INTEGER", nullable: false),
                    EducationField = table.Column<string>(type: "TEXT", nullable: false),
                    EducationPlace = table.Column<string>(type: "TEXT", nullable: false),
                    EducationAverage = table.Column<double>(type: "REAL", nullable: false),
                    MilitaryServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    MaritalStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    MarriageDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SuperCollectable = table.Column<long>(type: "INTEGER", nullable: false),
                    EmploymentEndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OldBaseSummery = table.Column<long>(type: "INTEGER", nullable: false),
                    OldHokmSummery = table.Column<long>(type: "INTEGER", nullable: false),
                    JobScore = table.Column<int>(type: "INTEGER", nullable: false),
                    JobGroupId = table.Column<int>(type: "INTEGER", nullable: false),
                    OccupationId = table.Column<int>(type: "INTEGER", nullable: false),
                    EducationRelationStatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfessionalPathId = table.Column<int>(type: "INTEGER", nullable: false),
                    PerformanceId = table.Column<int>(type: "INTEGER", nullable: false),
                    SpecialActivities = table.Column<int>(type: "INTEGER", nullable: false),
                    DevelopmentPlan = table.Column<int>(type: "INTEGER", nullable: false),
                    RoleExtra = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseInsurance = table.Column<string>(type: "TEXT", nullable: false),
                    InsuranceNumber = table.Column<string>(type: "TEXT", nullable: false),
                    BankName = table.Column<string>(type: "TEXT", nullable: false),
                    AccountNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Mobile = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_EducationRelationStatuses_EducationRelationStatusId",
                        column: x => x.EducationRelationStatusId,
                        principalTable: "EducationRelationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_EmploymentTypes_EmploymentTypeId",
                        column: x => x.EmploymentTypeId,
                        principalTable: "EmploymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_JobGroups_JobGroupId",
                        column: x => x.JobGroupId,
                        principalTable: "JobGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_MilitaryServices_MilitaryServiceId",
                        column: x => x.MilitaryServiceId,
                        principalTable: "MilitaryServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_Occupations_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_OrganizationUnits_OrganizationUnitId",
                        column: x => x.OrganizationUnitId,
                        principalTable: "OrganizationUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_Performances_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Performances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persons_ProfessionalPaths_ProfessionalPathId",
                        column: x => x.ProfessionalPathId,
                        principalTable: "ProfessionalPaths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "EmploymentTypes",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "رسمی" },
                    { 2, "قرارداد پاره‌وقت" },
                    { 3, "قرارداد تمام‌وقت" }
                });

            migrationBuilder.InsertData(
                table: "JobGroups",
                columns: new[] { "Id", "Description", "ProportionIncrease" },
                values: new object[,]
                {
                    { 1, "1", 1.0 },
                    { 2, "2", 1.02 },
                    { 3, "3", 1.02 },
                    { 4, "4", 1.02 },
                    { 5, "5", 1.02 },
                    { 6, "6", 1.02 },
                    { 7, "7", 1.02 },
                    { 8, "8", 1.02 },
                    { 9, "9", 1.02 },
                    { 10, "10", 1.02 },
                    { 11, "11", 1.05 },
                    { 12, "12", 1.05 },
                    { 13, "13", 1.05 },
                    { 14, "14", 1.05 },
                    { 15, "15", 1.05 },
                    { 16, "16", 1.06 },
                    { 17, "17", 1.06 },
                    { 18, "18", 1.06 },
                    { 19, "19", 1.06 },
                    { 20, "20", 1.06 },
                    { 21, "A", 1.07 },
                    { 22, "B", 1.07 },
                    { 23, "C", 1.07 },
                    { 24, "D", 1.07 },
                    { 25, "E", 1.07 }
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

            migrationBuilder.InsertData(
                table: "Parameters",
                columns: new[] { "Id", "Description", "Key", "Value", "Year" },
                values: new object[,]
                {
                    { 1, "پایه حقوق وزارت کار", "BaseSalary", 33218504L, 1401 },
                    { 2, "حق اولاد", "Children", 4179750L, 1401 },
                    { 3, "حق مسکن", "Housing", 6500000L, 1401 },
                    { 4, "بن خواروبار", "Grocery", 8500000L, 1401 },
                    { 5, "ایاب و ذهاب", "Transportation", 3000000L, 1401 },
                    { 6, "پایه سنوات", "BaseYears", 2100000L, 1401 },
                    { 7, "مزد ثابت کلیه سطوح", "ConstantSalary", 5151660L, 1401 }
                });

            migrationBuilder.InsertData(
                table: "Performances",
                columns: new[] { "Id", "Description", "Score" },
                values: new object[,]
                {
                    { 1, "عالی", 40 },
                    { 2, "فراتر از انتظار", 32 },
                    { 3, "در حد انتظار", 24 },
                    { 4, "پایین تر از حد انتظار", 16 },
                    { 5, "ضعیف", 8 }
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

            migrationBuilder.InsertData(
                table: "ExperienceScores",
                columns: new[] { "Id", "ProfessionalPathId", "Score", "WorkExperience" },
                values: new object[,]
                {
                    { 1, 1, 25.0, 0 },
                    { 2, 1, 25.0, 1 },
                    { 3, 1, 25.17241379, 2 },
                    { 4, 1, 25.344827590000001, 3 },
                    { 5, 1, 25.517241380000002, 4 },
                    { 6, 1, 25.689655170000002, 5 },
                    { 7, 1, 25.862068969999999, 6 },
                    { 8, 1, 26.03448276, 7 },
                    { 9, 1, 26.20689655, 8 },
                    { 10, 1, 26.37931034, 9 },
                    { 11, 1, 26.551724140000001, 10 },
                    { 12, 1, 26.724137930000001, 11 },
                    { 13, 1, 26.896551720000001, 12 },
                    { 14, 1, 27.068965519999999, 13 },
                    { 15, 1, 27.241379309999999, 14 },
                    { 16, 1, 27.413793099999999, 15 },
                    { 17, 1, 27.586206900000001, 16 },
                    { 18, 1, 27.758620690000001, 17 },
                    { 19, 1, 27.931034480000001, 18 },
                    { 20, 1, 28.103448279999999, 19 },
                    { 21, 1, 28.275862069999999, 20 },
                    { 22, 1, 28.448275859999999, 21 },
                    { 23, 1, 28.62068966, 22 },
                    { 24, 1, 28.79310345, 23 },
                    { 25, 1, 28.96551724, 24 },
                    { 26, 1, 29.137931030000001, 25 },
                    { 27, 1, 29.310344829999998, 26 },
                    { 28, 1, 29.482758619999998, 27 },
                    { 29, 1, 29.655172409999999, 28 },
                    { 30, 1, 29.82758621, 29 },
                    { 31, 1, 30.0, 30 },
                    { 32, 2, 20.0, 0 },
                    { 33, 2, 20.0, 1 },
                    { 34, 2, 20.17241379, 2 },
                    { 35, 2, 20.344827590000001, 3 },
                    { 36, 2, 20.517241380000002, 4 },
                    { 37, 2, 20.689655170000002, 5 },
                    { 38, 2, 20.862068969999999, 6 },
                    { 39, 2, 21.03448276, 7 },
                    { 40, 2, 21.20689655, 8 },
                    { 41, 2, 21.37931034, 9 },
                    { 42, 2, 21.551724140000001, 10 },
                    { 43, 2, 21.724137930000001, 11 },
                    { 44, 2, 21.896551720000001, 12 },
                    { 45, 2, 22.068965519999999, 13 },
                    { 46, 2, 22.241379309999999, 14 },
                    { 47, 2, 22.413793099999999, 15 },
                    { 48, 2, 22.586206900000001, 16 },
                    { 49, 2, 22.758620690000001, 17 },
                    { 50, 2, 22.931034480000001, 18 },
                    { 51, 2, 23.103448279999999, 19 },
                    { 52, 2, 23.275862069999999, 20 },
                    { 53, 2, 23.448275859999999, 21 },
                    { 54, 2, 23.62068966, 22 },
                    { 55, 2, 23.79310345, 23 },
                    { 56, 2, 23.96551724, 24 },
                    { 57, 2, 24.137931030000001, 25 },
                    { 58, 2, 24.310344829999998, 26 },
                    { 59, 2, 24.482758619999998, 27 },
                    { 60, 2, 24.655172409999999, 28 },
                    { 61, 2, 24.82758621, 29 },
                    { 62, 2, 25.0, 30 },
                    { 63, 3, 15.0, 0 },
                    { 64, 3, 15.0, 1 },
                    { 65, 3, 15.17241379, 2 },
                    { 66, 3, 15.34482759, 3 },
                    { 67, 3, 15.51724138, 4 },
                    { 68, 3, 15.68965517, 5 },
                    { 69, 3, 15.862068969999999, 6 },
                    { 70, 3, 16.03448276, 7 },
                    { 71, 3, 16.20689655, 8 },
                    { 72, 3, 16.37931034, 9 },
                    { 73, 3, 16.551724140000001, 10 },
                    { 74, 3, 16.724137930000001, 11 },
                    { 75, 3, 16.896551720000001, 12 },
                    { 76, 3, 17.068965519999999, 13 },
                    { 77, 3, 17.241379309999999, 14 },
                    { 78, 3, 17.413793099999999, 15 },
                    { 79, 3, 17.586206900000001, 16 },
                    { 80, 3, 17.758620690000001, 17 },
                    { 81, 3, 17.931034480000001, 18 },
                    { 82, 3, 18.103448279999999, 19 },
                    { 83, 3, 18.275862069999999, 20 },
                    { 84, 3, 18.448275859999999, 21 },
                    { 85, 3, 18.62068966, 22 },
                    { 86, 3, 18.79310345, 23 },
                    { 87, 3, 18.96551724, 24 },
                    { 88, 3, 19.137931030000001, 25 },
                    { 89, 3, 19.310344829999998, 26 },
                    { 90, 3, 19.482758619999998, 27 },
                    { 91, 3, 19.655172409999999, 28 },
                    { 92, 3, 19.82758621, 29 },
                    { 93, 3, 20.0, 30 },
                    { 94, 4, 10.0, 0 },
                    { 95, 4, 10.0, 1 },
                    { 96, 4, 10.17241379, 2 },
                    { 97, 4, 10.34482759, 3 },
                    { 98, 4, 10.51724138, 4 },
                    { 99, 4, 10.68965517, 5 },
                    { 100, 4, 10.862068969999999, 6 },
                    { 101, 4, 11.03448276, 7 },
                    { 102, 4, 11.20689655, 8 },
                    { 103, 4, 11.37931034, 9 },
                    { 104, 4, 11.551724139999999, 10 },
                    { 105, 4, 11.724137929999999, 11 },
                    { 106, 4, 11.89655172, 12 },
                    { 107, 4, 12.068965520000001, 13 },
                    { 108, 4, 12.241379309999999, 14 },
                    { 109, 4, 12.413793099999999, 15 },
                    { 110, 4, 12.586206900000001, 16 },
                    { 111, 4, 12.758620690000001, 17 },
                    { 112, 4, 12.931034479999999, 18 },
                    { 113, 4, 13.10344828, 19 },
                    { 114, 4, 13.275862070000001, 20 },
                    { 115, 4, 13.448275860000001, 21 },
                    { 116, 4, 13.62068966, 22 },
                    { 117, 4, 13.79310345, 23 },
                    { 118, 4, 13.96551724, 24 },
                    { 119, 4, 14.137931030000001, 25 },
                    { 120, 4, 14.31034483, 26 },
                    { 121, 4, 14.48275862, 27 },
                    { 122, 4, 14.65517241, 28 },
                    { 123, 4, 14.82758621, 29 },
                    { 124, 4, 15.0, 30 },
                    { 125, 5, 5.0, 0 },
                    { 126, 5, 5.0, 1 },
                    { 127, 5, 5.1724137929999996, 2 },
                    { 128, 5, 5.3448275860000001, 3 },
                    { 129, 5, 5.5172413789999997, 4 },
                    { 130, 5, 5.6896551720000001, 5 },
                    { 131, 5, 5.8620689659999998, 6 },
                    { 132, 5, 6.0344827590000003, 7 },
                    { 133, 5, 6.2068965519999999, 8 },
                    { 134, 5, 6.3793103450000004, 9 },
                    { 135, 5, 6.551724138, 10 },
                    { 136, 5, 6.7241379309999996, 11 },
                    { 137, 5, 6.896551724, 12 },
                    { 138, 5, 7.0689655169999996, 13 },
                    { 139, 5, 7.2413793100000001, 14 },
                    { 140, 5, 7.4137931029999997, 15 },
                    { 141, 5, 7.5862068970000003, 16 },
                    { 142, 5, 7.7586206899999999, 17 },
                    { 143, 5, 7.9310344830000004, 18 },
                    { 144, 5, 8.103448276, 19 },
                    { 145, 5, 8.2758620690000004, 20 },
                    { 146, 5, 8.4482758619999991, 21 },
                    { 147, 5, 8.6206896549999996, 22 },
                    { 148, 5, 8.7931034480000001, 23 },
                    { 149, 5, 8.9655172410000006, 24 },
                    { 150, 5, 9.1379310339999993, 25 },
                    { 151, 5, 9.3103448279999999, 26 },
                    { 152, 5, 9.4827586210000003, 27 },
                    { 153, 5, 9.6551724140000008, 28 },
                    { 154, 5, 9.8275862069999995, 29 },
                    { 155, 5, 10.0, 30 }
                });

            migrationBuilder.InsertData(
                table: "PersonalGroups",
                columns: new[] { "Id", "Grade", "ProfessionalPathId", "Score" },
                values: new object[,]
                {
                    { 1, 30, 1, "A" },
                    { 2, 35, 1, "A+" },
                    { 3, 40, 1, "A++" },
                    { 4, 45, 1, "B" },
                    { 5, 50, 1, "B+" },
                    { 6, 55, 1, "B++" },
                    { 7, 60, 1, "C" },
                    { 8, 65, 1, "C+" },
                    { 9, 70, 1, "C++" },
                    { 10, 75, 1, "D" },
                    { 11, 80, 1, "D+" },
                    { 12, 85, 1, "D++" },
                    { 13, 90, 1, "E" },
                    { 14, 95, 1, "E+" },
                    { 15, 100, 1, "E++" },
                    { 16, 30, 2, "16" },
                    { 17, 35, 2, "16+" },
                    { 18, 40, 2, "16++" },
                    { 19, 45, 2, "17" },
                    { 20, 50, 2, "17+" },
                    { 21, 55, 2, "17++" },
                    { 22, 60, 2, "18" },
                    { 23, 65, 2, "18+" },
                    { 24, 70, 2, "18++" },
                    { 25, 75, 2, "19" },
                    { 26, 80, 2, "19+" },
                    { 27, 85, 2, "19++" },
                    { 28, 90, 2, "20" },
                    { 29, 95, 2, "20+" },
                    { 30, 100, 2, "20++" },
                    { 31, 30, 3, "11" },
                    { 32, 35, 3, "11+" },
                    { 33, 40, 3, "11++" },
                    { 34, 45, 3, "12" },
                    { 35, 50, 3, "12+" },
                    { 36, 55, 3, "12++" },
                    { 37, 60, 3, "13" },
                    { 38, 65, 3, "13+" },
                    { 39, 70, 3, "13++" },
                    { 40, 75, 3, "14" },
                    { 41, 80, 3, "14+" },
                    { 42, 85, 3, "14++" },
                    { 43, 90, 3, "15" },
                    { 44, 95, 3, "15+" },
                    { 45, 100, 3, "15++" },
                    { 46, 30, 4, "6" },
                    { 47, 35, 4, "6+" },
                    { 48, 40, 4, "6++" },
                    { 49, 45, 4, "7" },
                    { 50, 50, 4, "7+" },
                    { 51, 55, 4, "7++" },
                    { 52, 60, 4, "8" },
                    { 53, 65, 4, "8+" },
                    { 54, 70, 4, "8++" },
                    { 55, 75, 4, "9" },
                    { 56, 80, 4, "9+" },
                    { 57, 85, 4, "9++" },
                    { 58, 90, 4, "10" },
                    { 59, 95, 4, "10+" },
                    { 60, 100, 4, "10++" },
                    { 61, 30, 5, "1" },
                    { 62, 35, 5, "1+" },
                    { 63, 40, 5, "1++" },
                    { 64, 45, 5, "2" },
                    { 65, 50, 5, "2+" },
                    { 66, 55, 5, "2++" },
                    { 67, 60, 5, "3" },
                    { 68, 65, 5, "3+" },
                    { 69, 70, 5, "3++" },
                    { 70, 75, 5, "4" },
                    { 71, 80, 5, "4+" },
                    { 72, 85, 5, "4++" },
                    { 73, 90, 5, "5" },
                    { 74, 95, 5, "5+" },
                    { 75, 100, 5, "5++" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceScores_ProfessionalPathId",
                table: "ExperienceScores",
                column: "ProfessionalPathId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalGroups_ProfessionalPathId",
                table: "PersonalGroups",
                column: "ProfessionalPathId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_EducationId",
                table: "Persons",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_EducationRelationStatusId",
                table: "Persons",
                column: "EducationRelationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_EmploymentTypeId",
                table: "Persons",
                column: "EmploymentTypeId");

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
                name: "IX_Persons_OrganizationUnitId",
                table: "Persons",
                column: "OrganizationUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PerformanceId",
                table: "Persons",
                column: "PerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ProfessionalPathId",
                table: "Persons",
                column: "ProfessionalPathId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperienceScores");

            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.DropTable(
                name: "PersonalGroups");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "EducationRelationStatuses");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "EmploymentTypes");

            migrationBuilder.DropTable(
                name: "JobGroups");

            migrationBuilder.DropTable(
                name: "MilitaryServices");

            migrationBuilder.DropTable(
                name: "Occupations");

            migrationBuilder.DropTable(
                name: "OrganizationUnits");

            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.DropTable(
                name: "ProfessionalPaths");
        }
    }
}
