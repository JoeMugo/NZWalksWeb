using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WalksAPI.Controllers
{
    // https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // https://localhost:portnumber/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "Joel", "Hope", "Abby", "Alvin" };

            return Ok(studentNames);
        }
    }
}
