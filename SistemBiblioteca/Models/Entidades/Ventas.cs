namespace SistemBiblioteca.Models.Entidades
{
    public class Ventas
    {
        public int idVenta { get; set; }
        public decimal subTotal { get; set; }
        public decimal descuento { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
        public DateTime fechaVenta { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
