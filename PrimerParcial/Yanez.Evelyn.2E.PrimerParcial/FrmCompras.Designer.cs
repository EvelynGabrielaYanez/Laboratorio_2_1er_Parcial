
namespace Yanez.Evelyn._2E.PrimerParcial
{
    partial class FrmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.lvProductos = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lvCarroDeCompras = new System.Windows.Forms.ListView();
            this.btnTirarProducto = new System.Windows.Forms.Button();
            this.btnVaciarCarrito = new System.Windows.Forms.Button();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lblTipoDeProducto = new System.Windows.Forms.Label();
            this.cmbTipoDeProducto = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvProductos
            // 
            this.lvProductos.AllowDrop = true;
            this.lvProductos.BackColor = System.Drawing.Color.Silver;
            this.lvProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvProductos.HideSelection = false;
            this.lvProductos.Location = new System.Drawing.Point(192, 26);
            this.lvProductos.MultiSelect = false;
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(298, 299);
            this.lvProductos.TabIndex = 0;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvProductos_MouseDoubleClick);
            this.lvProductos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvProductos_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.lvCarroDeCompras);
            this.panel1.Controls.Add(this.btnTirarProducto);
            this.panel1.Controls.Add(this.btnVaciarCarrito);
            this.panel1.Controls.Add(this.lblCarrito);
            this.panel1.Controls.Add(this.lblTipoDeProducto);
            this.panel1.Controls.Add(this.cmbTipoDeProducto);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 345);
            this.panel1.TabIndex = 8;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Silver;
            this.btnVolver.BackgroundImage = global::Yanez.Evelyn._2E.PrimerParcial.Properties.Resources.Volver;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Location = new System.Drawing.Point(14, 287);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(42, 37);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lvCarroDeCompras
            // 
            this.lvCarroDeCompras.AllowDrop = true;
            this.lvCarroDeCompras.BackColor = System.Drawing.Color.Silver;
            this.lvCarroDeCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCarroDeCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCarroDeCompras.HideSelection = false;
            this.lvCarroDeCompras.Location = new System.Drawing.Point(14, 97);
            this.lvCarroDeCompras.MultiSelect = false;
            this.lvCarroDeCompras.Name = "lvCarroDeCompras";
            this.lvCarroDeCompras.Size = new System.Drawing.Size(143, 184);
            this.lvCarroDeCompras.TabIndex = 9;
            this.lvCarroDeCompras.UseCompatibleStateImageBehavior = false;
            this.lvCarroDeCompras.View = System.Windows.Forms.View.SmallIcon;
            this.lvCarroDeCompras.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvCarroDeCompras_DragEnter);
            // 
            // btnTirarProducto
            // 
            this.btnTirarProducto.AllowDrop = true;
            this.btnTirarProducto.BackColor = System.Drawing.Color.Silver;
            this.btnTirarProducto.BackgroundImage = global::Yanez.Evelyn._2E.PrimerParcial.Properties.Resources.tacho;
            this.btnTirarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTirarProducto.FlatAppearance.BorderSize = 0;
            this.btnTirarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTirarProducto.Location = new System.Drawing.Point(114, 287);
            this.btnTirarProducto.Name = "btnTirarProducto";
            this.btnTirarProducto.Size = new System.Drawing.Size(42, 37);
            this.btnTirarProducto.TabIndex = 12;
            this.btnTirarProducto.UseVisualStyleBackColor = false;
            this.btnTirarProducto.Click += new System.EventHandler(this.btnTirarProducto_Click);
            // 
            // btnVaciarCarrito
            // 
            this.btnVaciarCarrito.BackColor = System.Drawing.Color.Silver;
            this.btnVaciarCarrito.BackgroundImage = global::Yanez.Evelyn._2E.PrimerParcial.Properties.Resources.iconoVaciarCarro;
            this.btnVaciarCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVaciarCarrito.Location = new System.Drawing.Point(64, 287);
            this.btnVaciarCarrito.Name = "btnVaciarCarrito";
            this.btnVaciarCarrito.Size = new System.Drawing.Size(42, 37);
            this.btnVaciarCarrito.TabIndex = 11;
            this.btnVaciarCarrito.UseVisualStyleBackColor = false;
            this.btnVaciarCarrito.Click += new System.EventHandler(this.btnVaciarCarrito_Click);
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarrito.ForeColor = System.Drawing.Color.White;
            this.lblCarrito.Location = new System.Drawing.Point(11, 75);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(136, 19);
            this.lblCarrito.TabIndex = 10;
            this.lblCarrito.Text = "Carro de Compras:";
            // 
            // lblTipoDeProducto
            // 
            this.lblTipoDeProducto.AutoSize = true;
            this.lblTipoDeProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDeProducto.ForeColor = System.Drawing.Color.White;
            this.lblTipoDeProducto.Location = new System.Drawing.Point(14, 25);
            this.lblTipoDeProducto.Name = "lblTipoDeProducto";
            this.lblTipoDeProducto.Size = new System.Drawing.Size(130, 19);
            this.lblTipoDeProducto.TabIndex = 9;
            this.lblTipoDeProducto.Text = "Tipo de Producto:";
            // 
            // cmbTipoDeProducto
            // 
            this.cmbTipoDeProducto.FormattingEnabled = true;
            this.cmbTipoDeProducto.Location = new System.Drawing.Point(14, 47);
            this.cmbTipoDeProducto.Name = "cmbTipoDeProducto";
            this.cmbTipoDeProducto.Size = new System.Drawing.Size(143, 23);
            this.cmbTipoDeProducto.TabIndex = 7;
            this.cmbTipoDeProducto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeProducto_SelectedIndexChanged);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(516, 348);
            this.Controls.Add(this.lvProductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTipoDeProducto;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Label lblTipoDeProducto;
        private System.Windows.Forms.Button btnTirarProducto;
        private System.Windows.Forms.Button btnVaciarCarrito;
        private System.Windows.Forms.ListView lvCarroDeCompras;
        private System.Windows.Forms.Button btnVolver;
    }
}