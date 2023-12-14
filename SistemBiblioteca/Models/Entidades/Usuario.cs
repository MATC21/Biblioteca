namespace SistemBiblioteca.Models.Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string cedula { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string contrasena { get; set; }

        public virtual Roles IdRolesNavigation { get; set; } = null!;
    }
}
