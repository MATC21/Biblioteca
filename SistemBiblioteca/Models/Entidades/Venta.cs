using System;
using System.Collections.Generic;

namespace SistemBiblioteca.Models.Entidades;

public partial class Venta
{
    public int IdVenta { get; set; }

    public int? IdUsuario { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Total { get; set; }

    public DateTime? FechaVenta { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
