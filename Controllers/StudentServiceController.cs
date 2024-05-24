using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.IRepository;
using WebApplication5.Model;
using WebApplication5.Repository;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentServiceController : ControllerBase
    {
        IStudentService? _studentService {  get; set; }

        public StudentServiceController()
        {
            StudentService student=new StudentService();
            _studentService = student;
        }
        [HttpGet]
        public IActionResult GetSudents()
        {
            return null;
        }
    }
}
