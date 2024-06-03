using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication5.Migrations.RailwayDb;
using WebApplication5.Models;

namespace WebApplication5.Data
{
    public class RailwayDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=RailwayDbContext;TrustServerCertificate=true;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//Data seeding
        {
            modelBuilder.Entity<Station>().HasData(
                new Station { Id = 1, Name = "NelloreRst", StationCode = "523434", Address = "Nellore,Andrapradesh" }
                );
        }
        public DbSet<Station> Stations { get; set; }

        public List<Station> Sp_GetAllStations()
        {
          List<Station> stations=  Stations.FromSqlRaw("EXECUTE [dbo].[sp_GetAllStations]").ToList();
            return stations;
        }

        public int SpInsertRailwayStations(Station station)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter($"@{nameof(station.Name)}",station.Name),
                new SqlParameter($"@{nameof(station.Address)}",station.Address),
                new SqlParameter($"@{nameof(station.StationCode)}",station.StationCode),
                new SqlParameter($"@{nameof(station.NumberOfTracks)}",station.NumberOfTracks),
            };
           int numberofrecordseffected= Database.ExecuteSqlRaw($"EXEC [dbo].[Sp_Insert_RailwayStation] @{nameof(station.Name)},@{nameof(station.Address)},@{nameof(station.StationCode)},@{nameof(station.NumberOfTracks)}", sqlParameters);
            return numberofrecordseffected;
        }
    }
}
