using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication5.Models
{
    [Table("TeachersList")]
    public class Teacher
    {
        [Key]//primary key and identity
        public int Id { get; set; }
        public string? Name { get; set; }//navarchar max
        public int Salary { get; set; }
        [Column(TypeName ="Varchar(256)")]
        public string? TeachingClasses { get; set; }
    }
}
