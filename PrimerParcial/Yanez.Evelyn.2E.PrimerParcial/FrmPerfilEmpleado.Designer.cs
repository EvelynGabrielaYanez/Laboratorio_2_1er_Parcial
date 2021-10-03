
namespace Yanez.Evelyn._2E.PrimerParcial
{
    partial class FrmPerfilEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfilEmpleado));
            this.pnlEmpleado = new System.Windows.Forms.Panel();
            this.picImagenUsuario = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblValorNombreUsuario = new System.Windows.Forms.Label();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblValorDNI = new System.Windows.Forms.Label();
            this.lblValorApellido = new System.Windows.Forms.Label();
            this.lblValorNombre = new System.Windows.Forms.Label();
            this.pnlEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenUsuario)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmpleado
            // 
            this.pnlEmpleado.BackColor = System.Drawing.Color.Indigo;
            this.pnlEmpleado.Controls.Add(this.picImagenUsuario);
            this.pnlEmpleado.Controls.Add(this.btnVolver);
            this.pnlEmpleado.Location = new System.Drawing.Point(1, -1);
            this.pnlEmpleado.Name = "pnlEmpleado";
            this.pnlEmpleado.Size = new System.Drawing.Size(174, 351);
            this.pnlEmpleado.TabIndex = 8;
            // 
            // picImagenUsuario
            // 
            this.picImagenUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picImagenUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagenUsuario.Image = global::Yanez.Evelyn._2E.PrimerParcial.Properties.Resources.imgAdmin;
            this.picImagenUsuario.InitialImage = null;
            this.picImagenUsuario.Location = new System.Drawing.Point(17, 36);
            this.picImagenUsuario.Name = "picImagenUsuario";
            this.picImagenUsuario.Size = new System.Drawing.Size(140, 140);
            this.picImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagenUsuario.TabIndex = 20;
            this.picImagenUsuario.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Silver;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(17, 283);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 25);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblValorNombreUsuario
            // 
            this.lblValorNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblValorNombreUsuario.Location = new System.Drawing.Point(133, 146);
            this.lblValorNombreUsuario.Name = "lblValorNombreUsuario";
            this.lblValorNombreUsuario.Size = new System.Drawing.Size(132, 19);
            this.lblValorNombreUsuario.TabIndex = 18;
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreDeUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(33, 146);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(70, 19);
            this.lblNombreDeUsuario.TabIndex = 12;
            this.lblNombreDeUsuario.Text = "Usuario:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.Black;
            this.lblDni.Location = new System.Drawing.Point(33, 192);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(38, 19);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(33, 100);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 19);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(31, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.lblValorDNI);
            this.pnlDatos.Controls.Add(this.lblValorNombreUsuario);
            this.pnlDatos.Controls.Add(this.lblNombreDeUsuario);
            this.pnlDatos.Controls.Add(this.lblValorApellido);
            this.pnlDatos.Controls.Add(this.lblValorNombre);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.lblApellido);
            this.pnlDatos.Controls.Add(this.lblDni);
            this.pnlDatos.Location = new System.Drawing.Point(197, 35);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(299, 272);
            this.pnlDatos.TabIndex = 9;
            // 
            // lblValorDNI
            // 
            this.lblValorDNI.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorDNI.ForeColor = System.Drawing.Color.Black;
            this.lblValorDNI.Location = new System.Drawing.Point(135, 192);
            this.lblValorDNI.Name = "lblValorDNI";
            this.lblValorDNI.Size = new System.Drawing.Size(131, 19);
            this.lblValorDNI.TabIndex = 16;
            // 
            // lblValorApellido
            // 
            this.lblValorApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorApellido.ForeColor = System.Drawing.Color.Black;
            this.lblValorApellido.Location = new System.Drawing.Point(133, 100);
            this.lblValorApellido.Name = "lblValorApellido";
            this.lblValorApellido.Size = new System.Drawing.Size(132, 19);
            this.lblValorApellido.TabIndex = 15;
            // 
            // lblValorNombre
            // 
            this.lblValorNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorNombre.ForeColor = System.Drawing.Color.Black;
            this.lblValorNombre.Location = new System.Drawing.Point(134, 54);
            this.lblValorNombre.Name = "lblValorNombre";
            this.lblValorNombre.Size = new System.Drawing.Size(131, 19);
            this.lblValorNombre.TabIndex = 14;
            // 
            // FrmPerfilEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Yanez.Evelyn._2E.PrimerParcial.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(516, 348);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPerfilEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Perfil";
            this.Load += new System.EventHandler(this.FrmPerfilEmpleado_Load);
            this.pnlEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenUsuario)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmpleado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblValorNombreUsuario;
        private System.Windows.Forms.Label lblValorDNI;
        private System.Windows.Forms.Label lblValorApellido;
        private System.Windows.Forms.Label lblValorNombre;
        private System.Windows.Forms.PictureBox picImagenUsuario;
    }
}