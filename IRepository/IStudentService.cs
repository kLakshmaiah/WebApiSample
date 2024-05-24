using WebApplication5.Model;

namespace WebApplication5.IRepository
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudent(int id);
        List<Student> PostStudent(string id);

        List<Student> DeleteStudent(int id);

        List<Student> UpdateStudent(Student student);

    }
}
