namespace CpTecnoCell
{
    partial class FrmCliente
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
            this.txtCedulaIdentidadCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCelularCliente = new System.Windows.Forms.TextBox();
            this.txtCorreoClienteCliente = new System.Windows.Forms.TextBox();
            this.txtNombresCliente = new System.Windows.Forms.TextBox();
            this.lblCelularCliente = new System.Windows.Forms.Label();
            this.lblCorreoElectronicoCliente = new System.Windows.Forms.Label();
            this.lblNombresCliente = new System.Windows.Forms.Label();
            this.lblCedulaIdentidadCliente = new System.Windows.Forms.Label();
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtParametroCliente = new System.Windows.Forms.TextBox();
            this.fondo = new System.Windows.Forms.Label();
            this.lblTituloCLiente = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.lblApellidosCliente = new System.Windows.Forms.Label();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.erpCorreoElectronicoCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCedulaIdentidadCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpNombresCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpApellidosCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDireccionCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCelularCliente = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCorreoElectronicoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidadCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombresCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpApellidosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDireccionCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelularCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedulaIdentidadCliente
            // 
            this.txtCedulaIdentidadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaIdentidadCliente.Location = new System.Drawing.Point(740, 135);
            this.txtCedulaIdentidadCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedulaIdentidadCliente.Name = "txtCedulaIdentidadCliente";
            this.txtCedulaIdentidadCliente.Size = new System.Drawing.Size(235, 22);
            this.txtCedulaIdentidadCliente.TabIndex = 182;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(599, 78);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 34);
            this.btnBuscar.TabIndex = 181;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCelularCliente
            // 
            this.txtCelularCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularCliente.Location = new System.Drawing.Point(743, 360);
            this.txtCelularCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelularCliente.Name = "txtCelularCliente";
            this.txtCelularCliente.Size = new System.Drawing.Size(235, 22);
            this.txtCelularCliente.TabIndex = 180;
            // 
            // txtCorreoClienteCliente
            // 
            this.txtCorreoClienteCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoClienteCliente.Location = new System.Drawing.Point(740, 411);
            this.txtCorreoClienteCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoClienteCliente.Name = "txtCorreoClienteCliente";
            this.txtCorreoClienteCliente.Size = new System.Drawing.Size(235, 22);
            this.txtCorreoClienteCliente.TabIndex = 179;
            // 
            // txtNombresCliente
            // 
            this.txtNombresCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresCliente.Location = new System.Drawing.Point(740, 186);
            this.txtNombresCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombresCliente.Name = "txtNombresCliente";
            this.txtNombresCliente.Size = new System.Drawing.Size(236, 22);
            this.txtNombresCliente.TabIndex = 178;
            // 
            // lblCelularCliente
            // 
            this.lblCelularCliente.AutoSize = true;
            this.lblCelularCliente.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularCliente.Location = new System.Drawing.Point(739, 335);
            this.lblCelularCliente.Name = "lblCelularCliente";
            this.lblCelularCliente.Size = new System.Drawing.Size(68, 21);
            this.lblCelularCliente.TabIndex = 177;
            this.lblCelularCliente.Text = "Celular:";
            // 
            // lblCorreoElectronicoCliente
            // 
            this.lblCorreoElectronicoCliente.AutoSize = true;
            this.lblCorreoElectronicoCliente.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectronicoCliente.Location = new System.Drawing.Point(739, 386);
            this.lblCorreoElectronicoCliente.Name = "lblCorreoElectronicoCliente";
            this.lblCorreoElectronicoCliente.Size = new System.Drawing.Size(155, 21);
            this.lblCorreoElectronicoCliente.TabIndex = 176;
            this.lblCorreoElectronicoCliente.Text = "Correo Electronico:";
            // 
            // lblNombresCliente
            // 
            this.lblNombresCliente.AutoSize = true;
            this.lblNombresCliente.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresCliente.Location = new System.Drawing.Point(739, 161);
            this.lblNombresCliente.Name = "lblNombresCliente";
            this.lblNombresCliente.Size = new System.Drawing.Size(84, 21);
            this.lblNombresCliente.TabIndex = 175;
            this.lblNombresCliente.Text = "Nombres:";
            // 
            // lblCedulaIdentidadCliente
            // 
            this.lblCedulaIdentidadCliente.AutoSize = true;
            this.lblCedulaIdentidadCliente.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaIdentidadCliente.Location = new System.Drawing.Point(739, 114);
            this.lblCedulaIdentidadCliente.Name = "lblCedulaIdentidadCliente";
            this.lblCedulaIdentidadCliente.Size = new System.Drawing.Size(141, 21);
            this.lblCedulaIdentidadCliente.TabIndex = 174;
            this.lblCedulaIdentidadCliente.Text = "Cedula Identidad";
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.AllowUserToAddRows = false;
            this.dgvListaCliente.AllowUserToDeleteRows = false;
            this.dgvListaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaCliente.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.Location = new System.Drawing.Point(25, 32);
            this.dgvListaCliente.MultiSelect = false;
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.ReadOnly = true;
            this.dgvListaCliente.RowHeadersWidth = 51;
            this.dgvListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCliente.Size = new System.Drawing.Size(616, 297);
            this.dgvListaCliente.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(867, 467);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 42);
            this.btnCancelar.TabIndex = 173;
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
            this.btnGuardar.Location = new System.Drawing.Point(726, 467);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 42);
            this.btnGuardar.TabIndex = 172;
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
            this.btnEliminar.Location = new System.Drawing.Point(308, 511);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 47);
            this.btnEliminar.TabIndex = 171;
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
            this.btnCerrar.Location = new System.Drawing.Point(459, 511);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(101, 47);
            this.btnCerrar.TabIndex = 170;
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
            this.btnEditar.Location = new System.Drawing.Point(190, 511);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 47);
            this.btnEditar.TabIndex = 169;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtParametroCliente
            // 
            this.txtParametroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtParametroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroCliente.Location = new System.Drawing.Point(278, 78);
            this.txtParametroCliente.Name = "txtParametroCliente";
            this.txtParametroCliente.Size = new System.Drawing.Size(314, 28);
            this.txtParametroCliente.TabIndex = 168;
            // 
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.Color.Silver;
            this.fondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fondo.Location = new System.Drawing.Point(11, 71);
            this.fondo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(701, 49);
            this.fondo.TabIndex = 167;
            this.fondo.Text = "Buscar por Documento o Nombre:";
            this.fondo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloCLiente
            // 
            this.lblTituloCLiente.AutoSize = true;
            this.lblTituloCLiente.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCLiente.Location = new System.Drawing.Point(769, 71);
            this.lblTituloCLiente.Name = "lblTituloCLiente";
            this.lblTituloCLiente.Size = new System.Drawing.Size(147, 29);
            this.lblTituloCLiente.TabIndex = 166;
            this.lblTituloCLiente.Text = "Detalle Cliente";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(63, 511);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 47);
            this.btnNuevo.TabIndex = 164;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.Black;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(999, 46);
            this.lblTitulo.TabIndex = 163;
            this.lblTitulo.Text = "CLIENTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxLista
            // 
            this.gbxLista.BackColor = System.Drawing.Color.Transparent;
            this.gbxLista.Controls.Add(this.dgvListaCliente);
            this.gbxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(28, 137);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(659, 348);
            this.gbxLista.TabIndex = 165;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Clientes";
            // 
            // lblApellidosCliente
            // 
            this.lblApellidosCliente.AutoSize = true;
            this.lblApellidosCliente.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosCliente.Location = new System.Drawing.Point(739, 223);
            this.lblApellidosCliente.Name = "lblApellidosCliente";
            this.lblApellidosCliente.Size = new System.Drawing.Size(86, 21);
            this.lblApellidosCliente.TabIndex = 183;
            this.lblApellidosCliente.Text = "Apellidos:";
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosCliente.Location = new System.Drawing.Point(743, 248);
            this.txtApellidosCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.Size = new System.Drawing.Size(236, 22);
            this.txtApellidosCliente.TabIndex = 184;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(743, 308);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(236, 22);
            this.txtDireccionCliente.TabIndex = 186;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(739, 283);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(87, 21);
            this.lblDireccionCliente.TabIndex = 185;
            this.lblDireccionCliente.Text = "Direccion:";
            // 
            // erpCorreoElectronicoCliente
            // 
            this.erpCorreoElectronicoCliente.ContainerControl = this;
            // 
            // erpCedulaIdentidadCliente
            // 
            this.erpCedulaIdentidadCliente.ContainerControl = this;
            // 
            // erpNombresCliente
            // 
            this.erpNombresCliente.ContainerControl = this;
            // 
            // erpApellidosCliente
            // 
            this.erpApellidosCliente.ContainerControl = this;
            // 
            // erpDireccionCliente
            // 
            this.erpDireccionCliente.ContainerControl = this;
            // 
            // erpCelularCliente
            // 
            this.erpCelularCliente.ContainerControl = this;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(997, 569);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.lblDireccionCliente);
            this.Controls.Add(this.txtApellidosCliente);
            this.Controls.Add(this.lblApellidosCliente);
            this.Controls.Add(this.txtCedulaIdentidadCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCelularCliente);
            this.Controls.Add(this.txtCorreoClienteCliente);
            this.Controls.Add(this.txtNombresCliente);
            this.Controls.Add(this.lblCelularCliente);
            this.Controls.Add(this.lblCorreoElectronicoCliente);
            this.Controls.Add(this.lblNombresCliente);
            this.Controls.Add(this.lblCedulaIdentidadCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtParametroCliente);
            this.Controls.Add(this.fondo);
            this.Controls.Add(this.lblTituloCLiente);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbxLista);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: TecnoCell - Cliente :::";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.Click += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpCorreoElectronicoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedulaIdentidadCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpNombresCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpApellidosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDireccionCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelularCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedulaIdentidadCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCelularCliente;
        private System.Windows.Forms.TextBox txtCorreoClienteCliente;
        private System.Windows.Forms.TextBox txtNombresCliente;
        private System.Windows.Forms.Label lblCelularCliente;
        private System.Windows.Forms.Label lblCorreoElectronicoCliente;
        private System.Windows.Forms.Label lblNombresCliente;
        private System.Windows.Forms.Label lblCedulaIdentidadCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtParametroCliente;
        private System.Windows.Forms.Label fondo;
        private System.Windows.Forms.Label lblTituloCLiente;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.Label lblApellidosCliente;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.ErrorProvider erpCorreoElectronicoCliente;
        private System.Windows.Forms.ErrorProvider erpCedulaIdentidadCliente;
        private System.Windows.Forms.ErrorProvider erpNombresCliente;
        private System.Windows.Forms.ErrorProvider erpApellidosCliente;
        private System.Windows.Forms.ErrorProvider erpDireccionCliente;
        private System.Windows.Forms.ErrorProvider erpCelularCliente;
    }
}