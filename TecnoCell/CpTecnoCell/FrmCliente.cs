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
    public partial class FrmCliente : Form
    {
        private bool esNuevo = false;
        private FrmVenta frmVenta; // Hace Referencia a FrmVenta
        public FrmCliente()//FrmVenta frmVenta)
        {
            InitializeComponent();
            //this.frmVenta = frmVenta;
        }

        public void listar()
        {
            var lista = ClienteCln.listarPa(txtParametroCliente.Text);
            dgvListaCliente.DataSource = lista;
            dgvListaCliente.Columns["id"].Visible = false;
            dgvListaCliente.Columns["estado"].Visible = false;
            dgvListaCliente.Columns["cedulaIdentidad"].HeaderText = "Cedula Identidad";
            dgvListaCliente.Columns["nombres"].HeaderText="Nombres";
            dgvListaCliente.Columns["apellidos"].HeaderText = "Apellidos";
            dgvListaCliente.Columns["direccion"].HeaderText = "Dirección";
            dgvListaCliente.Columns["celular"].HeaderText = "Celular";
            dgvListaCliente.Columns["correoElectronico"].HeaderText = "Correo Electrónico";


            btnEditar.Enabled = lista.Count() > 0;
            btnEliminar.Enabled = lista.Count() > 0;

            if (lista.Count > 0) dgvListaCliente.CurrentCell = dgvListaCliente.Rows[0].Cells["cedulaIdentidad"];
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Size = new Size(732, 608);
            txtNombresCliente.KeyPress += Util.onlyLetters;
            txtCelularCliente.KeyPress += Util.onlyNumbers;
            listar();
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control como Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }
        }


        private void limpiar()
        {
            txtCedulaIdentidadCliente.Text = string.Empty;
            txtNombresCliente.Text = string.Empty;
            txtApellidosCliente.Text = string.Empty;
            txtDireccionCliente.Text = string.Empty;
            txtCorreoClienteCliente.Text = string.Empty;
            txtCelularCliente.Text = string.Empty;
        }

        private bool validar()
        {
            bool esValido = true;

            erpCedulaIdentidadCliente.SetError(txtCedulaIdentidadCliente, "");
            erpNombresCliente.SetError(txtNombresCliente, "");
            erpApellidosCliente.SetError(txtApellidosCliente, "");
            erpDireccionCliente.SetError(txtDireccionCliente, "");
            erpCorreoElectronicoCliente.SetError(txtCorreoClienteCliente, "");
            erpCelularCliente.SetError(txtCelularCliente, "");


            if (string.IsNullOrEmpty(txtCedulaIdentidadCliente.Text))
            {
                esValido = false;
                erpCedulaIdentidadCliente.SetError(txtCedulaIdentidadCliente, "El campo Cedula Identidad es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtNombresCliente.Text))
            {
                esValido = false;
                erpNombresCliente.SetError(txtNombresCliente, "El campo Nombres es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtApellidosCliente.Text))
            {
                esValido = false;
                erpApellidosCliente.SetError(txtApellidosCliente, "El campo Apellidos es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtDireccionCliente.Text))
            {
                esValido = false;
                erpDireccionCliente.SetError(txtDireccionCliente, "El campo Dirección es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtCorreoClienteCliente.Text) || !txtCorreoClienteCliente.Text.Contains("@"))
            {
                esValido = false;
                erpCorreoElectronicoCliente.SetError(txtCorreoClienteCliente, "El campo Correo Electrónico es obligatorio y debe contener '@'.");
            }
            if (string.IsNullOrEmpty(txtCelularCliente.Text) || txtCelularCliente.Text.Length < 8)
            {
                esValido = false;
                erpCelularCliente.SetError(txtCelularCliente, "El campo Celular es obligatorio y debe tener al menos 8 dígitos.");
            }
            return esValido;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(1013, 608);
            esNuevo = true;
            txtCedulaIdentidadCliente.Focus();
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Size = new Size(732, 608);
            if (validar())
            {
                var cliente = new Cliente
                {
                    cedulaIdentidad = txtCedulaIdentidadCliente.Text.Trim(),
                    nombres = txtNombresCliente.Text.Trim(),
                    apellidos = txtApellidosCliente.Text.Trim(),
                    direccion = txtDireccionCliente.Text.Trim(),
                    correoElectronico = txtCorreoClienteCliente.Text.Trim(),
                    celular = long.Parse(txtCelularCliente.Text.Trim()),
                    usuarioRegistro = "administrador" //Util.usuario.usuario1
                };

                if (esNuevo)
                {
                    if (ClienteCln.existeDocumento(cliente.cedulaIdentidad))
                    {
                        MessageBox.Show("NO SE PUEDE AGREGAR, cedulaIdentidad ya existente.", ":::TecnoCell - Mensaje :::",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cliente.fechaRegistro = DateTime.Now;
                    cliente.estado = 1;
                    ClienteCln.insertar(cliente);
                }
                else
                {
                    int index = dgvListaCliente.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dgvListaCliente.Rows[index].Cells["id"].Value);
                    var clienteExistente = ClienteCln.obtenerUno(id);

                    if (cliente.cedulaIdentidad != clienteExistente.cedulaIdentidad && ClienteCln.existeDocumento(cliente.cedulaIdentidad))
                    {
                        MessageBox.Show("NO SE PUEDE ACTUALIZAR, cedulaIdentidad ya existente.", ":::TecnoCell - Mensaje :::",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cliente.id = id;
                    ClienteCln.actualizar(cliente);
                }

                MessageBox.Show("Cliente guardado correctamente", ":::TecnoCell - Mensaje :::",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Llamar a FrmVenta para actualizar los datos del cliente creado
                //frmVenta.SetListaCliente(cliente.cedulaIdentidad, cliente.nombres);
                limpiar();
                listar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(1013, 608);
            esNuevo = false;
            int index = dgvListaCliente.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaCliente.Rows[index].Cells["id"].Value);
            var cliente = ClienteCln.obtenerUno(id);
            txtCedulaIdentidadCliente.Text = cliente.cedulaIdentidad;
            txtNombresCliente.Text = cliente.nombres;
            txtApellidosCliente.Text = cliente.apellidos;
            txtDireccionCliente.Text = cliente.direccion;
            txtCorreoClienteCliente.Text = cliente.correoElectronico;
            txtCelularCliente.Text = cliente.celular.ToString();
            txtCedulaIdentidadCliente.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvListaCliente.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaCliente.Rows[index].Cells["id"].Value);
            string cedulaIdentidad = dgvListaCliente.Rows[index].Cells["cedulaIdentidad"].Value.ToString();
            DialogResult dialog =
                MessageBox.Show($"¿Está seguro que desea dar de baja al Cliente con N° de cedulaIdentidad {cedulaIdentidad}?",
                                ":::TecnoCell - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ClienteCln.eliminar(id, "administrador");// Util.usuario.usuario1);
                listar();
                MessageBox.Show("Cliente dado de baja correctamente", ":::TecnoCell - Mensaje :::",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(732, 608);
        }

    }
}
