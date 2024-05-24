using WebApplication5.IRepository;
using WebApplication5.Model;

namespace WebApplication5.Repository
{
    public class StudentService : IStudentService
    {
        List<Student> IStudentService.DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        List<Student> IStudentService.GetAllStudents()
        {
            throw new NotImplementedException();
        }

        Student IStudentService.GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        List<Student> IStudentService.PostStudent(string id)
        {
            throw new NotImplementedException();
        }

        List<Student> IStudentService.UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
