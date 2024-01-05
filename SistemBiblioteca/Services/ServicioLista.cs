using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemBiblioteca.Models.Entidades;

namespace SistemBiblioteca.Services
{
    public class ServicioLista : IServicioLista
    {
        private readonly LibreriaContext _libreriaContext;

        public ServicioLista(LibreriaContext libreriaContext)
        {
            _libreriaContext = libreriaContext;
        }

        public async Task<List<SelectListItem>> GetListAutor()
        {
            List<SelectListItem> lista = await _libreriaContext.Autor.Select(x => new SelectListItem
            {
                Text = x.nombre,
                Value = $"{x.idAutor}"
            })
            .OrderBy(x => x.Text)
            .ToListAsync();

            lista.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un autor]",
                Value = "0"
            });

            return lista;
        }


        public async Task<List<SelectListItem>> GetListCategoria()
        {
            List<SelectListItem> lista = await _libreriaContext.Categoria.Select(x => new SelectListItem
            {
                Text = x.categoria,
                Value = $"{x.idCategoria}"
            })
                .OrderBy(x => x.Text)
                .ToListAsync();

            lista.Insert(0, new SelectListItem
            {
                Text = "[Seleccione una categoria]",
                Value = "0"
            });

            return lista;
        }
    }
}
