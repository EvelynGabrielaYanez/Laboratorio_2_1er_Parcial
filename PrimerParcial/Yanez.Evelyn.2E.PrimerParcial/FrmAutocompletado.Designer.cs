
namespace Yanez.Evelyn._2E.PrimerParcial
{
    partial class FrmAutocompletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutocompletar));
            this.cmbEmpleado = new System.Windows.Forms.CheckBox();
            this.cmbAdministrador = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pnlFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.AutoSize = true;
            this.cmbEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbEmpleado.Location = new System.Drawing.Point(21, 44);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(95, 23);
            this.cmbEmpleado.TabIndex = 0;
            this.cmbEmpleado.Text = "Empleado";
            this.cmbEmpleado.UseVisualStyleBackColor = true;
            this.cmbEmpleado.CheckedChanged += new System.EventHandler(this.ChbEmpleado_CheckedChanged);
            // 
            // cmbAdministrador
            // 
            this.cmbAdministrador.AutoSize = true;
            this.cmbAdministrador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbAdministrador.Location = new System.Drawing.Point(128, 44);
            this.cmbAdministrador.Name = "cmbAdministrador";
            this.cmbAdministrador.Size = new System.Drawing.Size(125, 23);
            this.cmbAdministrador.TabIndex = 1;
            this.cmbAdministrador.Text = "Administrador";
            this.cmbAdministrador.UseVisualStyleBackColor = true;
            this.cmbAdministrador.CheckedChanged += new System.EventHandler(this.cmbAdministrador_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(20, 77);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 21);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(135, 77);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 21);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione el tipo de usuario:";
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.label1);
            this.pnlFondo.Controls.Add(this.btnAceptar);
            this.pnlFondo.Controls.Add(this.cmbAdministrador);
            this.pnlFondo.Controls.Add(this.btnCancelar);
            this.pnlFondo.Controls.Add(this.cmbEmpleado);
            this.pnlFondo.Location = new System.Drawing.Point(16, 14);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(256, 112);
            this.pnlFondo.TabIndex = 5;
            // 
            // FrmAutocompletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Yanez.Evelyn._2E.PrimerParcial.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(291, 140);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAutocompletar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autocompletar";
            this.Load += new System.EventHandler(this.FrmAutocompletar_Load);
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cmbEmpleado;
        private System.Windows.Forms.CheckBox cmbAdministrador;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFondo;
    }
}