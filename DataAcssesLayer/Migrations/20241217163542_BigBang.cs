﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcssesLayer.Migrations
{
    /// <inheritdoc />
    public partial class BigBang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Border",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    KollId = table.Column<int>(type: "int", nullable: false),
                    MoinId = table.Column<int>(type: "int", nullable: false),
                    BorderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Borderdistance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Border", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                });

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
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    KollId = table.Column<int>(type: "int", nullable: false),
                    MoinId = table.Column<int>(type: "int", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsIraqi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "farmers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    EachKiloPrice = table.Column<int>(type: "int", nullable: false),
                    weight = table.Column<int>(type: "int", nullable: false),
                    autherprices = table.Column<int>(type: "int", nullable: false),
                    sardkhaneprice = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sarh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBestanKar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_farmers", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "sardkhane",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sardkhane", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TarkhisKars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    KollId = table.Column<int>(type: "int", nullable: false),
                    MoinId = table.Column<int>(type: "int", nullable: false),
                    TarkisKarName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarkisKarMojavez = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarkisKarHazine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsIraqi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarkhisKars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KollId = table.Column<int>(type: "int", nullable: false),
                    MoinId = table.Column<int>(type: "int", nullable: false),
                    IsHagigi = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Noehmalekiyat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tablo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Landlinephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CityId",
                table: "Customer",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Border");

            migrationBuilder.DropTable(
                name: "CodeingKoll");

            migrationBuilder.DropTable(
                name: "CodingGrohTafsili");

            migrationBuilder.DropTable(
                name: "CodingMoind");

            migrationBuilder.DropTable(
                name: "CodingTafsili");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "farmers");

            migrationBuilder.DropTable(
                name: "Kalas");

            migrationBuilder.DropTable(
                name: "sardkhane");

            migrationBuilder.DropTable(
                name: "TarkhisKars");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
