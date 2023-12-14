namespace SistemBiblioteca.Models.Entidades
{
    public class Libro
    {
        public int idLibro { get; set; }
        public int idCategoria { get; set; }
        public int idAutor { get; set; }
        public int idEditorial { get; set; }
        public string titulo { get; set; }
        public string anio { get; set; }
        public bool estado { get; set; }
        public decimal precio { get; set; }
        public int fechaRegistro { get; set; }
        public string urlLibro { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; } = null!;
        public virtual Autor IdAutorNavigation { get; set; } = null!;
        public virtual Editorial IdEditorialNavigation { get; set; } = null!;
    }
}
