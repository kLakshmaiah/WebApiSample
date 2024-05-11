using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Model;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public List<Student> Get()
        {
            return Student.Students;
        }
        [HttpPost]
        public Student Post(Student student)
        {
            Student.Students.Add(student);
            return student;
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

