using SistemBiblioteca.Models.Entidades;

namespace SistemBiblioteca.Services
{
    public interface IServicioUsuario
    {
        public Task<Usuario> GetUsuario(string correo, string contraseña);
        public Task<Usuario> SaveUsuario(Usuario entidad);
        public Task<Usuario> GetUsuario(string usuarios);



    }
}
