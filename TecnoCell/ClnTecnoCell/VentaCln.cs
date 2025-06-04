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
            using (var context = new TecnoCell_dbEntities())
            {
                context.Venta.Add(venta);
                context.SaveChanges();
                return venta.id;
            }
        }
        public static int Actualizar(Venta venta)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var existente = context.Venta.Find(venta.id);
                if (existente != null)
                {
                    existente.id = venta.idUsuario;
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
            using (var context = new TecnoCell_dbEntities())
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

        public static List<Venta> Listar()
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Venta.Where(x => x.estado != -1).ToList();
            }
        }

        public static Venta ObtenerVentaDetalle(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var venta = context.Venta.Include("VentaDetalle") // Carga los detalles relacionados
                                         .FirstOrDefault(v => v.id == id);

                if (venta != null)
                {
                    // Opcional: Puedes cargar manualmente la lista de detalles
                    venta.VentaDetalle = context.VentaDetalle
                                                .Where(d => d.id == id)
                                                .ToList();
                }

                return venta;
            }
        }
        
        public static List<paVentaListar_Result> listarPa(string parametro)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                // Llamamos al procedimiento almacenado que acepta el parámetro
                return context.paVentaListar(parametro).ToList();
            }
        }

        public static List<VentaDetalle> ObtenerDetalleVenta(int idVenta)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.VentaDetalle
                              .Where(d => d.id == idVenta)
                              .ToList();
            }
        }
    }
}
