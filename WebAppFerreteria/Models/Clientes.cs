using System;
using System.Collections.Generic;

namespace WebAppFerreteria.Models;

public partial class Clientes
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? CorreoElectronico { get; set; }

    public string? Telefono { get; set; }

    public string Direccion { get; set; } = null!;

    public virtual ICollection<Pedidos> Pedidos { get; set; } = new List<Pedidos>();
}
