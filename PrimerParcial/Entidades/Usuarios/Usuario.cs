using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Usuario
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        /// <summary>
        /// Método constructor de un usuario
        /// </summary>
        private Usuario()
        {
            this.nombre = "";
            this.apellido = "";
        }
        
        /// <summary>
        /// Método constructor de un usuario
        /// </summary>
        /// <param name="dni">Dni del usuario</param>
        protected Usuario(int dni) : this()
        {
            this.dni = dni;
        }

        /// <summary>
        ///  Método constructor de un usuario
        /// </summary>
        /// <param name="dni">Dni del usuario</param>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="apellido">Apellido del usuario</param>
        protected Usuario(int dni, string nombre, string apellido) : this(dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo apellido
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        /// <summary>
        /// Propiedad de lectura del atributo dni
        /// </summary>
        public int Dni
        {
            get { return this.dni; }
        }

        /// <summary>
        /// Método encargado de validar que el DNI pasado por parametro
        /// tenga un largo entre 8 y 6 caractere y que el mismo sea númerico.
        /// </summary>
        /// <param name="strDni"></param>
        /// <returns>true = Valido | false = Invalido</returns>
        public static int ValidarDNI(string strDni)
        {
            int dni = 0;
            if (strDni.Length <= 8 && strDni.Length >= 6)
                int.TryParse(strDni, out dni);

            return dni;
        }

        /// <summary>
        /// Método encargado de obtener el tipo de usuario
        /// </summary>
        /// <returns></returns>
        public abstract string ObtenerTipo();

        /// <summary>
        /// Método encargado de retornar una cadena con los datos del ususario
        /// </summary>
        /// <returns>string con los datos del usuario(nombre, apelllido, dni y tipo de usuaro)</returns>
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {(this.nombre.Length > 0 ? this.nombre : "No registrado")}");
            sb.AppendLine($"Apellido: {(this.apellido.Length > 0 ? this.apellido : "No registrado")}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Usuario registrado como: {this.ObtenerTipo()}");
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador igual que validara que dos usuarios son iguales
        /// cuando tengan el mismo DNI
        /// </summary>
        /// <param name="usuario1">Primer usuario</param>
        /// <param name="usuario2">Segundo Usuario</param>
        /// <returns></returns>
        public static bool operator ==(Usuario usuario1, Usuario usuario2)
        {
            bool retorno = false;
            if (usuario1 is not null && usuario2 is not null)
                retorno = usuario1.Dni == usuario2.Dni;
            else if (usuario1 is null && usuario2 is null)
                retorno = true;
            return retorno;
        }

        /// <summary>
        /// Método encargado de comparar un objeto con un usuario
        /// en caso de ser de la clase usuario lo compara por dni.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public override bool Equals(Object usuario)
        {
            return usuario is Usuario && this == (Usuario)usuario;
        }

        /// <summary>
        /// Sobrecarga del operador igual que validara que dos usuarios son distintos
        /// cuando tengan distinto DNI
        /// </summary>
        /// <param name="usuario1">Primer usuario</param>
        /// <param name="usuario2">Segundo Usuario</param>
        /// <returns></returns>
        public static bool operator !=(Usuario usuario1, Usuario usuario2)
        {
            return !(usuario1 == usuario2);
        }
    }
}
