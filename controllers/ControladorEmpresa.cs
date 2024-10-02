using System;
using System.Collections.Generic;
using PrimerProyecto.Models;

namespace PrimerProyecto.Controladores
{
    // Clase que controla las operaciones relacionadas con las empresas
    public class ControladorEmpresa
    {
        // Lista que almacena las empresas
        private List<Empresa> empresas = new List<Empresa>();

        // Menú para manejar las operaciones de Empresa
        public void MenuEmpresa()
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú Empresa:");
                Console.WriteLine("1. Agregar Empresa");
                Console.WriteLine("2. Modificar Empresa");
                Console.WriteLine("3. Eliminar Empresa");
                Console.WriteLine("4. Listar Empresa");    
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
                        AgregarEmpresa(); // Llamar al método para agregar una persona
                        break;
                    case 2:
                        ModificarEmpresa(); // Llamar al método para modificar una persona
                        break;
                    case 3:
                        EliminarEmpresa(); // Llamar al método para eliminar una persona
                        break;
                    case 4:
                        ListarEmpresa(); // Llamar al método para listar personas
                        break;
                    case 0:
                        break; // Volver al menú principal
                    default:
                        Console.WriteLine("Opción no válida."); // Mensaje de error
                        break;
                }
            } while (opcion != 0); // Continuar hasta que el usuario elija volver
        }

        static void AgregarEmpresa()
        {}

        static void ModificarEmpresa()
        {}

        static void EliminarEmpresa()
        {}

        static void ListarEmpresa()
        {}


        // Método para agregar una nueva empresa a la lista
        public void AgregarEmpresa(Empresa empresa)
        {
            empresas.Add(empresa); // Añade la empresa proporcionada a la lista
        }

        // Método para modificar las propiedades de una empresa existente
        public void ModificarEmpresa(int codigo, string nombre)
        {
            // Busca la empresa en la lista por su código
            var empresa = empresas.Find(e => e.Codigo == codigo);
            if (empresa != null) // Si se encuentra la empresa
            {
                empresa.Nombre = nombre; // Modifica el nombre de la empresa
            }
        }

        // Método para eliminar una empresa de la lista
        public void EliminarEmpresa(int codigo)
        {
            // Busca la empresa en la lista por su código
            var empresa = empresas.Find(e => e.Codigo == codigo);
            if (empresa != null) // Si se encuentra la empresa
            {
                empresas.Remove(empresa); // Elimina la empresa de la lista
            }
        }

        // Método para listar todas las empresas
        public List<Empresa> ListarEmpresas()
        {
            return empresas; // Devuelve la lista de empresas
        }
    }
}
