using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
              _studentRepository = studentRepository;
        }
        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetStudents().ToList();
        }
    }
}
