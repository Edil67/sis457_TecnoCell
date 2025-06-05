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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.gbxFechaVenta = new System.Windows.Forms.GroupBox();
            this.txtNombreProductoVenta = new System.Windows.Forms.TextBox();
            this.lblNombreProductoVenta = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModeloProductoVenta = new System.Windows.Forms.TextBox();
            this.lblCantidadProductoVenta = new System.Windows.Forms.Label();
            this.nudCantidadProductoVenta = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioProductoVenta = new System.Windows.Forms.Label();
            this.lblStockProductoVenta = new System.Windows.Forms.Label();
            this.txtPrecioProductoVenta = new System.Windows.Forms.TextBox();
            this.txtStockProductoVenta = new System.Windows.Forms.TextBox();
            this.lblMarcaProductoVenta = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtMarcaProductoVenta = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAñadirProducto = new System.Windows.Forms.Button();
            this.gbxProductoVenta = new System.Windows.Forms.GroupBox();
            this.txtCedulaIdentidadVenta = new System.Windows.Forms.TextBox();
            this.lblCedulaIdentidadCLienteVenta = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNombreClienteVenta = new System.Windows.Forms.Label();
            this.txtNombreClienteVenta = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.gbxClienteVenta = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaVentas = new System.Windows.Forms.DataGridView();
            this.lblMontoTotalVentaDetalle = new System.Windows.Forms.Label();
            this.lblMontoPagoVentaDetalle = new System.Windows.Forms.Label();
            this.lblCMontoCambiotxtMontoTotalVentaDetalle = new System.Windows.Forms.Label();
            this.txtMontoTotalVentaDetalle = new System.Windows.Forms.TextBox();
            this.txtMontoCambioVentaDetalle = new System.Windows.Forms.TextBox();
            this.txtMontoPagoVentaDetalle = new System.Windows.Forms.TextBox();
            this.btnRegistrarVentaDetalle = new System.Windows.Forms.Button();
            this.lblColorProductoVenta = new System.Windows.Forms.Label();
            this.cbxColorProductoVenta = new System.Windows.Forms.ComboBox();
            this.erpCantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpModelo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpColor = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPrecioVenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCedulaIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNombreCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpMontoPago = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxFechaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProductoVenta)).BeginInit();
            this.gbxProductoVenta.SuspendLayout();
            this.gbxClienteVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombreCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMontoPago)).BeginInit();
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
            // txtNombreProductoVenta
            // 
            this.txtNombreProductoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProductoVenta.Location = new System.Drawing.Point(83, 31);
            this.txtNombreProductoVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProductoVenta.Name = "txtNombreProductoVenta";
            this.txtNombreProductoVenta.Size = new System.Drawing.Size(127, 26);
            this.txtNombreProductoVenta.TabIndex = 3;
            // 
            // lblNombreProductoVenta
            // 
            this.lblNombreProductoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreProductoVenta.AutoSize = true;
            this.lblNombreProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProductoVenta.Location = new System.Drawing.Point(5, 36);
            this.lblNombreProductoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProductoVenta.Name = "lblNombreProductoVenta";
            this.lblNombreProductoVenta.Size = new System.Drawing.Size(73, 18);
            this.lblNombreProductoVenta.TabIndex = 4;
            this.lblNombreProductoVenta.Text = "Nombre:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(193, 65);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(94, 38);
            this.btnBuscarProducto.TabIndex = 124;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(4, 77);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(74, 18);
            this.lblModelo.TabIndex = 125;
            this.lblModelo.Text = "Modelo :";
            // 
            // txtModeloProductoVenta
            // 
            this.txtModeloProductoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModeloProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloProductoVenta.Location = new System.Drawing.Point(82, 71);
            this.txtModeloProductoVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtModeloProductoVenta.Name = "txtModeloProductoVenta";
            this.txtModeloProductoVenta.Size = new System.Drawing.Size(92, 26);
            this.txtModeloProductoVenta.TabIndex = 126;
            // 
            // lblCantidadProductoVenta
            // 
            this.lblCantidadProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCantidadProductoVenta.AutoSize = true;
            this.lblCantidadProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProductoVenta.Location = new System.Drawing.Point(567, 77);
            this.lblCantidadProductoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadProductoVenta.Name = "lblCantidadProductoVenta";
            this.lblCantidadProductoVenta.Size = new System.Drawing.Size(79, 18);
            this.lblCantidadProductoVenta.TabIndex = 127;
            this.lblCantidadProductoVenta.Text = "Cantidad:";
            // 
            // nudCantidadProductoVenta
            // 
            this.nudCantidadProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudCantidadProductoVenta.Location = new System.Drawing.Point(638, 73);
            this.nudCantidadProductoVenta.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantidadProductoVenta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidadProductoVenta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadProductoVenta.Name = "nudCantidadProductoVenta";
            this.nudCantidadProductoVenta.Size = new System.Drawing.Size(70, 26);
            this.nudCantidadProductoVenta.TabIndex = 128;
            this.nudCantidadProductoVenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrecioProductoVenta
            // 
            this.lblPrecioProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecioProductoVenta.AutoSize = true;
            this.lblPrecioProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProductoVenta.Location = new System.Drawing.Point(299, 75);
            this.lblPrecioProductoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioProductoVenta.Name = "lblPrecioProductoVenta";
            this.lblPrecioProductoVenta.Size = new System.Drawing.Size(114, 18);
            this.lblPrecioProductoVenta.TabIndex = 129;
            this.lblPrecioProductoVenta.Text = "Precio Venta :";
            // 
            // lblStockProductoVenta
            // 
            this.lblStockProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStockProductoVenta.AutoSize = true;
            this.lblStockProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockProductoVenta.Location = new System.Drawing.Point(651, 34);
            this.lblStockProductoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockProductoVenta.Name = "lblStockProductoVenta";
            this.lblStockProductoVenta.Size = new System.Drawing.Size(57, 18);
            this.lblStockProductoVenta.TabIndex = 130;
            this.lblStockProductoVenta.Text = "Stock:";
            // 
            // txtPrecioProductoVenta
            // 
            this.txtPrecioProductoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProductoVenta.Location = new System.Drawing.Point(417, 71);
            this.txtPrecioProductoVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioProductoVenta.Name = "txtPrecioProductoVenta";
            this.txtPrecioProductoVenta.Size = new System.Drawing.Size(122, 26);
            this.txtPrecioProductoVenta.TabIndex = 131;
            // 
            // txtStockProductoVenta
            // 
            this.txtStockProductoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockProductoVenta.Location = new System.Drawing.Point(712, 32);
            this.txtStockProductoVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockProductoVenta.Name = "txtStockProductoVenta";
            this.txtStockProductoVenta.Size = new System.Drawing.Size(58, 26);
            this.txtStockProductoVenta.TabIndex = 132;
            // 
            // lblMarcaProductoVenta
            // 
            this.lblMarcaProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMarcaProductoVenta.AutoSize = true;
            this.lblMarcaProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaProductoVenta.Location = new System.Drawing.Point(299, 36);
            this.lblMarcaProductoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarcaProductoVenta.Name = "lblMarcaProductoVenta";
            this.lblMarcaProductoVenta.Size = new System.Drawing.Size(60, 18);
            this.lblMarcaProductoVenta.TabIndex = 133;
            this.lblMarcaProductoVenta.Text = "Marca:";
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
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtMarcaProductoVenta
            // 
            this.txtMarcaProductoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarcaProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaProductoVenta.Location = new System.Drawing.Point(363, 30);
            this.txtMarcaProductoVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarcaProductoVenta.Name = "txtMarcaProductoVenta";
            this.txtMarcaProductoVenta.Size = new System.Drawing.Size(133, 26);
            this.txtMarcaProductoVenta.TabIndex = 134;
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
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAñadirProducto
            // 
            this.btnAñadirProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirProducto.Location = new System.Drawing.Point(230, 27);
            this.btnAñadirProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirProducto.Name = "btnAñadirProducto";
            this.btnAñadirProducto.Size = new System.Drawing.Size(39, 33);
            this.btnAñadirProducto.TabIndex = 137;
            this.btnAñadirProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirProducto.UseVisualStyleBackColor = true;
            this.btnAñadirProducto.Click += new System.EventHandler(this.btnAñadirProducto_Click);
            // 
            // gbxProductoVenta
            // 
            this.gbxProductoVenta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbxProductoVenta.Controls.Add(this.cbxColorProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.lblColorProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.btnAñadirProducto);
            this.gbxProductoVenta.Controls.Add(this.btnQuitar);
            this.gbxProductoVenta.Controls.Add(this.txtMarcaProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.btnAgregarProducto);
            this.gbxProductoVenta.Controls.Add(this.lblMarcaProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.txtStockProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.txtPrecioProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.lblStockProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.lblPrecioProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.nudCantidadProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.lblCantidadProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.txtModeloProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.lblModelo);
            this.gbxProductoVenta.Controls.Add(this.btnBuscarProducto);
            this.gbxProductoVenta.Controls.Add(this.lblNombreProductoVenta);
            this.gbxProductoVenta.Controls.Add(this.txtNombreProductoVenta);
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
            // lblCedulaIdentidadCLienteVenta
            // 
            this.lblCedulaIdentidadCLienteVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCedulaIdentidadCLienteVenta.AutoSize = true;
            this.lblCedulaIdentidadCLienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaIdentidadCLienteVenta.Location = new System.Drawing.Point(9, 32);
            this.lblCedulaIdentidadCLienteVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedulaIdentidadCLienteVenta.Name = "lblCedulaIdentidadCLienteVenta";
            this.lblCedulaIdentidadCLienteVenta.Size = new System.Drawing.Size(160, 18);
            this.lblCedulaIdentidadCLienteVenta.TabIndex = 4;
            this.lblCedulaIdentidadCLienteVenta.Text = "Cédula de Identidad:";
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
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblNombreClienteVenta
            // 
            this.lblNombreClienteVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreClienteVenta.AutoSize = true;
            this.lblNombreClienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClienteVenta.Location = new System.Drawing.Point(16, 84);
            this.lblNombreClienteVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreClienteVenta.Name = "lblNombreClienteVenta";
            this.lblNombreClienteVenta.Size = new System.Drawing.Size(153, 18);
            this.lblNombreClienteVenta.TabIndex = 125;
            this.lblNombreClienteVenta.Text = "Nombre de Cliente:";
            // 
            // txtNombreClienteVenta
            // 
            this.txtNombreClienteVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreClienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClienteVenta.Location = new System.Drawing.Point(173, 80);
            this.txtNombreClienteVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreClienteVenta.Name = "txtNombreClienteVenta";
            this.txtNombreClienteVenta.Size = new System.Drawing.Size(275, 26);
            this.txtNombreClienteVenta.TabIndex = 126;
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
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // gbxClienteVenta
            // 
            this.gbxClienteVenta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbxClienteVenta.Controls.Add(this.btnAgregarCliente);
            this.gbxClienteVenta.Controls.Add(this.txtNombreClienteVenta);
            this.gbxClienteVenta.Controls.Add(this.lblNombreClienteVenta);
            this.gbxClienteVenta.Controls.Add(this.btnBuscarCliente);
            this.gbxClienteVenta.Controls.Add(this.lblCedulaIdentidadCLienteVenta);
            this.gbxClienteVenta.Controls.Add(this.txtCedulaIdentidadVenta);
            this.gbxClienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxClienteVenta.Location = new System.Drawing.Point(302, 51);
            this.gbxClienteVenta.Name = "gbxClienteVenta";
            this.gbxClienteVenta.Size = new System.Drawing.Size(586, 116);
            this.gbxClienteVenta.TabIndex = 147;
            this.gbxClienteVenta.TabStop = false;
            this.gbxClienteVenta.Text = "Cliente";
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
            // dgvListaVentas
            // 
            this.dgvListaVentas.AllowUserToAddRows = false;
            this.dgvListaVentas.AllowUserToDeleteRows = false;
            this.dgvListaVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaVentas.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVentas.Location = new System.Drawing.Point(1, 356);
            this.dgvListaVentas.MultiSelect = false;
            this.dgvListaVentas.Name = "dgvListaVentas";
            this.dgvListaVentas.ReadOnly = true;
            this.dgvListaVentas.RowHeadersWidth = 51;
            this.dgvListaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaVentas.Size = new System.Drawing.Size(885, 178);
            this.dgvListaVentas.TabIndex = 149;
            // 
            // lblMontoTotalVentaDetalle
            // 
            this.lblMontoTotalVentaDetalle.AutoSize = true;
            this.lblMontoTotalVentaDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoTotalVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalVentaDetalle.Location = new System.Drawing.Point(22, 315);
            this.lblMontoTotalVentaDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoTotalVentaDetalle.Name = "lblMontoTotalVentaDetalle";
            this.lblMontoTotalVentaDetalle.Size = new System.Drawing.Size(114, 18);
            this.lblMontoTotalVentaDetalle.TabIndex = 150;
            this.lblMontoTotalVentaDetalle.Text = "Total a Pagar:";
            // 
            // lblMontoPagoVentaDetalle
            // 
            this.lblMontoPagoVentaDetalle.AutoSize = true;
            this.lblMontoPagoVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPagoVentaDetalle.Location = new System.Drawing.Point(250, 317);
            this.lblMontoPagoVentaDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoPagoVentaDetalle.Name = "lblMontoPagoVentaDetalle";
            this.lblMontoPagoVentaDetalle.Size = new System.Drawing.Size(123, 18);
            this.lblMontoPagoVentaDetalle.TabIndex = 151;
            this.lblMontoPagoVentaDetalle.Text = "Monto de Pago";
            // 
            // lblCMontoCambiotxtMontoTotalVentaDetalle
            // 
            this.lblCMontoCambiotxtMontoTotalVentaDetalle.AutoSize = true;
            this.lblCMontoCambiotxtMontoTotalVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMontoCambiotxtMontoTotalVentaDetalle.Location = new System.Drawing.Point(521, 318);
            this.lblCMontoCambiotxtMontoTotalVentaDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCMontoCambiotxtMontoTotalVentaDetalle.Name = "lblCMontoCambiotxtMontoTotalVentaDetalle";
            this.lblCMontoCambiotxtMontoTotalVentaDetalle.Size = new System.Drawing.Size(71, 18);
            this.lblCMontoCambiotxtMontoTotalVentaDetalle.TabIndex = 152;
            this.lblCMontoCambiotxtMontoTotalVentaDetalle.Text = "Cambio:";
            // 
            // txtMontoTotalVentaDetalle
            // 
            this.txtMontoTotalVentaDetalle.Location = new System.Drawing.Point(143, 316);
            this.txtMontoTotalVentaDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotalVentaDetalle.Name = "txtMontoTotalVentaDetalle";
            this.txtMontoTotalVentaDetalle.Size = new System.Drawing.Size(91, 20);
            this.txtMontoTotalVentaDetalle.TabIndex = 153;
            // 
            // txtMontoCambioVentaDetalle
            // 
            this.txtMontoCambioVentaDetalle.Location = new System.Drawing.Point(596, 317);
            this.txtMontoCambioVentaDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoCambioVentaDetalle.Name = "txtMontoCambioVentaDetalle";
            this.txtMontoCambioVentaDetalle.Size = new System.Drawing.Size(119, 20);
            this.txtMontoCambioVentaDetalle.TabIndex = 155;
            // 
            // txtMontoPagoVentaDetalle
            // 
            this.txtMontoPagoVentaDetalle.Location = new System.Drawing.Point(381, 316);
            this.txtMontoPagoVentaDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoPagoVentaDetalle.Name = "txtMontoPagoVentaDetalle";
            this.txtMontoPagoVentaDetalle.Size = new System.Drawing.Size(119, 20);
            this.txtMontoPagoVentaDetalle.TabIndex = 154;
            // 
            // btnRegistrarVentaDetalle
            // 
            this.btnRegistrarVentaDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrarVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVentaDetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrarVentaDetalle.Location = new System.Drawing.Point(739, 311);
            this.btnRegistrarVentaDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarVentaDetalle.Name = "btnRegistrarVentaDetalle";
            this.btnRegistrarVentaDetalle.Size = new System.Drawing.Size(101, 40);
            this.btnRegistrarVentaDetalle.TabIndex = 156;
            this.btnRegistrarVentaDetalle.Text = "Registrar";
            this.btnRegistrarVentaDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarVentaDetalle.UseVisualStyleBackColor = true;
            this.btnRegistrarVentaDetalle.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // lblColorProductoVenta
            // 
            this.lblColorProductoVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblColorProductoVenta.AutoSize = true;
            this.lblColorProductoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorProductoVenta.Location = new System.Drawing.Point(514, 35);
            this.lblColorProductoVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColorProductoVenta.Name = "lblColorProductoVenta";
            this.lblColorProductoVenta.Size = new System.Drawing.Size(55, 18);
            this.lblColorProductoVenta.TabIndex = 138;
            this.lblColorProductoVenta.Text = "Color:";
            // 
            // cbxColorProductoVenta
            // 
            this.cbxColorProductoVenta.FormattingEnabled = true;
            this.cbxColorProductoVenta.Location = new System.Drawing.Point(570, 28);
            this.cbxColorProductoVenta.Name = "cbxColorProductoVenta";
            this.cbxColorProductoVenta.Size = new System.Drawing.Size(71, 28);
            this.cbxColorProductoVenta.TabIndex = 139;
            // 
            // erpCantidad
            // 
            this.erpCantidad.ContainerControl = this;
            // 
            // erpNombre
            // 
            this.erpNombre.ContainerControl = this;
            // 
            // erpModelo
            // 
            this.erpModelo.ContainerControl = this;
            // 
            // erpMarca
            // 
            this.erpMarca.ContainerControl = this;
            // 
            // erpColor
            // 
            this.erpColor.ContainerControl = this;
            // 
            // erpPrecioVenta
            // 
            this.erpPrecioVenta.ContainerControl = this;
            // 
            // erpCedulaIdentidad
            // 
            this.erpCedulaIdentidad.ContainerControl = this;
            // 
            // erpNombreCliente
            // 
            this.erpNombreCliente.ContainerControl = this;
            // 
            // erpMontoPago
            // 
            this.erpMontoPago.ContainerControl = this;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(893, 546);
            this.Controls.Add(this.btnRegistrarVentaDetalle);
            this.Controls.Add(this.txtMontoPagoVentaDetalle);
            this.Controls.Add(this.txtMontoCambioVentaDetalle);
            this.Controls.Add(this.txtMontoTotalVentaDetalle);
            this.Controls.Add(this.lblCMontoCambiotxtMontoTotalVentaDetalle);
            this.Controls.Add(this.lblMontoPagoVentaDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMontoTotalVentaDetalle);
            this.Controls.Add(this.dgvListaVentas);
            this.Controls.Add(this.gbxClienteVenta);
            this.Controls.Add(this.gbxProductoVenta);
            this.Controls.Add(this.gbxFechaVenta);
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: TecnoCell - Venta::";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.Click += new System.EventHandler(this.FrmVenta_Load);
            this.gbxFechaVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProductoVenta)).EndInit();
            this.gbxProductoVenta.ResumeLayout(false);
            this.gbxProductoVenta.PerformLayout();
            this.gbxClienteVenta.ResumeLayout(false);
            this.gbxClienteVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombreCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMontoPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.GroupBox gbxFechaVenta;
        private System.Windows.Forms.TextBox txtNombreProductoVenta;
        private System.Windows.Forms.Label lblNombreProductoVenta;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModeloProductoVenta;
        private System.Windows.Forms.Label lblCantidadProductoVenta;
        private System.Windows.Forms.NumericUpDown nudCantidadProductoVenta;
        private System.Windows.Forms.Label lblPrecioProductoVenta;
        private System.Windows.Forms.Label lblStockProductoVenta;
        private System.Windows.Forms.TextBox txtPrecioProductoVenta;
        private System.Windows.Forms.TextBox txtStockProductoVenta;
        private System.Windows.Forms.Label lblMarcaProductoVenta;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtMarcaProductoVenta;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAñadirProducto;
        private System.Windows.Forms.GroupBox gbxProductoVenta;
        private System.Windows.Forms.TextBox txtCedulaIdentidadVenta;
        private System.Windows.Forms.Label lblCedulaIdentidadCLienteVenta;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblNombreClienteVenta;
        private System.Windows.Forms.TextBox txtNombreClienteVenta;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.GroupBox gbxClienteVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaVentas;
        private System.Windows.Forms.Label lblMontoTotalVentaDetalle;
        private System.Windows.Forms.Label lblMontoPagoVentaDetalle;
        private System.Windows.Forms.Label lblCMontoCambiotxtMontoTotalVentaDetalle;
        private System.Windows.Forms.TextBox txtMontoTotalVentaDetalle;
        private System.Windows.Forms.TextBox txtMontoCambioVentaDetalle;
        private System.Windows.Forms.TextBox txtMontoPagoVentaDetalle;
        private System.Windows.Forms.Button btnRegistrarVentaDetalle;
        private System.Windows.Forms.Label lblColorProductoVenta;
        private System.Windows.Forms.ComboBox cbxColorProductoVenta;
        private System.Windows.Forms.ErrorProvider erpCantidad;
        private System.Windows.Forms.ErrorProvider erpNombre;
        private System.Windows.Forms.ErrorProvider erpModelo;
        private System.Windows.Forms.ErrorProvider erpMarca;
        private System.Windows.Forms.ErrorProvider erpColor;
        private System.Windows.Forms.ErrorProvider erpPrecioVenta;
        private System.Windows.Forms.ErrorProvider erpCedulaIdentidad;
        private System.Windows.Forms.ErrorProvider erpNombreCliente;
        private System.Windows.Forms.ErrorProvider erpMontoPago;
    }
}