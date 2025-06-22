using System;
using System.Collections.Generic;

namespace WebTiendaCelulares.Models;

public partial class Producto
{
    public int Id { get; set; }
    public int IdCategoria { get; set; }
    public string Nombre { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string Marca { get; set; } = null!;

    public string? Color { get; set; }

    public string? Descripcion { get; set; }

    public decimal PrecioVenta { get; set; }

    public int Stock { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Categorium IdCategoriaNavigation { get; set; } = null!;
    public virtual ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();
}
