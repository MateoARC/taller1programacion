using System;
using PrimerProyecto.Models;
using PrimerProyecto.Controladores;

namespace PrimerProyecto
{
    class Program
    {
        // Controladores para manejar las operaciones CRUD de cada modelo
        private static ControladorPersona controladorPersona = new ControladorPersona();
        private static ControladorProducto controladorProducto = new ControladorProducto();
        private static ControladorVendedor controladorVendedor = new ControladorVendedor();
        private static ControladorFactura controladorFactura = new ControladorFactura();
        private static ControladorCliente controladorCliente = new ControladorCliente();
        private static ControladorEmpresa controladorEmpresa = new ControladorEmpresa();
        //private static ControladorProductoPorFacturar controladorProductoPorFacturar = new controladorProductoPorFacturar();

        static void Main(string[] args)
        {
            int opcion;

            // Bucle principal para mostrar el menú
            do
            {
                // Mostrar el menú principal
                Console.WriteLine("Menú Principal:");
                Console.WriteLine("1. Personas");
                Console.WriteLine("2. Productos");
                Console.WriteLine("3. Vendedores");
                Console.WriteLine("4. Facturas");
                Console.WriteLine("5. Clientes");
                Console.WriteLine("6. Empresa");
                Console.WriteLine("7. Producto Por Factura");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                // Validar la entrada del usuario
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    continue; // Volver a mostrar el menú
                }

                // Manejar la opción elegida por el usuario
                switch (opcion)
                {
                    case 1:
                        MenuPersonas(); // Llamar al menú de personas
                        break;
                    case 2:
                        MenuProductos(); // Llamar al menú de productos
                        break;
                    case 3:
                        MenuVendedores(); // Llamar al menú de vendedores
                        break;
                    case 4:
                        MenuFacturas(); // Llamar al menú de facturas
                        break;
                    case 5:
                        controladorCliente.MenuCliente(); // llamar al menu de cliente
                        break;    
                    case 6:
                        controladorEmpresa.MenuEmpresa(); //llamar al menu de empresa
                        break;
                    /*case 7:
                        controladorProductoPorFacturar.MenuProductosPorFactura();//llamar la menu productos por factura 
                        break;*/
                    case 0:
                        Console.WriteLine("Saliendo..."); // Mensaje de salida
                        break;
                    default:
                        Console.WriteLine("Opción no válida."); // Mensaje de error
                        break;
                }
            } while (opcion != 0); // Continuar hasta que el usuario elija salir
        }


        

        // Menú para manejar las operaciones de Personas
        static void MenuPersonas()
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú Personas:");
                Console.WriteLine("1. Agregar Persona");
                Console.WriteLine("2. Modificar Persona");
                Console.WriteLine("3. Eliminar Persona");
                Console.WriteLine("4. Listar Personas");    
                Console.WriteLine("0. Volver al Menú Principal");
                Console.Write("Elige una opción: ");

                // Validar la entrada del usuario
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    continue; // Volver a mostrar el menú de personas
                }

                // Manejar la opción elegida por el usuario
                switch (opcion)
                {
                    case 1:
                        AgregarPersona(); // Llamar al método para agregar una persona
                        break;
                    case 2:
                        ModificarPersona(); // Llamar al método para modificar una persona
                        break;
                    case 3:
                        EliminarPersona(); // Llamar al método para eliminar una persona
                        break;
                    case 4:
                        ListarPersonas(); // Llamar al método para listar personas
                        break;
                    case 0:
                        break; // Volver al menú principal
                    default:
                        Console.WriteLine("Opción no válida."); // Mensaje de error
                        break;
                }
            } while (opcion != 0); // Continuar hasta que el usuario elija volver
        }

        // Método para agregar una nueva persona
        static void AgregarPersona()
        {
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine()); // Leer el código

            Console.Write("Email: ");
            string email = Console.ReadLine(); // Leer el email

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine(); // Leer el nombre

            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine(); // Leer el teléfono


            // Crear una nueva instancia de Persona
            Persona persona = new Persona(codigo, email, nombre, telefono);
            controladorPersona.AgregarPersona(persona); // Agregar la persona a la lista
            Console.WriteLine("Persona agregada."); // Mensaje de confirmación
        }

        // Método para modificar una persona existente
        static void ModificarPersona()
        {
            Console.Write("Código de la persona a modificar: ");
            int codigo = int.Parse(Console.ReadLine()); // Leer el código de la persona

            Console.Write("Nuevo Email: ");
            string email = Console.ReadLine(); // Leer el nuevo email

            Console.Write("Nuevo Nombre: ");
            string nombre = Console.ReadLine(); // Leer el nuevo nombre

            Console.Write("Nuevo Teléfono: ");
            string telefono = Console.ReadLine(); // Leer el nuevo teléfono


            // Modificar la persona en la lista
            controladorPersona.ModificarPersona(codigo, email, nombre, telefono);
            Console.WriteLine("Persona modificada."); // Mensaje de confirmación
        }

        // Método para eliminar una persona
        static void EliminarPersona()
        {
            Console.Write("Código de la persona a eliminar: ");
            int codigo = int.Parse(Console.ReadLine()); // Leer el código de la persona

            controladorPersona.EliminarPersona(codigo); // Eliminar la persona de la lista
            Console.WriteLine("Persona eliminada."); // Mensaje de confirmación
        }

        // Método para listar todas las personas
        static void ListarPersonas()
        {
            var personas = controladorPersona.ListarPersonas(); // Obtener la lista de personas
            foreach (var persona in personas) // Iterar sobre cada persona
            {
                // Mostrar los detalles de cada persona
                Console.WriteLine($"Código: {persona.Codigo}, Email: {persona.Email}, Nombre: {persona.Nombre}, Teléfono: {persona.Telefono}");
            }
        }

        // Similar a los métodos anteriores para Productos
        static void MenuProductos()
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú Productos:");
                Console.WriteLine("1. Agregar Producto");
                Console.WriteLine("2. Modificar Producto");
                Console.WriteLine("3. Eliminar Producto");
                Console.WriteLine("4. Listar Productos");
                Console.WriteLine("0. Volver al Menú Principal");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarProducto();
                        break;
                    case 2:
                        ModificarProducto();
                        break;
                    case 3:
                        EliminarProducto();
                        break;
                    case 4:
                        ListarProductos();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 0);
        }

        // Método para agregar un nuevo producto
        static void AgregarProducto()
        {
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine()); // Leer el código

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine(); // Leer el nombre

            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine()); // Leer el stock

            Console.Write("Valor Unitario: ");
            decimal valorUnitario = decimal.Parse(Console.ReadLine()); // Leer el valor unitario


            // Crear una nueva instancia de Producto
            Producto producto = new Producto(codigo, nombre, stock, valorUnitario);
            controladorProducto.AgregarProducto(producto); // Agregar el producto a la lista
            Console.WriteLine("Producto agregado."); // Mensaje de confirmación
        }

        // Método para modificar un producto existente
        static void ModificarProducto()
        {
            Console.Write("Código del producto a modificar: ");
            int codigo = int.Parse(Console.ReadLine()); // Leer el código del producto

            Console.Write("Nuevo Nombre: ");
            string nombre = Console.ReadLine(); // Leer el nuevo nombre

            Console.Write("Nuevo Stock: ");
            int stock = int.Parse(Console.ReadLine()); // Leer el nuevo stock

            Console.Write("Nuevo Valor Unitario: ");
            decimal valorUnitario = decimal.Parse(Console.ReadLine()); // Leer el nuevo valor unitario

            Console.WriteLine("Nueva Descripcion: ");
            string Descripcion = Console.ReadLine();

            // Modificar el producto en la lista
            controladorProducto.ModificarProducto(codigo, nombre, stock, valorUnitario,Descripcion);
            Console.WriteLine("Producto modificado."); // Mensaje de confirmación
        }

        // Método para eliminar un producto
        static void EliminarProducto()
        {
            Console.Write("Código del producto a eliminar: ");
            int codigo = int.Parse(Console.ReadLine()); // Leer el código del producto

            controladorProducto.EliminarProducto(codigo); // Eliminar el producto de la lista
            Console.WriteLine("Producto eliminado."); // Mensaje de confirmación
        }

        // Método para listar todos los productos
        static void ListarProductos()
        {
            var productos = controladorProducto.ListarProductos(); // Obtener la lista de productos
            foreach (var producto in productos) // Iterar sobre cada producto
            {
                // Mostrar los detalles de cada producto
                Console.WriteLine($"Código: {producto.Codigo}, Nombre: {producto.Nombre}, Stock: {producto.Stock}, Valor Unitario: {producto.ValorUnitario}");
            }
        }

        // Similar a los métodos anteriores para Vendedores
        static void MenuVendedores()
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú Vendedores:");
                Console.WriteLine("1. Agregar Vendedor");
                Console.WriteLine("2. Modificar Vendedor");
                Console.WriteLine("3. Eliminar Vendedor");
                Console.WriteLine("4. Listar Vendedores");
                Console.WriteLine("0. Volver al Menú Principal");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarVendedor();
                        break;
                    case 2:
                        ModificarVendedor();
                        break;
                    case 3:
                        EliminarVendedor();
                        break;
                    case 4:
                        ListarVendedores();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 0);
        }

        // Método para agregar un nuevo vendedor
        static void AgregarVendedor()
        {
            Console.Write("Carne: ");
            int carne = int.Parse(Console.ReadLine()); // Leer el carne

            Console.Write("Dirección: ");
            string direccion = Console.ReadLine(); // Leer la dirección

            // Crear una nueva instancia de Vendedor
            Vendedor vendedor = new Vendedor(carne, direccion);
            controladorVendedor.AgregarVendedor(vendedor); // Agregar el vendedor a la lista
            Console.WriteLine("Vendedor agregado."); // Mensaje de confirmación
        }

        // Método para modificar un vendedor existente
        static void ModificarVendedor()
        {
            Console.Write("Carne del vendedor a modificar: ");
            int carne = int.Parse(Console.ReadLine()); // Leer el carne del vendedor

            Console.Write("Nueva Dirección: ");
            string direccion = Console.ReadLine(); // Leer la nueva dirección

            // Modificar el vendedor en la lista
            controladorVendedor.ModificarVendedor(carne, direccion);
            Console.WriteLine("Vendedor modificado."); // Mensaje de confirmación
        }

        // Método para eliminar un vendedor
        static void EliminarVendedor()
        {
            Console.Write("Carne del vendedor a eliminar: ");
            int carne = int.Parse(Console.ReadLine()); // Leer el carne del vendedor

            controladorVendedor.EliminarVendedor(carne); // Eliminar el vendedor de la lista
            Console.WriteLine("Vendedor eliminado."); // Mensaje de confirmación
        }

        // Método para listar todos los vendedores
        static void ListarVendedores()
        {
            var vendedores = controladorVendedor.ListarVendedores(); // Obtener la lista de vendedores
            foreach (var vendedor in vendedores) // Iterar sobre cada vendedor
            {
                // Mostrar los detalles de cada vendedor
                Console.WriteLine($"Carne: {vendedor.Carne}, Dirección: {vendedor.Direccion}");
            }
        }

        // Similar a los métodos anteriores para Facturas
        static void MenuFacturas()
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú Facturas:");
                Console.WriteLine("1. Agregar Factura");
                Console.WriteLine("2. Modificar Factura");
                Console.WriteLine("3. Eliminar Factura");
                Console.WriteLine("4. Listar Facturas");
                Console.WriteLine("0. Volver al Menú Principal");
                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarFactura();
                        break;
                    case 2:
                        ModificarFactura();
                        break;
                    case 3:
                        EliminarFactura();
                        break;
                    case 4:
                        ListarFacturas();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 0);
        }

        // Método para agregar una nueva factura
        static void AgregarFactura()
        {
            Console.Write("Fecha (dd/MM/yyyy): ");
            DateTime fecha = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null); // Leer la fecha

            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine()); // Leer el número de la factura

            Console.Write("Total: ");
            decimal total = decimal.Parse(Console.ReadLine()); // Leer el total de la factura

            Console.Write("Código del producto: ");
            int codigoProducto = int.Parse(Console.ReadLine()); // Leer el código del producto

            // Buscando el producto por código
            Producto producto = controladorProducto.ListarProductos().Find(p => p.Codigo == codigoProducto);
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado."); // Mensaje de error si no se encuentra el producto
                return;
            }

            // Crear una nueva instancia de Factura
            Factura factura = new Factura(fecha, numero, total, producto);
            controladorFactura.AgregarFactura(factura); // Agregar la factura a la lista
            Console.WriteLine("Factura agregada."); // Mensaje de confirmación
        }

        // Método para modificar una factura existente
        static void ModificarFactura()
        {
            Console.Write("Número de la factura a modificar: ");
            int numero = int.Parse(Console.ReadLine()); // Leer el número de la factura

            Console.Write("Nueva Fecha (dd/MM/yyyy): ");
            DateTime fecha = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null); // Leer la nueva fecha

            Console.Write("Nuevo Total: ");
            decimal total = decimal.Parse(Console.ReadLine()); // Leer el nuevo total

            Console.Write("Código del nuevo producto: ");
            int codigoProducto = int.Parse(Console.ReadLine()); // Leer el código del nuevo producto

            // Buscando el producto por código
            Producto producto = controladorProducto.ListarProductos().Find(p => p.Codigo == codigoProducto);
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado."); // Mensaje de error si no se encuentra el producto
                return;
            }

            // Modificar la factura en la lista
            controladorFactura.ModificarFactura(numero, fecha, total, producto);
            Console.WriteLine("Factura modificada."); // Mensaje de confirmación
        }

        // Método para eliminar una factura
        static void EliminarFactura()
        {
            Console.Write("Número de la factura a eliminar: ");
            int numero = int.Parse(Console.ReadLine()); // Leer el número de la factura

            controladorFactura.EliminarFactura(numero); // Eliminar la factura de la lista
            Console.WriteLine("Factura eliminada."); // Mensaje de confirmación
        }

        // Método para listar todas las facturas
        static void ListarFacturas()
        {
            var facturas = controladorFactura.ListarFacturas(); // Obtener la lista de facturas
            foreach (var factura in facturas) // Iterar sobre cada factura
            {
                // Mostrar los detalles de cada factura
                Console.WriteLine($"Fecha: {factura.Fecha}, Número: {factura.Numero}, Total: {factura.Total}, Producto: {factura.ObtenerProducto().Nombre}");
            }
        }
    }
}
