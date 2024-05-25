using WebApplication5.Data;
using WebApplication5.IRepository;
using WebApplication5.Model;

namespace WebApplication5.Repository
{
    public class StudentService : IStudentService
    {
        List<Student> IStudentService.DeleteStudent(int id)
        {
            Student? student = Student.Students.FirstOrDefault(s => s.Id == id);
           bool isDeleted  =Student.Students.Remove(student);
            if (isDeleted)
            return Student.Students;
            else
              return  new List<Student>();
        }

        List<Student> IStudentService.GetAllStudents()
        {
            return Student.Students;
        }

        Student IStudentService.GetStudent(int id)
        {
            Student? student=Student.Students.FirstOrDefault(s=> s.Id == id);
            if(student is not null)
            {
                return student;
            }
            else
            {
                return null;
            }
        }

        List<Student> IStudentService.PostStudent(Student student)
        {
            Student.Students.Add(student);
            return Student.Students;
        }

        List<Student> IStudentService.UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
