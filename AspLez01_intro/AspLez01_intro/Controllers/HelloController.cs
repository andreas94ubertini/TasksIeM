using Microsoft.AspNetCore.Mvc;

namespace AspLez01_intro.Controllers
{
    [Route("api/hello")]

    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Ciao");
        }
        [HttpGet("saluta")]

        public IActionResult Saluta()
        {
            return Ok("Ciao Giovanni");
        }
        [HttpGet("saluta/{nome}")]

        public IActionResult SalutaPersonalizzato(string nome)
        {
            return Ok($"Ciao {nome}");
        }
        [HttpGet("saluta/{nome}/{cognome}")]

        public IActionResult SalutaPersonalizzato(string nome, string cognome)
        {
            return Ok($"Ciao {nome} {cognome}");
        }

    }
}
