using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yanez.Evelyn._2E.PrimerParcial
{
    public partial class FrmCargarSaldo : Form
    {
        Cliente cliente;

        /// <summary>
        /// Método constructor del formulario
        /// </summary>
        /// <param name="cliente"></param>
        public FrmCargarSaldo(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            nudMontoIngresado.Maximum = decimal.MaxValue;
            nudMontoIngresado.Minimum = 1;
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Configura las vistas y apariencia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCargarSaldo_Load(object sender, EventArgs e)
        {
            this.pnlFondo.BackColor = Color.FromArgb(100, Color.Silver);
            this.ConfigurarVistas();
        }

        /// <summary>
        /// Método encargado de configurar la vistas
        /// </summary>
        public void ConfigurarVistas()
        {
            this.lblValorApellido.Text = this.cliente.Apellido;
            this.lblValorNombre.Text = this.cliente.Nombre;
            this.lblValorDni.Text = this.cliente.Dni.ToString();
            this.lblValorSaldoActual.Text = this.cliente.Saldo.ToString();
        }

        /// <summary>
        /// Carga el saldo al cliente y cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarSaldo_Click(object sender, EventArgs e)
        {
            if (this.cliente.CargarSaldo((double)nudMontoIngresado.Value))
                DialogResult = DialogResult.OK;

            this.Close();
        }

        /// <summary>
        /// Calcula el total correspondiente a la posible modificacion de saldo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudMontoIngresado_ValueChanged(object sender, EventArgs e)
        {
            this.CalcularTotal();
        }

        /// <summary>
        /// Método que realiza el calculo del saldo final en funcion del 
        /// monto a ingresar y el saldo actual del cleinte
        /// </summary>
        private void CalcularTotal()
        {
            lblValorSaldoFinal.Text = (this.cliente.Saldo + (double)this.nudMontoIngresado.Value).ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
