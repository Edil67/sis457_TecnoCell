using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebTiendaCelulares.Models;

public partial class Cliente
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [Display(Name = "CedulaIdentidad")]
    public string CedulaIdentidad { get; set; } = null!;
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [Display(Name = "Nombres")]
    public string Nombres { get; set; } = null!;
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [Display(Name = "Apellidos")]
    public string Apellidos { get; set; } = null!;
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [Display(Name = "Direccion")]
    public string Direccion { get; set; } = null!;
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    [Display(Name = "Celular")]
    public long Celular { get; set; }

    public string? CorreoElectronico { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
