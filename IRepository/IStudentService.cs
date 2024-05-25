using WebApplication5.Model;

namespace WebApplication5.IRepository
{
    //IClass
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student GetStudent(int id);
        List<Student> PostStudent(Student student);

        List<Student> DeleteStudent(int id);

        List<Student> UpdateStudent(Student student);

    }
}
