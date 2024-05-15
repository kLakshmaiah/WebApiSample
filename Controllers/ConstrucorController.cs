using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstrucorController : ControllerBase
    {
       readonly ConstructorClass? constructorClass ;

        public ConstrucorController()
        {
            constructorClass = new ConstructorClass(new List<Vechile>
            {
                new Vechile { Id = 1, Name = "Car", Description = "This is a car" },
                new Vechile { Id = 2, Name = "Bike", Description = "This is a bike" },
                new Vechile { Id = 3, Name = "Truck", Description = "This is a truck" }
            });
        }
        [HttpGet]
        public List<Vechile> GetVechiles()
        {
            return constructorClass?.Vechiles;
        }
       
    }
}
