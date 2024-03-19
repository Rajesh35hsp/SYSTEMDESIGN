using Application;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Students : ControllerBase
    {
        private readonly IStudentService _studentService;

        public Students(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        [HttpGet]
        public ActionResult<List<Students>> Get()
        {
            var students = _studentService.GetAllStudents();
            return Ok(students);
        }
    }
}
