
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CadTecnoCell
{

using System;
    using System.Collections.Generic;
    
public partial class Producto
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Producto()
    {

        this.VentaDetalle = new HashSet<VentaDetalle>();

    }


    public int id { get; set; }

    public int idCategoria { get; set; }

    public string nombre { get; set; }

    public string modelo { get; set; }

    public string marca { get; set; }

    public string color { get; set; }

    public string descripcion { get; set; }

    public decimal precioVenta { get; set; }

    public int stock { get; set; }

    public string usuarioRegistro { get; set; }

    public System.DateTime fechaRegistro { get; set; }

    public short estado { get; set; }



    public virtual Categoria Categoria { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<VentaDetalle> VentaDetalle { get; set; }

}

}
