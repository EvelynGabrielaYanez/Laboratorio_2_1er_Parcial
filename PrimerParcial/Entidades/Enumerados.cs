using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Enumerado de tipos de usuarios
    /// </summary>
    public enum ETipoUsuario
    {
        Cliente,
        Empleado,
        Administador
    }

    /// <summary>
    /// Enumardo de tipos de productos
    /// </summary>
    public enum ETipoDeProducto
    {
        Alimento,
        Cama,
        Juguete,
        ArticuloDeCuidado,
        Farmacia,
        Limpieza
    }

    /// <summary>
    /// Enumerado de los tipos de animales
    /// </summary>
    public enum ETipoDeAnimal
    {
        Perro,
        Gato,
        Pajaro,
        Pez,
        Hamster
    }

    /// <summary>
    /// Enumerado de los tipos de pelajes
    /// </summary>
    public enum ETipoDePelaje
    {
        Raso,
        Largo,
        Corto,
        Rizado
    }
}
