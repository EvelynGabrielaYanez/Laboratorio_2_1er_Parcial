
namespace Yanez.Evelyn._2E.PrimerParcial
{
    partial class FrmCargarSaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarSaldo));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblValorNombre = new System.Windows.Forms.Label();
            this.lblValorApellido = new System.Windows.Forms.Label();
            this.lblValorDni = new System.Windows.Forms.Label();
            this.lblMontoIngresado = new System.Windows.Forms.Label();
            this.nudMontoIngresado = new System.Windows.Forms.NumericUpDown();
            this.btnCargarSaldo = new System.Windows.Forms.Button();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.lblSaldoFinal = new System.Windows.Forms.Label();
            this.lblValorSaldoActual = new System.Windows.Forms.Label();
            this.lblValorSaldoFinal = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlFondo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoIngresado)).BeginInit();
            this.pnlFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(10, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(10, 41);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 19);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(10, 71);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(38, 19);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI:";
            // 
            // lblValorNombre
            // 
            this.lblValorNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorNombre.Location = new System.Drawing.Point(152, 10);
            this.lblValorNombre.Name = "lblValorNombre";
            this.lblValorNombre.Size = new System.Drawing.Size(101, 20);
            this.lblValorNombre.TabIndex = 3;
            // 
            // lblValorApellido
            // 
            this.lblValorApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorApellido.Location = new System.Drawing.Point(152, 39);
            this.lblValorApellido.Name = "lblValorApellido";
            this.lblValorApellido.Size = new System.Drawing.Size(101, 20);
            this.lblValorApellido.TabIndex = 4;
            // 
            // lblValorDni
            // 
            this.lblValorDni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorDni.Location = new System.Drawing.Point(152, 68);
            this.lblValorDni.Name = "lblValorDni";
            this.lblValorDni.Size = new System.Drawing.Size(101, 20);
            this.lblValorDni.TabIndex = 5;
            // 
            // lblMontoIngresado
            // 
            this.lblMontoIngresado.AutoSize = true;
            this.lblMontoIngresado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMontoIngresado.Location = new System.Drawing.Point(10, 131);
            this.lblMontoIngresado.Name = "lblMontoIngresado";
            this.lblMontoIngresado.Size = new System.Drawing.Size(128, 19);
            this.lblMontoIngresado.TabIndex = 6;
            this.lblMontoIngresado.Text = "Monto Ingresado:";
            // 
            // nudMontoIngresado
            // 
            this.nudMontoIngresado.DecimalPlaces = 2;
            this.nudMontoIngresado.Location = new System.Drawing.Point(152, 132);
            this.nudMontoIngresado.Name = "nudMontoIngresado";
            this.nudMontoIngresado.Size = new System.Drawing.Size(101, 23);
            this.nudMontoIngresado.TabIndex = 7;
            this.nudMontoIngresado.ValueChanged += new System.EventHandler(this.nudMontoIngresado_ValueChanged);
            // 
            // btnCargarSaldo
            // 
            this.btnCargarSaldo.Location = new System.Drawing.Point(135, 192);
            this.btnCargarSaldo.Name = "btnCargarSaldo";
            this.btnCargarSaldo.Size = new System.Drawing.Size(118, 25);
            this.btnCargarSaldo.TabIndex = 8;
            this.btnCargarSaldo.Text = "Cargar Saldo";
            this.btnCargarSaldo.UseVisualStyleBackColor = true;
            this.btnCargarSaldo.Click += new System.EventHandler(this.btnCargarSaldo_Click);
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoActual.Location = new System.Drawing.Point(10, 101);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(97, 19);
            this.lblSaldoActual.TabIndex = 9;
            this.lblSaldoActual.Text = "Saldo Actual:";
            // 
            // lblSaldoFinal
            // 
            this.lblSaldoFinal.AutoSize = true;
            this.lblSaldoFinal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoFinal.Location = new System.Drawing.Point(10, 161);
            this.lblSaldoFinal.Name = "lblSaldoFinal";
            this.lblSaldoFinal.Size = new System.Drawing.Size(86, 19);
            this.lblSaldoFinal.TabIndex = 10;
            this.lblSaldoFinal.Text = "Saldo Final:";
            // 
            // lblValorSaldoActual
            // 
            this.lblValorSaldoActual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorSaldoActual.Location = new System.Drawing.Point(152, 97);
            this.lblValorSaldoActual.Name = "lblValorSaldoActual";
            this.lblValorSaldoActual.Size = new System.Drawing.Size(101, 20);
            this.lblValorSaldoActual.TabIndex = 11;
            // 
            // lblValorSaldoFinal
            // 
            this.lblValorSaldoFinal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorSaldoFinal.Location = new System.Drawing.Point(152, 158);
            this.lblValorSaldoFinal.Name = "lblValorSaldoFinal";
            this.lblValorSaldoFinal.Size = new System.Drawing.Size(101, 20);
            this.lblValorSaldoFinal.TabIndex = 12;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(10, 192);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(118, 25);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.lblNombre);
            this.pnlFondo.Controls.Add(this.btnVolver);
            this.pnlFondo.Controls.Add(this.lblValorApellido);
            this.pnlFondo.Controls.Add(this.lblSaldoFinal);
            this.pnlFondo.Controls.Add(this.lblApellido);
            this.pnlFondo.Controls.Add(this.lblSaldoActual);
            this.pnlFondo.Controls.Add(this.nudMontoIngresado);
            this.pnlFondo.Controls.Add(this.lblValorNombre);
            this.pnlFondo.Controls.Add(this.lblValorSaldoFinal);
            this.pnlFondo.Controls.Add(this.lblValorDni);
            this.pnlFondo.Controls.Add(this.lblMontoIngresado);
            this.pnlFondo.Controls.Add(this.lblValorSaldoActual);
            this.pnlFondo.Controls.Add(this.lblDni);
            this.pnlFondo.Controls.Add(this.btnCargarSaldo);
            this.pnlFondo.Location = new System.Drawing.Point(21, 22);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(263, 230);
            this.pnlFondo.TabIndex = 14;
            // 
            // FrmCargarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Yanez.Evelyn._2E.PrimerParcial.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(306, 275);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Saldo";
            this.Load += new System.EventHandler(this.FrmCargarSaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoIngresado)).EndInit();
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblValorNombre;
        private System.Windows.Forms.Label lblValorApellido;
        private System.Windows.Forms.Label lblValorDni;
        private System.Windows.Forms.Label lblMontoIngresado;
        private System.Windows.Forms.NumericUpDown nudMontoIngresado;
        private System.Windows.Forms.Button btnCargarSaldo;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.Label lblSaldoFinal;
        private System.Windows.Forms.Label lblValorSaldoActual;
        private System.Windows.Forms.Label lblValorSaldoFinal;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnlFondo;
    }
}