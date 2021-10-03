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
    public partial class FrmListadoProductos : Form
    {
        List<Producto> fuenteDeInformacion;

        /// <summary>
        /// Método constructor del formulario
        /// </summary>
        public FrmListadoProductos()
        {
            InitializeComponent();
            fuenteDeInformacion = new List<Producto>();
        }

        /// <summary>
        /// Confgiura la apariencia y carga los valores de los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            this.panelTipos.BackColor = Color.FromArgb(125, Color.Indigo);
            this.cmbTipoDeProducto.DataSource = Enum.GetValues(typeof(ETipoDeProducto));
            this.ActualizarDataGrid();
        }

        /// <summary>
        /// Busca y filtra la tabla por el id pasado por parametro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Producto> datosFiltrados = fuenteDeInformacion.ToList().Where(usuario =>
            {
                bool respuesta = true;
                if (int.TryParse(txtBuscar.Text, out int id))
                    respuesta &= usuario.Id == id;
                return respuesta;
            }).ToList();

            switch ((ETipoDeProducto)cmbTipoDeProducto.SelectedItem)
            {
                case ETipoDeProducto.Juguete:
                    dgProductos.DataSource = datosFiltrados.Cast<Juguete>().ToList();
                    break;
                case ETipoDeProducto.Cama:
                    dgProductos.DataSource = datosFiltrados.Cast<Cama>().ToList();
                    break;
                case ETipoDeProducto.Alimento:
                    dgProductos.DataSource = datosFiltrados.Cast<Alimento>().ToList();
                    break;
                case ETipoDeProducto.ArticuloDeCuidado:
                    dgProductos.DataSource = datosFiltrados.Cast<ArticuloDeCuidado>().ToList();
                    break;
                case ETipoDeProducto.Farmacia:
                    dgProductos.DataSource = datosFiltrados.Cast<Limpieza>().ToList();
                    break;
                case ETipoDeProducto.Limpieza:
                    dgProductos.DataSource = datosFiltrados.Cast<ArticuloDeFarmacia>().ToList();
                    break;
            }
        }

        /// <summary>
        /// Actializa y filtra el datagrid con la fuente y configura las columnas
        /// </summary>
        private void ActualizarDataGrid()
        {
            // Cargo la fuente
            switch ((ETipoDeProducto)cmbTipoDeProducto.SelectedItem)
            {
                case ETipoDeProducto.Cama:
                    fuenteDeInformacion = PetShop.FiltrarListadoProducto(typeof(Cama)).Keys.ToList();
                    this.dgProductos.DataSource = fuenteDeInformacion.Cast<Cama>().ToList();
                    break;
                case ETipoDeProducto.Alimento:
                    fuenteDeInformacion = PetShop.FiltrarListadoProducto(typeof(Alimento)).Keys.ToList();
                    this.dgProductos.DataSource = fuenteDeInformacion.Cast<Alimento>().ToList();
                    break;
                case ETipoDeProducto.Juguete:
                    fuenteDeInformacion = PetShop.FiltrarListadoProducto(typeof(Juguete)).Keys.ToList();
                    this.dgProductos.DataSource = fuenteDeInformacion.Cast<Juguete>().ToList();
                    break;
                case ETipoDeProducto.ArticuloDeCuidado:
                    fuenteDeInformacion = PetShop.FiltrarListadoProducto(typeof(ArticuloDeCuidado)).Keys.ToList();
                    this.dgProductos.DataSource = fuenteDeInformacion.Cast<ArticuloDeCuidado>().ToList();
                    break;
                case ETipoDeProducto.Farmacia:
                    fuenteDeInformacion = PetShop.FiltrarListadoProducto(typeof(ArticuloDeFarmacia)).Keys.ToList();
                    this.dgProductos.DataSource = fuenteDeInformacion.Cast<ArticuloDeFarmacia>().ToList();
                    break;
                case ETipoDeProducto.Limpieza:
                    fuenteDeInformacion = PetShop.FiltrarListadoProducto(typeof(Limpieza)).Keys.ToList();
                    this.dgProductos.DataSource = fuenteDeInformacion.Cast<Limpieza>().ToList();
                    break;
            }
        }

        /// <summary>
        /// Actualiza el datagrid para filtrarlo segun el tipo de producto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipoDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarDataGrid();
        }


    }
}
