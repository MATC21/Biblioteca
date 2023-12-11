using System.ComponentModel.DataAnnotations;

namespace SistemBiblioteca.Models.Entidades
{
    public class Categoria
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int? idCategoria { get; set; }
        public string? categoria { get; set; }
        public string? descripcion { get; set;}
    }
}
