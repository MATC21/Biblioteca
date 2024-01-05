using SistemBiblioteca.Models.Entidades;

namespace SistemBiblioteca.Services
{
    public interface IServicioCategoria
    {
        public Task<Categoria> GetCategoria(string categoria);
        public Task<Categoria> SaveCategorias(Categoria entidad);
    }
} 
