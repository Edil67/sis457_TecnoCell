using ClnTecnoCell;
using CadTecnoCell;
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
    public partial class FrmCategoria : Form
    {
        private bool esNuevo = false;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        public void listar()
        {
            var lista = CategoriaCln.listarPa(txtParametroCategoria.Text);
            dgvListaCategoria.DataSource = lista;
            dgvListaCategoria.Columns["id"].Visible = false;
            dgvListaCategoria.Columns["estado"].Visible = false;
            dgvListaCategoria.Columns["usuarioRegistro"].Visible = false;
            dgvListaCategoria.Columns["descripcion"].HeaderText = "Descripcion Categoría";

            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;

            if (lista.Count > 0) dgvListaCategoria.CurrentCell = dgvListaCategoria.Rows[0].Cells["descripcion"];
        }

        private void limpiar()
        {
            txtDescripcionCategoria.Text = string.Empty;
        }
        private bool validar()
        {   bool esValido = true;
            erpDescripcionCategoria.SetError(txtDescripcionCategoria, "");

            if (string.IsNullOrEmpty(txtDescripcionCategoria.Text))
            {
                erpDescripcionCategoria.SetError(txtDescripcionCategoria, "Debe ingresar una descripción de categoría.");
                esValido = false;
            }
            return esValido;
        }

       
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            Size = new Size(716, 527);
            listar();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(915, 527);
            txtDescripcionCategoria.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Size = new Size(716, 527);
            if (validar())
            {
                if (Util.usuario == null)
                {
                    MessageBox.Show("No se ha establecido un usuario. Inicie sesión primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var categoria = new Categoria();
                categoria.descripcion = txtDescripcionCategoria.Text.Trim();
                categoria.usuarioRegistro = Util.usuario.usuario1; // Asignar el usuario actual

                if (esNuevo)
                {
                    categoria.fechaRegistro = DateTime.Now;
                    categoria.estado = 1;
                    CategoriaCln.insertar(categoria);
                }
                else
                {
                    int index = dgvListaCategoria.CurrentCell.RowIndex;
                    categoria.id = Convert.ToInt32(dgvListaCategoria.Rows[index].Cells["id"].Value);
                    CategoriaCln.actualizar(categoria);
                }

                listar();
                MessageBox.Show("Categoría guardada correctamente", "::: TecnoCell - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(716, 527);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(915, 527);
            esNuevo = false;
            int index = dgvListaCategoria.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaCategoria.Rows[index].Cells["id"].Value);
            var categoria = CategoriaCln.obtenerUno(id);
            txtDescripcionCategoria.Text = categoria.descripcion;
            txtDescripcionCategoria.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvListaCategoria.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaCategoria.Rows[index].Cells["id"].Value);
            string descripcion = dgvListaCategoria.Rows[index].Cells["Descripcion"].Value.ToString();
            DialogResult dialog =
                MessageBox.Show($"¿Está seguro que desea dar de baja la Categoria con descripción {descripcion}?",
                "::: TecnoCell - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                CategoriaCln.eliminar(id, Util.usuario.usuario1);
                listar();
                MessageBox.Show("Categoria dado de baja correctamente", "::: TecnoCell - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
            listar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
