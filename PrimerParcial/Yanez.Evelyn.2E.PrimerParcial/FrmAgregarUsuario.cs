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
    public partial class FrmAgregarUsuario : Form
    {
        protected ErrorProvider errorProvider;
        public FrmAgregarUsuario()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// Encargado de validar y agregar el nuevo usuario al petshop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.ValidarDatos())
            {
                int dni = Usuario.ValidarDNI(txtDni.Text);
                if (dni != 0)
                {
                    bool retorno;
                    if (FrmListadoUsuarios.tipoDeEmpleado == ETipoUsuario.Cliente)
                    {
                        retorno = FrmEmpleado.empleado.AgregarCliente(txtNombre.Text, txtApellido.Text, dni);
                    }
                    else
                    {
                        retorno = ((Administrador)FrmEmpleado.empleado).AgregarEmpleado(txtNombre.Text, txtApellido.Text, dni, txtNombreUsuario.Text, txtContrasenia.Text, FrmListadoUsuarios.tipoDeEmpleado);
                    }
                    if (!retorno)
                        MessageBox.Show("Ya se encuentra cargado un usuario con ese DNI");
                    else
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
            }
            else
                errorProvider.SetError(txtDni, "El dni ingresado es invalido (Campo Obligatorio)");
        }
        /// <summary>
        /// Configura la visibilidad y apariencia de los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void FormAgregarUsuario_Load(object sender, EventArgs e)
        {
            // Se confgiuran los colores
            this.pnlFondo.BackColor = Color.FromArgb(100, Color.Silver);
            // Configura los campos visibles
            this.ConfiguraVisibilidad();
        }

        /// <summary>
        /// Método encargo de validar los datos de los campos nombre de usuario, contraseña, dni
        /// </summary>
        /// <returns></returns>
        protected bool ValidarDatos()
        {
            bool respuesta = true;
            errorProvider.SetError(txtNombreUsuario, "");
            errorProvider.SetError(txtContrasenia, "");
            errorProvider.SetError(txtDni, "");

            if (txtDni.Text.Trim() == string.Empty)
            {
                respuesta = false;
                errorProvider.SetError(txtDni, "Ingresar el DNI (Campo Obligatorio)");
            }
            if (txtNombreUsuario.Text.Trim() == string.Empty && txtNombreUsuario.Visible)
            {
                respuesta = false;
                errorProvider.SetError(txtNombreUsuario, "Ingresar la Contraseña (Campo Obligatorio)");
            }
            if (txtContrasenia.Text.Trim() == string.Empty && txtContrasenia.Visible)
            {
                respuesta = false;
                errorProvider.SetError(txtContrasenia, "Ingresar la Contraseña (Campo Obligatorio)");
            }
            return respuesta;
        }

        /// <summary>
        /// Método encargado de configurar la visibilidad del formulario
        /// </summary>
        private void ConfiguraVisibilidad()
        {
            if (FrmListadoUsuarios.tipoDeEmpleado == ETipoUsuario.Cliente)
            {
                this.txtNombreUsuario.Visible = false;
                this.txtContrasenia.Visible = false;
                this.lblNombreUsuario.Visible = false;
                this.lblContrasenia.Visible = false;
            }
        }
        /// <summary>
        /// Cancela el proceso de agregado y vuelve al formulario anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
