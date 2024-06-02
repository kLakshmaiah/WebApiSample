using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication5.Models
{
    [Table("RailwayStations")]
    public class Station
    {
        public int Id { get; set; }
        [Column(TypeName="varchar(256)")]
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? StationCode { get; set; }
        public int? NumberOfTracks { get; set;}
        [NotMapped]  //it is not inlcude in the Database
        public int? TotalStations { get; set; }
    }
}
