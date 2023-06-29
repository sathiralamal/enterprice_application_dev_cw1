using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTrackingApplication.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRecursive",
                table: "Meals",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "TotalCatories",
                table: "Meals",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRecursive",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "TotalCatories",
                table: "Meals");
        }
    }
}
