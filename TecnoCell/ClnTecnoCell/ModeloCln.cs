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
        public static int Insertar(Modelo modelo)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                context.Modelo.Add(modelo);
                context.SaveChanges();
                return modelo.id_Modelo;
            }
        }
        public static int Actualizar(Modelo modelo)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var mod = context.Modelo.Find(modelo.id_Modelo);
                if (mod != null)
                {
                    mod.nombreModelo = modelo.nombreModelo;
                    mod.modeloProducto = modelo.modeloProducto;
                    mod.marca = modelo.marca;
                    mod.descripcion = modelo.descripcion;
                    mod.color = modelo.color;
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static int Eliminar(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var modelo = context.Modelo.Find(id);
                if (modelo != null)
                {
                    context.Modelo.Remove(modelo);
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static List<Modelo> Listar()
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Modelo.ToList();
            }
        }
        public static Modelo ObtenerPorId(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Modelo.Find(id);
            }
        }
    }
}
