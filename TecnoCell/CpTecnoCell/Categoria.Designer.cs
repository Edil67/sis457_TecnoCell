namespace CpTecnoCell
{
    partial class Categoria
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvListaCategoria = new System.Windows.Forms.DataGridView();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParametroCategoria = new System.Windows.Forms.TextBox();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.erpDescripcionCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategoria)).BeginInit();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcionCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(46, 20);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(533, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Categoria";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListaCategoria
            // 
            this.dgvListaCategoria.AllowUserToAddRows = false;
            this.dgvListaCategoria.AllowUserToDeleteRows = false;
            this.dgvListaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaCategoria.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvListaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCategoria.Location = new System.Drawing.Point(30, 30);
            this.dgvListaCategoria.MultiSelect = false;
            this.dgvListaCategoria.Name = "dgvListaCategoria";
            this.dgvListaCategoria.ReadOnly = true;
            this.dgvListaCategoria.RowHeadersWidth = 51;
            this.dgvListaCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCategoria.Size = new System.Drawing.Size(617, 224);
            this.dgvListaCategoria.TabIndex = 0;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(-1, 91);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(173, 29);
            this.lblCategoria.TabIndex = 169;
            this.lblCategoria.Text = "Detalle Categoria";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusqueda.BackColor = System.Drawing.Color.White;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(261, 77);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(210, 47);
            this.lblBusqueda.TabIndex = 168;
            this.lblBusqueda.Text = "Buscar por Descripción:";
            this.lblBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 167;
            this.label3.Text = "Categoria:";
            // 
            // gbxLista
            // 
            this.gbxLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLista.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gbxLista.Controls.Add(this.dgvListaCategoria);
            this.gbxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(261, 130);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(666, 313);
            this.gbxLista.TabIndex = 164;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Producto";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, -6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(928, 76);
            this.label2.TabIndex = 158;
            this.label2.Text = "CATEGORIA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtParametroCategoria
            // 
            this.txtParametroCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroCategoria.Location = new System.Drawing.Point(478, 91);
            this.txtParametroCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.txtParametroCategoria.Name = "txtParametroCategoria";
            this.txtParametroCategoria.Size = new System.Drawing.Size(310, 27);
            this.txtParametroCategoria.TabIndex = 157;
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(15, 177);
            this.txtDescripcionCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(231, 24);
            this.txtDescripcionCategoria.TabIndex = 156;
            // 
            // erpDescripcionCategoria
            // 
            this.erpDescripcionCategoria.ContainerControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::CpTecnoCell.Properties.Resources.cancel;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(77, 364);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(95, 49);
            this.btnCerrar.TabIndex = 163;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::CpTecnoCell.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(800, 82);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 43);
            this.btnBuscar.TabIndex = 165;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Peru;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::CpTecnoCell.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(147, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 53);
            this.btnGuardar.TabIndex = 159;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::CpTecnoCell.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(25, 289);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 50);
            this.btnEditar.TabIndex = 161;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Yellow;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::CpTecnoCell.Properties.Resources._new;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(25, 225);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 52);
            this.btnNuevo.TabIndex = 160;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::CpTecnoCell.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(147, 290);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 49);
            this.btnEliminar.TabIndex = 162;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 436);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParametroCategoria);
            this.Controls.Add(this.txtDescripcionCategoria);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Categoria";
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategoria)).EndInit();
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcionCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvListaCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParametroCategoria;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.ErrorProvider erpDescripcionCategoria;
    }
}