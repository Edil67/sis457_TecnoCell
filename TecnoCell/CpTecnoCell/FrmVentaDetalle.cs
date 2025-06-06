using CadTecnoCell;
using ClnTecnoCell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpTecnoCell
{
    public partial class FrmVentaDetalle : Form
    {
        private FrmVenta frmVenta; // Hace Referencia a FrmVenta
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
            try
            {
                if (string.IsNullOrEmpty(txtParametroCedulaIdentidadVentaDetalle.Text))
                {
                    MessageBox.Show("Por favor, ingrese un identificador de venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtParametroCedulaIdentidadVentaDetalle.Text, out int id))
                {
                    MessageBox.Show("El identificador de la venta debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la venta con sus detalles
                Venta venta = VentaCln.obtenerVentaDetalle(id);


                if (venta == null)
                {
                    MessageBox.Show("No se encontró una venta con el ID especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Mostrar los datos de la venta
                dtpFechaVentaDetalle.Text = venta.fechaRegistro.ToString("dd/MM/yyyy HH:mm:ss");
                txtInfVentaCedulaIdentidad.Text = venta.documentoCliente; // Antes: venta.tipoDocumento
                txtInfVentaUsuario.Text = venta.usuarioRegistro;

                // Mostrar los totales
                txtMontoTotalVentaDetalle.Text = "0.00";
                txtMontoPagoVentaDetalle.Text = "0.00";
                txtMontoCambioVentaDetalle.Text = "0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtParametroCedulaIdentidadVentaDetalle.Text = "";
            dtpFechaVentaDetalle.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtInfVentaCedulaIdentidad.Text = "";
            txtInfVentaUsuario.Text = "";
            txtMontoTotalVentaDetalle.Text = "0.00";
            txtMontoPagoVentaDetalle.Text = "0.00";
            txtMontoCambioVentaDetalle.Text = "0.00";
        }
    }
}
