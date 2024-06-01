using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication5.Migrations.RailwayDb
{
    /// <inheritdoc />
    public partial class RailwaysStationDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RailwayStations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(256)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StationCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RailwayStations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RailwayStations",
                columns: new[] { "Id", "Address", "Name", "StationCode" },
                values: new object[] { 1, "Nellore,Andrapradesh", "NelloreRst", "523434" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RailwayStations");
        }
    }
}
