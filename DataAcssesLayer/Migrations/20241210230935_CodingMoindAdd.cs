using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAcssesLayer.Migrations
{
    /// <inheritdoc />
    public partial class CodingMoindAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodingMoin",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeMoin = table.Column<int>(type: "int", nullable: false),
                    MoinName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColdeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adrees = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expalein = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatuseIsActive = table.Column<bool>(type: "bit", nullable: false),
                    CodeKoll = table.Column<int>(type: "int", nullable: false),
                    KollName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TafsiliGropId = table.Column<int>(type: "int", nullable: false),
                    TafsiliGropName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodingMoind", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodingMoin");
        }
    }
}
