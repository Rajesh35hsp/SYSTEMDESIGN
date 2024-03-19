using Application;
using Domain;

namespace Infrastructure
{
    public class StudentRepository : IStudentRepository
    {
        public static List<Student> s = new List<Student>()
        {
           new Student(){FirstName="as",Email="adsad@asdf.com"},
        };

        public List<Student> GetStudents()
        {
            return s;
        }
    }
}
