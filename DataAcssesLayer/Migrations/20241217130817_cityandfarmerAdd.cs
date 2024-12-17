using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcssesLayer.Migrations
{
    /// <inheritdoc />
    public partial class cityandfarmerAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBestanKar",
                table: "farmers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "City",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBestanKar",
                table: "farmers");

            migrationBuilder.AlterColumn<int>(
                name: "CityName",
                table: "City",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
