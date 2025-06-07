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
        public static int insertar(Cliente cliente)
        {
            using (var context = new LabTiendaCelularesEntities())
            {
                bool existe = context.Cliente.Any(c => c.cedulaIdentidad == cliente.cedulaIdentidad && c.estado != -1);
                if (existe)
                {
                    throw new Exception("Ya existe un cliente con ese NIT/CI.");
                }

                context.Cliente.Add(cliente);
                context.SaveChanges();
                return cliente.id;
            }
        }
        public static int actualizar(Cliente cliente)
        {
            using (var context = new LabTiendaCelularesEntities())
            {
                // Validar duplicidad antes de actualizar
                if (context.Cliente.Any(c => c.cedulaIdentidad == cliente.cedulaIdentidad && c.id != cliente.id && c.estado != -1))
                {
                    throw new InvalidOperationException("Ya existe un cliente con la misma cédula de identidad.");
                }
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
        public static int eliminar(int id, string usuario)
        {
            using (var context = new LabTiendaCelularesEntities())
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
        public static List<Cliente> listar()
        {
            using (var context = new LabTiendaCelularesEntities())
            {
                return context.Cliente.Where(x => x.estado != -1).ToList();
            }
        }
        public static Cliente obtenerUno(int id)
        {
            using (var context = new LabTiendaCelularesEntities())
            {
                return context.Cliente.Find(id);
            }
        }
        public static List<paClienteListar_Result> listarPa(string parametro)
        {
            using (var context = new LabTiendaCelularesEntities())
            {
                return context.paClienteListar(parametro).ToList();
            }
        }

        public static bool existeDocumento(string cedulaidentidad)
        {
            using (var context = new LabTiendaCelularesEntities())
            {
                return context.Cliente.Any(c => c.cedulaIdentidad == cedulaidentidad && c.estado != -1);
            }
        }
    }
}
