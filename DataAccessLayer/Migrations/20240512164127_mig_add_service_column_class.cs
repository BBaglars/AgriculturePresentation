using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_service_column_class : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Class1",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Class2",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class1",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Class2",
                table: "Services");
        }
    }
}
