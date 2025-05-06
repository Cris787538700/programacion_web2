using System;
using System.Collections.Generic;

namespace WebAppFerreteria.Models;

public partial class Usuarios
{
    public int Id { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public string Rol { get; set; } = null!;

    public string NombreCompleto { get; set; } = null!;

    public bool EstaBloqueado { get; set; }

    public virtual ICollection<Pedidos> Pedidos { get; set; } = new List<Pedidos>();
}
