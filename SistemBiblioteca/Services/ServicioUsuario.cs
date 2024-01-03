using Microsoft.EntityFrameworkCore;
using SistemBiblioteca.Models.Entidades;

namespace SistemBiblioteca.Services
{
    public class ServicioUsuario : IServicioUsuario
    {
        private readonly LibreriaContext _libreriaContext;

        public ServicioUsuario(LibreriaContext libreriaContext)
        {
            _libreriaContext = libreriaContext;
        }

        public async Task<Usuario> GetUsuario(string correo, string contraseña)
        {
            Usuario usuario = await _libreriaContext.Usuarios.Where(u => u.Correo == correo && u.Contasena == contraseña).FirstOrDefaultAsync();

            return usuario;
        }

        public async Task<Usuario> GetUsuario(string usuarios)
        {
            Usuario usuario = await _libreriaContext.Usuarios.Where(u => u.NombreUsuario == usuarios).FirstOrDefaultAsync();

            return usuario;
        }

        public async Task<Usuario> SaveUsuario(Usuario entidad)
        {
            _libreriaContext.Usuarios.Add(entidad);
            await _libreriaContext.SaveChangesAsync();
            return entidad;
        }
    }
}
