using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTrackingApplication.Migrations
{
    /// <inheritdoc />
    public partial class add_recusive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRecursive",
                table: "Workouts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRecursive",
                table: "Workouts");
        }
    }
}
