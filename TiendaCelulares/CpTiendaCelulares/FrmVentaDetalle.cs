using CadTecnoCell;
using ClnTecnoCell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpTecnoCell
{
    public partial class FrmVentaDetalle : Form
    {
        //private FrmVenta frmVenta; // Hace Referencia a FrmVenta
        private List<Venta> ventas; // Lista de ventas obtenidas
        public FrmVentaDetalle(FrmVenta frmVenta)
        {
            InitializeComponent();
        }

        private void FrmVentaDetalle_Load(object sender, EventArgs e)
        {
            txtParametroCedulaIdentidadVentaDetalle.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtParametroCedulaIdentidadVentaDetalle.Text))
            {
                MessageBox.Show("Por favor, ingrese la cedula identidad del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Obtener el documento del cliente desde el campo de texto
            string documentoCliente = txtParametroCedulaIdentidadVentaDetalle.Text.Trim();

            // Buscar la venta por el documento del cliente
            ventas = obtenerVentasPorCliente(documentoCliente);

            if (ventas == null || !ventas.Any())
            {
                MessageBox.Show("No se encontró ninguna venta con el documento proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var primerVenta = ventas.First();
            txtInfNombreCliente.Text = primerVenta.Cliente.nombres;
            txtInfVentaCedulaIdentidad.Text = primerVenta.documentoCliente;
            txtInfVentaUsuario.Text = primerVenta.usuarioRegistro;
            dtpFechaVentaDetalle.Text = primerVenta.fechaRegistro.ToString("dd/MM/yyyy HH:mm:ss");

            // Mostrar todos los productos de todas las ventas del cliente
            var detalles = ventas
                .SelectMany(v => v.VentaDetalle.Select(d => new
                {
                    v.fechaRegistro,
                    Producto = d.Producto.nombre,
                    Modelo = d.Producto.modelo,
                    Marca = d.Producto.marca,
                    Color = d.Producto.color,
                    Cantidad = d.cantidad,
                    PrecioUnitario = d.precioUnitario,
                    Subtotal = d.cantidad * d.precioUnitario,
                    v.montoTotal,
                    v.montoPago,
                    v.montoCambio,
                    v.usuarioRegistro,
                    cedulaIdentidad = v.documentoCliente
                }))
                .ToList();

            dgvDetalleVenta.DataSource = detalles;
            dgvDetalleVenta.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            dgvDetalleVenta.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
        }


        


        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtParametroCedulaIdentidadVentaDetalle.Text = "";
            dtpFechaVentaDetalle.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtInfVentaCedulaIdentidad.Text = "";
            txtInfVentaUsuario.Text = "";
            txtInfNombreCliente.Text = "";
        }
    

        public static List<Venta> obtenerVentasPorCliente(string cedulaIdentidad)
        {
            using (var context = new LabTiendaCelularesEntities())
            {
                return context.Venta
                    .Include("Cliente")
                    .Include("VentaDetalle.Producto")
                    .Where(v => v.documentoCliente == cedulaIdentidad && v.estado != -1)
                    .ToList();
            }
        }

        private void btnNuevoRegistroVenta_Click(object sender, EventArgs e)
        {
            var frmVenta = new FrmVenta();
            frmVenta.ShowDialog();
        }

    }
}
