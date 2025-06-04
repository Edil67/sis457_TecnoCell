using CadTecnoCell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTecnoCell
{
    public class ModeloCln
    {
        public static int Insertar(Producto producto)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                context.Producto.Add(producto);
                context.SaveChanges();
                return producto.id;
            }
        }
        public static int Actualizar(Producto producto)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var mod = context.Producto.Find(producto.id);
                if (mod != null)
                {
                    mod.nombre = producto.nombre;
                    mod.marca = producto.marca;
                    mod.descripcion = producto.descripcion;
                    mod.color = producto.color;
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static int Eliminar(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var producto = context.Producto.Find(id);
                if (producto != null)
                {
                    context.Producto.Remove(producto);
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static List<Producto> Listar()
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Producto.ToList();
            }
        }
        public static Producto ObtenerPorId(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Producto.Find(id);
            }
        }
    }
}
