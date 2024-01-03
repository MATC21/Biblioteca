using System;
using System.Collections.Generic;

namespace SistemBiblioteca.Models.Entidades;

public partial class Libro
{
    public int IdLibro { get; set; }

    public int? IdCategoria { get; set; }

    public string? Titulo { get; set; }

    public int? Anio { get; set; }

    public bool? Estado { get; set; }

    public decimal? Precio { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdAutor { get; set; }

    public string? UrlLibro { get; set; }

    public int? IdEditorial { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Autor? IdAutorNavigation { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Editorial? IdEditorialNavigation { get; set; }
}
