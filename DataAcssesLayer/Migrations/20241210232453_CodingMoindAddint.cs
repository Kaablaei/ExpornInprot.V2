﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcssesLayer.Migrations
{
    /// <inheritdoc />
    public partial class CodingMoindAddint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColdeName",
                table: "CodingMoind");

            migrationBuilder.AlterColumn<int>(
                name: "CodeKoll",
                table: "CodingMoind",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CodeKoll",
                table: "CodingMoind",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColdeName",
                table: "CodingMoind",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
