
namespace Yanez.Evelyn._2E.PrimerParcial
{
    partial class FrmFinalizarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinalizarCompra));
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.pnlResumenDeCarro = new System.Windows.Forms.Panel();
            this.lblValorCantidad = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblValorCostoTotal = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.lblValorSaldo = new System.Windows.Forms.Label();
            this.lblValorDni = new System.Windows.Forms.Label();
            this.lblValorApellido = new System.Windows.Forms.Label();
            this.lblValorNombre = new System.Windows.Forms.Label();
            this.btnContinuarCompra = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombreDelCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.pnlResumenDeCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(16, 102);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowTemplate.Height = 25;
            this.dgvCarrito.Size = new System.Drawing.Size(486, 230);
            this.dgvCarrito.TabIndex = 0;
            this.dgvCarrito.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvCarrito_CellBeginEdit);
            this.dgvCarrito.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrito_CellEndEdit);
            // 
            // pnlResumenDeCarro
            // 
            this.pnlResumenDeCarro.BackColor = System.Drawing.Color.Indigo;
            this.pnlResumenDeCarro.Controls.Add(this.lblValorCantidad);
            this.pnlResumenDeCarro.Controls.Add(this.lblCantidad);
            this.pnlResumenDeCarro.Controls.Add(this.lblValorCostoTotal);
            this.pnlResumenDeCarro.Controls.Add(this.lblCostoTotal);
            this.pnlResumenDeCarro.Controls.Add(this.lblValorSaldo);
            this.pnlResumenDeCarro.Controls.Add(this.lblValorDni);
            this.pnlResumenDeCarro.Controls.Add(this.lblValorApellido);
            this.pnlResumenDeCarro.Controls.Add(this.lblValorNombre);
            this.pnlResumenDeCarro.Controls.Add(this.btnContinuarCompra);
            this.pnlResumenDeCarro.Controls.Add(this.btnFinalizarCompra);
            this.pnlResumenDeCarro.Controls.Add(this.lblSaldo);
            this.pnlResumenDeCarro.Controls.Add(this.lblDniCliente);
            this.pnlResumenDeCarro.Controls.Add(this.lblApellido);
            this.pnlResumenDeCarro.Controls.Add(this.lblNombreDelCliente);
            this.pnlResumenDeCarro.Location = new System.Drawing.Point(1, -4);
            this.pnlResumenDeCarro.Name = "pnlResumenDeCarro";
            this.pnlResumenDeCarro.Size = new System.Drawing.Size(520, 93);
            this.pnlResumenDeCarro.TabIndex = 8;
            // 
            // lblValorCantidad
            // 
            this.lblValorCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValorCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorCantidad.ForeColor = System.Drawing.Color.White;
            this.lblValorCantidad.Location = new System.Drawing.Point(276, 61);
            this.lblValorCantidad.Name = "lblValorCantidad";
            this.lblValorCantidad.Size = new System.Drawing.Size(76, 19);
            this.lblValorCantidad.TabIndex = 27;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(197, 61);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 19);
            this.lblCantidad.TabIndex = 26;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblValorCostoTotal
            // 
            this.lblValorCostoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValorCostoTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorCostoTotal.ForeColor = System.Drawing.Color.White;
            this.lblValorCostoTotal.Location = new System.Drawing.Point(109, 61);
            this.lblValorCostoTotal.Name = "lblValorCostoTotal";
            this.lblValorCostoTotal.Size = new System.Drawing.Size(83, 19);
            this.lblValorCostoTotal.TabIndex = 25;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCostoTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoTotal.ForeColor = System.Drawing.Color.White;
            this.lblCostoTotal.Location = new System.Drawing.Point(15, 61);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(88, 19);
            this.lblCostoTotal.TabIndex = 24;
            this.lblCostoTotal.Text = "Costo Total:";
            // 
            // lblValorSaldo
            // 
            this.lblValorSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValorSaldo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorSaldo.ForeColor = System.Drawing.Color.White;
            this.lblValorSaldo.Location = new System.Drawing.Point(254, 36);
            this.lblValorSaldo.Name = "lblValorSaldo";
            this.lblValorSaldo.Size = new System.Drawing.Size(98, 19);
            this.lblValorSaldo.TabIndex = 23;
            // 
            // lblValorDni
            // 
            this.lblValorDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValorDni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorDni.ForeColor = System.Drawing.Color.White;
            this.lblValorDni.Location = new System.Drawing.Point(254, 11);
            this.lblValorDni.Name = "lblValorDni";
            this.lblValorDni.Size = new System.Drawing.Size(98, 19);
            this.lblValorDni.TabIndex = 22;
            // 
            // lblValorApellido
            // 
            this.lblValorApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValorApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorApellido.ForeColor = System.Drawing.Color.White;
            this.lblValorApellido.Location = new System.Drawing.Point(99, 36);
            this.lblValorApellido.Name = "lblValorApellido";
            this.lblValorApellido.Size = new System.Drawing.Size(93, 19);
            this.lblValorApellido.TabIndex = 21;
            // 
            // lblValorNombre
            // 
            this.lblValorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValorNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorNombre.ForeColor = System.Drawing.Color.White;
            this.lblValorNombre.Location = new System.Drawing.Point(98, 11);
            this.lblValorNombre.Name = "lblValorNombre";
            this.lblValorNombre.Size = new System.Drawing.Size(93, 19);
            this.lblValorNombre.TabIndex = 20;
            // 
            // btnContinuarCompra
            // 
            this.btnContinuarCompra.BackColor = System.Drawing.Color.Silver;
            this.btnContinuarCompra.FlatAppearance.BorderSize = 0;
            this.btnContinuarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuarCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinuarCompra.Location = new System.Drawing.Point(361, 16);
            this.btnContinuarCompra.Name = "btnContinuarCompra";
            this.btnContinuarCompra.Size = new System.Drawing.Size(140, 25);
            this.btnContinuarCompra.TabIndex = 19;
            this.btnContinuarCompra.Text = "Continuar Comprando";
            this.btnContinuarCompra.UseVisualStyleBackColor = false;
            this.btnContinuarCompra.Click += new System.EventHandler(this.btnContinuarCompra_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.Silver;
            this.btnFinalizarCompra.FlatAppearance.BorderSize = 0;
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarCompra.Location = new System.Drawing.Point(361, 54);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(141, 25);
            this.btnFinalizarCompra.TabIndex = 15;
            this.btnFinalizarCompra.Text = "Finalizar compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(197, 36);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(51, 19);
            this.lblSaldo.TabIndex = 12;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDniCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDniCliente.ForeColor = System.Drawing.Color.White;
            this.lblDniCliente.Location = new System.Drawing.Point(197, 11);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(38, 19);
            this.lblDniCliente.TabIndex = 11;
            this.lblDniCliente.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(15, 36);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 19);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombreDelCliente
            // 
            this.lblNombreDelCliente.AutoSize = true;
            this.lblNombreDelCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreDelCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreDelCliente.ForeColor = System.Drawing.Color.White;
            this.lblNombreDelCliente.Location = new System.Drawing.Point(15, 11);
            this.lblNombreDelCliente.Name = "lblNombreDelCliente";
            this.lblNombreDelCliente.Size = new System.Drawing.Size(69, 19);
            this.lblNombreDelCliente.TabIndex = 9;
            this.lblNombreDelCliente.Text = "Nombre:";
            // 
            // FormFinalizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Yanez.Evelyn._2E.PrimerParcial.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(516, 348);
            this.Controls.Add(this.pnlResumenDeCarro);
            this.Controls.Add(this.dgvCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFinalizarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carro De Compras";
            this.Load += new System.EventHandler(this.FormFinalizarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.pnlResumenDeCarro.ResumeLayout(false);
            this.pnlResumenDeCarro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Panel pnlResumenDeCarro;
        private System.Windows.Forms.Button btnContinuarCompra;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombreDelCliente;
        private System.Windows.Forms.Label lblValorCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblValorCostoTotal;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblValorSaldo;
        private System.Windows.Forms.Label lblValorDni;
        private System.Windows.Forms.Label lblValorApellido;
        private System.Windows.Forms.Label lblValorNombre;
    }
}