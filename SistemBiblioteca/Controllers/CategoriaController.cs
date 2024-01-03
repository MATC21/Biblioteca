using Microsoft.AspNetCore.Mvc;
using SistemBiblioteca.Models.Entidades;

namespace SistemBiblioteca.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            var listaCategoria = new List<Models.Entidades.Categoria>()
            {
                new Models.Entidades.Categoria
                {
                    idCategoria = 2,
                    categoria = "TERROR",
                    descripcion = "TODO SOBRE TERROR"
                },
                new Models.Entidades.Categoria
                {
                    idCategoria = 3,
                    categoria = "ACCION",
                    descripcion = "TODO SOBRE ACCION"
                }
        };

            return View(listaCategoria);
        }
    }
}
