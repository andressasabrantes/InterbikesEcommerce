using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interbikes.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangingBikeToBikesOnTableCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bikes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bike");
        }
    }
}
