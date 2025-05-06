using System;
using System.Collections.Generic;

namespace WebAppFerreteria.Models;

public partial class Pedidos
{
    public int Id { get; set; }

    public int ClienteId { get; set; }

    public DateTime FechaPedido { get; set; }

    public string Estado { get; set; } = null!;

    public string? DireccionEntrega { get; set; }

    public int? EmpleadoId { get; set; }

    public virtual Clientes? Cliente { get; set; } = null!;

    public virtual ICollection<DetallesPedido> DetallesPedido { get; set; } = new List<DetallesPedido>();

    public virtual Usuarios? Empleado { get; set; }

    public virtual Facturas? Facturas { get; set; }
}
