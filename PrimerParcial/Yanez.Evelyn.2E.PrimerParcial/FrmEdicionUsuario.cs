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
    public partial class FrmEdicionUsuario : FrmAgregarUsuario
    {
        Usuario usuario;

        /// <summary>
        /// Método constructor del formulario
        /// </summary>
        /// <param name="usuario"></param>
        public FrmEdicionUsuario(Usuario usuario) : base()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            if (usuario != null)
            {
                this.usuario = usuario;
            }
            else
            {
                DialogResult = DialogResult.Abort;
                this.Close();
            }

        }

        /// <summary>
        /// Valida y realiza la edicion del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidarDatos())
            {
                int dni = Usuario.ValidarDNI(txtDni.Text);
                if (dni != 0)
                {
                    bool retorno;
                    if (FrmListadoUsuarios.tipoDeEmpleado == ETipoUsuario.Cliente)
                    {
                        retorno = FrmEmpleado.empleado.ActualizarCliente(this.txtNombre.Text, this.txtApellido.Text, dni);
                    }
                    else
                    {
                        retorno = ((Administrador)FrmEmpleado.empleado).ActualizarEmpleado(this.txtNombre.Text, this.txtApellido.Text, dni, this.txtNombreUsuario.Text, this.txtContrasenia.Text, FrmListadoUsuarios.tipoDeEmpleado);
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
                    base.errorProvider.SetError(txtDni, "El dni ingresado es invalido (Campo Obligatorio)");
            }
        }

        /// <summary>
        /// Sobrescribe el evento load del formulairo agregar para incorporar la configuraicon de 
        /// los campos que son propios del editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void FormAgregarUsuario_Load(object sender, EventArgs e)
        {
            base.FormAgregarUsuario_Load(sender,e);
            this.txtContrasenia.Enabled = false;
            this.txtNombreUsuario.Enabled = false;
            this.txtDni.Enabled = false;
            this.CargarDatosUsuario();

        }

        /// <summary>
        /// Carga los datos del usuario a los campos
        /// </summary>
        private void CargarDatosUsuario()
        {
            if (FrmListadoUsuarios.tipoDeEmpleado != ETipoUsuario.Cliente)
            {
                this.txtNombreUsuario.Text = ((Empleado)this.usuario).NombreUsuario;
                this.txtContrasenia.Text = ((Empleado)this.usuario).Contrasenia;
            }

            txtDni.Text = this.usuario.Dni.ToString();
            txtApellido.Text = usuario.Apellido;
            txtNombre.Text = usuario.Nombre;
        }
    }
}
