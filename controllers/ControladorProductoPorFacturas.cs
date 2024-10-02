using System;
using System.Collections.Generic;
using PrimerProyecto.Models;

namespace PrimerProyecto.Controladores
{
    // Clase que controla las operaciones relacionadas con los productos
    public class ControladorProductoPorFacturar
    {
        // Menú para manejar las operaciones de productos por factura
        public void MenuProductosPorFactura()
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú Productos Por Factura:");
                Console.WriteLine("1. Agregar Productos Por Factura");
                Console.WriteLine("2. Modificar Productos Por Factura");
                Console.WriteLine("3. Eliminar Productos Por Factura");
                Console.WriteLine("4. Listar Productos Por Factura");
                Console.WriteLine("0. Volver al Menú Principal");
                Console.Write("Elige una opción: ");

                // Validar la entrada del usuario
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    continue; // Volver a mostrar el menú de productos
                }

                // Manejar la opción elegida por el usuario
                switch (opcion)
                {
                    case 1:
                        AgregarProductosPorFactura(); // Llamar al método para agregar un producto por factura
                        break;
                    case 2:
                        ModificarProductosPorFactura(); // Llamar al método para modificar un producto por factura
                        break;
                    case 3:
                        EliminarProductosPorFactura(); // Llamar al método para eliminar un producto por factura
                        break;
                    case 4:
                        ListarProductosPorFactura(); // Llamar al método para listar productos por factura
                        break;
                    case 0:
                        break; // Volver al menú principal
                    default:
                        Console.WriteLine("Opción no válida."); // Mensaje de error
                        break;
                }
            } while (opcion != 0); // Continuar hasta que el usuario elija volver
        }

        static void AgregarProductosPorFactura() { }

        static void ModificarProductosPorFactura() { }

        static void EliminarProductosPorFactura() { }

        static void ListarProductosPorFactura() { }
    }
}
