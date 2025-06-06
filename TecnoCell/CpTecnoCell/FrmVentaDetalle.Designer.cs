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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtInfVentaUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuarioVentaDetalle = new System.Windows.Forms.Label();
            this.txtInfVentaCedulaIdentidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCeduaIdentidad = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblInfNombreCliente = new System.Windows.Forms.Label();
            this.lblMontoPagoVentaDetalle = new System.Windows.Forms.Label();
            this.txtInfClienteCedulaIdentidad = new System.Windows.Forms.TextBox();
            this.gvxInfCliente = new System.Windows.Forms.GroupBox();
            this.lblInfCeulaIdentidadVentaDetalle = new System.Windows.Forms.Label();
            this.txtInfNombreCliente = new System.Windows.Forms.TextBox();
            this.txtMontoPagoVentaDetalle = new System.Windows.Forms.TextBox();
            this.lblMontoTotalVentaDetalle = new System.Windows.Forms.Label();
            this.txtMontoCambioVentaDetalle = new System.Windows.Forms.TextBox();
            this.lblMontoCambioVentaDetalle = new System.Windows.Forms.Label();
            this.txtMontoTotalVentaDetalle = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.txtParametroCedulaIdentidadVentaDetalle = new System.Windows.Forms.TextBox();
            this.gbxInfVentaDetalle = new System.Windows.Forms.GroupBox();
            this.lblTituloVentaDetalle = new System.Windows.Forms.Label();
            this.dtpFechaVentaDetalle = new System.Windows.Forms.DateTimePicker();
            this.gvxInfCliente.SuspendLayout();
            this.gbxInfVentaDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(469, 42);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 38);
            this.btnBuscar.TabIndex = 247;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtInfVentaUsuario
            // 
            this.txtInfVentaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfVentaUsuario.Location = new System.Drawing.Point(497, 39);
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
            this.lblUsuarioVentaDetalle.Location = new System.Drawing.Point(494, 21);
            this.lblUsuarioVentaDetalle.Name = "lblUsuarioVentaDetalle";
            this.lblUsuarioVentaDetalle.Size = new System.Drawing.Size(75, 18);
            this.lblUsuarioVentaDetalle.TabIndex = 92;
            this.lblUsuarioVentaDetalle.Text = "Usuario:";
            // 
            // txtInfVentaCedulaIdentidad
            // 
            this.txtInfVentaCedulaIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfVentaCedulaIdentidad.Location = new System.Drawing.Point(279, 42);
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
            this.label3.Location = new System.Drawing.Point(6, 21);
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
            this.lblCeduaIdentidad.Location = new System.Drawing.Point(276, 21);
            this.lblCeduaIdentidad.Name = "lblCeduaIdentidad";
            this.lblCeduaIdentidad.Size = new System.Drawing.Size(143, 18);
            this.lblCeduaIdentidad.TabIndex = 91;
            this.lblCeduaIdentidad.Text = "Cedula Identidad";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(576, 42);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(77, 38);
            this.btnBorrar.TabIndex = 248;
            this.btnBorrar.Text = "Limpiar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // lblInfNombreCliente
            // 
            this.lblInfNombreCliente.AutoSize = true;
            this.lblInfNombreCliente.BackColor = System.Drawing.Color.White;
            this.lblInfNombreCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfNombreCliente.Location = new System.Drawing.Point(204, 34);
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
            this.lblMontoPagoVentaDetalle.Location = new System.Drawing.Point(237, 312);
            this.lblMontoPagoVentaDetalle.Name = "lblMontoPagoVentaDetalle";
            this.lblMontoPagoVentaDetalle.Size = new System.Drawing.Size(107, 18);
            this.lblMontoPagoVentaDetalle.TabIndex = 245;
            this.lblMontoPagoVentaDetalle.Text = "Monto Pago:";
            // 
            // txtInfClienteCedulaIdentidad
            // 
            this.txtInfClienteCedulaIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfClienteCedulaIdentidad.Location = new System.Drawing.Point(9, 52);
            this.txtInfClienteCedulaIdentidad.Name = "txtInfClienteCedulaIdentidad";
            this.txtInfClienteCedulaIdentidad.ReadOnly = true;
            this.txtInfClienteCedulaIdentidad.Size = new System.Drawing.Size(137, 21);
            this.txtInfClienteCedulaIdentidad.TabIndex = 85;
            // 
            // gvxInfCliente
            // 
            this.gvxInfCliente.BackColor = System.Drawing.Color.White;
            this.gvxInfCliente.Controls.Add(this.lblInfCeulaIdentidadVentaDetalle);
            this.gvxInfCliente.Controls.Add(this.txtInfClienteCedulaIdentidad);
            this.gvxInfCliente.Controls.Add(this.txtInfNombreCliente);
            this.gvxInfCliente.Controls.Add(this.lblInfNombreCliente);
            this.gvxInfCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvxInfCliente.Location = new System.Drawing.Point(17, 200);
            this.gvxInfCliente.Name = "gvxInfCliente";
            this.gvxInfCliente.Size = new System.Drawing.Size(657, 99);
            this.gvxInfCliente.TabIndex = 240;
            this.gvxInfCliente.TabStop = false;
            this.gvxInfCliente.Text = "Informacion Cliente";
            // 
            // lblInfCeulaIdentidadVentaDetalle
            // 
            this.lblInfCeulaIdentidadVentaDetalle.AutoSize = true;
            this.lblInfCeulaIdentidadVentaDetalle.BackColor = System.Drawing.Color.White;
            this.lblInfCeulaIdentidadVentaDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfCeulaIdentidadVentaDetalle.Location = new System.Drawing.Point(6, 34);
            this.lblInfCeulaIdentidadVentaDetalle.Name = "lblInfCeulaIdentidadVentaDetalle";
            this.lblInfCeulaIdentidadVentaDetalle.Size = new System.Drawing.Size(165, 18);
            this.lblInfCeulaIdentidadVentaDetalle.TabIndex = 84;
            this.lblInfCeulaIdentidadVentaDetalle.Text = "Documento Cliente:";
            // 
            // txtInfNombreCliente
            // 
            this.txtInfNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfNombreCliente.Location = new System.Drawing.Point(206, 52);
            this.txtInfNombreCliente.Name = "txtInfNombreCliente";
            this.txtInfNombreCliente.ReadOnly = true;
            this.txtInfNombreCliente.Size = new System.Drawing.Size(191, 21);
            this.txtInfNombreCliente.TabIndex = 86;
            // 
            // txtMontoPagoVentaDetalle
            // 
            this.txtMontoPagoVentaDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMontoPagoVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPagoVentaDetalle.Location = new System.Drawing.Point(350, 309);
            this.txtMontoPagoVentaDetalle.Name = "txtMontoPagoVentaDetalle";
            this.txtMontoPagoVentaDetalle.ReadOnly = true;
            this.txtMontoPagoVentaDetalle.Size = new System.Drawing.Size(47, 21);
            this.txtMontoPagoVentaDetalle.TabIndex = 246;
            this.txtMontoPagoVentaDetalle.Text = "0";
            // 
            // lblMontoTotalVentaDetalle
            // 
            this.lblMontoTotalVentaDetalle.AutoSize = true;
            this.lblMontoTotalVentaDetalle.BackColor = System.Drawing.Color.White;
            this.lblMontoTotalVentaDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalVentaDetalle.Location = new System.Drawing.Point(59, 314);
            this.lblMontoTotalVentaDetalle.Name = "lblMontoTotalVentaDetalle";
            this.lblMontoTotalVentaDetalle.Size = new System.Drawing.Size(106, 18);
            this.lblMontoTotalVentaDetalle.TabIndex = 243;
            this.lblMontoTotalVentaDetalle.Text = "Monto Total:";
            // 
            // txtMontoCambioVentaDetalle
            // 
            this.txtMontoCambioVentaDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMontoCambioVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCambioVentaDetalle.Location = new System.Drawing.Point(576, 311);
            this.txtMontoCambioVentaDetalle.Name = "txtMontoCambioVentaDetalle";
            this.txtMontoCambioVentaDetalle.ReadOnly = true;
            this.txtMontoCambioVentaDetalle.Size = new System.Drawing.Size(46, 21);
            this.txtMontoCambioVentaDetalle.TabIndex = 244;
            this.txtMontoCambioVentaDetalle.Text = "0";
            // 
            // lblMontoCambioVentaDetalle
            // 
            this.lblMontoCambioVentaDetalle.AutoSize = true;
            this.lblMontoCambioVentaDetalle.BackColor = System.Drawing.Color.White;
            this.lblMontoCambioVentaDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCambioVentaDetalle.Location = new System.Drawing.Point(444, 312);
            this.lblMontoCambioVentaDetalle.Name = "lblMontoCambioVentaDetalle";
            this.lblMontoCambioVentaDetalle.Size = new System.Drawing.Size(126, 18);
            this.lblMontoCambioVentaDetalle.TabIndex = 241;
            this.lblMontoCambioVentaDetalle.Text = "Monto Cambio:";
            // 
            // txtMontoTotalVentaDetalle
            // 
            this.txtMontoTotalVentaDetalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMontoTotalVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotalVentaDetalle.Location = new System.Drawing.Point(171, 311);
            this.txtMontoTotalVentaDetalle.Name = "txtMontoTotalVentaDetalle";
            this.txtMontoTotalVentaDetalle.ReadOnly = true;
            this.txtMontoTotalVentaDetalle.Size = new System.Drawing.Size(39, 21);
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
            this.txtParametroCedulaIdentidadVentaDetalle.Size = new System.Drawing.Size(201, 20);
            this.txtParametroCedulaIdentidadVentaDetalle.TabIndex = 237;
            // 
            // gbxInfVentaDetalle
            // 
            this.gbxInfVentaDetalle.BackColor = System.Drawing.Color.White;
            this.gbxInfVentaDetalle.Controls.Add(this.dtpFechaVentaDetalle);
            this.gbxInfVentaDetalle.Controls.Add(this.txtInfVentaUsuario);
            this.gbxInfVentaDetalle.Controls.Add(this.lblUsuarioVentaDetalle);
            this.gbxInfVentaDetalle.Controls.Add(this.txtInfVentaCedulaIdentidad);
            this.gbxInfVentaDetalle.Controls.Add(this.label3);
            this.gbxInfVentaDetalle.Controls.Add(this.lblCeduaIdentidad);
            this.gbxInfVentaDetalle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInfVentaDetalle.Location = new System.Drawing.Point(17, 115);
            this.gbxInfVentaDetalle.Name = "gbxInfVentaDetalle";
            this.gbxInfVentaDetalle.Size = new System.Drawing.Size(657, 99);
            this.gbxInfVentaDetalle.TabIndex = 239;
            this.gbxInfVentaDetalle.TabStop = false;
            this.gbxInfVentaDetalle.Text = "Información Venta";
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
            // dtpFechaVentaDetalle
            // 
            this.dtpFechaVentaDetalle.Location = new System.Drawing.Point(9, 39);
            this.dtpFechaVentaDetalle.Name = "dtpFechaVentaDetalle";
            this.dtpFechaVentaDetalle.Size = new System.Drawing.Size(245, 26);
            this.dtpFechaVentaDetalle.TabIndex = 94;
            // 
            // FrmVentaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(684, 354);
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
            this.Name = "FrmVentaDetalle";
            this.Text = "::: TecnoCell - VentaDetalle :::";
            this.Click += new System.EventHandler(this.FrmVentaDetalle_Load);
            this.gvxInfCliente.ResumeLayout(false);
            this.gvxInfCliente.PerformLayout();
            this.gbxInfVentaDetalle.ResumeLayout(false);
            this.gbxInfVentaDetalle.PerformLayout();
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
        private System.Windows.Forms.TextBox txtInfClienteCedulaIdentidad;
        private System.Windows.Forms.GroupBox gvxInfCliente;
        private System.Windows.Forms.Label lblInfCeulaIdentidadVentaDetalle;
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
    }
}