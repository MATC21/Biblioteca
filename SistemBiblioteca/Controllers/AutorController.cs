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
            autor.nombreAutor = "DASDAS";
            autor.apellidoAutor = "HHFYH";

            return View(autor);
        }

    }
}
