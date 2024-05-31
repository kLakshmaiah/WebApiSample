using WebApplication5.Model;
using WebApplication5.Models;

namespace WebApplication5.IRepository
{
    //IClass
    public interface IStudentService
    {
        Guid InstanceId { get; }
        List<Student> GetAllStudents();
        Student GetStudent(int id);
        List<Student> PostStudent(Student student);

        List<Student> DeleteStudent(int id);

        List<Student> UpdateStudent(Student student);

        DatabaseValue GetDatabaseValuesFromConfiugration(IConfiguration configuration,string secotionName);

    }
}
