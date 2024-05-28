using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.IRepository;
using WebApplication5.Model;
using WebApplication5.Repository;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentService1Controller : ControllerBase
    {
        IStudentService? _studentService { get; set; }

        public StudentService1Controller(IStudentService studentService)
        {
           _studentService = studentService;//new StudentService()
        }
        [HttpGet]
        public IActionResult GetAllSudents()
        {

            return Ok( _studentService?.InstanceId);
        }
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            Student? student = _studentService?.GetStudent(id);
            if (student is not null)
                return Ok(student);
            else
                return NotFound();
        }
        [HttpPost]
        public IActionResult Post(Student student)
        {
            return Ok(_studentService?.PostStudent(student));
        }

        [HttpDelete]
        public IActionResult Delete(Student student)
        {
            int id = Convert.ToInt32(student.Id);
            //Student deleteStudent=Student.students.where(s=>s.Id=student.Id)
            //							.FirstOrDefault();
            List<Student>? deleteStudent1 = _studentService?.DeleteStudent(id);

            if (deleteStudent1 is not null)
            {
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }
        }
    }
}
