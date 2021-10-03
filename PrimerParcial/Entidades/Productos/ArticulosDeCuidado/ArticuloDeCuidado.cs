using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class ArticuloDeCuidado : Producto
    {
        ETipoDeAnimal animalQueLoConsume;
        public ArticuloDeCuidado(string descripcion, double precio, string marca, string proveedor , ETipoDeAnimal animalQueLoConsume, int stock) : base(descripcion, precio, marca, proveedor,stock)
        {
            this.animalQueLoConsume = animalQueLoConsume;
        }
        public string AnimalQueLoConsume
        {
            get { return this.animalQueLoConsume.ToString(); }
        }



    }
}
