using System;
using System.Collections.Generic;

namespace WebAppFerreteria.Models;

public partial class Facturas
{
    public int Id { get; set; }

    public int PedidoId { get; set; }

    public DateTime FechaFactura { get; set; }

    public decimal Total { get; set; }

    public string? MetodoPago { get; set; }

    public virtual Pedidos? Pedido { get; set; } = null!;
}
