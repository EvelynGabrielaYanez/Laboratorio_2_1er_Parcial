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
    public partial class FrmVentas : Form
    {
        /// <summary>
        /// Método constructor
        /// </summary>
        public FrmVentas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Configura la apariencia y completa los campos correspondientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            // Se configuran los paneles
            pnlFiltros.BackColor = Color.FromArgb(125, Color.Indigo);
            // Se configura la apariencia de los botones
            btnFiltrar.BackColor = Color.FromArgb(171, 143, 192);
            btnQuitarFiltro.BackColor = Color.FromArgb(171, 143, 192);

            // Se confgiura los campos de filtro
            chbFiltroPorFecha.Checked = false;
            this.dtpFechaDeNegocio.Enabled = false;
            // Se carga información en dataGridVew
            this.ActualizarDataGridView();
        }

        /// <summary>
        /// Método encargado de actualizar la informacion del datagreed
        /// y la recaudacion total
        /// </summary>
        private void ActualizarDataGridView()
        {
            dgvVentas.DataSource = PetShop.Ventas;
            lblValorRecaudaciónTotal.Text = PetShop.CalcularRecaudacionTotal().ToString();
        }

        /// <summary>
        /// Filtra el datagreid por fecha, dni de usuario o dni de empleado
        /// segun corresponda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDeNegocio = dtpFechaDeNegocio.Value;
            //Filtra y actualiza el dataGridView
            dgvVentas.DataSource = PetShop.Ventas.Where(venta => {
                bool respuesta = true;
                if (chbFiltroPorFecha.Checked)
                    respuesta &= venta.FechaDeNegocio.Date == fechaDeNegocio.Date;
                if (int.TryParse(txtCliente.Text, out int dniCliente))
                    respuesta &= venta.ClienteDNI == dniCliente;
                if (int.TryParse(txtEmpleado.Text, out int dniEmpleado))
                    respuesta &= venta.EmpleadoDNI == dniEmpleado;

                return respuesta;
            }).ToList();
        }

        /// <summary>
        /// Busca y filtra el datagrid por el id de venta del txtbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Venta> datosFiltrados = PetShop.Ventas.ToList().Where(venta => {
                bool respuesta = true;
                if (int.TryParse(txtBusqueda.Text, out int id))
                    respuesta &= venta.Id == id;

                return respuesta;
            }).ToList();
            dgvVentas.DataSource = datosFiltrados;
        }

        /// <summary>
        /// Activa o desactiva el filtro por fecha segun corresponda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbFiltroPorFecha_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbFiltroPorFecha.Checked)
                this.dtpFechaDeNegocio.Enabled = true;
            else
                this.dtpFechaDeNegocio.Enabled = false;
        }

        /// <summary>
        /// Quita el filtro del datagrid y limpia los campos de filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            this.txtCliente.Text = string.Empty;
            this.txtEmpleado.Text = string.Empty;
            chbFiltroPorFecha.Checked = false;
            this.dtpFechaDeNegocio.Enabled = false;
            this.ActualizarDataGridView();
        }
    }
}
