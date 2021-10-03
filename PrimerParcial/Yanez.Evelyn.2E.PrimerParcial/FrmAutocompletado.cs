using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Yanez.Evelyn._2E.PrimerParcial
{
    public partial class FrmAutocompletar : Form
    {
        public static Empleado empleado; 
        /// <summary>
        /// Método constructor del formulario
        /// </summary>
        public FrmAutocompletar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se configura la apriencia y ele stado incial de los checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAutocompletar_Load(object sender, EventArgs e)
        {
            this.cmbEmpleado.Checked = true;
            this.pnlFondo.BackColor = Color.FromArgb(125, Color.Silver);
        }

        /// <summary>
        /// En caso de estar tildado el checkbox se deshabilita el de administrador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmbEmpleado.Checked)
                this.cmbAdministrador.Checked = false;
        }

        /// <summary>
        /// En caso de estar tildado el checkbox se deshabilita el de empleado 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmbAdministrador.Checked)
                this.cmbEmpleado.Checked = false;
        }

        /// <summary>
        /// Acepta la seleccion del tipo de usuario autocompletado, busca uno
        /// y lo carga.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            empleado = null;
            if (this.cmbEmpleado.Checked)
            {
                List<Usuario> lista = PetShop.FiltrarListadoUsuario(typeof(Empleado), true);
                if (lista.Count != 0)
                    FrmAutocompletar.empleado = (Empleado)lista[0];
            }
            else
            {
                List<Usuario> lista = PetShop.FiltrarListadoUsuario(typeof(Administrador), true);
                if (lista.Count != 0)
                    FrmAutocompletar.empleado = (Administrador)lista[0];

            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Cancela el autocompletado y vuelve al formulario anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
