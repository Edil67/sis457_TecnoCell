namespace CpTecnoCell
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pctPrincipal = new System.Windows.Forms.PictureBox();
            this.ribbonTab3 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup5 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaVenta = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup8 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaVentaDetalle = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab2 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaCategoria = new C1.Win.Ribbon.RibbonButton();
            this.btnCaProductos = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaCliente = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctPrincipal
            // 
            this.pctPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pctPrincipal.Image")));
            this.pctPrincipal.Location = new System.Drawing.Point(0, 161);
            this.pctPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pctPrincipal.Name = "pctPrincipal";
            this.pctPrincipal.Size = new System.Drawing.Size(1073, 401);
            this.pctPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPrincipal.TabIndex = 2;
            this.pctPrincipal.TabStop = false;
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Groups.Add(this.ribbonGroup5);
            this.ribbonTab3.Groups.Add(this.ribbonGroup8);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "VENTA";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("ribbonGroup5.IconSet")))));
            this.ribbonGroup5.Items.Add(this.btnCaVenta);
            this.ribbonGroup5.Name = "ribbonGroup5";
            // 
            // btnCaVenta
            // 
            this.btnCaVenta.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaVenta.IconSet")))));
            this.btnCaVenta.Name = "btnCaVenta";
            this.btnCaVenta.Text = "VENTAS";
            this.btnCaVenta.Click += new System.EventHandler(this.btnCaVenta_Click);
            // 
            // ribbonGroup8
            // 
            this.ribbonGroup8.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(100, 100), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("ribbonGroup8.IconSet")))));
            this.ribbonGroup8.Items.Add(this.btnCaVentaDetalle);
            this.ribbonGroup8.Name = "ribbonGroup8";
            // 
            // btnCaVentaDetalle
            // 
            this.btnCaVentaDetalle.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(100, 100), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaVentaDetalle.IconSet")))));
            this.btnCaVentaDetalle.Name = "btnCaVentaDetalle";
            this.btnCaVentaDetalle.Text = "VENTA DETALLES";
            this.btnCaVentaDetalle.Click += new System.EventHandler(this.btnCaVentaDetalle_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup4);
            this.ribbonTab2.Name = "ribbonTab2";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Group";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Groups.Add(this.ribbonGroup2);
            this.ribbonTab1.Groups.Add(this.ribbonGroup3);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "CÁTALOGO";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.btnCaCategoria);
            this.ribbonGroup1.Items.Add(this.btnCaProductos);
            this.ribbonGroup1.Name = "ribbonGroup1";
            // 
            // btnCaCategoria
            // 
            this.btnCaCategoria.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaCategoria.IconSet")))));
            this.btnCaCategoria.Name = "btnCaCategoria";
            this.btnCaCategoria.Text = "CATEGORIAS";
            this.btnCaCategoria.Click += new System.EventHandler(this.btnCaCategoria_Click);
            // 
            // btnCaProductos
            // 
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaProductos.IconSet")))));
            this.btnCaProductos.Name = "btnCaProductos";
            this.btnCaProductos.Text = "PRODUCTOS";
            this.btnCaProductos.Click += new System.EventHandler(this.btnCaProductos_Click);
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("ribbonGroup2.IconSet")))));
            this.ribbonGroup2.Items.Add(this.btnCaCliente);
            this.ribbonGroup2.Name = "ribbonGroup2";
            // 
            // btnCaCliente
            // 
            this.btnCaCliente.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaCliente.IconSet")))));
            this.btnCaCliente.Name = "btnCaCliente";
            this.btnCaCliente.Text = "CLIENTES";
            this.btnCaCliente.Click += new System.EventHandler(this.btnCaCliente_Click);
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Name = "ribbonGroup3";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Margin = new System.Windows.Forms.Padding(2);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1073, 161);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 562);
            this.Controls.Add(this.pctPrincipal);
            this.Controls.Add(this.c1Ribbon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "::: TecnoCell - Principal :::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctPrincipal;
        private C1.Win.Ribbon.RibbonTab ribbonTab3;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup5;
        private C1.Win.Ribbon.RibbonButton btnCaVenta;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup8;
        private C1.Win.Ribbon.RibbonButton btnCaVentaDetalle;
        private C1.Win.Ribbon.RibbonTab ribbonTab2;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonButton btnCaCliente;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonButton btnCaCategoria;
        private C1.Win.Ribbon.RibbonButton btnCaProductos;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
    }
}