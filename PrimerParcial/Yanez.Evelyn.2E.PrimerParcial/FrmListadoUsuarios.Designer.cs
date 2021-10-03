
namespace Yanez.Evelyn._2E.PrimerParcial
{
    partial class FrmListadoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoUsuarios));
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoDeUsuario = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelTipos = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.chbInactivos = new System.Windows.Forms.CheckBox();
            this.chbActivos = new System.Windows.Forms.CheckBox();
            this.pnlActivos = new System.Windows.Forms.Panel();
            this.pnlInactivos = new System.Windows.Forms.Panel();
            this.btnSaldo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.panelTipos.SuspendLayout();
            this.pnlActivos.SuspendLayout();
            this.pnlInactivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(157, 16);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(147, 23);
            this.cmbTipoUsuario.TabIndex = 0;
            this.cmbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoUsuario_SelectedIndexChanged);
            // 
            // lblTipoDeUsuario
            // 
            this.lblTipoDeUsuario.AutoSize = true;
            this.lblTipoDeUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDeUsuario.ForeColor = System.Drawing.Color.White;
            this.lblTipoDeUsuario.Location = new System.Drawing.Point(36, 17);
            this.lblTipoDeUsuario.Name = "lblTipoDeUsuario";
            this.lblTipoDeUsuario.Size = new System.Drawing.Size(116, 19);
            this.lblTipoDeUsuario.TabIndex = 1;
            this.lblTipoDeUsuario.Text = "Tipo De Usuario";
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.AllowUserToResizeRows = false;
            this.dgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsuarios.BackgroundColor = System.Drawing.Color.Silver;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(35, 112);
            this.dgUsuarios.MultiSelect = false;
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.RowTemplate.Height = 25;
            this.dgUsuarios.Size = new System.Drawing.Size(650, 270);
            this.dgUsuarios.TabIndex = 2;
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
            this.btnBuscar.Location = new System.Drawing.Point(653, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Silver;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAgregar.Location = new System.Drawing.Point(75, 65);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(35, 34);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Silver;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.Location = new System.Drawing.Point(116, 65);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(35, 34);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Silver;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEditar.Location = new System.Drawing.Point(35, 65);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(34, 34);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panelTipos
            // 
            this.panelTipos.BackColor = System.Drawing.Color.Indigo;
            this.panelTipos.Controls.Add(this.lblTipoDeUsuario);
            this.panelTipos.Controls.Add(this.cmbTipoUsuario);
            this.panelTipos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelTipos.Location = new System.Drawing.Point(-1, -3);
            this.panelTipos.Name = "panelTipos";
            this.panelTipos.Size = new System.Drawing.Size(727, 56);
            this.panelTipos.TabIndex = 10;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(460, 69);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "DNI del Usuario";
            this.txtBuscar.Size = new System.Drawing.Size(186, 23);
            this.txtBuscar.TabIndex = 11;
            // 
            // chbInactivos
            // 
            this.chbInactivos.AutoSize = true;
            this.chbInactivos.BackColor = System.Drawing.Color.Transparent;
            this.chbInactivos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbInactivos.ForeColor = System.Drawing.Color.White;
            this.chbInactivos.Location = new System.Drawing.Point(5, 1);
            this.chbInactivos.Name = "chbInactivos";
            this.chbInactivos.Size = new System.Drawing.Size(87, 23);
            this.chbInactivos.TabIndex = 12;
            this.chbInactivos.Text = "Inactivos";
            this.chbInactivos.UseVisualStyleBackColor = false;
            // 
            // chbActivos
            // 
            this.chbActivos.AutoSize = true;
            this.chbActivos.BackColor = System.Drawing.Color.Transparent;
            this.chbActivos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbActivos.ForeColor = System.Drawing.Color.White;
            this.chbActivos.Location = new System.Drawing.Point(5, 2);
            this.chbActivos.Name = "chbActivos";
            this.chbActivos.Size = new System.Drawing.Size(77, 23);
            this.chbActivos.TabIndex = 13;
            this.chbActivos.Text = "Activos";
            this.chbActivos.UseVisualStyleBackColor = false;
            // 
            // pnlActivos
            // 
            this.pnlActivos.Controls.Add(this.chbActivos);
            this.pnlActivos.Location = new System.Drawing.Point(246, 68);
            this.pnlActivos.Name = "pnlActivos";
            this.pnlActivos.Size = new System.Drawing.Size(87, 24);
            this.pnlActivos.TabIndex = 14;
            // 
            // pnlInactivos
            // 
            this.pnlInactivos.Controls.Add(this.chbInactivos);
            this.pnlInactivos.Location = new System.Drawing.Point(354, 68);
            this.pnlInactivos.Name = "pnlInactivos";
            this.pnlInactivos.Size = new System.Drawing.Size(91, 24);
            this.pnlInactivos.TabIndex = 15;
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.Color.Silver;
            this.btnSaldo.BackgroundImage = global::Yanez.Evelyn._2E.PrimerParcial.Properties.Resources.imgSaldo1;
            this.btnSaldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaldo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSaldo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btnSaldo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSaldo.Location = new System.Drawing.Point(116, 65);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(35, 34);
            this.btnSaldo.TabIndex = 16;
            this.btnSaldo.UseVisualStyleBackColor = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // FrmListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(724, 407);
            this.Controls.Add(this.btnSaldo);
            this.Controls.Add(this.pnlInactivos);
            this.Controls.Add(this.pnlActivos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panelTipos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListadoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Usuarios";
            this.Load += new System.EventHandler(this.FormListadoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.panelTipos.ResumeLayout(false);
            this.panelTipos.PerformLayout();
            this.pnlActivos.ResumeLayout(false);
            this.pnlActivos.PerformLayout();
            this.pnlInactivos.ResumeLayout(false);
            this.pnlInactivos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblTipoDeUsuario;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panelTipos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.CheckBox chbInactivos;
        private System.Windows.Forms.CheckBox chbActivos;
        private System.Windows.Forms.Panel pnlActivos;
        private System.Windows.Forms.Panel pnlInactivos;
        private System.Windows.Forms.Button btnSaldo;
    }
}