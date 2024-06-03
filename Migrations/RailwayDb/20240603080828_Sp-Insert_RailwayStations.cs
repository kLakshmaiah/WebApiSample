using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication5.Migrations.RailwayDb
{
    /// <inheritdoc />
    public partial class SpInsert_RailwayStations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string SpInsertStations = @"CREATE PROCEDURE [dbo].[Sp_Insert_RailwayStation]
                                            @Name varchar(256)=NULL,@Address varchar(256)=NULL,@StationCode varchar(256)=NULL,@NumberOfTracks int=NULL
                                            as
                                            BEGIN
                                            INSERT INTO RailwayStations(Name,Address,StationCode,NumberOfTracks) VALUES(@Name,@Address,@StationCode,@NumberOfTracks)
                                            END
                                        ";
            migrationBuilder.Sql(SpInsertStations);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string SpInsertStationsDrop = "DROP PROCEDURE [dbo].[Sp_Insert_RailwayStation]";
            migrationBuilder.Sql(SpInsertStationsDrop);
        }
    }
}
