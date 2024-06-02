using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication5.Migrations.RailwayDb
{
    /// <inheritdoc />
    public partial class Sp_Stations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string spstations = @"CREATE PROCEDURE [dbo].[sp_GetAllStations]
                                     AS
                                       BEGIN
                                            SELECT ID,Name,Address,StationCode,NumberOfTracks,(SELECT count(*) FROM RailwayStations) as TotalStations FROM RailwayStations
                                        END
                                    ";
            migrationBuilder.Sql(spstations);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string dropspstations = "DROP PROCEDURE [dbo].[sp_GetAllStations]";
            migrationBuilder.Sql(dropspstations);
        }
    }
}
