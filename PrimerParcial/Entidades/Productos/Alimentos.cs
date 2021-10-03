using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alimento : Producto
    {
        double kilos;
        ETipoDeAnimal animalQueLoConsume;

        /// <summary>
        /// Método constructor de un Alimento
        /// </summary>
        /// <param name="descripcion">Descripción del alimento</param>
        /// <param name="precio">Precio del alimento</param>
        /// <param name="marca">Marca del alimento</param>
        /// <param name="Kilos">Peso del alimento</param>
        /// <param name="animalQueLoConsume">Tipo de animal que consume el alimento</param>
        /// <param name="proveedor">Proveedor del alimento</param>
        /// <param name="stock">Stock del alimento</param>
        public Alimento(string descripcion, double precio, string marca, double kilos, ETipoDeAnimal animalQueLoConsume, string proveedor,int stock) : base(descripcion, precio, marca,proveedor, stock)
        {
            this.kilos = kilos;
            this.animalQueLoConsume = animalQueLoConsume;
        }
        public double Kilos
        {
            get { return this.kilos; }
        }

        public string AnimalQueLoConsume
        {
            get { return this.animalQueLoConsume.ToString(); }
        }


    }
}
