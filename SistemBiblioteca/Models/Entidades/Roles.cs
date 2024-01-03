using System;
using System.Collections.Generic;

namespace SistemBiblioteca.Models.Entidades;

public partial class Roles
{
    public int IdRol { get; set; }

    public string? NombreRol { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
