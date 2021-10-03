using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Yanez.Evelyn._2E.PrimerParcial
{
    public partial class FrmListadoUsuarios : Form
    {
        public static ETipoUsuario tipoDeEmpleado;
        static List<Usuario> fuenteDeInformacion;

        /// <summary>
        /// Método constructor del formulario
        /// </summary>
        public FrmListadoUsuarios()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Configura la aparienciay carga los valores a los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormListadoUsuarios_Load(object sender, EventArgs e)
        {
            panelTipos.BackColor = Color.FromArgb(125, Color.Indigo);
            pnlActivos.BackColor = Color.FromArgb(100, Color.Silver);
            pnlInactivos.BackColor = Color.FromArgb(100, Color.Silver);
            if (FrmEmpleado.empleado.GetType() == typeof(Administrador))
            {
                this.cmbTipoUsuario.DataSource = Enum.GetValues(typeof(ETipoUsuario));
            }
            else
            {
                this.cmbTipoUsuario.Items.Add(ETipoUsuario.Cliente);
                this.cmbTipoUsuario.SelectedIndex = 0;
            }

            tipoDeEmpleado = (ETipoUsuario)this.cmbTipoUsuario.SelectedItem;
        }

        /// <summary>
        /// Actualiza el DataGrid con la información filtrada y configura las columas
        /// </summary>
        private void ActualizarDataGrid()
        {
            // Cargo la fuente
            switch (FrmListadoUsuarios.tipoDeEmpleado)
            {
                case ETipoUsuario.Administador:
                    fuenteDeInformacion = PetShop.FiltrarListadoUsuario(typeof(Administrador), false);
                    this.dgUsuarios.DataSource = fuenteDeInformacion.Cast<Administrador>().ToList();
                    break;
                case ETipoUsuario.Empleado:
                    fuenteDeInformacion = PetShop.FiltrarListadoUsuario(typeof(Empleado), false);
                    this.dgUsuarios.DataSource = fuenteDeInformacion.Cast<Empleado>().ToList();
                    break;
                case ETipoUsuario.Cliente:
                    fuenteDeInformacion = PetShop.FiltrarListadoUsuario(typeof(Cliente));
                    this.dgUsuarios.DataSource = fuenteDeInformacion.Cast<Cliente>().ToList();
                    // configuro los campos
                    this.dgUsuarios.Columns["Carrito"].Visible = false;
                    break;
            }
            // Se corrige la visa de los nombre con camellCase
            if (FrmListadoUsuarios.tipoDeEmpleado == ETipoUsuario.Administador ||
                FrmListadoUsuarios.tipoDeEmpleado == ETipoUsuario.Empleado)
            {
                this.dgUsuarios.Columns["NombreUsuario"].HeaderText = "Nombre de Usuario";
                this.dgUsuarios.Columns["Contrasenia"].HeaderText = "Contraseña";
            }
        }

        /// <summary>
        /// Actualiza el datagred y configura la visibilidad segun el usuario logeado y
        /// el tipo de usuario seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmListadoUsuarios.tipoDeEmpleado = (ETipoUsuario)this.cmbTipoUsuario.SelectedItem;
            this.ActualizarDataGrid();
            if (FrmListadoUsuarios.tipoDeEmpleado == ETipoUsuario.Cliente)
            {
                btnEliminar.Visible = false;
                chbActivos.Visible = false;
                chbInactivos.Visible = false;
                pnlActivos.Visible = false;
                pnlInactivos.Visible = false;
                btnSaldo.Visible = true;
            }
            else
            {
                btnEliminar.Visible = true;
                chbActivos.Visible = true;
                chbInactivos.Visible = true;
                pnlActivos.Visible = true;
                pnlInactivos.Visible = true;
                btnSaldo.Visible = false;
            }
        }

        /// <summary>
        /// Obtiene los datos seleccionados del datagred y retorna la
        /// referencia al usuario del listado de usuarios del petshop correspondiente
        /// </summary>
        /// <returns></returns>
        private Usuario ObtenerDatosDeSeleccion()
        {
            Usuario usuario = null;
            // En caso de no haber ninguna fila le asigno -1
            int indiceFila = dgUsuarios.CurrentRow is null ? -1 : dgUsuarios.CurrentRow.Index;
            if (indiceFila >= 0)
            {
                DataGridViewRow fila = dgUsuarios.Rows[indiceFila];
                int dni = (int)fila.Cells["dni"].Value;
                string nombre = fila.Cells["nombre"].Value.ToString();
                string apellido = fila.Cells["apellido"].Value.ToString();
                switch ((ETipoUsuario)this.cmbTipoUsuario.SelectedItem)
                {
                    case ETipoUsuario.Administador:
                    case ETipoUsuario.Empleado:
                        string nombreUsuario = fila.Cells["nombreUsuario"].Value.ToString();
                        string contrasenia = fila.Cells["contrasenia"].Value.ToString();
                        usuario = new Empleado(dni, nombre, apellido, nombreUsuario, contrasenia);
                        break;
                    case ETipoUsuario.Cliente:
                        double dineroInvertido = (double)fila.Cells["saldo"].Value;
                        usuario = new Cliente(dni, nombre, apellido);
                        break;
                }
            }
            return usuario;
        }

        /// <summary>
        /// Realiza la baja logica del usuario seleccionado. Estando este en el listado
        /// de usuarios del petshop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usuarioSeleccionado = this.ObtenerDatosDeSeleccion();
            if (usuarioSeleccionado != null)
            {
                if (!((Administrador)FrmEmpleado.empleado).EliminarUsuario(usuarioSeleccionado.Dni))
                {
                    MessageBox.Show("Ocurrio un error al intentar eliminar el usuario");
                }
                else
                {
                    this.HacerSonidoExito();
                    this.ActualizarDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el usuario que desea eliminar");
            }
        }

        /// <summary>
        /// Edita el usuario seleccionado el la lista de usuarios del petshop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuario = this.ObtenerDatosDeSeleccion();
            if (usuario != null)
            {
                FrmEdicionUsuario frmEdicionUsuario = new FrmEdicionUsuario(usuario);
                if (frmEdicionUsuario.ShowDialog() == DialogResult.OK)
                {
                    this.HacerSonidoExito();
                    this.ActualizarDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el usuario que desea modificar");
            }
        }

        /// <summary>
        /// Agrega el usuario seleccionado el la lista de usuarios del petshop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario frmAgregarUsuario = new FrmAgregarUsuario();
            if (frmAgregarUsuario.ShowDialog() == DialogResult.OK)
            {
                this.HacerSonidoExito();
            }
        }

        /// <summary>
        /// Método que realiza sonido de éxito con los media de windows
        /// </summary>
        private void HacerSonidoExito()
        {
            string sonidoExito = @"C:\Windows\Media\chimes.wav";
            this.ActualizarDataGrid();
            SoundPlayer sonido = new SoundPlayer(sonidoExito);
            sonido.Play();
        }

        /// <summary>
        /// Método que busca y filtra el datagrid por el id pasado por parametro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Usuario> datosFiltrados = fuenteDeInformacion.ToList().Where(usuario =>
            {
                bool respuesta = true;
                if (int.TryParse(txtBuscar.Text,out int dni))
                    respuesta &= usuario.Dni == dni;
                if (usuario is Empleado)
                {
                    if(chbActivos.Checked != chbInactivos.Checked)
                        respuesta &= ((Empleado)usuario).Activo == (chbActivos.Checked && !chbInactivos.Checked);
                }
                return respuesta;
            }).ToList();

            this.ActualizarFiltrado(datosFiltrados);
        }

        /// <summary>
        /// Método que recibe una lista de usuarios que puede o no estar filtada y 
        /// actualiza la fuente del datagrid con la misma.
        /// </summary>
        /// <param name="datosFiltrados"></param>
        private void ActualizarFiltrado(List<Usuario> datosFiltrados)
        {
            switch (FrmListadoUsuarios.tipoDeEmpleado)
            {
                case ETipoUsuario.Administador:
                case ETipoUsuario.Empleado:
                    dgUsuarios.DataSource = datosFiltrados.Cast<Empleado>().ToList();
                    break;
                case ETipoUsuario.Cliente:
                    dgUsuarios.DataSource = datosFiltrados.Cast<Cliente>().ToList();
                    // configuro los campos
                    this.dgUsuarios.Columns["Carrito"].Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Abre el formulario para la carga de saldo del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaldo_Click(object sender, EventArgs e)
        {
            Usuario usuario = this.ObtenerDatosDeSeleccion();
            if (usuario != null && usuario is Cliente)
            {
                FrmCargarSaldo frmCargarSaldo = new FrmCargarSaldo((Cliente)PetShop.BuscarCliente((Cliente)usuario));
                if (frmCargarSaldo.ShowDialog() == DialogResult.OK)
                {
                    this.HacerSonidoExito();
                    this.ActualizarDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el cliente que desea modificar");
            }
        }
    }
}
