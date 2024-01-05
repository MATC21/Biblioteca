using SistemBiblioteca.Models.Entidades;

namespace SistemBiblioteca.Services
{
    public interface IServicioAutor
    {
        public Task<Autor> GetAutor(string nombre,string apellido);
        public Task<Autor> SaveAutor(Autor entidad);

    }
}
