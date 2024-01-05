using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemBiblioteca.Models.Entidades;

namespace SistemBiblioteca.Controllers
{
    public class AutoresController : Controller
    {
        private readonly LibreriaContext _libreriaContext;

        public AutoresController(LibreriaContext libreriaContext)
        {
            _libreriaContext = libreriaContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> listaautor()
        {
            return View(await _libreriaContext.Autor.ToListAsync());
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Autor autor)
        {

            if (ModelState.IsValid)
            {
                _libreriaContext.Add(autor);
                await _libreriaContext.SaveChangesAsync();
                TempData["AlertMessagge"] = "Autor creado existosamente";
                return RedirectToAction("listaautor");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "A ocurrido un error");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Editar(int id)
        {
            if (id == null || _libreriaContext.Autor == null)
            {
                return NotFound();
            }
            var autor = await _libreriaContext.Autor.FindAsync(id);
            if (autor == null)
            {
                return NotFound();
            }
            return View(autor);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(int id, Autor entidad)
        {
            if (id != entidad.idAutor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _libreriaContext.Update(entidad);
                    await _libreriaContext.SaveChangesAsync();
                    TempData["AlertMessagge"] = "Autor actualizado" + "Exitosamente";
                    return RedirectToAction("listaautor");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(ex.Message, "Ocurrio un error" + "al actualizar");
                }
            }

            return View(entidad);
        }

        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null || _libreriaContext.Autor == null)
            {
                return NotFound();
            }

            var autor = await _libreriaContext.Autor
                .FirstOrDefaultAsync(a => a.idAutor == id);

            if (autor == null)
            {
                return NotFound();
            }
            try
            {
                _libreriaContext.Autor.Remove(autor);
                await _libreriaContext.SaveChangesAsync();
                TempData["AlertMessagge"] = "Autor Eliminado" + "Exitosamente";

            }
            catch (Exception ex)
            {
                ModelState.AddModelError(ex.Message, "Ocurrio un error" + "al eliminar");
            }

            return RedirectToAction(nameof(listaautor));
        }
    }
}
