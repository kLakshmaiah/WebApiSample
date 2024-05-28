using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.IRepository;
using WebApplication5.Repository;

namespace WebApplication5.ServicesLifeTime
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private IStudentService StudentService { get; set; }
        public IStudentService StudentService1 { get; }
        public IStudentService StudentService2 { get; }
        public IConfiguration Configuration { get; }

        public ServicesController(IStudentService studentService,IStudentService studentService1,IStudentService studentService2,IConfiguration configuration)
        {
            StudentService = studentService;
            StudentService1 = studentService1;
            StudentService2 = studentService2;
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string guid1 = string.Concat("this is from Service1 ",StudentService.InstanceId.ToString());
            string guid2 = string.Concat("this is from Service2 ", StudentService1.InstanceId.ToString());
            string guid3 = string.Concat("this is from Service3 ", StudentService2.InstanceId.ToString());
            
            return Ok(new[] {guid1,guid2,guid3 });
        }

        [HttpPost]
        public IActionResult Post()
        {
            string guid1 = string.Concat("this is from Service1 ", StudentService.InstanceId.ToString());
            string guid2 = string.Concat("this is from Service2 ", StudentService1.InstanceId.ToString());

            return Ok(new[] { guid1, guid2 });
        }
    }
}
