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
        public static int Insertar(DetalleCompra detalleCompra)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                context.DetalleCompra.Add(detalleCompra);
                context.SaveChanges();
                return detalleCompra.id;
            }
        }
        public static int Actualizar(DetalleCompra detalleCompra)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var det = context.DetalleCompra.Find(detalleCompra.id);
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
                var detalleCompra = context.DetalleCompra.Find(id);
                if (detalleCompra != null)
                {
                    context.DetalleCompra.Remove(detalleCompra);
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static List<DetalleCompra> Listar()
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.DetalleCompra.ToList();
            }
        }
        public static DetalleCompra ObtenerPorId(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.DetalleCompra.Find(id);
            }
        }
    }
}
