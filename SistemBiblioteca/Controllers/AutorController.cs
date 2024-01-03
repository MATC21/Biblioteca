using Microsoft.AspNetCore.Mvc;
using SistemBiblioteca.Models.Entidades;

namespace SistemBiblioteca.Controllers
{
    public class AutorController : Controller
    {
        public IActionResult Index()
        {
            var autor = new Autor();
            autor.idAutor = 1;
            autor.nombre = "DASDAS";
            autor.apellido = "HHFYH";

            return View(autor);
        }

    }
}
