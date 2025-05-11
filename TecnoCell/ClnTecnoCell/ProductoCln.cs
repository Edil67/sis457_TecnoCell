using CadTecnoCell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ClnTecnoCell
{
    public class ProductoCln
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
                var prod = context.Producto.Find(producto.id);
                if (prod != null)
                {
                    prod.descripcion = producto.descripcion;
                    prod.precioVenta = producto.precioVenta;
                    prod.stock = producto.stock;
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
