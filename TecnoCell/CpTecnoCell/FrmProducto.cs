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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Size = new Size(828, 356);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(828, 356);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(828, 491);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
