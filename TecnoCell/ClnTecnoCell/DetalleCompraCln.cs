using CadTecnoCell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTecnoCell
{
    public class DetalleCompraCln
    {
        public static int Insertar(CompraDetalle detalleCompra)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                context.CompraDetalle.Add(detalleCompra);
                context.SaveChanges();
                return detalleCompra.id;
            }
        }
        public static int Actualizar(CompraDetalle detalleCompra)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var det = context.CompraDetalle.Find(detalleCompra.id);
                if (det != null)
                {
                    det.cantidad = detalleCompra.cantidad;
                    det.precioUnitario = detalleCompra.precioUnitario;
                    det.total = detalleCompra.total;
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static int Eliminar(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var detalleCompra = context.CompraDetalle.Find(id);
                if (detalleCompra != null)
                {
                    context.CompraDetalle.Remove(detalleCompra);
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static List<CompraDetalle> Listar()
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.CompraDetalle.ToList();
            }
        }
        public static CompraDetalle ObtenerPorId(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.CompraDetalle.Find(id);
            }
        }
    }
}
