using System.ComponentModel.DataAnnotations;

namespace SistemBiblioteca.Models.Entidades
{
    public class Editorial
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int idEditorial { get; set; }
        public string nombre { get;}
    }
}
