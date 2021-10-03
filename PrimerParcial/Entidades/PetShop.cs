using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PetShop
    {
        #region Atributos
        static List<Usuario> usuarios;
        static Dictionary<Producto, string> productos;
        static List<Venta> ventas;
        #endregion

        #region Constructores
        /// <summary>
        /// Método constructor estatico del PetShop
        /// </summary>
        static PetShop()
        {
            usuarios = new List<Usuario>();
            productos = new Dictionary<Producto, string>();
            ventas = new List<Venta>();
            // Se HardCodean los listados
            PetShop.HardcodearProductos();
            PetShop.HardcodearUsuarios();
            PetShop.HardcodearVentas();
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad sólo lectura del atributo usuarios
        /// </summary>
        public static List<Usuario> Usuarios
        {
            get { return PetShop.usuarios; }
        }

        /// <summary>
        /// Propiedad sólo lectura del atributo ventas
        /// </summary>
        public static List<Venta> Ventas
        {
            get { return PetShop.ventas; }
        }
        #endregion

        #region Hardcodeo
        /// <summary>
        /// Método encargado de hardcodear los usuarios
        /// </summary>
        public static void HardcodearUsuarios()
        {
            // Se cargan los clientes
            Cliente cliente1 = new Cliente(39429755, "evelyn", "yanez");
            Cliente cliente2 = new Cliente(39429754, "lucas", "yanez");
            PetShop.usuarios.Add(cliente1);
            PetShop.usuarios.Add(cliente2);

            // Se cargan los empleados
            Empleado empleado1 = new Empleado(39429759, "FedeSco", "empleado");
            Empleado empleado2 = new Empleado(39429758, "CamiYa", "empleado");
            PetShop.usuarios.Add(empleado1);
            PetShop.usuarios.Add(empleado2);

            // Se cargan los administradores
            Administrador adminsitrador1 = new Administrador(39429757, "admin", "admin");
            Administrador adminsitrador2 = new Administrador(39429756, "pro", "pro");
            PetShop.usuarios.Add(adminsitrador1);
            PetShop.usuarios.Add(adminsitrador2);
        }

        /// <summary>
        /// Método encargado de hardcodear los productos
        /// </summary>
        public static void HardcodearProductos()
        {
            // Se cargan alimentos
            Alimento alimento1 = new Alimento("Mix Perros Adultos", 300, "Sabrositos", 1.5, ETipoDeAnimal.Perro, "MONAMI", 15);
            Alimento alimento2 = new Alimento("Regular Fit", 6184, "Sabrositos", 7.5, ETipoDeAnimal.Gato, "MONAMI", 50);
            Alimento alimento3 = new Alimento("Mix Canarios Mezcla Semillas", 6184, "Nelsoni R.", 0.75, ETipoDeAnimal.Pajaro, "Pet & Fish", 30);
            Alimento alimento4 = new Alimento("Tropimix", 6184, "Zootec", 1, ETipoDeAnimal.Hamster, "Puppis", 34);
            PetShop.productos.Add(alimento1, "Alimento_Sabrositos_Para_Perros");
            PetShop.productos.Add(alimento2, "Regular_Fit_Sabrositos");
            PetShop.productos.Add(alimento3, "Mix_Canarios_Mezcla_Semillas_Nelsoni");
            PetShop.productos.Add(alimento4, "Tropimix_Zootec");

            // Se cargan camas
            Cama cama1 = new Cama("Circular con estampado", 4000, "Coconing", "MascotasYa", "Ecológico hipoalergénico", "Polyester", 5);
            Cama cama2 = new Cama("Rectangular y lisa", 5000, "Coconing", "MascotasYa", "Ecológico hipoalergénico", "Funda suave", 2);
            Cama cama3 = new Cama("Modelo Small", 5000, "Eggys S", "MascotasYa", "Fibra de poliéster", "Funda de peluche suave", 1);
            PetShop.productos.Add(cama1, "Circular_con_estampado_Coconing");
            PetShop.productos.Add(cama2, "Rectangular_y_lisa_Coconing");
            PetShop.productos.Add(cama3, "Modelo_Small_Eggys");

            // Se cargan Juguetes
            Juguete juguete1 = new Juguete("Hueso Soga", 430, "CanCat", false, false, "Puppis", 10);
            Juguete juguete2 = new Juguete("Hueso De Goma Dispensador", 800, "Rascals", false, true, "Puppis", 8);
            Juguete juguete3 = new Juguete("Porta Alimento Interactivo", 1540, "PetToys", true, true, "Es Divertido", 3);
            PetShop.productos.Add(juguete1, "Hueso_Soga_CanCat");
            PetShop.productos.Add(juguete2, "Hueso_De_Goma_Dispensador_Rascals");
            PetShop.productos.Add(juguete3, "Porta_Alimento_Interactivo_PetToys");

            // Se cargan los Articulos de Cuidado de la Mascota
            // Articulos de Farmacia
            ArticuloDeFarmacia articuloFarmacia1 = new ArticuloDeFarmacia("Perrolac - Sustituto Lacteo 500g", 1390, "Alimasc", "Foyel", ETipoDeAnimal.Perro, false, 7);
            ArticuloDeFarmacia articuloFarmacia2 = new ArticuloDeFarmacia("Algel en comprimidos con tramadol 120 Comprimidos", 450, "Algen", "Foyel", ETipoDeAnimal.Gato, true, 6);
            ArticuloDeFarmacia articuloFarmacia3 = new ArticuloDeFarmacia("Vitaminas para hamsters", 600, "Omega3 Pets", "Puppis", ETipoDeAnimal.Hamster, false, 4);
            ArticuloDeFarmacia articuloFarmacia4 = new ArticuloDeFarmacia("Beepower - Promotor De Crecimiento 100ml", 1390, "Exzootix", "Puppis", ETipoDeAnimal.Pajaro, true, 10);
            PetShop.productos.Add(articuloFarmacia1, "Perrolac_Sustituto_Lacteo_500g_Alimasc");
            PetShop.productos.Add(articuloFarmacia2, "Algel_comprimidos_tramadol_120");
            PetShop.productos.Add(articuloFarmacia3, "Vitaminas_para_hamsters_Omega3_Pets");
            PetShop.productos.Add(articuloFarmacia4, "Beepower_Promotor_Crecimiento_100ml_Exzootix");

            // Articulos de Limpieza
            Limpieza limpieza1 = new Limpieza("Cepillo Removedor De Pelos", 1000, "PAKEWAY", "Puppis", ETipoDeAnimal.Perro, ETipoDePelaje.Largo, 9);
            Limpieza limpieza2 = new Limpieza("Sacapelos Y Masajeador", 1500, "FuriMinator", "Puppis", ETipoDeAnimal.Perro, ETipoDePelaje.Rizado, 11);
            Limpieza limpieza3 = new Limpieza("Guante Sacapelos", 2500, "FuriMinator", "Puppis", ETipoDeAnimal.Gato, ETipoDePelaje.Corto, 69);
            Limpieza limpieza4 = new Limpieza("Shampoo Pulguicida Antiparasitario", 2500, "Aqua Ecto", "Alimasc", ETipoDeAnimal.Perro, ETipoDePelaje.Raso, 10);
            PetShop.productos.Add(limpieza1, "Cepillo_Removedor_Pelos_PAKEWAY");
            PetShop.productos.Add(limpieza2, "Sacapelos_Masajeador_FuriMinator");
            PetShop.productos.Add(limpieza3, "Guante_Sacapelos_FuriMinator");
            PetShop.productos.Add(limpieza4, "Shampoo_Pulguicida_Antiparasitario_Aqua_Ecto");
        }

        /// <summary>
        /// Método encargado de hardcodear los ventas
        /// </summary>
        public static void HardcodearVentas()
        {
            List<Producto> listaProductos = PetShop.productos.Keys.ToList();
            Dictionary<Producto, int> listaDeProductos1 = new Dictionary<Producto, int>(){
                       { listaProductos[0],4 },
                        { listaProductos[1],5 }
            };
            Dictionary<Producto, int> listaDeProductos2 = new Dictionary<Producto, int>(){
                       { listaProductos[2],10 },
                        { listaProductos[3],2 }
            };
            Dictionary<Producto, int> listaDeProductos3 = new Dictionary<Producto, int>(){
                       { listaProductos[1],1 },
                        { listaProductos[5],10 },
                        { listaProductos[9],2 },
                        { listaProductos[10],5 }
            };
            Dictionary<Producto, int> listaDeProductos4 = new Dictionary<Producto, int>(){
                       { listaProductos[6],3},
                        { listaProductos[7],2 },
                        { listaProductos[8],1 }
            };
            ventas = new List<Venta>() {
                { new Venta((Cliente)PetShop.usuarios[0], (Empleado)PetShop.usuarios[2], listaDeProductos1) },
                { new Venta((Cliente)PetShop.usuarios[1], (Empleado)PetShop.usuarios[3], listaDeProductos2) },
                { new Venta((Cliente)PetShop.usuarios[1], (Empleado)PetShop.usuarios[4], listaDeProductos3) },
                { new Venta((Cliente)PetShop.usuarios[0], (Empleado)PetShop.usuarios[2], listaDeProductos4) }
            };

        }

        #endregion


        #region Métodos
        /// <summary>
        /// Método encargado de buscar y validar que un empleado se encuentre en el PetShop
        /// y tenga el mismo nombre de usuario, dni y contraseña.
        /// </summary>
        /// <param name="usuarioAValidar"></param>
        /// <param name="usuarioRespuesta"></param>
        /// <returns></returns>
        public static bool BuscarYValidarUsuario(Empleado usuarioAValidar, out Usuario usuarioRespuesta)
        {
            bool retorno = false;
            usuarioRespuesta = null;
            foreach (Usuario usuario in PetShop.usuarios)
            {
                if ((usuario is Empleado) && ((Empleado)usuario).Activo && usuarioAValidar.ValidarUsuario(usuario)) 
                {
                    usuarioRespuesta = usuario;
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Valida la existencia de un empleado por dni y nombre de usuario en el listado de 
        /// usuarios en el PetShop
        /// </summary>
        /// <param name="empleadoAValidar"></param>
        /// <returns></returns>
        public static bool ValidarExistencia(Empleado empleadoAValidar)
        {
            bool respuesta = false;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario is Empleado && ((Empleado)usuario).Activo && usuario.Equals(empleadoAValidar))
                {
                    respuesta = true; 
                    break;
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Valida la existencia de un cliente por dni en el PetShop
        /// </summary>
        /// <param name="clienteAValidar"></param>
        /// <returns></returns>
        public static bool ValidarExistencia(Cliente clienteAValidar)
        {
            bool respuesta = false;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario is Cliente && usuario.Equals(clienteAValidar))
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }

        /// <summary>
        ///     Metodo que validara si en la lista si alguien ya esta usando el dni o el nombre de usuario.
        /// </summary>
        /// <param name="usuarioAValidar"></param>
        /// <returns> 
        ///     true = existe alguien esta usando el nombre de usuario o el dni.
        ///     false = no se esta el nombre de usuario ni el dni.
        /// </returns>
        public static bool ValidarDniONombreUsuario(Empleado empleadoAValidar)
        {
            bool respuesta = false;
            foreach (Usuario usuario in usuarios)
            {
                if ( usuario is Empleado &&
                    (usuario.Dni == empleadoAValidar.Dni ||
                    ((Empleado)usuario).NombreUsuario == empleadoAValidar.NombreUsuario))
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Método encargado de buscar un cliente el el listado del PetShop
        /// </summary>
        /// <param name="usuarioAValidar"></param>
        /// <returns></returns>
        public static Usuario BuscarCliente(Cliente usuarioAValidar)
        {
            Usuario respuesta = null;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario is Cliente && usuario == usuarioAValidar)
                {
                    respuesta = usuario;
                    break;
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Método encargo de filtrar el listado de usuarios.
        /// </summary>
        /// <param name="tipoDeUsuario">Tipo de usuario a filtrar</param>
        /// <param name="soloActivos">Solo activos en casos usuarios que sean Empleado</param>
        /// <returns>Listado filtrado</returns>
        public static List<Usuario> FiltrarListadoUsuario(Type tipoDeUsuario, bool soloActivos)
        {
            List<Usuario> listaRetorno = new List<Usuario>();
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.GetType() == tipoDeUsuario)
                {
                    if (soloActivos && (!(usuario is Empleado) || ((Empleado)usuario).Activo))
                    {
                        listaRetorno.Add(usuario);
                    }
                    else if(!soloActivos)
                    {
                        listaRetorno.Add(usuario);
                    }
                }
            }
            return listaRetorno;
        }

        /// <summary>
        /// Método encargado de filtrar el listado del Petshop por tipo de usuario
        /// </summary>
        /// <param name="tipoDeUsuario">Tipo de usuario</param>
        /// <returns>Listado filtrado</returns>
        public static List<Usuario> FiltrarListadoUsuario(Type tipoDeUsuario)
        {
            List<Usuario> listaRetorno = new List<Usuario>();
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.GetType() == tipoDeUsuario)
                {
                    listaRetorno.Add(usuario);
                }
            }
            return listaRetorno;
        }

        /// <summary>
        /// Método encargado de filtrar los productos por el tipo de producto
        /// pasado por parametro
        /// </summary>
        /// <param name="tipoDeProducto">Tipo de producto por el que se filtara</param>
        /// <returns>Listado Filtrado</returns>
        public static Dictionary<Producto, string> FiltrarListadoProducto(Type tipoDeProducto)
        {
            Dictionary<Producto, string> retorno = new Dictionary<Producto, string>();
            foreach (KeyValuePair< Producto,string> producto in productos)
            {
                if (producto.Key.GetType() == tipoDeProducto || 
                    (tipoDeProducto == typeof(ArticuloDeCuidado) && producto.Key is ArticuloDeCuidado))
                {
                    retorno.Add(producto.Key, producto.Value);
                }
            }
            return retorno;
        }

        /// <summary>
        /// Método encargado de buscar un producto por id
        /// </summary>
        /// <param name="id">Id del producto buscado</param>
        /// <returns>Producto correspondiente al id</returns>
        public static Producto BuscarProducto(int id)
        {
            Producto productoRetorno = null;
            foreach (KeyValuePair<Producto, string> producto in PetShop.productos)
            {
                if (producto.Key.Id == id)
                {
                    productoRetorno = producto.Key;
                    break;
                }
            }
            return productoRetorno;
        }

        /// <summary>
        /// Método que genera el ticket de una venta
        /// </summary>
        /// <param name="venta">Venta de la que generara el tiquet</param>
        /// <returns>string con el path donde se guardo el ticket</returns>
        public static string GenerarTicket(Venta venta)
        {
            string nombreArchivo = $"{venta.FechaDeNegocio.ToString("yyyy-MM-dd")}_{venta.Id}";
            string pathCompleto = Path.GetFullPath($"..\\..\\..\\..\\..\\{nombreArchivo}.txt");
            TextWriter archivoDeTexto = new StreamWriter(pathCompleto);
            archivoDeTexto.WriteLine((string)venta);

            archivoDeTexto.Close();
            return pathCompleto;
        }

        /// <summary>
        /// Método encargado de calcular la recaudacion total del PetShop.
        /// </summary>
        /// <returns></returns>
        public static double CalcularRecaudacionTotal()
        {
            double recaudacion = 0;
            foreach (Venta venta in PetShop.ventas)
            {
                recaudacion += venta.PrecioTotal;
            }
            return recaudacion;
        }
        #endregion
    }
}
