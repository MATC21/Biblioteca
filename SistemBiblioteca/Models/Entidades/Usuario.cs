using System;
using System.Collections.Generic;

namespace SistemBiblioteca.Models.Entidades;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int? IdRol { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Cedula { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public string? Contasena { get; set; }

    public virtual Roles? IdRolNavigation { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
