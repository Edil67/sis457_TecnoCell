using CadTecnoCell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTecnoCell
{
    public class UsuarioCln
    {
        public static Usuario obtenerUno(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Usuario

                    .Where(e => e.id == id)
                    .FirstOrDefault();
            }
        }
        public static Usuario validar(string usuario, string clave)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Usuario
                    .Where(u => u.usuario1 == usuario && u.clave == clave)
                    .FirstOrDefault();
            }
        }

    }
}
