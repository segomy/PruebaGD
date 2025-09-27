using System;
using System.Collections.Generic;

namespace PruebaGD.Models;

public partial class Producto
{
    public int CodigoProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public int CodigoCategoria { get; set; }

    public virtual Categorium CodigoCategoriaNavigation { get; set; } = null!;

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
