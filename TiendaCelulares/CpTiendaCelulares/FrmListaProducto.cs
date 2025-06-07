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
    public partial class FrmListaProducto : Form
    {
        private FrmVenta frmVenta;
        public FrmListaProducto(FrmVenta venta)
        {
            InitializeComponent();
            frmVenta = venta;
        }

        public void listar()
        {
            var lista = ProductoCln.listarPa(txtParametroProducto.Text);
            dgvLista.DataSource = lista;
            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["modelo"];
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametroProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void FrmListaProducto_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow != null)
            {
                // Obtén los datos del producto seleccionado
                string cedulaIdentidad = "";
                string nombre = dgvLista.CurrentRow.Cells["nombre"].Value.ToString();
                string modelo = dgvLista.CurrentRow.Cells["modelo"].Value.ToString();
                string marca = dgvLista.CurrentRow.Cells["marca"].Value.ToString();
                string color = dgvLista.CurrentRow.Cells["color"].Value.ToString();
                string stock = dgvLista.CurrentRow.Cells["stock"].Value.ToString();
                string precioVenta = dgvLista.CurrentRow.Cells["precioVenta"].Value.ToString();

                // Llama al método del formulario de venta
                frmVenta.SetListaProducto(cedulaIdentidad, nombre, modelo, marca, color, stock, precioVenta);
                this.Close(); // Cierra el formulario de selección
            }
        }
    }
}

