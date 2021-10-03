
namespace Yanez.Evelyn._2E.PrimerParcial
{
    partial class FrmDatosProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosProducto));
            this.pnlCarro = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnActualizarCantidad = new System.Windows.Forms.Button();
            this.btnAgregarQuitarCarro = new System.Windows.Forms.Button();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lbCarroDeCompras = new System.Windows.Forms.ListBox();
            this.pnlDetalleProducto = new System.Windows.Forms.Panel();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblValorNumero = new System.Windows.Forms.Label();
            this.lblValorTipoProducto = new System.Windows.Forms.Label();
            this.lblValorStock = new System.Windows.Forms.Label();
            this.lblValorPrecio = new System.Windows.Forms.Label();
            this.lblValorProveedor = new System.Windows.Forms.Label();
            this.lblValorDescripcion = new System.Windows.Forms.Label();
            this.lblValorMarca = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTipoDeProducto = new System.Windows.Forms.Label();
            this.pnlCarro.SuspendLayout();
            this.pnlDetalleProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCarro
            // 
            this.pnlCarro.BackColor = System.Drawing.Color.Indigo;
            this.pnlCarro.Controls.Add(this.btnVolver);
            this.pnlCarro.Controls.Add(this.btnActualizarCantidad);
            this.pnlCarro.Controls.Add(this.btnAgregarQuitarCarro);
            this.pnlCarro.Controls.Add(this.lblCarrito);
            this.pnlCarro.Controls.Add(this.lbCarroDeCompras);
            this.pnlCarro.Location = new System.Drawing.Point(-1, -1);
            this.pnlCarro.Name = "pnlCarro";
            this.pnlCarro.Size = new System.Drawing.Size(172, 348);
            this.pnlCarro.TabIndex = 9;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 295);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(143, 27);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnActualizarCantidad
            // 
            this.btnActualizarCantidad.Location = new System.Drawing.Point(13, 59);
            this.btnActualizarCantidad.Name = "btnActualizarCantidad";
            this.btnActualizarCantidad.Size = new System.Drawing.Size(143, 27);
            this.btnActualizarCantidad.TabIndex = 12;
            this.btnActualizarCantidad.Text = "Guardar Cantidad";
            this.btnActualizarCantidad.UseVisualStyleBackColor = true;
            this.btnActualizarCantidad.Click += new System.EventHandler(this.btnActualizarCantidad_Click);
            // 
            // btnAgregarQuitarCarro
            // 
            this.btnAgregarQuitarCarro.Location = new System.Drawing.Point(13, 25);
            this.btnAgregarQuitarCarro.Name = "btnAgregarQuitarCarro";
            this.btnAgregarQuitarCarro.Size = new System.Drawing.Size(143, 27);
            this.btnAgregarQuitarCarro.TabIndex = 11;
            this.btnAgregarQuitarCarro.Text = "Agregar al Carro";
            this.btnAgregarQuitarCarro.UseVisualStyleBackColor = true;
            this.btnAgregarQuitarCarro.Click += new System.EventHandler(this.btnAgregarCarro_Click);
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarrito.ForeColor = System.Drawing.Color.White;
            this.lblCarrito.Location = new System.Drawing.Point(13, 95);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(136, 19);
            this.lblCarrito.TabIndex = 10;
            this.lblCarrito.Text = "Carro de Compras:";
            // 
            // lbCarroDeCompras
            // 
            this.lbCarroDeCompras.AllowDrop = true;
            this.lbCarroDeCompras.BackColor = System.Drawing.Color.Silver;
            this.lbCarroDeCompras.FormattingEnabled = true;
            this.lbCarroDeCompras.HorizontalScrollbar = true;
            this.lbCarroDeCompras.ItemHeight = 15;
            this.lbCarroDeCompras.Location = new System.Drawing.Point(13, 122);
            this.lbCarroDeCompras.Name = "lbCarroDeCompras";
            this.lbCarroDeCompras.Size = new System.Drawing.Size(143, 169);
            this.lbCarroDeCompras.TabIndex = 8;
            // 
            // pnlDetalleProducto
            // 
            this.pnlDetalleProducto.Controls.Add(this.nudCantidad);
            this.pnlDetalleProducto.Controls.Add(this.lblValorNumero);
            this.pnlDetalleProducto.Controls.Add(this.lblValorTipoProducto);
            this.pnlDetalleProducto.Controls.Add(this.lblValorStock);
            this.pnlDetalleProducto.Controls.Add(this.lblValorPrecio);
            this.pnlDetalleProducto.Controls.Add(this.lblValorProveedor);
            this.pnlDetalleProducto.Controls.Add(this.lblValorDescripcion);
            this.pnlDetalleProducto.Controls.Add(this.lblValorMarca);
            this.pnlDetalleProducto.Controls.Add(this.lblCantidad);
            this.pnlDetalleProducto.Controls.Add(this.lblProveedor);
            this.pnlDetalleProducto.Controls.Add(this.lblValorTotal);
            this.pnlDetalleProducto.Controls.Add(this.lblTotal);
            this.pnlDetalleProducto.Controls.Add(this.lblStock);
            this.pnlDetalleProducto.Controls.Add(this.lblPrecio);
            this.pnlDetalleProducto.Controls.Add(this.lblId);
            this.pnlDetalleProducto.Controls.Add(this.lblDescripcion);
            this.pnlDetalleProducto.Controls.Add(this.lblMarca);
            this.pnlDetalleProducto.Controls.Add(this.lblTipoDeProducto);
            this.pnlDetalleProducto.Location = new System.Drawing.Point(197, 24);
            this.pnlDetalleProducto.Name = "pnlDetalleProducto";
            this.pnlDetalleProducto.Size = new System.Drawing.Size(294, 297);
            this.pnlDetalleProducto.TabIndex = 10;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(83, 245);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(57, 23);
            this.nudCantidad.TabIndex = 17;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // lblValorNumero
            // 
            this.lblValorNumero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorNumero.Location = new System.Drawing.Point(227, 34);
            this.lblValorNumero.Name = "lblValorNumero";
            this.lblValorNumero.Size = new System.Drawing.Size(50, 19);
            this.lblValorNumero.TabIndex = 16;
            // 
            // lblValorTipoProducto
            // 
            this.lblValorTipoProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorTipoProducto.Location = new System.Drawing.Point(52, 34);
            this.lblValorTipoProducto.Name = "lblValorTipoProducto";
            this.lblValorTipoProducto.Size = new System.Drawing.Size(99, 19);
            this.lblValorTipoProducto.TabIndex = 15;
            // 
            // lblValorStock
            // 
            this.lblValorStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorStock.Location = new System.Drawing.Point(223, 175);
            this.lblValorStock.Name = "lblValorStock";
            this.lblValorStock.Size = new System.Drawing.Size(59, 19);
            this.lblValorStock.TabIndex = 14;
            // 
            // lblValorPrecio
            // 
            this.lblValorPrecio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorPrecio.Location = new System.Drawing.Point(226, 128);
            this.lblValorPrecio.Name = "lblValorPrecio";
            this.lblValorPrecio.Size = new System.Drawing.Size(59, 19);
            this.lblValorPrecio.TabIndex = 13;
            // 
            // lblValorProveedor
            // 
            this.lblValorProveedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorProveedor.Location = new System.Drawing.Point(84, 175);
            this.lblValorProveedor.Name = "lblValorProveedor";
            this.lblValorProveedor.Size = new System.Drawing.Size(78, 19);
            this.lblValorProveedor.TabIndex = 12;
            // 
            // lblValorDescripcion
            // 
            this.lblValorDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorDescripcion.Location = new System.Drawing.Point(106, 87);
            this.lblValorDescripcion.Name = "lblValorDescripcion";
            this.lblValorDescripcion.Size = new System.Drawing.Size(168, 19);
            this.lblValorDescripcion.TabIndex = 11;
            // 
            // lblValorMarca
            // 
            this.lblValorMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorMarca.Location = new System.Drawing.Point(66, 128);
            this.lblValorMarca.Name = "lblValorMarca";
            this.lblValorMarca.Size = new System.Drawing.Size(98, 19);
            this.lblValorMarca.TabIndex = 10;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(4, 245);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 19);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProveedor.Location = new System.Drawing.Point(4, 175);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(78, 19);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Provedor:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.Location = new System.Drawing.Point(211, 245);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(72, 19);
            this.lblValorTotal.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(168, 245);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 19);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStock.Location = new System.Drawing.Point(168, 175);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(51, 19);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(170, 128);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 19);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(157, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(68, 19);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Número:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(7, 87);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 19);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(7, 128);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 19);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // lblTipoDeProducto
            // 
            this.lblTipoDeProducto.AutoSize = true;
            this.lblTipoDeProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDeProducto.Location = new System.Drawing.Point(7, 34);
            this.lblTipoDeProducto.Name = "lblTipoDeProducto";
            this.lblTipoDeProducto.Size = new System.Drawing.Size(43, 19);
            this.lblTipoDeProducto.TabIndex = 0;
            this.lblTipoDeProducto.Text = "Tipo:";
            // 
            // FormDatosProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Yanez.Evelyn._2E.PrimerParcial.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(516, 348);
            this.Controls.Add(this.pnlDetalleProducto);
            this.Controls.Add(this.pnlCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDatosProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del Producto";
            this.Load += new System.EventHandler(this.FormDatosProducto_Load);
            this.pnlCarro.ResumeLayout(false);
            this.pnlCarro.PerformLayout();
            this.pnlDetalleProducto.ResumeLayout(false);
            this.pnlDetalleProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCarro;
        private System.Windows.Forms.Button btnAgregarQuitarCarro;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.ListBox lbCarroDeCompras;
        private System.Windows.Forms.Panel pnlDetalleProducto;
        private System.Windows.Forms.Label lblValorStock;
        private System.Windows.Forms.Label lblValorPrecio;
        private System.Windows.Forms.Label lblValorProveedor;
        private System.Windows.Forms.Label lblValorDescripcion;
        private System.Windows.Forms.Label lblValorMarca;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTipoDeProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblValorNumero;
        private System.Windows.Forms.Label lblValorTipoProducto;
        private System.Windows.Forms.Button btnActualizarCantidad;
        private System.Windows.Forms.Button btnVolver;
    }
}