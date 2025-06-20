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

            using (var context = new LabTiendaCelularesEntities())
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
            dgvListaVentas.Columns.Add("usuarioRegistro", "Usuario Registro");
            dgvListaVentas.Columns.Add("fechaRegistro", "Fecha Registro"); // Nueva columna

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmListaProducto productoFrm = new FrmListaProducto(this);
            productoFrm.ShowDialog();
        }
        public void SetListaProducto(string cedulIdentidad, string nombre, string modelo, string marca, string color, string stock, string precioVenta)
        {
            txtCedulaIdentidadVenta.Text = cedulIdentidad;
            txtNombreProductoVenta.Text = nombre;
            txtModeloProductoVenta.Text = modelo;
            txtMarcaProductoVenta.Text = marca;
            cbxColorProductoVenta.Text = color;
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
            erpMontoCambio.SetError(txtMontoCambioVentaDetalle, "");
            erpMontoTotal.SetError(txtMontoTotalVentaDetalle, "");

            // Solo valida la cédula y el nombre del cliente si es para registrar la venta
            if (RegistroVenta)
            {
                if (string.IsNullOrWhiteSpace(txtCedulaIdentidadVenta.Text))
                {
                    esValido = false;
                    erpCedulaIdentidad.SetError(txtCedulaIdentidadVenta, "Este campo no debe estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(txtNombreClienteVenta.Text))
                {
                    esValido = false;
                    erpNombreCliente.SetError(txtNombreClienteVenta, "Este campo no debe estar vacío.");
                }
            }

            // Validación para productos (siempre que se agregue un producto)
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

            // Validación de pago solo al registrar la venta
            if (RegistroVenta)
            {
                if (string.IsNullOrWhiteSpace(txtMontoPagoVentaDetalle.Text) ||
                    !decimal.TryParse(txtMontoPagoVentaDetalle.Text, out decimal pagaCon) ||
                    pagaCon < Convert.ToDecimal(txtMontoTotalVentaDetalle.Text))
                {
                    esValido = false;
                    erpMontoPago.SetError(txtMontoPagoVentaDetalle, "El monto de pago debe ser suficiente para cubrir el total.");
                }
                if (string.IsNullOrWhiteSpace(txtMontoCambioVentaDetalle.Text) ||
                    !decimal.TryParse(txtMontoCambioVentaDetalle.Text, out _))
                {
                    esValido = false;
                    erpMontoCambio.SetError(txtMontoCambioVentaDetalle, "El campo Monto Cambio es obligatorio y debe ser un número válido.");
                }
                if (string.IsNullOrWhiteSpace(txtMontoTotalVentaDetalle.Text) ||
                    !decimal.TryParse(txtMontoTotalVentaDetalle.Text, out _))
                {
                    esValido = false;
                    erpMontoTotal.SetError(txtMontoTotalVentaDetalle, "El campo Monto Total es obligatorio y debe ser un número válido.");
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

            using (var context = new LabTiendaCelularesEntities())
            {
                var producto = context.Producto.FirstOrDefault(p => p.modelo == codigo);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ALERTA DE STOCK IGUAL A CERO
                if (producto.stock == 0)
                {
                    MessageBox.Show("El producto seleccionado no tiene stock disponible.", "Stock agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int stock = producto.stock;
                if (stock < 0)
                {
                    MessageBox.Show("El producto tiene stock negativo, verifique el inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        row.Cells["montoTotal"].Value = nuevaCantidad * producto.precioVenta;

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
                var montoTotal = precioVenta * cantidadVenta;

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
                    montoTotal,                   // montoTotal
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
            // monot cambioy monto total
            txtMontoPagoVentaDetalle.Clear();
            txtMontoCambioVentaDetalle.Clear();
            txtMontoTotalVentaDetalle.Clear();

            // Recorremos las filas del DataGridView y sumamos los montos totales
            if (dgvListaVentas.Rows.Count == 0)
            {
                txtMontoTotalVentaDetalle.Text = "0.00";
                return;
            }   


            foreach (DataGridViewRow row in dgvListaVentas.Rows)
            {
                if (row.Cells["montoTotal"].Value != null &&
                    decimal.TryParse(row.Cells["montoTotal"].Value.ToString(), out decimal total))
                {
                    totalPagar += total;
                }
            }
            //calcular automaticamente el cambio 

            txtMontoTotalVentaDetalle.Text = totalPagar.ToString("0.00");
            if (decimal.TryParse(txtMontoPagoVentaDetalle.Text, out decimal montoPago) && montoPago >= totalPagar)
            {
                decimal cambio = montoPago - totalPagar;
                txtMontoCambioVentaDetalle.Text = cambio.ToString("0.00");
            }
            else
            {
                txtMontoCambioVentaDetalle.Text = "0.00"; // Si no hay pago o es insuficiente, el cambio es 0
            }

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
            using (var context = new LabTiendaCelularesEntities())
            {
                // Buscar el cliente por cédula de identidad
                var cliente = context.Cliente.FirstOrDefault(c => c.cedulaIdentidad == txtCedulaIdentidadVenta.Text.Trim());
                if (cliente == null)
                {
                    MessageBox.Show("El cliente no existe. Debe registrar el cliente antes de realizar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var venta = new Venta
                {
                    idCliente = cliente.id,
                    idUsuario = idEmpleado,
                    documentoCliente = txtCedulaIdentidadVenta.Text.Trim(),
                    montoPago = decimal.Parse(txtMontoPagoVentaDetalle.Text.Trim()),
                    montoCambio = decimal.Parse(txtMontoCambioVentaDetalle.Text.Trim()),
                    montoTotal = decimal.Parse(txtMontoTotalVentaDetalle.Text.Trim()),
                    usuarioRegistro = Util.usuario.usuario1,
                    fechaRegistro = DateTime.Now,
                    estado = 1
                };

                context.Venta.Add(venta);
                context.SaveChanges(); // Aquí se guarda la venta y se genera el IdVenta

                int idVenta = venta.id;

                foreach (DataGridViewRow row in dgvListaVentas.Rows)
                {
                    if (row.Cells["Modelo"].Value != null && row.Cells["Cantidad"].Value != null)
                    {
                        string modelo = row.Cells["Modelo"].Value.ToString();
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        var producto = context.Producto.FirstOrDefault(p => p.modelo == modelo);
                        if (producto == null)
                        {
                            MessageBox.Show($"Producto {modelo} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Actualizar stock
                        producto.stock -= cantidad;
                        if (producto.stock == 1)
                        {
                            MessageBox.Show($"El stock del producto {producto.nombre} esta bajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Crear el detalle de venta
                        var detalle = new VentaDetalle
                        {
                            idVenta = idVenta,
                            idProducto = producto.id,
                            cantidad = cantidad,
                            precioUnitario = producto.precioVenta,
                            usuarioRegistro = Util.usuario.usuario1,
                            fechaRegistro = DateTime.Now,
                            estado = 1
                        };

                        context.VentaDetalle.Add(detalle);
                    }
                }

                // Guardar los detalles y los cambios de stock
                context.SaveChanges();

                MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormularioVenta();
            }
        }

        private void LimpiarFormularioVenta()
        {
            txtModeloProductoVenta.Clear();
            txtNombreProductoVenta.Clear();
            txtMarcaProductoVenta.Clear();
            txtStockProductoVenta.Clear();
            txtPrecioProductoVenta.Clear();
            nudCantidadProductoVenta.Value = 1;
            txtMontoTotalVentaDetalle.Clear();
            txtMontoPagoVentaDetalle.Clear();
            txtMontoCambioVentaDetalle.Clear();
        }

        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {
            var frmProducto = new FrmProducto(this);
            frmProducto.ShowDialog(); ;
        }
    }
}
