using System;
using System.Collections.Generic;

namespace SistemBiblioteca.Models.Entidades;

public partial class Categoria
{
    public int idCategoria { get; set; }

    public string? categoria { get; set; }

    public string? descripcion { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
