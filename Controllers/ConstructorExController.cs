using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstructorExController : ControllerBase
    {
        [HttpGet]
        public List<Constructor1> GetConstructors()
        {
            Constructor2 constructor2 = new Constructor2();
            constructor2?.Constructors?.Add(new Constructor1 { id = 1, Name = "John", salary = 1000 });
            return constructor2?.Constructors;
        }
    }
}
