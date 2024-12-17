using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcssesLayer.Migrations
{
    /// <inheritdoc />
    public partial class border : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHagigi = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Noehmalekiyat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tablo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Landlinephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityCode = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_customer_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customer_CityId",
                table: "customer",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
