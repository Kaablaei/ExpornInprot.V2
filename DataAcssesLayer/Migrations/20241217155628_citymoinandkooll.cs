using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcssesLayer.Migrations
{
    /// <inheritdoc />
    public partial class citymoinandkooll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KollId",
                table: "customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MoinId",
                table: "customer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KollId",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "MoinId",
                table: "customer");
        }
    }
}
