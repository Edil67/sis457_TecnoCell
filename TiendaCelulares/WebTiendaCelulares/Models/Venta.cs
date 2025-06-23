using System;
using System.Collections.Generic;

namespace WebTiendaCelulares.Models;

public partial class Venta
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdUsuario { get; set; }

    public string? DocumentoCliente { get; set; }

    public decimal MontoPago { get; set; }

    public decimal MontoCambio { get; set; }

    public decimal MontoTotal { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();
}
