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
                var existente = context.Cliente.Find(cliente.id);
                if (existente != null)
                {
                    existente.cedulaIdentidad = cliente.cedulaIdentidad;
                    existente.nombres = cliente.nombres;
                    existente.apellidos = cliente.apellidos;
                    existente.direccion = cliente.direccion;
                    existente.celular = cliente.celular;
                    existente.usuarioRegistro = cliente.usuarioRegistro;
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static int Eliminar(int id, string usuario)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                var cliente = context.Cliente.Find(id);
                if (cliente != null)
                {
                    cliente.estado = -1;
                    cliente.usuarioRegistro = usuario;
                    return context.SaveChanges();
                }
                return 0;
            }
        }
        public static List<Cliente> Listar()
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Cliente.Where(x => x.estado != -1).ToList();
            }
        }
        public static Cliente ObtenerUno(int id)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.Cliente.Find(id);
            }
        }
        public static List<paClienteListar_Result> ListarPorParametro(string parametro)
        {
            using (var context = new TecnoCell_dbEntities())
            {
                return context.paClienteListar(parametro).ToList();
            }
        }
    }
}
