using Microsoft.EntityFrameworkCore;
using SistemBiblioteca.Models.Entidades;

namespace SistemBiblioteca.Services
{
    public class ServicioAutor : IServicioAutor
    {
        private readonly LibreriaContext _libreriaContext;

        public ServicioAutor(LibreriaContext libreriaContext)
        {
            _libreriaContext = libreriaContext;  
        }

        public async Task<Autor> GetAutor(string nombre,string apellido)
        {
            Autor autor = await _libreriaContext.Autor.Where(a => a.nombre == nombre &&  a.apellido == apellido ).FirstOrDefaultAsync();

            return autor;
        }

        public async Task<Autor> SaveAutor(Autor entidad)
        {
            _libreriaContext.Autor.Add(entidad);
            await _libreriaContext.SaveChangesAsync();
            return entidad;
        }
    }
}
