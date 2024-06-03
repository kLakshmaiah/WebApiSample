using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Data;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RailwayStationController : ControllerBase
    {
        public RailwayStationController(RailwayDbContext railwayDbContext)
        {
            dbContext = railwayDbContext;
        }

        public RailwayDbContext dbContext { get; }
        [HttpGet]
        public IActionResult GetAllStations()
        {
            return Ok(dbContext?.Sp_GetAllStations());
        }
        [HttpPost]
        public IActionResult CreateStation(Station station)
        {
            try
            {
                //dbContext.Stations.Add(station);
                //int numberofrecordsinserted = dbContext.SaveChanges();
                int numberofrecordsinserted= dbContext.SpInsertRailwayStations(station);
                if (numberofrecordsinserted == 0)
                {
                    return BadRequest(station);
                }
                return Ok(string.Format("number of records inserted {0}", numberofrecordsinserted));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
