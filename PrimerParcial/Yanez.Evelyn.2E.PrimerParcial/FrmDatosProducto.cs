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
    public partial class FrmDatosProducto : Form
    {
        Producto producto;
        /// <summary>
        /// Método constructor del formulario
        /// </summary>
        /// <param name="producto"></param>
        public FrmDatosProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        /// <summary>
        /// Carga los controles y configura la apariencia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDatosProducto_Load(object sender, EventArgs e)
        {
            // Se configura la apariencia
            this.pnlCarro.BackColor = Color.FromArgb(125, Color.Indigo);
            this.pnlDetalleProducto.BackColor = Color.FromArgb(125, Color.Silver);
            this.btnAgregarQuitarCarro.BackColor = Color.FromArgb(125, Color.Silver);

            // Se completan los campos
            this.lblValorDescripcion.Text = this.producto.Descripcion;
            this.lblValorMarca.Text = this.producto.Marca;
            this.lblValorTipoProducto.Text = this.producto.ObtenerTipoDeProducto();
            this.lblValorProveedor.Text = this.producto.Proveedor;
            this.lblValorNumero.Text = this.producto.Id.ToString();
            this.lblValorPrecio.Text = $"$ {this.producto.Precio}";
            this.lblValorStock.Text = this.producto.Stock.ToString();
            this.nudCantidad.Minimum = 0;
            this.nudCantidad.Maximum = decimal.MaxValue;

            this.CalcularPrecioTotal();

            this.ActualizarVista();
        }

        /// <summary>
        /// Método encargado de calcular el precio total
        /// </summary>
        private void CalcularPrecioTotal()
        {
            lblValorTotal.Text = $"$ {(double)nudCantidad.Value * this.producto.Precio}";
        }

        /// <summary>
        /// Agregara el producto al carro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCarro_Click(object sender, EventArgs e)
        {
            if (FrmEmpleado.cliente.ValidarProductoEnCanasto(this.producto.Id))
            {
                FrmEmpleado.cliente.Carrito.Remove(this.producto);
            }
            else
            {
                if(this.producto.Stock > 0)
                    FrmEmpleado.cliente.Carrito.Add(this.producto, (int)nudCantidad.Value);
            }
            this.ActualizarVista();
        }

        /// <summary>
        /// Actualiza la cantidad del producto en el carro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarCantidad_Click(object sender, EventArgs e)
        {
            if (FrmEmpleado.cliente.ValidarProductoEnCanasto(this.producto.Id) && this.producto.Stock > 0 )
            {
                FrmEmpleado.cliente.Carrito.Remove(this.producto);
                FrmEmpleado.cliente.Carrito.Add(this.producto, (int)nudCantidad.Value);
            }
            this.ActualizarVista();
        }

        /// <summary>
        /// Actualiza la vista segun el estado del producto en el carrito
        /// </summary>
        private void ActualizarVista()
        {
            this.lbCarroDeCompras.Items.Clear();
            foreach (KeyValuePair<Producto, int> producto in FrmEmpleado.cliente.Carrito)
            {
                this.lbCarroDeCompras.Items.Add($"{producto.Value} - {(string)producto.Key}");
            }
            if (FrmEmpleado.cliente.Carrito.TryGetValue(this.producto, out int cantidad))
                nudCantidad.Value = cantidad;
            else
                nudCantidad.Value = 1;
            if (FrmEmpleado.cliente.ValidarProductoEnCanasto(this.producto.Id))
            {
                btnAgregarQuitarCarro.Text = "Quitar del Carro";
                btnActualizarCantidad.Visible = true;
            }
            else
            {
                btnAgregarQuitarCarro.Text = "Agregar al Carro";
                btnActualizarCantidad.Visible = false;
            }
        }

        /// <summary>
        /// Cierra el formulario y vuelve al anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Valida el stock y calcula la cantidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            this.ValidarYCalcular();
        }

        /// <summary>
        /// Método encargado de validar la cantidad con el stock y calcular el precio total
        /// En caso de superar el stock se le pondra por defecto el valor máximo
        /// </summary>
        private void ValidarYCalcular() 
        {
            if (nudCantidad.Value > this.producto.Stock)
                nudCantidad.Value = this.producto.Stock;

            // Calcula el total
            this.CalcularPrecioTotal();
        }
    }
}
