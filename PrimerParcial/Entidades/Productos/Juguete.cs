using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juguete : Producto
    {
        bool haceSonido;
        bool contieneComida;
        /// <summary>
        /// Método Consutrctor de un Juguete
        /// </summary>
        /// <param name="descripcion">Descripcion del juguete</param>
        /// <param name="precio">Precio del juguete</param>
        /// <param name="marca">Marca del juguete</param>
        /// <param name="haceSonido">El juguete hace sonido SI/NO</param>
        /// <param name="contieneComida">El juguete contiene comida SI/NO</param>
        /// <param name="proveedor">El proveedor del jugete</param>
        /// <param name="stock">El stock disponible del jugete</param>
        public Juguete(string descripcion, double precio, string marca,bool haceSonido, bool contieneComida,string proveedor,int stock) : base(descripcion, precio,marca, proveedor,stock)
        {
            this.haceSonido = haceSonido;
            this.contieneComida = contieneComida;
        }
        public bool HaceSonido
        {
            get { return this.haceSonido; }
        }
        public bool ContieneComida
        {
            get { return this.contieneComida; }
        }

    }
}
