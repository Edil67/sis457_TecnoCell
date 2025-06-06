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
using static ClnTecnoCell.ProductoCln;

namespace CpTecnoCell
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cedulaIdentidad = txtCedulaIdentidadVenta.Text;

            if (string.IsNullOrWhiteSpace(cedulaIdentidad))
            {
                MessageBox.Show("Por favor, ingrese el cedula de identidad del cliente ", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new TecnoCell_dbEntities())
            {
                var cliente = context.Cliente.FirstOrDefault(c => c.cedulaIdentidad == cedulaIdentidad);

                if (cliente != null)
                {
                    txtNombreClienteVenta.Text = cliente.nombres;
                }
                else
                {
                    MessageBox.Show("El cliente no existe, puede crear un cliente si desea ", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarDocumento();
                }
            }
        }
        public void SetListaCliente(string cedulaIdentidad, string nombres)
        {
            txtCedulaIdentidadVenta.Text = cedulaIdentidad;
            txtNombreClienteVenta.Text = nombres;

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var frmCliente = new FrmCliente(this);
            frmCliente.ShowDialog();
        }
        private void limpiarDocumento()
        {
            txtCedulaIdentidadVenta.Text = string.Empty;
        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            cbxColorProductoVenta.DataSource = coloresProducto.ListaColores;

            //txtCedulaIdentidadVenta.KeyPress += Util.onlyNumbers;
            dgvListaVentas.Columns.Add("cedulaIdentidad", "Cedula Identidad Cliente");
            dgvListaVentas.Columns.Add("nombre", "Nombres");
            dgvListaVentas.Columns.Add("modelo", "Modelo");
            dgvListaVentas.Columns.Add("marca", "Marca");
            dgvListaVentas.Columns.Add("color", "Color");
            dgvListaVentas.Columns.Add("PrecioVenta", "Precio de Venta");
            dgvListaVentas.Columns.Add("Cantidad", "Cantidad");
            dgvListaVentas.Columns.Add("montoTotal", "Total");
            dgvListaVentas.Columns.Add("usuarioRegistro", "Usuario de Registro");
            dgvListaVentas.Columns.Add("fechaRegistro", "Fecha de Registro"); // Nueva columna

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmListaProducto productoFrm = new FrmListaProducto(this);
            productoFrm.ShowDialog();
        }
        public void SetListaProducto( string cedulIdentidad, string nombre, string modelo, string marca, string color,  string stock, string precioVenta)
        {
            txtCedulaIdentidadVenta.Text = cedulIdentidad;
            txtNombreProductoVenta.Text = nombre;
            txtModeloProductoVenta.Text = modelo;
            txtMarcaProductoVenta.Text = marca;
            cbxColorProductoVenta.Text = color;
            // Asignar el stock y precio de venta a los campos correspondientes     
            txtStockProductoVenta.Text = stock;
            txtPrecioProductoVenta.Text = precioVenta;
            if (int.TryParse(stock, out int stockDisponible))
            {
                nudCantidadProductoVenta.Maximum = stockDisponible;
            }
            else

                nudCantidadProductoVenta.Maximum = 1;
            
        }

        private bool validar(bool RegistroVenta = false)
        {
            bool esValido = true;
            erpNombreCliente.SetError(txtNombreClienteVenta, "");
            erpCedulaIdentidad.SetError(txtCedulaIdentidadVenta, "");
            erpNombre.SetError(txtNombreProductoVenta, "");
            erpModelo.SetError(txtModeloProductoVenta, "");
            erpMarca.SetError(txtMarcaProductoVenta, "");
            erpColor.SetError(cbxColorProductoVenta, "");
            erpCantidad.SetError(nudCantidadProductoVenta, "");
            erpPrecioVenta.SetError(txtPrecioProductoVenta, "");
            erpMontoPago.SetError(txtMontoPagoVentaDetalle, "");

            if (string.IsNullOrWhiteSpace(txtCedulaIdentidadVenta.Text))
            {
                esValido = false;
                erpCedulaIdentidad.SetError(txtCedulaIdentidadVenta, "Este campo no debe estar vacío.");
            }

            if (!RegistroVenta) // Validación para productos
            {
                if (string.IsNullOrEmpty(txtModeloProductoVenta.Text))
                {
                    esValido = false;
                    erpModelo.SetError(txtModeloProductoVenta, "El campo Modelo es obligatorio.");
                }
                if (string.IsNullOrEmpty(txtNombreProductoVenta.Text))
                {
                    esValido = false;
                    erpNombre.SetError(txtNombreProductoVenta, "El campo Nombre es obligatorio.");
                }
                if (string.IsNullOrEmpty(txtMarcaProductoVenta.Text))
                {
                    esValido = false;
                    erpMarca.SetError(txtMarcaProductoVenta, "El campo Marca es obligatorio.");
                }
                if (string.IsNullOrEmpty(cbxColorProductoVenta.Text))
                {
                    esValido = false;
                    erpColor.SetError(cbxColorProductoVenta, "Debe seleccionar un color.");
                }
                if (string.IsNullOrEmpty(txtPrecioProductoVenta.Text) || !decimal.TryParse(txtPrecioProductoVenta.Text, out _))
                {
                    esValido = false;
                    erpPrecioVenta.SetError(txtPrecioProductoVenta, "El campo Precio de Venta es obligatorio y debe ser un número válido.");
                }

                if (nudCantidadProductoVenta.Value <= 0)
                {
                    esValido = false;
                    erpCantidad.SetError(nudCantidadProductoVenta, "La cantidad debe ser mayor a cero.");
                }
            }

            if (RegistroVenta)
            {
                if (string.IsNullOrWhiteSpace(txtMontoPagoVentaDetalle.Text) || !decimal.TryParse(txtMontoPagoVentaDetalle.Text, out decimal pagaCon) || pagaCon < Convert.ToDecimal(txtMontoTotalVentaDetalle.Text))
                {
                    esValido = false;
                    erpMontoPago.SetError(txtMontoPagoVentaDetalle, "El monto de pago debe ser suficiente para cubrir el total.");
                }
            }

            return esValido;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Por favor, corrija los errores antes de agregar el producto.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtModeloProductoVenta.Text))
            {
                MessageBox.Show("Por favor, selecciona un producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = txtModeloProductoVenta.Text;
            int cantidadVenta = (int)nudCantidadProductoVenta.Value;

            using (var context = new TecnoCell_dbEntities())
            {
                var producto = context.Producto.FirstOrDefault(p => p.modelo == codigo);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal stock = producto.stock;
                if (stock <= 0)
                {
                    MessageBox.Show("El producto no tiene stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar cantidad solicitada
                if (cantidadVenta > stock)
                {
                    MessageBox.Show("La cantidad solicitada excede el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar si el producto ya existe en el DataGridView
                foreach (DataGridViewRow row in dgvListaVentas.Rows)
                {
                    if (row.Cells["Modelo"].Value?.ToString() == codigo)
                    {
                        int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        int nuevaCantidad = cantidadActual + cantidadVenta;

                        if (nuevaCantidad > stock)
                        {
                            MessageBox.Show("La cantidad total excede el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Actualizar la cantidad y el total
                        row.Cells["Cantidad"].Value = nuevaCantidad;
                        row.Cells["montototal"].Value = nuevaCantidad * producto.precioVenta;

                        // Recalcular el total a pagar
                        CalcularTotalPagar();
                        LimpiarCampos();
                        return;
                    }
                }

                // Si no existe en el DataGridView, agregarlo como un nuevo registro
                var nombre = producto.nombre;
                var modelo = producto.modelo;
                var marca = producto.marca;
                var color = producto.color;
                var precioVenta = producto.precioVenta;
                var montototal = precioVenta * cantidadVenta;

                int id = Util.usuario.id;
                if (id <= 0)
                {
                    MessageBox.Show("No se pudo identificar al empleado asociado al usuario actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var usuarioRegistro = Util.usuario.usuario1;
                var fechaRegistro = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                dgvListaVentas.Rows.Add(
                    txtCedulaIdentidadVenta.Text, // cedulaIdentidad
                    txtNombreClienteVenta.Text,   // nombre
                    modelo,                       // modelo
                    marca,                        // marca
                    color,                        // color
                    precioVenta,                  // PrecioVenta
                    cantidadVenta,                // Cantidad
                    montototal,                   // montoTotal
                    usuarioRegistro,              // usuarioRegistro
                    fechaRegistro
                );

                LimpiarCampos();
                CalcularTotalPagar();
            }
        }
        private void LimpiarCampos()
        {
            txtModeloProductoVenta.Clear();
            txtNombreProductoVenta.Clear();
            txtMarcaProductoVenta.Clear();
            txtStockProductoVenta.Clear();
            txtPrecioProductoVenta.Clear();
            nudCantidadProductoVenta.Value = 1;
        }

        private void CalcularTotalPagar()
        {
            decimal totalPagar = 0;

            foreach (DataGridViewRow row in dgvListaVentas.Rows)
            {
                if (row.Cells["montoTotal"].Value != null &&
                    decimal.TryParse(row.Cells["montoTotal"].Value.ToString(), out decimal total))
                {
                    totalPagar += total;
                }
            }

            txtMontoTotalVentaDetalle.Text = totalPagar.ToString("0.00");
        }


        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvListaVentas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListaVentas.SelectedRows)
                {
                    dgvListaVentas.Rows.RemoveAt(row.Index);
                }
                CalcularTotalPagar();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para quitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios y que haya productos en la venta
                if (string.IsNullOrEmpty(txtCedulaIdentidadVenta.Text) ||
                    string.IsNullOrEmpty(txtNombreClienteVenta.Text) ||
                    dgvListaVentas.Rows.Count == 0 ||
                    string.IsNullOrEmpty(txtMontoPagoVentaDetalle.Text) ||
                    string.IsNullOrEmpty(txtMontoCambioVentaDetalle.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos y agregue al menos un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que el usuario actual esté asociado a un empleado
                int idEmpleado = Util.usuario.id;
                if (idEmpleado <= 0)
                {
                    MessageBox.Show("No se pudo identificar al empleado asociado al usuario actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Registrar la venta
                using (var context = new TecnoCell_dbEntities())
                {
                    var venta = new Venta
                    {
                        id = idEmpleado,
                        documentoCliente = txtCedulaIdentidadVenta.Text.Trim(),
                        montoPago = decimal.Parse(txtMontoPagoVentaDetalle.Text.Trim()),
                        montoCambio = decimal.Parse(txtMontoCambioVentaDetalle.Text.Trim()),
                        montoTotal = decimal.Parse(txtMontoTotalVentaDetalle.Text.Trim()),
                        usuarioRegistro = Util.usuario.usuario1,
                        fechaRegistro = DateTime.Now,
                        estado = 1
                    };

                    context.Venta.Add(venta);
                    context.SaveChanges(); // Guardar para generar el ID de la venta

                    int idVenta = venta.id;

                    // Registrar los detalles de la venta y actualizar el stock
                    foreach (DataGridViewRow row in dgvListaVentas.Rows)
                    {
                        if (row.Cells["Modelo"].Value != null && row.Cells["Cantidad"].Value != null)
                        {
                            string codigoProducto = row.Cells["Modelo"].Value.ToString();
                            int cantidadVendida = Convert.ToInt32(row.Cells["Cantidad"].Value);

                            var producto = context.Producto.FirstOrDefault(p => p.modelo == codigoProducto);

                            if (producto != null)
                            {
                                producto.stock -= cantidadVendida;

                                if (producto.stock < 0)
                                {
                                    MessageBox.Show($"El stock del producto {producto.nombre} no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                var detalleVenta = new VentaDetalle
                                {
                                    idVenta = idVenta,
                                    idProducto = producto.id,
                                    cantidad = cantidadVendida,
                                    precioUnitario = producto.precioVenta,
                                    usuarioRegistro = Util.usuario.usuario1,
                                    fechaRegistro = DateTime.Now,
                                    estado = 1
                                };

                                context.VentaDetalle.Add(detalleVenta);
                            }
                        }
                    }

                    context.SaveChanges();

                    MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormularioVenta();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar la venta: {ex.Message}\n{ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void LimpiarFormularioVenta()
        {
            txtCedulaIdentidadVenta.Clear();
            txtNombreClienteVenta.Clear();
            txtModeloProductoVenta.Clear();
            txtNombreProductoVenta.Clear();
            txtMarcaProductoVenta.Clear();
            txtStockProductoVenta.Clear();
            txtPrecioProductoVenta.Clear();
            nudCantidadProductoVenta.Value = 1;
            txtMontoTotalVentaDetalle.Clear();
            txtMontoPagoVentaDetalle.Clear();
            txtMontoCambioVentaDetalle.Clear();
            dgvListaVentas.Rows.Clear();
        }



        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {
            var frmProducto = new FrmProducto(this);
            frmProducto.ShowDialog(); ;
        }
    }
}
