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
using static ClnTecnoCell.ProductoCln;

namespace CpTecnoCell
{
    public partial class FrmProducto : Form
    {  
        private bool esNuevo = false; 
        public FrmProducto(FrmVenta frmVenta)
        {
            InitializeComponent();
        }


        public void listar()
        {
            var lista = ProductoCln.listarPa(txtParametroProducto.Text.Trim());
            dgvListaProducto.DataSource = lista;
            dgvListaProducto.Columns["id"].Visible = false;
            dgvListaProducto.Columns["idCategoria"].Visible = false;
            dgvListaProducto.Columns["estado"].Visible = false;
            dgvListaProducto.Columns["nombre"].HeaderText = "Nombre";
            dgvListaProducto.Columns["modelo"].HeaderText = "Modelo";
            dgvListaProducto.Columns["marca"].HeaderText = "Marca";
            dgvListaProducto.Columns["color"].HeaderText = "Color";
            dgvListaProducto.Columns["descripcion"].HeaderText = "Descripción";
            dgvListaProducto.Columns["precioVenta"].HeaderText = "Precio de Venta";
            dgvListaProducto.Columns["stock"].HeaderText = "Stock";
            dgvListaProducto.Columns["categoriaDescripcion"].HeaderText = "Categoria";
            dgvListaProducto.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            dgvListaProducto.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";


            // Habilitar los botones si se encontró al menos un producto
            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;

            // Seleccionar la primera celda si hay resultados
            if (lista.Count > 0)
                dgvListaProducto.CurrentCell = dgvListaProducto.Rows[0].Cells["modelo"];
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Size = new Size(757, 608);

            cbxCategoriaProducto.DataSource = CategoriaCln.listar();
            cbxCategoriaProducto.DisplayMember = "descripcion";
            cbxCategoriaProducto.ValueMember = "id";


            cbxColorProducto.DataSource = null;
            cbxColorProducto.DataSource = coloresProducto.ListaColores;
            cbxColorProducto.SelectedItem = "Negro"; // Cambia "Negro" por el color que desees

            listar();


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(1023, 608);
            limpiar();


            cbxColorProducto.SelectedItem = "Negro";

        }

        private void limpiar()
        {
            txtNombreProducto.Text= string.Empty;
            txtModeloProducto.Text = string.Empty;
            txtMarcaProducto.Text = string.Empty;
            cbxColorProducto.SelectedItem = "Negro";
            txtDescripcionProducto.Text = string.Empty;
            txtPrecioVentaProducto.Text = string.Empty;

            nudStockProducto.Text = string.Empty;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(1023, 608);

            int index = dgvListaProducto.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaProducto.Rows[index].Cells["id"].Value);
            var producto = ProductoCln.obtenerUno(id);

            txtNombreProducto.Text = producto.nombre;
            txtModeloProducto.Text = producto.modelo;
            txtMarcaProducto.Text = producto.marca;
            cbxColorProducto.Text = producto.color;
            txtDescripcionProducto.Text = producto.descripcion;

            cbxColorProducto.SelectedItem = "Negro"; // Asignar el color seleccionado
            txtPrecioVentaProducto.Text = producto.precioVenta.ToString();
            if (producto.stock < nudStockProducto.Minimum)
                nudStockProducto.Value = nudStockProducto.Minimum;
            else if (producto.stock > nudStockProducto.Maximum)
                nudStockProducto.Value = nudStockProducto.Maximum;
            else
                nudStockProducto.Value = producto.stock;

            txtNombreProducto.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(757, 608);
            listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametroProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private bool validar()
        {
            bool esValido = true;
            erpNombre.SetError(txtNombreProducto, "");
            erpModelo.SetError(txtModeloProducto, "");
            erpMarca.SetError(txtMarcaProducto, "");
            erpColor.SetError(cbxColorProducto, "");
            erpDescripcion.SetError(txtDescripcionProducto, "");
            erpPrecioVenta.SetError(txtPrecioVentaProducto, "");
            erpStock.SetError(nudStockProducto, "");


            if (string.IsNullOrEmpty(txtNombreProducto.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombreProducto, "El campo Nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(txtModeloProducto.Text))
            {
                esValido = false;
                erpModelo.SetError(txtModeloProducto, "El campo Modelo es obligatorio");
            }
            if (string.IsNullOrEmpty(txtMarcaProducto.Text))
            {
                esValido = false;
                erpMarca.SetError(txtMarcaProducto, "El campo Marca es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxColorProducto.Text))
            {
                esValido = false;
                erpColor.SetError(cbxColorProducto, "Debe seleccionar un color");
            }
            if (string.IsNullOrEmpty(txtDescripcionProducto.Text))
            {
                esValido = false;
                erpDescripcion.SetError(txtDescripcionProducto, "El campo Descripción es obligatorio");
            }
            if (string.IsNullOrEmpty(txtPrecioVentaProducto.Text) || !decimal.TryParse(txtPrecioVentaProducto.Text, out _))
            {
                esValido = false;
                erpPrecioVenta.SetError(txtPrecioVentaProducto, "El campo Precio de Venta es obligatorio y debe ser un número válido");
            }
            if (nudStockProducto.Value < 0)
            {
                esValido = false;
                erpStock.SetError(nudStockProducto, "El campo Stock no debe ser negativo");
            }

            return esValido;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                    var producto = new Producto();
                    producto.nombre = txtNombreProducto.Text.Trim();
                    producto.modelo = txtModeloProducto.Text.Trim();
                    producto.marca = txtMarcaProducto.Text.Trim();
                    producto.color = cbxColorProducto.Text;
                    producto.descripcion = txtDescripcionProducto.Text.Trim();
                    producto.precioVenta = decimal.Parse(txtPrecioVentaProducto.Text.Trim());

                    producto.stock = (int)nudStockProducto.Value;
                    producto.usuarioRegistro =Util.usuario.usuario1;

                    producto.idCategoria = Convert.ToInt32(cbxCategoriaProducto.SelectedValue);

                    if (esNuevo)
                    {
                        producto.fechaRegistro = DateTime.Now;
                        producto.estado = 1;
                        ProductoCln.insertar(producto);
                    }
                    else
                    {
                        int index = dgvListaProducto.CurrentCell.RowIndex;
                        producto.id = Convert.ToInt32(dgvListaProducto.Rows[index].Cells["id"].Value);
                        ProductoCln.actualizar(producto);
                    }

                    listar();
                    btnCancelar.PerformClick();
                    MessageBox.Show("Producto guardado correctamente", "::: TecnoCell - Mensaje :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar(); // Solo limpia si se guardaron los datos correctamente
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvListaProducto.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaProducto.Rows[index].Cells["id"].Value); // Cambia "id" por "idProducto"
            string modelo = dgvListaProducto.Rows[index].Cells["modelo"].Value.ToString();
            DialogResult dialog =
                MessageBox.Show($"¿Está seguro que desea dar de baja al producto con modelo {modelo}?",
                "::: TecnoCell - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ProductoCln.eliminar(id, Util.usuario.usuario1);
                listar();
                MessageBox.Show("Producto dado de baja correctamente", "::: TecnoCell - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
