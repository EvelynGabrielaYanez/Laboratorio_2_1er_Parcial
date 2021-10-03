using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Empleado
    {
        /// <summary>
        /// Método constructor de un administrador con dni, nombrede usuario y contraseña
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrasenia"></param>
        public Administrador(int dni, string nombreUsuario, string contrasenia) : base(dni, nombreUsuario, contrasenia)
        {
        }

        /// <summary>
        /// Método constructor d eun administrador con dni, nombre de usuario, contraseña,
        /// apellido, nombre.
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrasenia"></param>
        public Administrador(int dni, string nombre, string apellido, string nombreUsuario, string contrasenia) : base(dni, nombre, apellido, nombreUsuario, contrasenia)
        { 
        }

        /// <summary>
        /// Método que le permite al administrador elminiar un usuario
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public bool EliminarUsuario(int dni)
        {
            bool respuesta = false;
            foreach (Usuario usuario in PetShop.Usuarios)
            {
                if (usuario is Empleado && usuario is not Cliente && dni == usuario.Dni)
                {
                    ((Empleado)usuario).Activo = false;
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }

        public override string ObtenerTipo()
        {
            return ETipoUsuario.Administador.ToString();
        }

        /// <summary>
        /// Método que le permite al administrador actualizar un empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrasenia"></param>
        /// <param name="tipoEmpleado"></param>
        /// <returns></returns>
        public bool ActualizarEmpleado(string nombre, string apellido, int dni,string nombreUsuario,string contrasenia, ETipoUsuario tipoEmpleado)
        {
            bool respuesta = false;
            Empleado empleadoEditado;
            if (PetShop.ValidarExistencia(this))
            {
                if (tipoEmpleado == ETipoUsuario.Administador)
                    empleadoEditado = new Administrador(dni, nombre, apellido, nombreUsuario, contrasenia);
                else
                    empleadoEditado = new Empleado(dni, nombre, apellido, nombreUsuario, contrasenia);

                foreach (Usuario usuario in PetShop.Usuarios)
                {
                    if (usuario is Empleado && empleadoEditado.Equals(usuario))
                    {
                        PetShop.Usuarios.Remove(usuario);
                        PetShop.Usuarios.Add(empleadoEditado);
                        respuesta = true;
                        break;
                    }
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Método que le permite al administrador agregar un empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrasenia"></param>
        /// <param name="tipoEmpleado"></param>
        /// <returns></returns>
        public bool AgregarEmpleado(string nombre, string apellido, int dni, string nombreUsuario, string contrasenia,ETipoUsuario tipoEmpleado)
        {
            bool response = false;
            Empleado nuevoEmpleado;
            if (PetShop.ValidarExistencia(this))
            {
                if (tipoEmpleado == ETipoUsuario.Administador)
                    nuevoEmpleado = new Administrador(dni, nombre, apellido, nombreUsuario, contrasenia);
                else
                    nuevoEmpleado = new Empleado(dni, nombre, apellido, nombreUsuario, contrasenia);
                if (!PetShop.ValidarDniONombreUsuario(nuevoEmpleado))
                {
                    PetShop.Usuarios.Add(nuevoEmpleado);
                    response = true;
                }
            }
            return response;
        }
    }
}
