using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        Cliente cliente;
        Empleado empleado;
        Dictionary<Producto, int> productos;
        DateTime fechaDeNegocio;
        static int ultimoId;
        int id;
        /// <summary>
        /// Método constructor statuco de una venta
        /// pone por defecto el ultimo id en 0
        /// </summary>
        static Venta()
        {
            ultimoId = 0;
        }

        /// <summary>
        /// Método constructor de una venta que asignara por defecto:
        /// fechaDeNegocio = fecha actual
        /// id = ultimo Id
        /// empleado = null
        /// E incrementara el ultimdo id en 1
        /// </summary>
        private Venta()
        {
            this.fechaDeNegocio = DateTime.Now;
            this.id = Venta.ultimoId;
            Venta.ultimoId++;
            this.empleado = null;
        }

        /// <summary>
        /// Método constructor de una venta 
        /// </summary>
        /// <param name="cliente">Cliente al que se le vende</param>
        /// <param name="productos">Productos que se le vendieron</param>
        public Venta(Cliente cliente, Dictionary<Producto, int> productos) : this()
        {
            this.cliente = cliente;
            this.productos = new Dictionary<Producto, int>(productos);
        }

        /// <summary>
        /// Método constructor de una venta 
        /// </summary>
        /// <param name="cliente">Cliente al que se le vende</param>
        /// <param name="empleado">Empleado que realizo la venta</param>
        /// <param name="productos">Productos que se le vendieron</param>
        public Venta(Cliente cliente, Empleado empleado ,Dictionary<Producto, int> productos) : this(cliente, productos)
        {
            this.empleado = empleado;
        }

        #region Propiedades

        /// <summary>
        /// Propiedad sólo lectura del dni del cliente que compro
        /// </summary>
        public int ClienteDNI
        {
            get { return this.cliente.Dni; }
        }

        /// <summary>
        /// Propiedad sólo lectura del dni del empelado que realizo la venta
        /// </summary>
        public int EmpleadoDNI
        {
            get { return this.empleado.Dni; }
        }

        /// <summary>
        /// Propiedad sólo escritura del empleado que realizo la venta
        /// </summary>
        public Empleado Empleado
        {
            set { this.empleado = value; }
        }

        /// <summary>
        /// Propiedad sólo lectura de la fecha de negocio en que se realizo la venta
        /// </summary>
        public DateTime FechaDeNegocio
        {
            get { return this.fechaDeNegocio.Date; }
        }

        /// <summary>
        /// Propiedad sólo lectura del Id de la venta
        /// </summary>
        public int Id
        {
            get { return this.id; }
        }

        /// <summary>
        /// Propiedad sólo lectura que calculara el precio total de la venta
        /// en funcion de las cantidad y precios de los productos comprados
        /// </summary>
        public double PrecioTotal
        {
            get
            {
                double precioTotal = 0;
                foreach (KeyValuePair<Producto, int> parProductoCantidad in this.productos)
                {
                    precioTotal += parProductoCantidad.Key.Precio;
                }
                return precioTotal;
            }
        }

        /// <summary>
        /// Propiedad sólo lectura que calculara la cantidad total de productos comprados
        /// </summary>
        public double CantidadDeProductos
        {
            get
            {
                int cantidadProductos = 0;
                foreach (KeyValuePair<Producto, int> parProductoCantidad in this.productos)
                {
                    cantidadProductos += parProductoCantidad.Value;
                }
                return cantidadProductos;
            }
        }

        /// <summary>
        /// Casteo de venta  a string que genera una cadena con con el detalle de la venta
        /// </summary>
        /// <param name="venta">Venta de la que se generara el detalle</param>
        public static explicit operator string(Venta venta)
        {
            StringBuilder respuesta = new StringBuilder();
            respuesta.AppendLine("".PadRight(95, '-'));
            respuesta.AppendLine("\nDATOS DEL CONSUMIDOR");
            respuesta.AppendLine(venta.cliente.MostrarDatos());
            respuesta.AppendLine("".PadRight(95, '-'));
            respuesta.AppendLine("\nDATOS DEL VENDEDOR");
            respuesta.AppendLine(venta.empleado.MostrarDatos());
            respuesta.AppendLine("".PadRight(95, '-'));
            respuesta.AppendLine("\nPRODUCTOS");
            string enunciado = string.Format("{0,19}|{1,16}|{2,8}|{3,8}|{4,10}|{5,20}", "Número del Producto","Tipo De Producto" ,"Cantidad", "Precio", "Marca", "Descripción");
            respuesta.AppendLine(enunciado);
            foreach (KeyValuePair<Producto, int> parProductoCantidad in venta.productos)
            {
                Producto producto = parProductoCantidad.Key;
                string datosProducto = string.Format("{0,19}|{1,16}|{2,8}|{3,8}|{4,10}|{5,20}", producto.Id, producto.ObtenerTipoDeProducto() ,parProductoCantidad.Value, producto.Precio, producto.Marca, producto.Descripcion);
                respuesta.AppendLine(datosProducto);
            }
            respuesta.AppendLine("".PadRight(95, '-'));
            respuesta.AppendLine("\nMONTOS FINALES");
            respuesta.AppendLine($"Cantidad Final: {venta.CantidadDeProductos}");
            respuesta.AppendLine($"Precio Final: {venta.PrecioTotal}");

            return respuesta.ToString();
        }

        #endregion
    }
}
