using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSales.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CarSales_CarId",
                table: "CarSales");

            migrationBuilder.AddColumn<bool>(
                name: "IsSold",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_CarSales_CarId",
                table: "CarSales",
                column: "CarId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CarSales_CarId",
                table: "CarSales");

            migrationBuilder.DropColumn(
                name: "IsSold",
                table: "Cars");

            migrationBuilder.CreateIndex(
                name: "IX_CarSales_CarId",
                table: "CarSales",
                column: "CarId");
        }
    }
}
