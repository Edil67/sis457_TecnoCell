using CadTecnoCell;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTecnoCell
{
    public class ClienteCln
    {
        public static int Insertar(Cliente cliente)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                context.Cliente.Add(cliente);
                context.SaveChanges();
                return cliente.id;
            }
        }
        public static int Actualizar(Cliente cliente)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var cli = context.Cliente.Find(cliente.id);
                if (cli != null)
                {
                    cli.nombres = cliente.nombres;
                    cli.primerApellido = cliente.primerApellido;
                    cli.segundoApellido = cliente.segundoApellido;
                    cli.direccion = cliente.direccion;
                    cli.celular = cliente.celular;
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static int Eliminar(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var cliente = context.Cliente.Find(id);
                if (cliente != null)
                {
                    context.Cliente.Remove(cliente);
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static List<Cliente> Listar()
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Cliente.ToList();
            }
        }
        public static Cliente ObtenerPorId(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Cliente.Find(id);
            }
        }
    }
}
