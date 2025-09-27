using System;
using System.Collections.Generic;

namespace PruebaGD.Models;

public partial class Venta
{
    public int CodigoVenta { get; set; }

    public DateOnly Fecha { get; set; }

    public int CodigoProducto { get; set; }

    public virtual Producto CodigoProductoNavigation { get; set; } = null!;
}
