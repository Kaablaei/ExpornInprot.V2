using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcssesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TafsiliDetail",
                table: "CodingTafsili");

            migrationBuilder.RenameColumn(
                name: "CodeMoin",
                table: "CodingTafsili",
                newName: "GropTafsiliCode");

            migrationBuilder.AddColumn<string>(
                name: "Explain",
                table: "CodingTafsili",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GropTafsiliName",
                table: "CodingTafsili",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "TafsiliStatusIaActive",
                table: "CodingTafsili",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Explain",
                table: "CodingTafsili");

            migrationBuilder.DropColumn(
                name: "GropTafsiliName",
                table: "CodingTafsili");

            migrationBuilder.DropColumn(
                name: "TafsiliStatusIaActive",
                table: "CodingTafsili");

            migrationBuilder.RenameColumn(
                name: "GropTafsiliCode",
                table: "CodingTafsili",
                newName: "CodeMoin");

            migrationBuilder.AddColumn<string>(
                name: "TafsiliDetail",
                table: "CodingTafsili",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
