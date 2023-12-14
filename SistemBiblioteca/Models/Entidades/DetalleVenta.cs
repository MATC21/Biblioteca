namespace SistemBiblioteca.Models.Entidades
{
    public partial class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public int? IdVenta { get; set; }
        public int? IdLibro { get; set; }
        public int? Cantidad { get; set; }

        public virtual Libro? IdLibroNavigation { get; set; }
        public virtual Ventas? IdVentaNavigation { get; set; }
    }
}


