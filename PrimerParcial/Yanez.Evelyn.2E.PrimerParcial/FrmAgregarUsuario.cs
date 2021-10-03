using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (this.ValidarDatos())
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
                else
                    errorProvider.SetError(txtDni, "El dni ingresado es invalido (Campo Obligatorio)");
            }
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
            // configura los avisos de error
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

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
            // Valida que el campo DNI no este vacio
            if (txtDni.Text.Trim() == string.Empty)
            {
                respuesta = false;
                errorProvider.SetError(txtDni, "Ingresar el DNI (Campo Obligatorio)");
            }
            // Valida que el campo de nombre en caso de no estar vacio tenga solo letras
            if (txtNombre.Text.Length > 0 && !Regex.IsMatch(txtNombre.Text, @"^[a-zA-ZñÑ]+$"))
            {
                errorProvider.SetError(txtNombre, "El nombre puede contener sólo letras (mayuscula y/o minuscula)");
                respuesta = false;
            }
            // Valida que el campo de apellido en caso de no estar vacio tenga solo letras
            if (txtApellido.Text.Length > 0 && !Regex.IsMatch(txtApellido.Text, @"^[a-zA-ZñÑ]+$"))
            {
                errorProvider.SetError(txtApellido, "El apellido puede contener sólo letras (mayuscula y/o minuscula)");
                respuesta = false;
            }
            // Valida que el campo de nombre de usuario no este vacio y tenga solo letras o '_'
            if (txtNombreUsuario.Text.Trim() == string.Empty && txtNombreUsuario.Visible)
            {
                respuesta = false;
                errorProvider.SetError(txtNombreUsuario, "Ingresar la el nombre de usuario (Campo Obligatorio)");
            }
            else if (!Regex.IsMatch(txtNombreUsuario.Text, @"^[a-zA-Z_ñÑ]+$") && txtNombreUsuario.Visible)
            {
                errorProvider.SetError(txtNombreUsuario, "El nombre de usuario puede contener '_' y letras (mayuscula y/o minuscula)");
                respuesta = false;
            }
            // Valida que el campo de contraseña de usuario no este vacio y tenga solo letras, '_','.' y un largo de 8
            if (txtContrasenia.Text.Trim() == string.Empty && txtContrasenia.Visible)
            {
                respuesta = false;
                errorProvider.SetError(txtContrasenia, "Ingresar la Contraseña (Campo Obligatorio)");
            }
            else if ((!Regex.IsMatch(txtContrasenia.Text, @"^[a-zA-Z0-9._ñÑ]+$") || txtContrasenia.Text.Length != 8) && txtContrasenia.Visible)
            {
                errorProvider.SetError(txtContrasenia, "La contraseña puede contener numeros, '.', '_' y letras (mayuscula y/o minuscula) y debe tener un largo de 8");
                respuesta = false;
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
