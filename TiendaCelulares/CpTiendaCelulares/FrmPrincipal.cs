﻿using System;
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
        private FrmAutenticacion frmAutenticacion;
        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.frmAutenticacion = frmAutenticacion;
        }
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
            var frmProducto = new FrmVenta();
            new FrmProducto(frmProducto).ShowDialog();
        }

        private void btnCaCliente_Click(object sender, EventArgs e)
        {   var frmVenta = new FrmVenta();
            new FrmCliente(frmVenta).ShowDialog();
        }

        private void btnCaVentaDetalle_Click(object sender, EventArgs e)
        {
            var frmVenta = new FrmVenta();
            new FrmVentaDetalle(frmVenta).ShowDialog();
        }
    }
}
