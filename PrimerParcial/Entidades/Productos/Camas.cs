using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cama : Producto
    {
        string tipoDeReyeno;
        string tipoDeTela;
        /// <summary>
        /// Método constructor de una Cama
        /// </summary>
        /// <param name="descripcion">Descripcion de la cama</param>
        /// <param name="precio">Precio de la cama</param>
        /// <param name="marca">Marca de la cama</param>
        /// <param name="proveedor">Proveedor de la cama</param>
        /// <param name="tipoDeReyeno">Tipo de reyeno de la cama</param>
        /// <param name="tipoDeTela">Tipo de reyeno de la tela</param>
        /// <param name="stock">Stock disponible de la cama</param>
        public Cama(string descripcion, double precio, string marca, string proveedor,string tipoDeReyeno, string tipoDeTela, int stock) : base(descripcion, precio, marca,proveedor, stock)
        {
            this.tipoDeReyeno = tipoDeReyeno;
            this.tipoDeTela = tipoDeTela;
        }

        public string TipoDeReyeno
        {
            get { return this.tipoDeReyeno; }
        }
        public string TipoDeTela
        {
            get { return this.tipoDeTela; }
        }
    }
}
