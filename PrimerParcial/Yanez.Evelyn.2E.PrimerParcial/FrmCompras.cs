using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yanez.Evelyn._2E.PrimerParcial
{
    public partial class FrmCompras : Form
    {
        ErrorProvider alertaInformacion;
        ErrorProvider erroresInformacion;
        ETipoDeProducto tipoDeProducto;

        /// <summary>
        /// Método constructor del formulario
        /// </summary>
        private FrmCompras()
        {
            InitializeComponent();
            alertaInformacion = new ErrorProvider();
            erroresInformacion = new ErrorProvider();
        }
        /// <summary>
        /// Método constructor del formulario
        /// </summary>
        /// <param name="tipoDeProducto"></param>
        public FrmCompras(ETipoDeProducto tipoDeProducto) : this()
        {
            this.tipoDeProducto = tipoDeProducto;
        }

        /// <summary>
        /// Método todo que configura la apariencia y carga el estadado incial de los controles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCompras_Load(object sender, EventArgs e)
        {
            lvProductos.View = View.LargeIcon;
            panel1.BackColor = Color.FromArgb(125, Color.Indigo);
            this.cmbTipoDeProducto.DataSource = Enum.GetValues(typeof(ETipoDeProducto));
            this.cmbTipoDeProducto.SelectedItem = this.tipoDeProducto;

            // Se carga la informacion para utilizar el carro.
            alertaInformacion.Icon = new Icon(Properties.Resources.icoInformacion, 40, 40);
            alertaInformacion.SetError(lblCarrito,"Arrastrar productos para agregar al carro o hacer doble clic para ver el detalle.");

            this.ActualizarProductos();
            this.ActualizarCarro();
        }

        /// <summary>
        /// Método encargado de actualizar el listview de los productos
        /// </summary>
        private void ActualizarProductos()
        {
            Dictionary<Producto, string> listaFiltrada = new Dictionary<Producto, string>();
            lvProductos.Clear();
            switch ((ETipoDeProducto)this.cmbTipoDeProducto.SelectedItem)
            {
                case ETipoDeProducto.Alimento:
                    listaFiltrada = PetShop.FiltrarListadoProducto(typeof(Alimento));
                    break;
                case ETipoDeProducto.Cama:
                    listaFiltrada = PetShop.FiltrarListadoProducto(typeof(Cama));
                    break;
                case ETipoDeProducto.Juguete:
                    listaFiltrada = PetShop.FiltrarListadoProducto(typeof(Juguete));
                    break;
                case ETipoDeProducto.ArticuloDeCuidado:
                    listaFiltrada = PetShop.FiltrarListadoProducto(typeof(ArticuloDeCuidado));
                    break;
                case ETipoDeProducto.Farmacia:
                    listaFiltrada = PetShop.FiltrarListadoProducto(typeof(ArticuloDeFarmacia));
                    break;
                case ETipoDeProducto.Limpieza:
                    listaFiltrada = PetShop.FiltrarListadoProducto(typeof(Limpieza));
                    break;
            }

            ImageList listaDeImagenes = new ImageList();
            ResourceManager adminDeRecursos = Properties.Resources.ResourceManager;
            int i = 0;
            foreach (KeyValuePair<Producto, string> producto in listaFiltrada)
            {
                Bitmap imagen = (Bitmap)adminDeRecursos.GetObject(producto.Value);
                listaDeImagenes.Images.Add(imagen);
                lvProductos.Items.Add(producto.Key.Id.ToString(), producto.Key.Descripcion, i);
                i++;
            }
            listaDeImagenes.ImageSize = new Size(75, 80);
            lvProductos.LargeImageList = listaDeImagenes;
        }

        /// <summary>
        /// Si se genero con dos clicks y tiene un item seleccionado 
        /// arrojara un evento de doble click del mouse y 
        /// si fue con uno solo generara un evento de drag and drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvProductos_MouseDown(object sender, MouseEventArgs e)
        {
            erroresInformacion.SetError(lvProductos, "");
            if (e.Clicks == 2 && lvProductos.SelectedItems.Count == 1)
            {
                lvProductos_MouseDoubleClick(sender, e);
            }
            else
            {
                ListViewItem item = lvProductos.GetItemAt(e.X, e.Y);
                if (item is not null)
                    DoDragDrop(item.Name, DragDropEffects.Copy);
            }
        }

        /// <summary>
        /// Cuando se cambia el producto seleccionado el combobox actualizara el
        /// listview de productos para que muestre el correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipoDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarProductos();
        }

        /// <summary>
        /// Cuando se haga doble click sobre el producto abrira el formulario con
        /// el detalle correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (int.TryParse(lvProductos.SelectedItems[0].Name, out int id))
            {
                Producto producto = PetShop.BuscarProducto(id);
                FrmDatosProducto frmDatosProducto = new FrmDatosProducto(producto);
                this.Visible = false;
                frmDatosProducto.ShowDialog();
                this.Visible = true;
                this.ActualizarCarro();
            }
        }

        /// <summary>
        /// Método encargado de actualizar el listview con el carro 
        /// del cliente
        /// </summary>
        private void ActualizarCarro()
        {
            lvCarroDeCompras.Clear();
            if (FrmEmpleado.cliente is not null)
            {
                int i = 0;
                foreach (KeyValuePair<Producto, int> producto in FrmEmpleado.cliente.Carrito)
                {
                    string datosAMostrar = $"{producto.Value} - {(string)producto.Key}";
                    lvCarroDeCompras.Items.Add(producto.Key.Id.ToString(), datosAMostrar,i);
                    i++;
                }
            }
        }

        /// <summary>
        /// Al recibir una entrada validara si el producto se encuentra en el canasto
        /// y en caso no estarlo validara que el local tenga stock del mismo y lo agregara.
        /// Caso contrario seteara el errorprovider con el error correspondiente.
        /// </summary>7
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvCarroDeCompras_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        private void lvCarroDeCompras_DragDrop(object sender, DragEventArgs e)
        {
            string strId = (string)e.Data.GetData(DataFormats.Text);

            if (int.TryParse(strId, out int id) && !FrmEmpleado.cliente.ValidarProductoEnCanasto(id))
            {
                Producto producto = PetShop.BuscarProducto(id);
                if (producto.Stock > 0)
                {
                    // Se agrega el producto al carro del cliente.
                    FrmEmpleado.cliente[id] = producto;
                    this.ActualizarCarro();
                }
                else
                {
                    erroresInformacion.SetError(lvProductos, "No se pudo agregar el producto. No tenemos stock.");
                }
            }
            else
            {
                erroresInformacion.SetError(lvProductos, "El producto no se pudo agregar, ya se encontraba en el canasto.");
            }
        }

        /// <summary>
        /// Vaciara el carrito y actualizara el listview del mismo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            FrmEmpleado.cliente.Carrito.Clear();
            this.ActualizarCarro();
        }

        /// <summary>
        /// Eliminara el producto del carro y actualizara el listview del mismo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTirarProducto_Click(object sender, EventArgs e)
        {
            if (this.lvCarroDeCompras.SelectedItems.Count > 0)
            {
                if (int.TryParse(this.lvCarroDeCompras.SelectedItems[0].Name, out int id))
                {
                    Producto producto = PetShop.BuscarProducto(id);
                    if (producto is not null)
                    {
                        FrmEmpleado.cliente.Carrito.Remove(producto);
                        this.ActualizarCarro();
                    }
                }
            }
        }

        /// <summary>
        /// Cerrara el formulario y volvera al anteiror.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
