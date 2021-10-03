using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Usuario
    {
        double saldo;
        Dictionary<Producto, int> carrito;

        /// <summary>
        /// Método constructor de un cliente
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Cliente(int dni, string nombre, string apellido) : base(dni, nombre, apellido)
        {
            this.saldo = 0;
            carrito = new Dictionary<Producto, int>();
        }

        /// <summary>
        /// Proiedad lectura y escritura del atributo saldo
        /// </summary>
        public double Saldo
        {
            get { return this.saldo; }
            set {
                this.saldo = value;
            }
        }

        /// <summary>
        /// Propiedad sólo lectura  del atributo carrito
        /// </summary>
        public Dictionary<Producto, int> Carrito
        {
            get { 
                return this.carrito; 
            }
        }

        /// <summary>
        /// Indexador encargado de agregar al carrito en caso de no exisitr el producto
        /// o incrementar en uno la cantidad cargada en el carrito si este ya estaba cagado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Producto this[int id]
        {
            set 
            {
                KeyValuePair<Producto, int> parProductoCantidad = this.BuscarProductoEnCanasto(id);
                if (!parProductoCantidad.Equals(default(KeyValuePair<Producto, int>)))
                {
                    this.carrito.Remove(parProductoCantidad.Key);
                    this.carrito.Add(parProductoCantidad.Key, parProductoCantidad.Value + 1);
                }
                else
                {
                    this.carrito.Add(value,1);
                }
            }
        }

        /// <summary>
        /// Método encargado de retornar el tipo de cliente
        /// </summary>
        /// <returns></returns>
        public override string ObtenerTipo()
        {
            return ETipoUsuario.Cliente.ToString();
        }

        /// <summary>
        /// Método encargado de realizar la compra con la informacion del carrito
        /// y cliente. Asignara el valor por defecto al empleado de la venta
        /// </summary>
        /// <returns></returns>
        private Venta RealizarCompra()
        {
            double gastosTotales = 0;
            // Valida que el stock y el total cumplan con las reglas de negocio
            foreach (KeyValuePair<Producto, int> producto in this.carrito)
            {
                int cantidadActual = this.carrito.GetValueOrDefault(producto.Key);
                gastosTotales += producto.Key.Precio * cantidadActual;
                if (!(producto.Key.Stock >= cantidadActual && cantidadActual>0 && gastosTotales <= this.saldo))
                {
                    return null;
                }
            }

            Venta venta = new Venta(this, this.carrito);
            // Reduce el stock del producto en el petship
            foreach (KeyValuePair<Producto, int> producto in this.carrito)
            {
                int cantidadActual = this.carrito.GetValueOrDefault(producto.Key);
                producto.Key.Stock -= cantidadActual;
            }
            this.carrito.Clear();
            this.Saldo -= gastosTotales;

            // Agrega la venta al historico
            PetShop.Ventas.Add(venta);

            return venta;
        }

        /// <summary>
        /// Conversión implicita de un cliente a una venta.
        /// Generara una venta con todos los datos del cliente y
        /// a signara el valor por defecto al empleado de la venta
        /// </summary>
        /// <param name="cliente"></param>
        public static implicit operator Venta(Cliente cliente)
        {
            return cliente.RealizarCompra();
        }

        /// <summary>
        /// Método que edita la cantidad de productos que hay en el carrito
        /// en caso de que el mismo ya se encuentre cargado
        /// </summary>
        /// <param name="cantidadDelProducto"></param>
        /// <param name="idProducto"></param>
        /// <returns></returns>
        public bool EditarCantidadDeProducto(int cantidadDelProducto,int idProducto)
        {
            bool respuesta = false;
            if (cantidadDelProducto > 0 && idProducto > 0)
            {
                Producto producto = PetShop.BuscarProducto(idProducto);
                if (producto is not null)
                {
                    this.carrito.Remove(producto);
                    this.carrito.Add(producto, cantidadDelProducto);
                    respuesta = true;
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Método encargado de buscar un producto en el canasto del cliente.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public KeyValuePair<Producto, int> BuscarProductoEnCanasto(int id)
        {
            KeyValuePair<Producto, int> retorno = new KeyValuePair<Producto, int>();
            foreach (KeyValuePair<Producto,int> producto in carrito)
            {
                if (producto.Key.Id == id)
                {
                    retorno = producto;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Método que valida si un producto está o no en el canasto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool ValidarProductoEnCanasto(int id)
        {
            return !this.BuscarProductoEnCanasto(id).Equals(default(KeyValuePair<Producto, int>));
        }

        /// <summary>
        /// Sobrecarga del operador igual que comparara dos clientes
        /// En caso de ser los dos nulos retornara true
        /// En caso de no serlo considerara que estos son iguales cuando tengan el mismo DNI
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public static bool operator == (Cliente cliente1, Cliente cliente2)
        {
            bool retorno = false;
            if (cliente1 is not null && cliente2 is not null)
                retorno = cliente1.Dni == cliente2.Dni;
            else if (cliente1 is null && cliente2 is null)
                retorno = true;
            return retorno;
        }

        /// <summary>
        /// Sobrecarga de Equales que en caso de ser el objeto pasado por parametro 
        /// un cliente lo comparara por dni
        /// Caso contrario retornara falso
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public override bool Equals(Object cliente)
        {
            return cliente.GetType() == typeof(Cliente) && this == (Cliente)cliente;
        }

        /// <summary>
        /// Sobrecarga del operador igual que comparara dos clientes
        /// En caso de ser los dos nulos retornara falso
        /// En caso de no serlo considerara que estos son distinto cuando tengan el distinto DNI
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }

        /// <summary>
        /// Método encargado de retornar los datos del cliente
        /// </summary>
        /// <returns></returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            return sb.ToString();
        }

        /// <summary>
        /// Método encargado de cargarle saldo a un cliente
        /// En caso de este ya tener saldo se mantendra el mismo y se le 
        /// adicionara el pasado por parámetros
        /// </summary>
        /// <param name="saldoACargar"></param>
        /// <returns></returns>
        public bool CargarSaldo(double saldoACargar)
        {
            bool respuesta = false;
            if (saldoACargar > 0)
            {
                this.Saldo += saldoACargar;
                respuesta = true;
            }
            return respuesta;
        }
    }
}
