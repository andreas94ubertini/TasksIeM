using AspLez01_intro.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspLez01_intro.Controllers
{
    [ApiController]
    [Route("api/studente")]
    public class StudenteController : Controller
    {
        [HttpGet("test")]
        public IActionResult TestGet()
        {
            return Ok("Test di GET");
        }
        [HttpPost("test")]
        public IActionResult TestPost()
        {
            return Ok("Test di POST");
        }
        [HttpGet("dettaglio ")]
        public IActionResult GetStudente()
        {
            Studente s = new Studente(1,"Giovanni", "Pace", "AB1234");
            return Ok(s);
        }
    }
}
