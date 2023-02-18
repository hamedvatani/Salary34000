using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salary34000.Migrations
{
    /// <inheritdoc />
    public partial class DateTimes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChildrenCount",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DocumentDate",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildrenCount",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "DocumentDate",
                table: "Persons");
        }
    }
}
