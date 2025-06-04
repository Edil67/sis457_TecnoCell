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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCaCategoria_Click(object sender, EventArgs e)
        {
            new FrmCategoria().ShowDialog();
        }

        private void btnCaVenta_Click(object sender, EventArgs e)
        {
            new FrmVenta().ShowDialog();
        }

        private void btnCaProductos_Click(object sender, EventArgs e)
        {
            new FrmProducto().ShowDialog();
        }

        private void btnCaCliente_Click(object sender, EventArgs e)
        {
            new FrmCliente().ShowDialog();
        }

        private void btnCaVentaDetalle_Click(object sender, EventArgs e)
        {
            new FrmVentaDetalle().ShowDialog();
        }
    }
}
