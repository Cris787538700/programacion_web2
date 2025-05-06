using System;
using System.Collections.Generic;

namespace WebAppFerreteria.Models;

public partial class Productos
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal PrecioUnitario { get; set; }

    public int Stock { get; set; }

    public string? UnidadMedida { get; set; }

    public string? ImagenUrl { get; set; }

    public virtual ICollection<DetallesPedido> DetallesPedido { get; set; } = new List<DetallesPedido>();
}
