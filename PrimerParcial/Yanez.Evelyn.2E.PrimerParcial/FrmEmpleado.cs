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
    public partial class FrmEmpleado : Form
    {
        public static Empleado empleado;
        public static Cliente cliente;
        int contadorTimer;
        static bool ignorarFormClosing;

        /// <summary>
        /// Método constructor del formulario
        /// </summary>
        public FrmEmpleado()
        {
            InitializeComponent();
            FrmEmpleado.empleado = null;
            FrmEmpleado.cliente = null;
            ignorarFormClosing = false;
        }

        /// <summary>
        /// Pregunta al usuario si desea cerrar la sesión y en caso de desearlo la cierra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ignorarFormClosing)
            {
                if (MessageBox.Show("¿Seguro que desea cerrar sesión?", "Cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
                else
                    FrmEmpleado.empleado = null;
            }
        }

        /// <summary>
        /// Configura la apariencia, las vistas e inicia el timer de actividad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            // Inicializa el timer
            tmrMenuPrincipal.Start();
            // Se configura la apariencia de los paneles
            pnlMenu.BackColor = Color.FromArgb(125,Color.Indigo);
            panelAlimentos.BackColor = Color.FromArgb(125,Color.Silver);
            panelCamas.BackColor = Color.FromArgb(125,Color.Silver);
            panelJuguetes.BackColor = Color.FromArgb(125,Color.Silver);
            panelArticulosDeCuidado.BackColor = Color.FromArgb(125,Color.Silver);
            msMenu.BringToFront();
            pnlMenu.SendToBack();

            // configuro la apariencia del menustrip segun el tipo de empleado
            if (FrmEmpleado.empleado.GetType() == typeof(Administrador))
                msMenu.BackColor = Color.FromArgb(171, 143, 192);
            else
                msMenu.BackColor = Color.Silver;

            // Se configura la apariencia de los botones
            btnBuscarCliente.BackColor = Color.FromArgb(171, 143, 192);
            btnDescartarCompra.BackColor = Color.FromArgb(171, 143, 192);
            btnFinalizarCompra.BackColor = Color.FromArgb(171, 143, 192);

            // Configura el auto completado del dni del cliente
            AutoCompleteStringCollection fuenteDeAutoCompletado = new AutoCompleteStringCollection();
            // Busca la lista de clientes para autocompletar
            List<Cliente> clientes = PetShop.FiltrarListadoUsuario(typeof(Cliente)).Cast<Cliente>().ToList();
            foreach (Cliente cliente in clientes)
            {
                fuenteDeAutoCompletado.Add(cliente.Dni.ToString());
            }

            // configura el textBox del DNI del cliente
            this.txtDniCliente.AutoCompleteCustomSource = fuenteDeAutoCompletado;
            this.txtDniCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtDniCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Completa los labels del Cliente por defecto
            lblNombreDelCliente.Text = $"Nombre:";
            lblApellido.Text = $"Apellido:";
            lblDniCliente.Text = $"DNI:";
            lblSaldo.Text = $"Saldo:";

            // Se bloquean los botones de finalizacion y descarte de venta.
            btnFinalizarCompra.Enabled = false;
            btnDescartarCompra.Enabled = false;

            // se configuran el menu segun el tipo de empleado
            this.VistaSegunEmpleado();
        }

        /// <summary>
        /// Método encargado de configurar las vistas segun el empleado logueado
        /// </summary>
        private void VistaSegunEmpleado()
        {
            if (typeof(Empleado) == FrmEmpleado.empleado.GetType())
                msMenu.Items[0].Visible = false;
        }

        /// <summary>
        /// Cuando detecta movimiento del mouse reinicia el timer
        /// Detecta la posicion del mouse y si muestra o no el 
        /// menu segun corresponda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEmpleado_MouseMove(object sender, MouseEventArgs e)
        {
            this.contadorTimer = 0;
            this.tmrMenuPrincipal.Start();
            if (e.Y <= 10)
                msMenu.Visible = true;
            else
                msMenu.Visible = false;
        }

        /// <summary>
        /// Cuando detecta movimiento del mouse en el panel reinicia el timer
        /// Detecta la posicion del mouse en el panel y si muestra o no el 
        /// menu segun corresponda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlMenu_MouseMove(object sender, MouseEventArgs e)
        {
            this.contadorTimer = 0;
            this.tmrMenuPrincipal.Start();
            if (pnlMenu.PointToClient(Cursor.Position).Y <= 10)
                msMenu.Visible = true;
            else
                msMenu.Visible = false;
        }

        /// <summary>
        /// Abre el formulario del listade de usuarios y le saca la visibilidad al actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void configurarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoUsuarios frmListadoUsuarios = new FrmListadoUsuarios();
            this.Visible = false;
            frmListadoUsuarios.ShowDialog();
            this.Visible = true;
        }

        /// <summary>
        /// Abre el formulario compra en la seccion alimentos y le saca la visibilidad al actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            if (FrmEmpleado.cliente is not null)
            {
                FrmCompras frmCompras = new FrmCompras(ETipoDeProducto.Alimento);
                this.Visible = false;
                frmCompras.ShowDialog();
                this.Visible = true;
            }
        }

        /// <summary>
        /// Abre el formulario compra en la seccion articulos de cuidado y le saca la visibilidad al actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArticulosDeCuidado_Click(object sender, EventArgs e)
        {
            if (FrmEmpleado.cliente is not null)
            {
                FrmCompras frmCompras = new FrmCompras(ETipoDeProducto.ArticuloDeCuidado);
                this.Visible = false;
                frmCompras.ShowDialog();
                this.Visible = true;
            }
        }

        /// <summary>
        /// Abre el formulario compra en la seccion juguetes y le saca la visibilidad al actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJuguetes_Click(object sender, EventArgs e)
        {
            if (FrmEmpleado.cliente is not null)
            {
                FrmCompras frmCompras = new FrmCompras(ETipoDeProducto.Juguete);
                this.Visible = false;
                frmCompras.ShowDialog();
                this.Visible = true;
            }
        }

        /// <summary>
        /// Abre el formulario compra en la seccion camas y le saca la visibilidad al actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCamas_Click(object sender, EventArgs e)
        {
            if (FrmEmpleado.cliente is not null)
            {
                FrmCompras frmCompras = new FrmCompras(ETipoDeProducto.Cama);
                this.Visible = false;
                frmCompras.ShowDialog();
                this.Visible = true;
            }
        }

        /// <summary>
        /// Busca y valida el dni ingresado y carga el cliente junto con sus datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            int dni = Usuario.ValidarDNI(txtDniCliente.Text);
            if (dni != 0)
            {
                FrmEmpleado.cliente = new Cliente(dni, "", "");
                Usuario usuario = PetShop.BuscarCliente(FrmEmpleado.cliente);
                if (usuario != null && usuario.GetType() == typeof(Cliente))
                {
                    FrmEmpleado.cliente = (Cliente)usuario;
                }
                else
                {
                    if (MessageBox.Show("No existe un cliente con el DNI indicado.\n¿Desea registrarlo?", "Cliente No Registrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmListadoUsuarios frmListadoUsuarios = new FrmListadoUsuarios();
                        this.Visible = false;
                        frmListadoUsuarios.ShowDialog();
                        this.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("El DNI ingresado es invalido");
            }
            this.ConfigurarDatosCliente();
        }


        /// <summary>
        /// Método encargado de cargar los datos del cliente si este se encuentra cargado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigurarDatosCliente()
        {
            if (FrmEmpleado.cliente != null)
            {
                lblNombreDelCliente.Text = $"Nombre: {FrmEmpleado.cliente.Nombre}";
                lblApellido.Text = $"Apellido: {FrmEmpleado.cliente.Apellido}";
                lblDniCliente.Text = $"DNI: {FrmEmpleado.cliente.Dni}";
                lblSaldo.Text = $"Saldo: {FrmEmpleado.cliente.Saldo}";
                btnFinalizarCompra.Enabled = true;
                btnDescartarCompra.Enabled = true;
            }
            else
            {
                lblNombreDelCliente.Text = $"Nombre:";
                lblApellido.Text = $"Apellido:";
                lblDniCliente.Text = $"DNI:";
                lblSaldo.Text = $"Saldo:";
                btnFinalizarCompra.Enabled = false;
                btnDescartarCompra.Enabled = false;
            }
        }


        /// <summary>
        /// Realiza el cierre de la sesión pidiendole al usuario una configuración del mismo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarSesionTSM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Descarga la compra para continuar con otra venta.
        /// No vacia el carro del cliente al descartarla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescartarCompra_Click(object sender, EventArgs e)
        {
            this.DescartarComra();
        }

        /// <summary>
        /// Método encargado de descartar la compra y vaciar los campos.
        /// En caso de queresr continuar con la compra mas tarde esta queda almacenada en el carrito del cliente
        /// </summary>
        private void DescartarComra()
        {
            FrmEmpleado.cliente = null;
            this.ConfigurarDatosCliente();
            txtDniCliente.Text = string.Empty;
        }

        /// <summary>
        /// Abre el formulario para finalizar la compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            FrmFinalizarCompra frmFinalizarCompra = new FrmFinalizarCompra(FrmEmpleado.cliente);
            this.Visible = false;
            if (frmFinalizarCompra.ShowDialog() == DialogResult.OK)
                this.DescartarComra();
            else
                this.lblSaldo.Text = $"Saldo: ${FrmEmpleado.cliente.Saldo}";

            this.Visible = true;
        }

        /// <summary>
        /// Abre el formulario del listado de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoProductos frmListadoProductos = new FrmListadoProductos();
            this.Visible = false;
            frmListadoProductos.ShowDialog();
            this.Visible = true;
        }

        /// <summary>
        /// Abre el formulario del listado de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            this.Visible = false;
            frmVentas.ShowDialog();
            this.Visible = true;
        }

        /// <summary>
        /// Ingrementa el timer y cierra la sesión por inactividad si alcanza el tiempo determinado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrMenuPrincipal_Tick(object sender, EventArgs e)
        {
            this.contadorTimer++;
            if (this.contadorTimer == 100)
            {
                ignorarFormClosing = true;
                FormCollection formulariosDeLaApp = Application.OpenForms;
                foreach (Form formulario in formulariosDeLaApp)
                {
                    if (formulario.Name != "FrmInicioSesion" && formulario.Name != "FrmEmpleado")
                        formulario.Close();
                }
                MessageBox.Show("Se cerro la sesión por inactividad","Sesión Finalizada",MessageBoxButtons.OK,MessageBoxIcon.Information);

                this.Close();
            }
        }

        /// <summary>
        /// Cuando cambia la visibilidad a falso detiene  el timer si no lo inicia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEmpleado_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
                this.tmrMenuPrincipal.Stop();
        }

        /// <summary>
        /// Abre el formulario con el perfil del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verPerfilTSM_Click(object sender, EventArgs e)
        {
            FrmPerfilEmpleado frmPerfilEmpleado = new FrmPerfilEmpleado();
            this.Visible = false;
            frmPerfilEmpleado.ShowDialog();
            this.Visible = true;
        }
    }
}
