using CadTecnoCell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTecnoCell
{
    public class CompraCln
    {
        public static int Insertar(Compra compra)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                context.Compra.Add(compra);
                context.SaveChanges();
                return compra.id;
            }
        }
        public static int Actualizar(Compra compra)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var comp = context.Compra.Find(compra.id);
                if (comp != null)
                {
                    comp.fecha = compra.fecha;
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static int Eliminar(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var compra = context.Compra.Find(id);
                if (compra != null)
                {
                    context.Compra.Remove(compra);
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static List<Compra> Listar()
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Compra.ToList();
            }
        }
        public static Compra ObtenerPorId(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Compra.Find(id);
            }
        }
    }
}
