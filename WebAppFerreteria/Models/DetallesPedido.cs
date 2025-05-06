using System;
using System.Collections.Generic;

namespace WebAppFerreteria.Models;

public partial class DetallesPedido
{
    public int Id { get; set; }

    public int PedidoId { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public virtual Pedidos? Pedido { get; set; } = null!;

    public virtual Productos? Producto { get; set; } = null!;
}
