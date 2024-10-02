using System;
using System.Collections.Generic;
using PrimerProyecto.Models;

namespace PrimerProyecto.Controladores
{
    // Clase que controla las operaciones relacionadas con los clientes
    public class ControladorCliente
    {
        // Lista que almacena los clientes
        private List<Cliente> clientes = new List<Cliente>();

        // Menú para manejar las operaciones de Clientes
        public void MenuCliente()
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú Cliente:");
                Console.WriteLine("1. Agregar Cliente");
                Console.WriteLine("2. Modificar Cliente");
                Console.WriteLine("3. Eliminar Cliente");
                Console.WriteLine("4. Listar Cliente");
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
                        AgregarCliente(); // Llamar al método para agregar un cliente
                        break;
                    case 2:
                        ModificarCliente(); // Llamar al método para modificar un cliente
                        break;
                    case 3:
                        EliminarCliente(); // Llamar al método para eliminar un cliente
                        break;
                    case 4:
                        ListarCliente(); // Llamar al método para listar clientes
                        break;
                    case 0:
                        break; // Volver al menú principal
                    default:
                        Console.WriteLine("Opción no válida."); // Mensaje de error
                        break;
                }
            } while (opcion != 0); // Continuar hasta que el usuario elija volver
        }

        private void AgregarCliente()
        {
            // Aquí deberías implementar la lógica para agregar un cliente
            Console.Write("Ingrese el código del cliente: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el crédito del cliente: ");
            decimal credito = decimal.Parse(Console.ReadLine());

            // Crear un nuevo cliente y agregarlo
            var cliente = new Cliente(codigo, credito); // Usar el constructor que acepta parámetros
            AgregarCliente(cliente);
            Console.WriteLine("Cliente agregado.");
        }

        private void ModificarCliente()
        {
            Console.Write("Ingrese el código del cliente a modificar: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nuevo crédito: ");
            decimal credito = decimal.Parse(Console.ReadLine());

            ModificarCliente(codigo, credito);
            Console.WriteLine("Cliente modificado.");
        }

        private void EliminarCliente()
        {
            Console.Write("Ingrese el código del cliente a eliminar: ");
            int codigo = int.Parse(Console.ReadLine());

            EliminarCliente(codigo);
            Console.WriteLine("Cliente eliminado.");
        }

        private void ListarCliente()
        {
            var listaClientes = ListarClientes();
            if (listaClientes.Count == 0)
            {
                Console.WriteLine("No hay clientes registrados.");
                return;
            }

            foreach (var cliente in listaClientes)
            {
                Console.WriteLine($"Código: {cliente.Codigo}, Crédito: {cliente.Credito}");
            }
        }

        // Método para agregar un nuevo cliente a la lista
        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente); // Añade el cliente proporcionado a la lista
        }

        // Método para modificar las propiedades de un cliente existente
        public void ModificarCliente(int codigo, decimal credito)
        {
            // Busca el cliente en la lista por su código
            var cliente = clientes.Find(c => c.Codigo == codigo);
            if (cliente != null) // Si se encuentra el cliente
            {
                cliente.Credito = credito; // Modifica el crédito del cliente
            }
        }

        // Método para eliminar un cliente de la lista
        public void EliminarCliente(int codigo)
        {
            // Busca el cliente en la lista por su código
            var cliente = clientes.Find(c => c.Codigo == codigo);
            if (cliente != null) // Si se encuentra el cliente
            {
                clientes.Remove(cliente); // Elimina el cliente de la lista
            }
        }

        // Método para listar todos los clientes
        public List<Cliente> ListarClientes()
        {
            return clientes; // Devuelve la lista de clientes
        }
    }
}
