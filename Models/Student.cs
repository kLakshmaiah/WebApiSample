namespace WebApplication5.Model
{
    public  class Student
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? StudentId { get; set; }
        public  string? StudentDescription { get; set; }
        public static  List<Student> Students { get; set; }
         static Student()
        {
            Students = new List<Student>()
            {
                new Student { Id = 1, Name = "John", Description = "John is a student1", StudentId = 1, StudentDescription = "John is a student" },
                new Student { Id = 2, Name = "Jane", Description = "Jane is a student2", StudentId = 2, StudentDescription = "Jane is a student" },
                new Student { Id = 3, Name = "Doe", Description = "Doe is a student3", StudentId = 3, StudentDescription = "Doe is a student" },
                new Student { Id = 4, Name = "Doe1", Description = "Doe is a student4", StudentId = 4, StudentDescription = "Doe is a student" },
                new Student { Id = 5, Name = "Doe2", Description = "Doe is a student5", StudentId = 5, StudentDescription = "Doe is a student" },
                new Student { Id = 6, Name = "Doe3", Description = "Doe is a student6", StudentId = 6, StudentDescription = "Doe is a student" }
            };
        }
        public static List<Student> GetStudent()
        {
            Students = new List<Student>()
            {
                new Student { Id = 1, Name = "John", Description = "John is a student1", StudentId = 1, StudentDescription = "John is a student" },
                new Student { Id = 2, Name = "Jane", Description = "Jane is a student2", StudentId = 2, StudentDescription = "Jane is a student" },
                new Student { Id = 3, Name = "Doe", Description = "Doe is a student3", StudentId = 3, StudentDescription = "Doe is a student" },
                new Student { Id = 4, Name = "Doe1", Description = "Doe is a student4", StudentId = 4, StudentDescription = "Doe is a student" },
                new Student { Id = 5, Name = "Doe2", Description = "Doe is a student5", StudentId = 5, StudentDescription = "Doe is a student" },
                new Student { Id = 6, Name = "Doe3", Description = "Doe is a student6", StudentId = 6, StudentDescription = "Doe is a student" }
            };  
            
            return Students;
        }
    }
}
