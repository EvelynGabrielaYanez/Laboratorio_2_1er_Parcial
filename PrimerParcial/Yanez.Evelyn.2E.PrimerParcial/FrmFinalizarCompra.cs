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
    public partial class FrmFinalizarCompra : Form
    {
        string valorActualDeLaCelda;
        Cliente cliente;

        /// <summary>
        /// Método constructor del formulario
        /// </summary>
        /// <param name="cliente"></param>
        public FrmFinalizarCompra(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        /// <summary>
        /// Cierra el fomrulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinuarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Confgirua las vistas, apariencia y carga los componentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFinalizarCompra_Load(object sender, EventArgs e)
        {
            // Se configura la apariencia
            this.pnlResumenDeCarro.BackColor = Color.FromArgb(125, Color.Indigo);
            this.btnContinuarCompra.BackColor = Color.FromArgb(171, 143, 192);
            this.btnFinalizarCompra.BackColor = Color.FromArgb(171, 143, 192);

            // Carga los datos al carro
            this.CargarCarro();

            // Se cargan los datos del cliente a la pantalla
            this.ActualizarDatosDelCliente();
        }

        /// <summary>
        /// Método encargado de cargar el carro del cliente en el datagridView
        /// </summary>
        private void CargarCarro()
        {
            // Se carga el carro de compras
            dgvCarrito.Columns.Add("id", "Número");
            dgvCarrito.Columns.Add("precio", "Precio");
            dgvCarrito.Columns.Add("stock", "Stock");
            dgvCarrito.Columns.Add("cantidad", "Cantidad");
            dgvCarrito.Columns.Add("descripcion", "Descripción");
            dgvCarrito.Columns.Add("marca", "Marca");
            dgvCarrito.Columns["id"].ReadOnly = true;
            dgvCarrito.Columns["precio"].ReadOnly = true;
            dgvCarrito.Columns["stock"].ReadOnly = true;
            dgvCarrito.Columns["stock"].DefaultCellStyle.Format = "G";
            dgvCarrito.Columns["cantidad"].ReadOnly = false;
            dgvCarrito.Columns["descripcion"].ReadOnly = true;
            dgvCarrito.Columns["marca"].ReadOnly = true;
            double costoTotal = 0;
            int cantidadTotal = 0;
            foreach (KeyValuePair<Producto, int> parProductoCantida in FrmEmpleado.cliente.Carrito)
            {
                Producto producto = parProductoCantida.Key;
                dgvCarrito.Rows.Add(producto.Id, producto.Precio, producto.Stock, parProductoCantida.Value, producto.Descripcion, producto.Marca);
                costoTotal += producto.Precio * parProductoCantida.Value;
                cantidadTotal += parProductoCantida.Value;
            }
            dgvCarrito.Columns["cantidad"].DefaultCellStyle.BackColor = Color.FromArgb(171, 143, 192);

            this.lblValorCostoTotal.Text = $"{costoTotal}";
            this.lblValorCantidad.Text = $"{cantidadTotal}";

        }

        /// <summary>
        /// Método encargado de actualizar los datos del cliente en los textbox correspondientes
        /// </summary>
        private void ActualizarDatosDelCliente()
        {
            this.lblValorSaldo.Text = $"$ {this.cliente.Saldo}";
            this.lblValorApellido.Text = this.cliente.Apellido;
            this.lblValorNombre.Text = this.cliente.Nombre;
            this.lblValorDni.Text = this.cliente.Dni.ToString();
        }

        /// <summary>
        /// Finaliza la compra generando una venta y un ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (FrmEmpleado.cliente.Carrito.Count > 0)
            {
                Venta venta = cliente;
                if (venta is not null)
                {
                    venta.Empleado = FrmEmpleado.empleado;
                    string pathCompleto = PetShop.GenerarTicket(venta);
                    MessageBox.Show($"¡Compra Finalizada con Éxito!\nSe genero el ticket en {pathCompleto}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if (MessageBox.Show("No posee saldo suficiente.\n ¿Desea cargar Saldo?", "Saldo insuficiente", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        FrmCargarSaldo frmCargarSaldo = new FrmCargarSaldo(FrmEmpleado.cliente);
                        this.Visible = false;
                        frmCargarSaldo.ShowDialog();
                        this.Visible = true;
                    }
                }
                this.ActualizarDatosDelCliente();
            }
            else
            {
                MessageBox.Show("El carro se ecuentra vacio. No puede ralizar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Valida la edicion de de la celda cantidad
        /// No puede superar el stock y en caso de hacerlo asignara el maximo
        /// Si se escribe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCarrito_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            DataGridViewRow fila = dgvCarrito.Rows[indiceFila];

            if (int.TryParse(fila.Cells["cantidad"].Value.ToString(), out int cantidad))
            {
                int stock = int.Parse(fila.Cells["stock"].Value.ToString());
                if (stock < cantidad)
                {
                    cantidad = stock;
                    fila.Cells["cantidad"].Value = stock.ToString();
                }
                else if (0 >= cantidad)
                {
                    cantidad = 1;
                    fila.Cells["cantidad"].Value = "1";
                }

                // Se actualizan los resumenes
                double precio = double.Parse(fila.Cells["precio"].Value.ToString());
                double costoTotal = double.Parse(this.lblValorCostoTotal.Text);
                double cantidadTotal = int.Parse(this.lblValorCantidad.Text);
                // Resto los montos con las cantidades anteriores a la modificación
                costoTotal -= int.Parse(valorActualDeLaCelda) * precio;
                cantidadTotal -= int.Parse(valorActualDeLaCelda);
                // sumo los montos nuevos
                costoTotal += cantidad * precio;
                cantidadTotal += cantidad;

                this.lblValorCostoTotal.Text = $"{costoTotal}";
                this.lblValorCantidad.Text = $"{cantidadTotal}";

                // se busca el id del producto modificado
                int id = int.Parse(fila.Cells["Id"].Value.ToString());
                // se actualizan las cantidades en el carrito
                FrmEmpleado.cliente.EditarCantidadDeProducto(cantidad, id);
            }
            else
            {
                fila.Cells["cantidad"].Value = valorActualDeLaCelda;
            }

        }

        /// <summary>
        /// Guarda en memoria el valor de la celda antes de la modificaición
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCarrito_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.valorActualDeLaCelda = dgvCarrito.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
    }
}
