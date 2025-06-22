using CadTecnoCell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTecnoCell
{
    public class CategoriaCln
    {
        public static int insertar(Categoria categoria)
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                context.Categoria.Add(categoria);
                context.SaveChanges();
                return categoria.id;
            }
        }

        public static int actualizar(Categoria categoria)
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                var existente = context.Categoria.Find(categoria.id);
                existente.descripcion = categoria.descripcion;
                existente.usuarioRegistro = categoria.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                var categoria = context.Categoria.Find(id);
                categoria.estado = -1;
                categoria.usuarioRegistro = usuario;
                return context.SaveChanges();
            }
        }

        public static Categoria obtenerUno(int id)
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                return context.Categoria.Find(id);
            }
        }

        public static List<Categoria> listar()
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                return context.Categoria.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paCategoriaListar_Result> listarPa(string parametro)
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                return context.paCategoriaListar(parametro).ToList();
            }
        }

        public static bool ExisteDescripcion(string descripcion)
        {
            using (var context = new FinalTiendaCelularesEntities())
            {
                return context.Categoria.Any(c => c.descripcion.Equals(descripcion, StringComparison.OrdinalIgnoreCase) && c.estado != -1);
            }
        }
    }
}
