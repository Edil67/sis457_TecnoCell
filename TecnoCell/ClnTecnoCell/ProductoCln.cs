using CadTecnoCell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ClnTecnoCell
{
    public class ProductoCln
    {
        public static int insertar(Producto producto)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                context.Producto.Add(producto);
                context.SaveChanges();
                return producto.id;
            }
        }

        public static int actualizar(Producto producto)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var existente = context.Producto.Find(producto.id);
                if (existente != null)
                {
                    existente.nombre = producto.nombre;
                    existente.marca = producto.marca;
                    existente.color = producto.color;
                    existente.precioVenta = producto.precioVenta;
                    existente.stock = producto.stock;
                    existente.descripcion = producto.descripcion;
                    existente.usuarioRegistro = producto.usuarioRegistro;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var producto = context.Producto.Find(id);

                producto.estado = -1; // Eliminación lógica
                producto.usuarioRegistro = usuario;
                return context.SaveChanges();
            }
        }
        public static List<Producto> Listar()
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Producto.Where(x => x.estado != -1).ToList();
            }
        }

        public static Producto obtenerUno(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Producto.Find(id);
            }
        }
        public static List<paProductoListar_Result> listarPa(string parametro)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                // Llamamos al procedimiento almacenado que acepta el parámetro
                return context.paProductoListar(parametro).ToList();
            }
        }

        public static class coloresProducto
        {
            public static readonly List<string> ListaColores = new List<string>
           {
               "Negro", "Blanco", "Rojo", "Azul", "Verde", "Amarillo", "Gris"
               // Agrega los colores que necesites
           };
        }
    }
}
