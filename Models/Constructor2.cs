namespace WebApplication5.Models
{
    public class Constructor2
    {
       public List<Constructor1> Constructors { get; set; }=new List<Constructor1>();
        public Constructor2()
        {
        }
        public Constructor2(List<Constructor1> constructors)
        {
            Constructors = constructors;
        }
    }
}
