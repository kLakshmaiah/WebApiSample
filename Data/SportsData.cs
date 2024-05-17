using WebApplication5.Model;
using WebApplication5.Models;

namespace WebApplication5.Data
{
    public class SportsData
    {
        public static List<Sports> Sports { get; set; }
        static SportsData()
        {
            Sports = new List<Sports>()
           {
               new Sports(){Id=1, NumberOfPlayers=8,SportName="VollyBall"},
               new Sports(){Id=2, NumberOfPlayers=12,SportName="Cricket"}
           };
        }
    }
}
