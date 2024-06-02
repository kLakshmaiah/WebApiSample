using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication5.Migrations.RailwayDb
{
    /// <inheritdoc />
    public partial class NumberOfTracksaddedRailwaysStations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfTracks",
                table: "RailwayStations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RailwayStations",
                keyColumn: "Id",
                keyValue: 1,
                column: "NumberOfTracks",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfTracks",
                table: "RailwayStations");
        }
    }
}
