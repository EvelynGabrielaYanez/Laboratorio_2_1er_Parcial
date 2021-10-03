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
    public partial class FrmInicioSesion : Form
    {
        ErrorProvider errorProvider;
        /// <summary>
        /// Método constructor del formulario
        /// </summary>
        public FrmInicioSesion()
        {
            InitializeComponent();
            this.errorProvider = new ErrorProvider();
        }


        /// <summary>
        /// Configura la apariencia de los controles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInicioSecion_Load(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.pnlAutocompletar.BackColor = Color.FromArgb(100, Color.Silver);
            this.pnlErrorUsuario.BackColor = Color.FromArgb(100, Color.Silver);
            this.errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.pnlErrorUsuario.Visible = false;
            this.lblUsuarioInvalido.Visible = false;
        }

        /// <summary>
        /// Valida los datos ingresados y en caso de ser validos
        /// inicia la sesion y abre el menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (this.ValidarDatos())
            {
                // Valida el DNI ingresado
                int dni = Usuario.ValidarDNI(this.txtDni.Text);
                if (dni != 0)
                {
                    Empleado bufferEmpleado = new Empleado(dni, this.txtNombreUsuario.Text, this.txtNombreContrasenia.Text);
                    // Busca el empleado en el listado de empelados del PetSop y valida los datos ingresados
                    if (PetShop.BuscarYValidarUsuario(bufferEmpleado, out Usuario empleado))
                    {
                        FrmEmpleado frmEmpleado = new FrmEmpleado();
                        FrmEmpleado.empleado = (Empleado)empleado;
                        this.Visible = false;
                        frmEmpleado.ShowDialog();
                        this.Visible = true;

                        this.pnlErrorUsuario.Visible = false;
                        this.lblUsuarioInvalido.Visible = false;
                    }
                    else
                    {
                        this.pnlErrorUsuario.Visible = true;
                        this.lblUsuarioInvalido.Visible = true;
                    }

                }

            }

        }

        /// <summary>
        /// Método encargado de validar los datos ingresados por el usuario
        /// </summary>
        /// <returns></returns>
        private bool ValidarDatos()
        {
            bool respuesta = true;
            errorProvider.SetError(txtNombreUsuario, "");
            errorProvider.SetError(txtNombreContrasenia, "");
            errorProvider.SetError(txtDni, "");
            if (txtNombreUsuario.Text.Trim() == string.Empty)
            {
                respuesta = false;
                errorProvider.SetError(txtNombreUsuario, "Ingresar el Nombre del Usuario");
            }

            if (txtNombreContrasenia.Text.Trim() == string.Empty)
            {
                respuesta = false;
                errorProvider.SetError(txtNombreContrasenia, "Ingresar la Contraseña");
            }
            if (txtDni.Text.Trim() == string.Empty)
            {
                respuesta = false;
                errorProvider.SetError(txtDni, "Ingresar el DNI");
            }
            if (Usuario.ValidarDNI(txtDni.Text) == 0)
            {
                respuesta = false;
                errorProvider.SetError(txtDni, "El dni ingresado es invalido");
            }
            return respuesta;
        }

        /// <summary>
        /// Abre el formulario de autocomepletado y si correpsonde carga los datos del mismo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAutocompletar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmAutocompletar frmAutocompletar = new FrmAutocompletar();
            if (DialogResult.Cancel != frmAutocompletar.ShowDialog())
            {
                Empleado empleado = FrmAutocompletar.empleado;
                if (empleado != null)
                    this.CompletarDatos(empleado);
                else
                    MessageBox.Show("No hay ningun usuario cargado con el tipo pedido.");
            }

        }

        /// <summary>
        /// Metodo encargado de compeltar los textbox con los datos del empleado
        /// </summary>
        /// <param name="empelado"></param>
        private void CompletarDatos(Empleado empelado)
        {
            this.txtNombreContrasenia.Text = empelado.Contrasenia;
            this.txtNombreUsuario.Text = empelado.NombreUsuario;
            this.txtDni.Text = empelado.Dni.ToString();
        }

    }
}
