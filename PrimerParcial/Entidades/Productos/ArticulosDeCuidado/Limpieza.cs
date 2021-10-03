using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Limpieza : ArticuloDeCuidado
    {
        ETipoDePelaje tipoDePelaje;
        public Limpieza(string descripcion, double precio, string marca, string proveedor, ETipoDeAnimal tipoDeAnimal, ETipoDePelaje tipoDePelaje, int stock) : base(descripcion, precio, marca, proveedor, tipoDeAnimal, stock)
        {
            this.tipoDePelaje = tipoDePelaje;
        }
    }
}
