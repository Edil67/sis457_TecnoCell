using CadTecnoCell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTecnoCell
{
    public class VentaCln
    {
        public static int Insertar(Venta venta)
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                context.Venta.Add(venta);
                context.SaveChanges();
                return venta.id;
            }
        }
        public static int Actualizar(Venta venta)
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                var existente = context.Venta.Find(venta.id);
                if (existente != null)
                {
                    existente.idUsuario = venta.idUsuario;
                    existente.documentoCliente= venta.documentoCliente;
                    existente.montoPago= venta.montoPago;
                    existente.montoCambio = venta.montoCambio;
                    existente.montoTotal = venta.montoTotal;
                    existente.usuarioRegistro = venta.usuarioRegistro;
                    return context.SaveChanges();
                }
                return 0; // Manejar caso donde no se encuentra la venta
            }
        }

        public static int Eliminar(int id, string usuario)
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                var venta = context.Venta.Find(id);
                if (venta != null)
                {
                    venta.estado = -1; // Marcar como eliminado
                    venta.usuarioRegistro = usuario;
                    return context.SaveChanges();
                }
                return 0; // Manejar caso donde no se encuentra la venta
            }
        }

        public static List<Venta> listar()
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                return context.Venta.Where(x => x.estado != -1).ToList();
            }
        }

        public static Venta obtenerVentaDetalle(string cedulaIdentidad)
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                var venta = context.Venta
                    .Include("VentaDetalle.Producto")
                    .FirstOrDefault(v => v.documentoCliente == cedulaIdentidad);

                return venta;
            }
        }
        
        public static List<paVentaListar_Result> listarPa(string parametro)
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                // Llamamos al procedimiento almacenado que acepta el parámetro
                return context.paVentaListar(parametro).ToList();
            }
        }

        public static List<VentaDetalle> obtenerDetalleVenta(int idVenta)
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                return context.VentaDetalle
                              .Where(d => d.id == idVenta)
                              .ToList();
            }
        }

  
    }
}
