﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcssesLayer.Migrations
{
    /// <inheritdoc />
    public partial class bigbang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodeingKoll",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeKoll = table.Column<int>(type: "int", nullable: false),
                    KollName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccoungGrop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountStatuseIsBebtor = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeingKoll", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CodingGrohTafsili",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodingGrohTafsili", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CodingMoind",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeMoin = table.Column<int>(type: "int", nullable: false),
                    MoinName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adrees = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expalein = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatuseIsActive = table.Column<bool>(type: "bit", nullable: false),
                    CodeKoll = table.Column<int>(type: "int", nullable: true),
                    KollName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TafsiliGropId = table.Column<int>(type: "int", nullable: false),
                    TafsiliGropName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodingMoind", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CodingTafsili",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeTafsili = table.Column<int>(type: "int", nullable: false),
                    TafsiliName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TafsiliStatusIaActive = table.Column<bool>(type: "bit", nullable: false),
                    GropTafsiliCode = table.Column<int>(type: "int", nullable: false),
                    GropTafsiliName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodingTafsili", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Kalas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    KollId = table.Column<int>(type: "int", nullable: false),
                    MoinId = table.Column<int>(type: "int", nullable: false),
                    KalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    VahedMoayan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vahedjoz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MabnayeMohasebat = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kalas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodeingKoll");

            migrationBuilder.DropTable(
                name: "CodingGrohTafsili");

            migrationBuilder.DropTable(
                name: "CodingMoind");

            migrationBuilder.DropTable(
                name: "CodingTafsili");

            migrationBuilder.DropTable(
                name: "Kalas");
        }
    }
}
