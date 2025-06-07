namespace CpTecnoCell
{
    partial class FrmVentaDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentaDetalle));
            this.txtInfVentaUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuarioVentaDetalle = new System.Windows.Forms.Label();
            this.txtInfVentaCedulaIdentidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCeduaIdentidad = new System.Windows.Forms.Label();
            this.lblInfNombreCliente = new System.Windows.Forms.Label();
            this.lblMontoPagoVentaDetalle = new System.Windows.Forms.Label();
            this.gvxInfCliente = new System.Windows.Forms.GroupBox();
            this.txtInfNombreCliente = new System.Windows.Forms.TextBox();
            this.txtMontoPagoVentaDetalle = new System.Windows.Forms.TextBox();
            this.lblMontoTotalVentaDetalle = new System.Windows.Forms.Label();
            this.txtMontoCambioVentaDetalle = new System.Windows.Forms.TextBox();
            this.lblMontoCambioVentaDetalle = new System.Windows.Forms.Label();
            this.txtMontoTotalVentaDetalle = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtParametroCedulaIdentidadVentaDetalle = new System.Windows.Forms.TextBox();
            this.gbxInfVentaDetalle = new System.Windows.Forms.GroupBox();
            this.dtpFechaVentaDetalle = new System.Windows.Forms.DateTimePicker();
            this.lblTituloVentaDetalle = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.btnNuevoRegistroVenta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gvxInfCliente.SuspendLayout();
            this.gbxInfVentaDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInfVentaUsuario
            // 
            this.txtInfVentaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfVentaUsuario.Location = new System.Drawing.Point(333, 40);
            this.txtInfVentaUsuario.MaxLength = 15;
            this.txtInfVentaUsuario.Name = "txtInfVentaUsuario";
            this.txtInfVentaUsuario.ReadOnly = true;
            this.txtInfVentaUsuario.Size = new System.Drawing.Size(139, 21);
            this.txtInfVentaUsuario.TabIndex = 93;
            // 
            // lblUsuarioVentaDetalle
            // 
            this.lblUsuarioVentaDetalle.AutoSize = true;
            this.lblUsuarioVentaDetalle.BackColor = System.Drawing.Color.White;
            this.lblUsuarioVentaDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioVentaDetalle.Location = new System.Drawing.Point(330, 22);
            this.lblUsuarioVentaDetalle.Name = "lblUsuarioVentaDetalle";
            this.lblUsuarioVentaDetalle.Size = new System.Drawing.Size(75, 18);
            this.lblUsuarioVentaDetalle.TabIndex = 92;
            this.lblUsuarioVentaDetalle.Text = "Usuario:";
            // 
            // txtInfVentaCedulaIdentidad
            // 
            this.txtInfVentaCedulaIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfVentaCedulaIdentidad.Location = new System.Drawing.Point(45, 56);
            this.txtInfVentaCedulaIdentidad.MaxLength = 12;
            this.txtInfVentaCedulaIdentidad.Name = "txtInfVentaCedulaIdentidad";
            this.txtInfVentaCedulaIdentidad.ReadOnly = true;
            this.txtInfVentaCedulaIdentidad.Size = new System.Drawing.Size(189, 21);
            this.txtInfVentaCedulaIdentidad.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 89;
            this.label3.Text = "Fecha:";
            // 
            // lblCeduaIdentidad
            // 
            this.lblCeduaIdentidad.AutoSize = true;
            this.lblCeduaIdentidad.BackColor = System.Drawing.Color.White;
            this.lblCeduaIdentidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCeduaIdentidad.Location = new System.Drawing.Point(42, 35);
            this.lblCeduaIdentidad.Name = "lblCeduaIdentidad";
            this.lblCeduaIdentidad.Size = new System.Drawing.Size(143, 18);
            this.lblCeduaIdentidad.TabIndex = 91;
            this.lblCeduaIdentidad.Text = "Cedula Identidad";
            // 
            // lblInfNombreCliente
            // 
            this.lblInfNombreCliente.AutoSize = true;
            this.lblInfNombreCliente.BackColor = System.Drawing.Color.White;
            this.lblInfNombreCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfNombreCliente.Location = new System.Drawing.Point(310, 35);
            this.lblInfNombreCliente.Name = "lblInfNombreCliente";
            this.lblInfNombreCliente.Size = new System.Drawing.Size(136, 18);
            this.lblInfNombreCliente.TabIndex = 83;
            this.lblInfNombreCliente.Text = "Nombre Cliente:";
            // 
            // lblMontoPagoVentaDetalle
            // 
            this.lblMontoPagoVentaDetalle.AutoSize = true;
            this.lblMontoPagoVentaDetalle.BackColor = System.Drawing.Color.White;
            this.lblMontoPagoVentaDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPagoVentaDetalle.Location = new System.Drawing.Point(237, 326);
            this.lblMontoPagoVentaDetalle.Name = "lblMontoPagoVentaDetalle";
            this.lblMontoPagoVentaDetalle.Size = new System.Drawing.Size(107, 18);
            this.lblMontoPagoVentaDetalle.TabIndex = 245;
            this.lblMontoPagoVentaDetalle.Text = "Monto Pago:";
            // 
            // gvxInfCliente
            // 
            this.gvxInfCliente.BackColor = System.Drawing.Color.White;
            this.gvxInfCliente.Controls.Add(this.txtInfNombreCliente);
            this.gvxInfCliente.Controls.Add(this.lblInfNombreCliente);
            this.gvxInfCliente.Controls.Add(this.lblCeduaIdentidad);
            this.gvxInfCliente.Controls.Add(this.txtInfVentaCedulaIdentidad);
            this.gvxInfCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvxInfCliente.Location = new System.Drawing.Point(17, 214);
            this.gvxInfCliente.Name = "gvxInfCliente";
            this.gvxInfCliente.Size = new System.Drawing.Size(657, 99);
            this.gvxInfCliente.TabIndex = 240;
            this.gvxInfCliente.TabStop = false;
            this.gvxInfCliente.Text = "Informacion Cliente";
            // 
            // txtInfNombreCliente
            // 
            this.txtInfNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfNombreCliente.Location = new System.Drawing.Point(302, 56);
            this.txtInfNombreCliente.MaxLength = 100;
            this.txtInfNombreCliente.Name = "txtInfNombreCliente";
            this.txtInfNombreCliente.ReadOnly = true;
            this.txtInfNombreCliente.Size = new System.Drawing.Size(191, 21);
            this.txtInfNombreCliente.TabIndex = 86;
            // 
            // txtMontoPagoVentaDetalle
            // 
            this.txtMontoPagoVentaDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMontoPagoVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPagoVentaDetalle.Location = new System.Drawing.Point(350, 323);
            this.txtMontoPagoVentaDetalle.Name = "txtMontoPagoVentaDetalle";
            this.txtMontoPagoVentaDetalle.ReadOnly = true;
            this.txtMontoPagoVentaDetalle.Size = new System.Drawing.Size(64, 21);
            this.txtMontoPagoVentaDetalle.TabIndex = 246;
            this.txtMontoPagoVentaDetalle.Text = "0";
            // 
            // lblMontoTotalVentaDetalle
            // 
            this.lblMontoTotalVentaDetalle.AutoSize = true;
            this.lblMontoTotalVentaDetalle.BackColor = System.Drawing.Color.White;
            this.lblMontoTotalVentaDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalVentaDetalle.Location = new System.Drawing.Point(59, 328);
            this.lblMontoTotalVentaDetalle.Name = "lblMontoTotalVentaDetalle";
            this.lblMontoTotalVentaDetalle.Size = new System.Drawing.Size(106, 18);
            this.lblMontoTotalVentaDetalle.TabIndex = 243;
            this.lblMontoTotalVentaDetalle.Text = "Monto Total:";
            // 
            // txtMontoCambioVentaDetalle
            // 
            this.txtMontoCambioVentaDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMontoCambioVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCambioVentaDetalle.Location = new System.Drawing.Point(576, 325);
            this.txtMontoCambioVentaDetalle.Name = "txtMontoCambioVentaDetalle";
            this.txtMontoCambioVentaDetalle.ReadOnly = true;
            this.txtMontoCambioVentaDetalle.Size = new System.Drawing.Size(55, 21);
            this.txtMontoCambioVentaDetalle.TabIndex = 244;
            this.txtMontoCambioVentaDetalle.Text = "0";
            // 
            // lblMontoCambioVentaDetalle
            // 
            this.lblMontoCambioVentaDetalle.AutoSize = true;
            this.lblMontoCambioVentaDetalle.BackColor = System.Drawing.Color.White;
            this.lblMontoCambioVentaDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCambioVentaDetalle.Location = new System.Drawing.Point(444, 326);
            this.lblMontoCambioVentaDetalle.Name = "lblMontoCambioVentaDetalle";
            this.lblMontoCambioVentaDetalle.Size = new System.Drawing.Size(126, 18);
            this.lblMontoCambioVentaDetalle.TabIndex = 241;
            this.lblMontoCambioVentaDetalle.Text = "Monto Cambio:";
            // 
            // txtMontoTotalVentaDetalle
            // 
            this.txtMontoTotalVentaDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMontoTotalVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotalVentaDetalle.Location = new System.Drawing.Point(171, 325);
            this.txtMontoTotalVentaDetalle.Name = "txtMontoTotalVentaDetalle";
            this.txtMontoTotalVentaDetalle.ReadOnly = true;
            this.txtMontoTotalVentaDetalle.Size = new System.Drawing.Size(49, 21);
            this.txtMontoTotalVentaDetalle.TabIndex = 242;
            this.txtMontoTotalVentaDetalle.Text = "0";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.BackColor = System.Drawing.Color.White;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDocumento.Location = new System.Drawing.Point(26, 55);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(172, 18);
            this.lblNumeroDocumento.TabIndex = 238;
            this.lblNumeroDocumento.Text = "Numero Documento:";
            // 
            // txtParametroCedulaIdentidadVentaDetalle
            // 
            this.txtParametroCedulaIdentidadVentaDetalle.Location = new System.Drawing.Point(213, 53);
            this.txtParametroCedulaIdentidadVentaDetalle.Multiline = true;
            this.txtParametroCedulaIdentidadVentaDetalle.Name = "txtParametroCedulaIdentidadVentaDetalle";
            this.txtParametroCedulaIdentidadVentaDetalle.Size = new System.Drawing.Size(209, 27);
            this.txtParametroCedulaIdentidadVentaDetalle.TabIndex = 237;
            // 
            // gbxInfVentaDetalle
            // 
            this.gbxInfVentaDetalle.BackColor = System.Drawing.Color.White;
            this.gbxInfVentaDetalle.Controls.Add(this.dtpFechaVentaDetalle);
            this.gbxInfVentaDetalle.Controls.Add(this.txtInfVentaUsuario);
            this.gbxInfVentaDetalle.Controls.Add(this.lblUsuarioVentaDetalle);
            this.gbxInfVentaDetalle.Controls.Add(this.label3);
            this.gbxInfVentaDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInfVentaDetalle.Location = new System.Drawing.Point(17, 129);
            this.gbxInfVentaDetalle.Name = "gbxInfVentaDetalle";
            this.gbxInfVentaDetalle.Size = new System.Drawing.Size(657, 99);
            this.gbxInfVentaDetalle.TabIndex = 239;
            this.gbxInfVentaDetalle.TabStop = false;
            this.gbxInfVentaDetalle.Text = "Información Venta";
            // 
            // dtpFechaVentaDetalle
            // 
            this.dtpFechaVentaDetalle.Location = new System.Drawing.Point(45, 40);
            this.dtpFechaVentaDetalle.Name = "dtpFechaVentaDetalle";
            this.dtpFechaVentaDetalle.Size = new System.Drawing.Size(245, 26);
            this.dtpFechaVentaDetalle.TabIndex = 94;
            // 
            // lblTituloVentaDetalle
            // 
            this.lblTituloVentaDetalle.AutoSize = true;
            this.lblTituloVentaDetalle.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentaDetalle.Location = new System.Drawing.Point(12, 19);
            this.lblTituloVentaDetalle.Name = "lblTituloVentaDetalle";
            this.lblTituloVentaDetalle.Size = new System.Drawing.Size(136, 29);
            this.lblTituloVentaDetalle.TabIndex = 249;
            this.lblTituloVentaDetalle.Text = "Detalle Venta";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(17, 362);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.Size = new System.Drawing.Size(656, 155);
            this.dgvDetalleVenta.TabIndex = 250;
            // 
            // btnNuevoRegistroVenta
            // 
            this.btnNuevoRegistroVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoRegistroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRegistroVenta.Image = global::CpTecnoCell.Properties.Resources.registerNew;
            this.btnNuevoRegistroVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoRegistroVenta.Location = new System.Drawing.Point(469, 88);
            this.btnNuevoRegistroVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoRegistroVenta.Name = "btnNuevoRegistroVenta";
            this.btnNuevoRegistroVenta.Size = new System.Drawing.Size(202, 38);
            this.btnNuevoRegistroVenta.TabIndex = 251;
            this.btnNuevoRegistroVenta.Text = "Nuevo Registro";
            this.btnNuevoRegistroVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoRegistroVenta.UseVisualStyleBackColor = false;
            this.btnNuevoRegistroVenta.Click += new System.EventHandler(this.btnNuevoRegistroVenta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(469, 42);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 38);
            this.btnBuscar.TabIndex = 247;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = global::CpTecnoCell.Properties.Resources.limpiar;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(576, 42);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(95, 38);
            this.btnBorrar.TabIndex = 248;
            this.btnBorrar.Text = "Limpiar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // FrmVentaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(684, 521);
            this.Controls.Add(this.btnNuevoRegistroVenta);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.lblTituloVentaDetalle);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblMontoPagoVentaDetalle);
            this.Controls.Add(this.gvxInfCliente);
            this.Controls.Add(this.txtMontoPagoVentaDetalle);
            this.Controls.Add(this.txtParametroCedulaIdentidadVentaDetalle);
            this.Controls.Add(this.lblMontoTotalVentaDetalle);
            this.Controls.Add(this.txtMontoCambioVentaDetalle);
            this.Controls.Add(this.lblMontoCambioVentaDetalle);
            this.Controls.Add(this.txtMontoTotalVentaDetalle);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.gbxInfVentaDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentaDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: TecnoCell - VentaDetalle :::";
            this.Click += new System.EventHandler(this.FrmVentaDetalle_Load);
            this.gvxInfCliente.ResumeLayout(false);
            this.gvxInfCliente.PerformLayout();
            this.gbxInfVentaDetalle.ResumeLayout(false);
            this.gbxInfVentaDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtInfVentaUsuario;
        private System.Windows.Forms.Label lblUsuarioVentaDetalle;
        private System.Windows.Forms.TextBox txtInfVentaCedulaIdentidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCeduaIdentidad;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblInfNombreCliente;
        private System.Windows.Forms.Label lblMontoPagoVentaDetalle;
        private System.Windows.Forms.GroupBox gvxInfCliente;
        private System.Windows.Forms.TextBox txtInfNombreCliente;
        private System.Windows.Forms.TextBox txtMontoPagoVentaDetalle;
        private System.Windows.Forms.Label lblMontoTotalVentaDetalle;
        private System.Windows.Forms.TextBox txtMontoCambioVentaDetalle;
        private System.Windows.Forms.Label lblMontoCambioVentaDetalle;
        private System.Windows.Forms.TextBox txtMontoTotalVentaDetalle;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.TextBox txtParametroCedulaIdentidadVentaDetalle;
        private System.Windows.Forms.GroupBox gbxInfVentaDetalle;
        private System.Windows.Forms.Label lblTituloVentaDetalle;
        private System.Windows.Forms.DateTimePicker dtpFechaVentaDetalle;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Button btnNuevoRegistroVenta;
    }
}