namespace CpTecnoCell
{
    partial class FrmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.gbxFechaVenta = new System.Windows.Forms.GroupBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidadVenta = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAñadirProducto = new System.Windows.Forms.Button();
            this.gbxProductoVenta = new System.Windows.Forms.GroupBox();
            this.txtCedulaIdentidadVenta = new System.Windows.Forms.TextBox();
            this.lblCedulaIdentidad = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNombreVenta = new System.Windows.Forms.Label();
            this.txtNombreVenta = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblPagoCon = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtMontoAPagar = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.gbxFechaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVenta)).BeginInit();
            this.gbxProductoVenta.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Enabled = false;
            this.dtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Location = new System.Drawing.Point(5, 22);
            this.dtpFechaVenta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaVenta.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(278, 23);
            this.dtpFechaVenta.TabIndex = 1;
            this.dtpFechaVenta.Value = new System.DateTime(2024, 6, 7, 21, 24, 35, 0);
            // 
            // gbxFechaVenta
            // 
            this.gbxFechaVenta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbxFechaVenta.Controls.Add(this.dtpFechaVenta);
            this.gbxFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFechaVenta.Location = new System.Drawing.Point(7, 51);
            this.gbxFechaVenta.Name = "gbxFechaVenta";
            this.gbxFechaVenta.Size = new System.Drawing.Size(289, 55);
            this.gbxFechaVenta.TabIndex = 146;
            this.gbxFechaVenta.TabStop = false;
            this.gbxFechaVenta.Text = "Fecha Venta";
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(97, 31);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(127, 26);
            this.txtProducto.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(5, 36);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Producto :";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(194, 67);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(94, 38);
            this.btnBuscarProducto.TabIndex = 124;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(20, 79);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(74, 18);
            this.lblModelo.TabIndex = 125;
            this.lblModelo.Text = "Modelo :";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(96, 73);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(92, 26);
            this.txtCodigoProducto.TabIndex = 126;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(617, 35);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 18);
            this.lblCantidad.TabIndex = 127;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // nudCantidadVenta
            // 
            this.nudCantidadVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudCantidadVenta.Location = new System.Drawing.Point(688, 31);
            this.nudCantidadVenta.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantidadVenta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidadVenta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadVenta.Name = "nudCantidadVenta";
            this.nudCantidadVenta.Size = new System.Drawing.Size(70, 26);
            this.nudCantidadVenta.TabIndex = 128;
            this.nudCantidadVenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(299, 81);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(114, 18);
            this.lblPrecio.TabIndex = 129;
            this.lblPrecio.Text = "Precio Venta :";
            // 
            // lblStock
            // 
            this.lblStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(543, 81);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(57, 18);
            this.lblStock.TabIndex = 130;
            this.lblStock.Text = "Stock:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(417, 77);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(122, 26);
            this.txtPrecioVenta.TabIndex = 131;
            // 
            // txtStock
            // 
            this.txtStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(604, 79);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(166, 26);
            this.txtStock.TabIndex = 132;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(310, 35);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 18);
            this.lblDescripcion.TabIndex = 133;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProducto.Location = new System.Drawing.Point(793, 7);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(68, 50);
            this.btnAgregarProducto.TabIndex = 135;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(417, 31);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(183, 26);
            this.txtDescripcion.TabIndex = 134;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuitar.Location = new System.Drawing.Point(793, 63);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(68, 50);
            this.btnQuitar.TabIndex = 136;
            this.btnQuitar.Text = "Borrar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnAñadirProducto
            // 
            this.btnAñadirProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirProducto.Location = new System.Drawing.Point(265, 26);
            this.btnAñadirProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirProducto.Name = "btnAñadirProducto";
            this.btnAñadirProducto.Size = new System.Drawing.Size(39, 33);
            this.btnAñadirProducto.TabIndex = 137;
            this.btnAñadirProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirProducto.UseVisualStyleBackColor = true;
            // 
            // gbxProductoVenta
            // 
            this.gbxProductoVenta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbxProductoVenta.Controls.Add(this.btnAñadirProducto);
            this.gbxProductoVenta.Controls.Add(this.btnQuitar);
            this.gbxProductoVenta.Controls.Add(this.txtDescripcion);
            this.gbxProductoVenta.Controls.Add(this.btnAgregarProducto);
            this.gbxProductoVenta.Controls.Add(this.lblDescripcion);
            this.gbxProductoVenta.Controls.Add(this.txtStock);
            this.gbxProductoVenta.Controls.Add(this.txtPrecioVenta);
            this.gbxProductoVenta.Controls.Add(this.lblStock);
            this.gbxProductoVenta.Controls.Add(this.lblPrecio);
            this.gbxProductoVenta.Controls.Add(this.nudCantidadVenta);
            this.gbxProductoVenta.Controls.Add(this.lblCantidad);
            this.gbxProductoVenta.Controls.Add(this.txtCodigoProducto);
            this.gbxProductoVenta.Controls.Add(this.lblModelo);
            this.gbxProductoVenta.Controls.Add(this.btnBuscarProducto);
            this.gbxProductoVenta.Controls.Add(this.lblNombre);
            this.gbxProductoVenta.Controls.Add(this.txtProducto);
            this.gbxProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProductoVenta.Location = new System.Drawing.Point(7, 173);
            this.gbxProductoVenta.Name = "gbxProductoVenta";
            this.gbxProductoVenta.Size = new System.Drawing.Size(881, 118);
            this.gbxProductoVenta.TabIndex = 148;
            this.gbxProductoVenta.TabStop = false;
            this.gbxProductoVenta.Text = "Producto";
            // 
            // txtCedulaIdentidadVenta
            // 
            this.txtCedulaIdentidadVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCedulaIdentidadVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaIdentidadVenta.Location = new System.Drawing.Point(173, 28);
            this.txtCedulaIdentidadVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedulaIdentidadVenta.Name = "txtCedulaIdentidadVenta";
            this.txtCedulaIdentidadVenta.Size = new System.Drawing.Size(275, 26);
            this.txtCedulaIdentidadVenta.TabIndex = 3;
            // 
            // lblCedulaIdentidad
            // 
            this.lblCedulaIdentidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCedulaIdentidad.AutoSize = true;
            this.lblCedulaIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaIdentidad.Location = new System.Drawing.Point(9, 32);
            this.lblCedulaIdentidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedulaIdentidad.Name = "lblCedulaIdentidad";
            this.lblCedulaIdentidad.Size = new System.Drawing.Size(160, 18);
            this.lblCedulaIdentidad.TabIndex = 4;
            this.lblCedulaIdentidad.Text = "Cédula de Identidad:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(465, 19);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(101, 41);
            this.btnBuscarCliente.TabIndex = 124;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // lblNombreVenta
            // 
            this.lblNombreVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreVenta.AutoSize = true;
            this.lblNombreVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVenta.Location = new System.Drawing.Point(16, 84);
            this.lblNombreVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreVenta.Name = "lblNombreVenta";
            this.lblNombreVenta.Size = new System.Drawing.Size(153, 18);
            this.lblNombreVenta.TabIndex = 125;
            this.lblNombreVenta.Text = "Nombre de Cliente:";
            // 
            // txtNombreVenta
            // 
            this.txtNombreVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVenta.Location = new System.Drawing.Point(173, 80);
            this.txtNombreVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreVenta.Name = "txtNombreVenta";
            this.txtNombreVenta.Size = new System.Drawing.Size(275, 26);
            this.txtNombreVenta.TabIndex = 126;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(465, 66);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregarCliente.Size = new System.Drawing.Size(101, 45);
            this.btnAgregarCliente.TabIndex = 127;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            // 
            // gbxCliente
            // 
            this.gbxCliente.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbxCliente.Controls.Add(this.btnAgregarCliente);
            this.gbxCliente.Controls.Add(this.txtNombreVenta);
            this.gbxCliente.Controls.Add(this.lblNombreVenta);
            this.gbxCliente.Controls.Add(this.btnBuscarCliente);
            this.gbxCliente.Controls.Add(this.lblCedulaIdentidad);
            this.gbxCliente.Controls.Add(this.txtCedulaIdentidadVenta);
            this.gbxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCliente.Location = new System.Drawing.Point(302, 51);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(586, 116);
            this.gbxCliente.TabIndex = 147;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(893, 47);
            this.label1.TabIndex = 144;
            this.label1.Text = "Sistema de Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(1, 356);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(885, 178);
            this.dgvVentas.TabIndex = 149;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(22, 315);
            this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(114, 18);
            this.lblTotalPagar.TabIndex = 150;
            this.lblTotalPagar.Text = "Total a Pagar:";
            // 
            // lblPagoCon
            // 
            this.lblPagoCon.AutoSize = true;
            this.lblPagoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoCon.Location = new System.Drawing.Point(281, 317);
            this.lblPagoCon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagoCon.Name = "lblPagoCon";
            this.lblPagoCon.Size = new System.Drawing.Size(123, 18);
            this.lblPagoCon.TabIndex = 151;
            this.lblPagoCon.Text = "Monto de Pago";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(548, 316);
            this.lblCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(71, 18);
            this.lblCambio.TabIndex = 152;
            this.lblCambio.Text = "Cambio:";
            // 
            // txtMontoAPagar
            // 
            this.txtMontoAPagar.Location = new System.Drawing.Point(143, 316);
            this.txtMontoAPagar.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoAPagar.Name = "txtMontoAPagar";
            this.txtMontoAPagar.Size = new System.Drawing.Size(119, 20);
            this.txtMontoAPagar.TabIndex = 153;
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(623, 315);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(119, 20);
            this.txtCambio.TabIndex = 155;
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Location = new System.Drawing.Point(412, 316);
            this.txtPagaCon.Margin = new System.Windows.Forms.Padding(4);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(119, 20);
            this.txtPagaCon.TabIndex = 154;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(776, 296);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(101, 40);
            this.btnRegistrarVenta.TabIndex = 156;
            this.btnRegistrarVenta.Text = "Registrar";
            this.btnRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(893, 546);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.txtPagaCon);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.txtMontoAPagar);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblPagoCon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.gbxProductoVenta);
            this.Controls.Add(this.gbxFechaVenta);
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: TecnoCell - Venta::";
            this.gbxFechaVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVenta)).EndInit();
            this.gbxProductoVenta.ResumeLayout(false);
            this.gbxProductoVenta.PerformLayout();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.GroupBox gbxFechaVenta;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidadVenta;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAñadirProducto;
        private System.Windows.Forms.GroupBox gbxProductoVenta;
        private System.Windows.Forms.TextBox txtCedulaIdentidadVenta;
        private System.Windows.Forms.Label lblCedulaIdentidad;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblNombreVenta;
        private System.Windows.Forms.TextBox txtNombreVenta;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblPagoCon;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtMontoAPagar;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.Button btnRegistrarVenta;
    }
}