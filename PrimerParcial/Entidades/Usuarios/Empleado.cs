using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Usuario
    {
        protected string nombreUsuario;
        protected string contrasenia;
        protected bool activo;
        /// <summary>
        /// Método Consutructor de un empelado con dni, nombre de usuario y contraseña
        /// por defecto el nombre y el apellido estaran vacios
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrasenia"></param>
        public Empleado(int dni, string nombreUsuario, string contrasenia) : base(dni)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.activo = true;
        }
        /// <summary>
        ///  Método Consutructor de un empelado con dni, nombre de usuario, contraseña,
        ///  nombre y apellido
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrasenia"></param>
        public Empleado(int dni, string nombre, string apellido, string nombreUsuario, string contrasenia) : base(dni, nombre, apellido)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.activo = true;
        }
        /// <summary>
        /// Propiedad de lectura y escritora del nombre de usuario
        /// </summary>
        public string NombreUsuario
        {
            get { return this.nombreUsuario; }
        }
        /// <summary>
        /// Propiedad de lectura de una contraseña
        /// </summary>
        public string Contrasenia
        {
            get { return this.contrasenia; }
        }
        /// <summary>
        /// Método encargado de retornar los datos del empleado
        /// </summary>
        /// <returns></returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Tipo De Empleado: {this.dni}");
            return sb.ToString();
        }

        /// <summary>
        /// Método encargado de retornar el tipo de empleado
        /// </summary>
        /// <returns></returns>
        public override string ObtenerTipo()
        {
            return ETipoUsuario.Empleado.ToString();
        }

        /// <summary>
        /// Propiedad de lectura y escritura del estado de actividad del 
        /// empelado
        /// </summary>
        public bool Activo
        {
            get { return this.activo; }
            set { this.activo = value; }
        }

        /// <summary>
        /// Validara si los empleados tienen el mismo Id y nombre de usuario
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public override bool Equals(Object empleado)
        {
            return empleado is Empleado && this == (Empleado)empleado;
        }
        /// <summary>
        ///  Validara si los empleados tienen el mismo Id y nombre de usuario,
        ///  en caso de ser ambos nulos retoranra verdadero
        /// </summary>
        /// <param name="empleado1"></param>
        /// <param name="empleado2"></param>
        /// <returns></returns>
        public static bool operator ==(Empleado empleado1, Empleado empleado2)
        {
            bool retorno = false;
            if (empleado1 is not null && empleado2 is not null)
                retorno = empleado1.nombreUsuario == empleado2.nombreUsuario && empleado1.Dni == empleado2.Dni;
            else if (empleado1 is null && empleado2 is null)
                retorno = true;
            return retorno;
        }

        /// <summary>
        ///  Validara si los empleados tiene distinto Id o nombre de usuario,
        ///  en caso de ser ambos nulos retoranra verdadero
        /// </summary>
        /// <param name="empleado1"></param>
        /// <param name="empleado2"></param>
        /// <returns></returns>
        public static bool operator !=(Empleado empleado1, Empleado empleado2)
        {
            return !(empleado1 == empleado2);
        }
        /// <summary>
        /// Validara si los usuarios son iguales y poseen la misma contraseña
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>bool = SI false = NO</returns>
        public virtual bool ValidarUsuario(Usuario usuario)
        {
            bool respuesta = false;
            if (usuario is Empleado)
            {
                Empleado empleado = (Empleado)usuario;
                respuesta =this.Contrasenia == empleado.contrasenia && empleado.Equals(this);
            }
            return respuesta;
        }

        /// <summary>
        /// Método encargado de validar si el empleado se encuentra registrado en el petshop y en caso de
        /// estarlo le permitira modificar el cliente pasado por parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        public bool ActualizarCliente(string nombre, string apellido, int dni)
        {
            bool respuesta = false;
            Cliente usuarioEditado = new Cliente(dni, nombre, apellido);
            // Valido que el empleado que quiere actualizar esta registrado en el petshop
            if (PetShop.ValidarExistencia(this))
            {
                foreach (Usuario usuario in PetShop.Usuarios)
                {
                    if (usuario.GetType() == typeof(Cliente) && usuarioEditado.Dni == usuario.Dni)
                    {
                        PetShop.Usuarios.Remove(usuario);
                        PetShop.Usuarios.Add(usuarioEditado);
                        respuesta = true;
                        break;
                    }
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Método encargado de validar si el empleado se encuentra registrado en el petshop y en caso de
        /// estarlo le permitira agregar el cliente pasado por parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        public bool AgregarCliente(string nombre, string apellido, int dni)
        {
            bool respuesta = false;
            Cliente nuevoUsuario = new Cliente(dni, nombre, apellido);
            // Valido que el empleado que quiere agregar esta registrado en el petshop
            if (PetShop.ValidarExistencia(this))
            {
                if (!PetShop.ValidarExistencia(nuevoUsuario))
                {
                    PetShop.Usuarios.Add(nuevoUsuario);
                    respuesta = true;
                }
            }
            return respuesta;
        }

    }
}
