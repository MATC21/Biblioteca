using System;
using System.Collections.Generic;

namespace SistemBiblioteca.Models.Entidades;

public partial class Autor
{
    public int idAutor { get; set; }

    public string? nombre { get; set; }

    public string? apellido { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
