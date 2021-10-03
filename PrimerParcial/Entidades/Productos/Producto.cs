using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    public abstract class Producto
    {
        protected string descripcion;
        protected double precio;
        protected string marca;
        protected string proveedor;
        static int ultimoId;
        protected int id;
        protected int stock;
        /// <summary>
        /// Método Consutrcor de la clase producto
        /// </summary>
        static Producto()
        {
            Producto.ultimoId = 0;
        }
        private Producto()
        {
            this.id = Producto.ultimoId;
            Producto.ultimoId++;
        }
        /// <summary>
        /// Método Constructor de la clase producto
        /// </summary>
        /// <param name="descripcion">Descripción del producto</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="marca">Marca del producto</param>
        /// <param name="proveedor">Proveedor del producto</param>
        /// <param name="stock">Stock del producto</param>
        public Producto(string descripcion,double precio, string marca, string proveedor, int stock) : this()
        {
            this.descripcion = descripcion;
            this.marca = marca;
            this.precio = precio;
            this.proveedor = proveedor;
            this.stock = stock;
        }
        /// <summary>
        /// Propiedad solo lectura del atributo Id
        /// </summary>
        public int Id
        {
            get { return this.id; }
        }
        /// <summary>
        /// Propiedad solo lectura del atributo descripcion
        /// </summary>
        public string Descripcion
        {
            get { return this.descripcion; }
        }
        /// <summary>
        /// Propiedad solo lectura del atributo marca
        /// </summary>
        public string Marca
        {
            get { return this.marca; }
        }
        /// <summary>
        /// Propiedad solo lectura del atributo precio
        /// </summary>
        public double Precio
        {
            get { return this.precio; }
        }
        /// <summary>
        /// Propiedad solo lectura del atributo proveedor
        /// </summary>
        public string Proveedor
        {
            get { return this.proveedor; }
        }
        /// <summary>
        /// Propiedad solo lectura del atributo stock
        /// </summary>
        public int Stock
        {
            set { this.stock = value; }
            get { return this.stock; }
        }
        /// <summary>
        /// Método para obtener el tipo de producto
        /// </summary>
        /// <returns>cadena de caracteres con el tipo de producto</returns>
        public string ObtenerTipoDeProducto()
        {
            string retorno;

            if (this.GetType() == typeof(Alimento))
                retorno = ETipoDeProducto.Alimento.ToString();
            else if(this.GetType() == typeof(Cama))
                retorno = ETipoDeProducto.Cama.ToString();
            else if (this.GetType() == typeof(Juguete))
                retorno = ETipoDeProducto.Juguete.ToString();
            else
                retorno = ETipoDeProducto.ArticuloDeCuidado.ToString();

            return retorno;
        }

        /// <summary>
        /// Conversor explicito de producto a string
        /// </summary>
        /// <param name="producto">Retorna "Descricion - marca - Id" del producto</param>
        public static explicit operator string(Producto producto)
        {
            return $"{producto.Descripcion} - {producto.Marca} - {producto.Id}";
        }

    }
}
