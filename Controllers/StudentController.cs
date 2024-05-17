using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Model;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //[HttpGet]
        //public ActionResult<List<Student>> Get()
        //{
        //    Student.Students = new List<Student>();
        //    if(Student.Students.Count == 0)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(Student.Students);
        //}
        //[Route("vinay")]
        //[HttpGet]
        //public ActionResult Get()
        //{
        //    Student.Students = new List<Student>();
        //    if(Student.Students.Count == 0)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(Student.Students);
        //}
        //[Route("vinay")]
        [HttpGet("vinay/{vinay1?}",Name ="ccc")]
        public IActionResult Get(int? vinay1)
        {
            Student? student = Student.Students?.Where(s => s.Id == vinay1)?.FirstOrDefault();
            if (student is null)
            {
                return NotFound();
            }

            // Generate the URL for this route
            string url = Url.RouteUrl("ccc", new { vinay1 = vinay1 });

            // Return the student and the URL in the response
            return Ok(new { student = student, url = url });
        }


        [HttpPost]
        public IActionResult Post(Student student)
        {
            Student.Students.Add(student);
            string url = Url.RouteUrl("ccc", new { vinay1 = Student.Students });
            return StatusCode(201,student);
        }

        [HttpDelete]
        public bool Delete(Student student)
        {
            Student result = Student.Students.Where(student=>student.Id==student.Id).FirstOrDefault();
           bool result1= Student.Students.Remove(result);
            if (result1)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        [HttpPut]
        public bool Put(Student student)
        {
            int index= Student.Students.FindIndex(S=>S.Id==student.Id);
            if(index==0)
            {
                //Student.Students[index] = student;
                Student.Students.Insert(index,student);
                return true;
            }
            return false;
        }
    }

}

