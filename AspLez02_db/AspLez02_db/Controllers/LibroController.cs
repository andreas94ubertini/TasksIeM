using AspLez02_db.Models;
using AspLez02_db.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspLez02_db.Controllers
{
    [ApiController]
    [Route("api/libri")]
    public class LibroController : Controller
    {
        [HttpGet]
        public IActionResult Elenco()
        {
            List<Libro> l = LibroRepository.GetIstanza().GetAll();
            return Ok(l);
        }
        [HttpGet("getlibro/{s}")]
        public IActionResult GetByCod(string s)
        {
            Libro? l = LibroRepository.GetIstanza().GetByCod(s);
            if(l != null)
                return Ok(l);
            return NotFound();
        }
    }
}
