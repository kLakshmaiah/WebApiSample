using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Data;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        public DatabaseController(SchoolDbContext schoolDbContext)
        {
            SchoolDbContext = schoolDbContext;
        }

        public SchoolDbContext SchoolDbContext { get; }

        [HttpGet]
        public IActionResult GetTeachers()
        {
            return Ok(SchoolDbContext.Teachers.ToList());
        }
        [HttpPost]
        public IActionResult CreateTeacher(Teacher teacher)
        {
            SchoolDbContext.Teachers.Add(teacher);
            int numberofrecordsinserted = SchoolDbContext.SaveChanges();//saved in the Database
            if (numberofrecordsinserted == 0)
            {
                return BadRequest(teacher);
            }
            else
            {
                string message = $"number of records inserted {numberofrecordsinserted}";
                    return Ok(message);
            }
        }
    }
}
