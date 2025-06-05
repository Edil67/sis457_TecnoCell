namespace CpTecnoCell
{
    partial class FrmProducto
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
            this.txtPrecioVentaProducto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbxColorProducto = new System.Windows.Forms.ComboBox();
            this.lblColorProducto = new System.Windows.Forms.Label();
            this.lblPrecioVentaProducto = new System.Windows.Forms.Label();
            this.lblStockProducto = new System.Windows.Forms.Label();
            this.lblTituloDetalleProducto = new System.Windows.Forms.Label();
            this.dgvListaProducto = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.nudStockProducto = new System.Windows.Forms.NumericUpDown();
            this.txtParametroProducto = new System.Windows.Forms.TextBox();
            this.fondo = new System.Windows.Forms.Label();
            this.lblDescripcionProducto = new System.Windows.Forms.Label();
            this.lblModeloProducto = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.gbxListaProducto = new System.Windows.Forms.GroupBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtModeloProducto = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMarcaProducto = new System.Windows.Forms.Label();
            this.txtMarcaProducto = new System.Windows.Forms.TextBox();
            this.erpNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpModelo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpColor = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPrecioVenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockProducto)).BeginInit();
            this.gbxListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpStock)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrecioVentaProducto
            // 
            this.txtPrecioVentaProducto.Location = new System.Drawing.Point(760, 385);
            this.txtPrecioVentaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVentaProducto.Name = "txtPrecioVentaProducto";
            this.txtPrecioVentaProducto.Size = new System.Drawing.Size(226, 20);
            this.txtPrecioVentaProducto.TabIndex = 176;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(636, 80);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 31);
            this.btnBuscar.TabIndex = 175;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(887, 514);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 42);
            this.btnCancelar.TabIndex = 174;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(762, 514);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 42);
            this.btnGuardar.TabIndex = 173;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(319, 515);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 47);
            this.btnEliminar.TabIndex = 172;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(470, 515);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 47);
            this.btnCerrar.TabIndex = 171;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(201, 515);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(93, 47);
            this.btnEditar.TabIndex = 170;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cbxColorProducto
            // 
            this.cbxColorProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxColorProducto.FormattingEnabled = true;
            this.cbxColorProducto.Items.AddRange(new object[] {
            "Blanco",
            "Negro",
            "Azul",
            "Azul Marino",
            "Gris"});
            this.cbxColorProducto.Location = new System.Drawing.Point(760, 282);
            this.cbxColorProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cbxColorProducto.Name = "cbxColorProducto";
            this.cbxColorProducto.Size = new System.Drawing.Size(227, 25);
            this.cbxColorProducto.TabIndex = 166;
            // 
            // lblColorProducto
            // 
            this.lblColorProducto.AutoSize = true;
            this.lblColorProducto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorProducto.Location = new System.Drawing.Point(756, 257);
            this.lblColorProducto.Name = "lblColorProducto";
            this.lblColorProducto.Size = new System.Drawing.Size(55, 21);
            this.lblColorProducto.TabIndex = 165;
            this.lblColorProducto.Text = "Color:";
            // 
            // lblPrecioVentaProducto
            // 
            this.lblPrecioVentaProducto.AutoSize = true;
            this.lblPrecioVentaProducto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVentaProducto.Location = new System.Drawing.Point(757, 360);
            this.lblPrecioVentaProducto.Name = "lblPrecioVentaProducto";
            this.lblPrecioVentaProducto.Size = new System.Drawing.Size(134, 21);
            this.lblPrecioVentaProducto.TabIndex = 168;
            this.lblPrecioVentaProducto.Text = "Precio de Venta:";
            // 
            // lblStockProducto
            // 
            this.lblStockProducto.AutoSize = true;
            this.lblStockProducto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockProducto.Location = new System.Drawing.Point(757, 414);
            this.lblStockProducto.Name = "lblStockProducto";
            this.lblStockProducto.Size = new System.Drawing.Size(56, 21);
            this.lblStockProducto.TabIndex = 167;
            this.lblStockProducto.Text = "Stock:";
            // 
            // lblTituloDetalleProducto
            // 
            this.lblTituloDetalleProducto.AutoSize = true;
            this.lblTituloDetalleProducto.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalleProducto.Location = new System.Drawing.Point(779, 78);
            this.lblTituloDetalleProducto.Name = "lblTituloDetalleProducto";
            this.lblTituloDetalleProducto.Size = new System.Drawing.Size(169, 29);
            this.lblTituloDetalleProducto.TabIndex = 158;
            this.lblTituloDetalleProducto.Text = "Detalle Producto";
            // 
            // dgvListaProducto
            // 
            this.dgvListaProducto.AllowUserToAddRows = false;
            this.dgvListaProducto.AllowUserToDeleteRows = false;
            this.dgvListaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaProducto.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProducto.Location = new System.Drawing.Point(25, 32);
            this.dgvListaProducto.MultiSelect = false;
            this.dgvListaProducto.Name = "dgvListaProducto";
            this.dgvListaProducto.ReadOnly = true;
            this.dgvListaProducto.RowHeadersWidth = 51;
            this.dgvListaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProducto.Size = new System.Drawing.Size(622, 297);
            this.dgvListaProducto.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(74, 515);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 47);
            this.btnNuevo.TabIndex = 155;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // nudStockProducto
            // 
            this.nudStockProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStockProducto.Location = new System.Drawing.Point(761, 434);
            this.nudStockProducto.Margin = new System.Windows.Forms.Padding(4);
            this.nudStockProducto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStockProducto.Name = "nudStockProducto";
            this.nudStockProducto.Size = new System.Drawing.Size(119, 23);
            this.nudStockProducto.TabIndex = 169;
            // 
            // txtParametroProducto
            // 
            this.txtParametroProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtParametroProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroProducto.Location = new System.Drawing.Point(309, 83);
            this.txtParametroProducto.Name = "txtParametroProducto";
            this.txtParametroProducto.Size = new System.Drawing.Size(320, 28);
            this.txtParametroProducto.TabIndex = 162;
            // 
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.Color.DarkGray;
            this.fondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fondo.Location = new System.Drawing.Point(15, 69);
            this.fondo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(289, 58);
            this.fondo.TabIndex = 160;
            this.fondo.Text = "Buscar por Nombre, Modelo,Marca:";
            this.fondo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProducto.Location = new System.Drawing.Point(757, 311);
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(104, 21);
            this.lblDescripcionProducto.TabIndex = 164;
            this.lblDescripcionProducto.Text = "Descripción:";
            // 
            // lblModeloProducto
            // 
            this.lblModeloProducto.AutoSize = true;
            this.lblModeloProducto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloProducto.Location = new System.Drawing.Point(757, 157);
            this.lblModeloProducto.Name = "lblModeloProducto";
            this.lblModeloProducto.Size = new System.Drawing.Size(73, 21);
            this.lblModeloProducto.TabIndex = 163;
            this.lblModeloProducto.Text = "Modelo:";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionProducto.Location = new System.Drawing.Point(760, 335);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(227, 23);
            this.txtDescripcionProducto.TabIndex = 161;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(756, 106);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(77, 21);
            this.lblNombreProducto.TabIndex = 159;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // gbxListaProducto
            // 
            this.gbxListaProducto.BackColor = System.Drawing.Color.Transparent;
            this.gbxListaProducto.Controls.Add(this.dgvListaProducto);
            this.gbxListaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListaProducto.Location = new System.Drawing.Point(39, 141);
            this.gbxListaProducto.Name = "gbxListaProducto";
            this.gbxListaProducto.Size = new System.Drawing.Size(665, 348);
            this.gbxListaProducto.TabIndex = 157;
            this.gbxListaProducto.TabStop = false;
            this.gbxListaProducto.Text = "Lista de Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(759, 130);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(227, 23);
            this.txtNombreProducto.TabIndex = 156;
            // 
            // txtModeloProducto
            // 
            this.txtModeloProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloProducto.Location = new System.Drawing.Point(760, 181);
            this.txtModeloProducto.Name = "txtModeloProducto";
            this.txtModeloProducto.Size = new System.Drawing.Size(227, 23);
            this.txtModeloProducto.TabIndex = 154;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.Black;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(1, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1006, 46);
            this.lblTitulo.TabIndex = 153;
            this.lblTitulo.Text = "PRODUCTOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarcaProducto
            // 
            this.lblMarcaProducto.AutoSize = true;
            this.lblMarcaProducto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaProducto.Location = new System.Drawing.Point(757, 207);
            this.lblMarcaProducto.Name = "lblMarcaProducto";
            this.lblMarcaProducto.Size = new System.Drawing.Size(61, 21);
            this.lblMarcaProducto.TabIndex = 178;
            this.lblMarcaProducto.Text = "Marca:";
            // 
            // txtMarcaProducto
            // 
            this.txtMarcaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaProducto.Location = new System.Drawing.Point(760, 231);
            this.txtMarcaProducto.Name = "txtMarcaProducto";
            this.txtMarcaProducto.Size = new System.Drawing.Size(227, 23);
            this.txtMarcaProducto.TabIndex = 177;
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
            // erpDescripcion
            // 
            this.erpDescripcion.ContainerControl = this;
            // 
            // erpPrecioVenta
            // 
            this.erpPrecioVenta.ContainerControl = this;
            // 
            // erpStock
            // 
            this.erpStock.ContainerControl = this;
            // 
            // cbxCategoriaProducto
            // 
            this.cbxCategoriaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoriaProducto.FormattingEnabled = true;
            this.cbxCategoriaProducto.Items.AddRange(new object[] {
            "Tablets",
            "Calular",
            "Fundas"});
            this.cbxCategoriaProducto.Location = new System.Drawing.Point(759, 486);
            this.cbxCategoriaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategoriaProducto.Name = "cbxCategoriaProducto";
            this.cbxCategoriaProducto.Size = new System.Drawing.Size(227, 25);
            this.cbxCategoriaProducto.TabIndex = 180;
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProducto.Location = new System.Drawing.Point(756, 461);
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(88, 21);
            this.lblCategoriaProducto.TabIndex = 179;
            this.lblCategoriaProducto.Text = "Categoria:";
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1007, 569);
            this.Controls.Add(this.cbxCategoriaProducto);
            this.Controls.Add(this.lblCategoriaProducto);
            this.Controls.Add(this.lblMarcaProducto);
            this.Controls.Add(this.txtMarcaProducto);
            this.Controls.Add(this.txtPrecioVentaProducto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cbxColorProducto);
            this.Controls.Add(this.lblColorProducto);
            this.Controls.Add(this.lblPrecioVentaProducto);
            this.Controls.Add(this.lblStockProducto);
            this.Controls.Add(this.lblTituloDetalleProducto);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.nudStockProducto);
            this.Controls.Add(this.txtParametroProducto);
            this.Controls.Add(this.fondo);
            this.Controls.Add(this.lblDescripcionProducto);
            this.Controls.Add(this.lblModeloProducto);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.gbxListaProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtModeloProducto);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: TecnoCell - Producto :::";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.Click += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockProducto)).EndInit();
            this.gbxListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecioVentaProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cbxColorProducto;
        private System.Windows.Forms.Label lblColorProducto;
        private System.Windows.Forms.Label lblPrecioVentaProducto;
        private System.Windows.Forms.Label lblStockProducto;
        private System.Windows.Forms.Label lblTituloDetalleProducto;
        private System.Windows.Forms.DataGridView dgvListaProducto;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.NumericUpDown nudStockProducto;
        private System.Windows.Forms.TextBox txtParametroProducto;
        private System.Windows.Forms.Label fondo;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.Label lblModeloProducto;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.GroupBox gbxListaProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtModeloProducto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMarcaProducto;
        private System.Windows.Forms.TextBox txtMarcaProducto;
        private System.Windows.Forms.ErrorProvider erpNombre;
        private System.Windows.Forms.ErrorProvider erpModelo;
        private System.Windows.Forms.ErrorProvider erpMarca;
        private System.Windows.Forms.ErrorProvider erpColor;
        private System.Windows.Forms.ErrorProvider erpDescripcion;
        private System.Windows.Forms.ErrorProvider erpPrecioVenta;
        private System.Windows.Forms.ErrorProvider erpStock;
        private System.Windows.Forms.ComboBox cbxCategoriaProducto;
        private System.Windows.Forms.Label lblCategoriaProducto;
    }
}