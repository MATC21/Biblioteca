using Microsoft.EntityFrameworkCore;
using SistemBiblioteca.Models.Entidades;

namespace SistemBiblioteca.Services
{
    public class ServicioCategoria : IServicioCategoria
    {
        private readonly LibreriaContext _libreriaContext ;

        public ServicioCategoria(LibreriaContext libreriaContext)
        {
            _libreriaContext = libreriaContext;
        }

        public async Task<Categoria> GetCategoria(string categoria)
        {
            Categoria categoriaE = await _libreriaContext.Categoria.Where(c => c.categoria == categoria).FirstOrDefaultAsync();
            return categoriaE;
        }

        public async Task<Categoria> SaveCategorias(Categoria entidad)
        {
            _libreriaContext.Categoria.Add(entidad);
            await _libreriaContext.SaveChangesAsync();
            return entidad;
        }
    }
}
