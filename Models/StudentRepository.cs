namespace Lecture49YT_MVC_Add_Students.Models
{
    public class StudentRepository
    {
        public static List<Student> students = new List<Student>();

        public static void AddStudents(Student s)
        {
            
            students.Add(s);
        }
    }
}
