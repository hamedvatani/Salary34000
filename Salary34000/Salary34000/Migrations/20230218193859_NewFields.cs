using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salary34000.Migrations
{
    /// <inheritdoc />
    public partial class NewFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ConsolidatedInsurance",
                table: "Persons",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConsolidatedInsurance",
                table: "Persons");
        }
    }
}
