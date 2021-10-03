
namespace Yanez.Evelyn._2E.PrimerParcial
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblValorRecaudaciónTotal = new System.Windows.Forms.Label();
            this.lblFondoTotal = new System.Windows.Forms.Label();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.chbFiltroPorFecha = new System.Windows.Forms.CheckBox();
            this.dtpFechaDeNegocio = new System.Windows.Forms.DateTimePicker();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.Indigo;
            this.pnlFiltros.Controls.Add(this.lblValorRecaudaciónTotal);
            this.pnlFiltros.Controls.Add(this.lblFondoTotal);
            this.pnlFiltros.Controls.Add(this.btnQuitarFiltro);
            this.pnlFiltros.Controls.Add(this.chbFiltroPorFecha);
            this.pnlFiltros.Controls.Add(this.dtpFechaDeNegocio);
            this.pnlFiltros.Controls.Add(this.txtEmpleado);
            this.pnlFiltros.Controls.Add(this.txtCliente);
            this.pnlFiltros.Controls.Add(this.btnFiltrar);
            this.pnlFiltros.Controls.Add(this.label3);
            this.pnlFiltros.Controls.Add(this.label2);
            this.pnlFiltros.Controls.Add(this.label1);
            this.pnlFiltros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlFiltros.Location = new System.Drawing.Point(2, 2);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(727, 65);
            this.pnlFiltros.TabIndex = 21;
            // 
            // lblValorRecaudaciónTotal
            // 
            this.lblValorRecaudaciónTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorRecaudaciónTotal.ForeColor = System.Drawing.Color.White;
            this.lblValorRecaudaciónTotal.Location = new System.Drawing.Point(182, 39);
            this.lblValorRecaudaciónTotal.Name = "lblValorRecaudaciónTotal";
            this.lblValorRecaudaciónTotal.Size = new System.Drawing.Size(135, 19);
            this.lblValorRecaudaciónTotal.TabIndex = 30;
            // 
            // lblFondoTotal
            // 
            this.lblFondoTotal.AutoSize = true;
            this.lblFondoTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFondoTotal.ForeColor = System.Drawing.Color.White;
            this.lblFondoTotal.Location = new System.Drawing.Point(43, 39);
            this.lblFondoTotal.Name = "lblFondoTotal";
            this.lblFondoTotal.Size = new System.Drawing.Size(135, 19);
            this.lblFondoTotal.TabIndex = 29;
            this.lblFondoTotal.Text = "Recaudación Total:";
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuitarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarFiltro.Location = new System.Drawing.Point(408, 36);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(134, 22);
            this.btnQuitarFiltro.TabIndex = 28;
            this.btnQuitarFiltro.Text = "Quitar Filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = false;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click);
            // 
            // chbFiltroPorFecha
            // 
            this.chbFiltroPorFecha.AutoSize = true;
            this.chbFiltroPorFecha.Location = new System.Drawing.Point(40, 11);
            this.chbFiltroPorFecha.Name = "chbFiltroPorFecha";
            this.chbFiltroPorFecha.Size = new System.Drawing.Size(15, 14);
            this.chbFiltroPorFecha.TabIndex = 27;
            this.chbFiltroPorFecha.UseVisualStyleBackColor = true;
            this.chbFiltroPorFecha.CheckStateChanged += new System.EventHandler(this.chbFiltroPorFecha_CheckStateChanged);
            // 
            // dtpFechaDeNegocio
            // 
            this.dtpFechaDeNegocio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeNegocio.Location = new System.Drawing.Point(117, 4);
            this.dtpFechaDeNegocio.Name = "dtpFechaDeNegocio";
            this.dtpFechaDeNegocio.Size = new System.Drawing.Size(120, 23);
            this.dtpFechaDeNegocio.TabIndex = 26;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(550, 7);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.PlaceholderText = "DNI del Empleado";
            this.txtEmpleado.Size = new System.Drawing.Size(134, 23);
            this.txtEmpleado.TabIndex = 24;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(324, 7);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PlaceholderText = "DNI del Cliente";
            this.txtCliente.Size = new System.Drawing.Size(129, 23);
            this.txtCliente.TabIndex = 23;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Location = new System.Drawing.Point(550, 36);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(134, 22);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(462, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empleado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.Location = new System.Drawing.Point(653, 73);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(36, 113);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowTemplate.Height = 25;
            this.dgvVentas.Size = new System.Drawing.Size(650, 270);
            this.dgvVentas.TabIndex = 18;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(478, 79);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PlaceholderText = "Id de la Venta";
            this.txtBusqueda.Size = new System.Drawing.Size(169, 23);
            this.txtBusqueda.TabIndex = 22;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Yanez.Evelyn._2E.PrimerParcial.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(724, 407);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNegocio;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.CheckBox chbFiltroPorFecha;
        private System.Windows.Forms.Label lblFondoTotal;
        private System.Windows.Forms.Label lblValorRecaudaciónTotal;
    }
}