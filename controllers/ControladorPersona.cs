// Controladores/ControladorPersona.cs
using System; // Se necesita para utilizar clases del espacio de nombres básico
using System.Collections.Generic; // Se necesita para utilizar la clase List
using PrimerProyecto.Models; // Se necesita para utilizar el modelo Persona

namespace PrimerProyecto.Controladores
{
    // Clase que controla las operaciones relacionadas con las personas
    public class ControladorPersona
    {
        // Lista que almacena las personas
        private List<Persona> personas = new List<Persona>();

        // Método para agregar una nueva persona a la lista
        public void AgregarPersona(Persona persona)
        {
            personas.Add(persona); // Añade la persona proporcionada a la lista
        }

        // Método para modificar las propiedades de una persona existente
        public void ModificarPersona(int codigo, string email, string nombre, string telefono)
        {
            // Busca la persona en la lista por su código
            var persona = personas.Find(p => p.Codigo == codigo);
            if (persona != null) // Si se encuentra la persona
            {
                persona.Email = email; // Modifica el email de la persona
                persona.Nombre = nombre; // Modifica el nombre de la persona
                persona.Telefono = telefono; // Modifica el teléfono de la persona
            }
        }

        // Método para eliminar una persona de la lista
        public void EliminarPersona(int codigo)
        {
            // Busca la persona en la lista por su código
            var persona = personas.Find(p => p.Codigo == codigo);
            if (persona != null) // Si se encuentra la persona
            {
                personas.Remove(persona); // Elimina la persona de la lista
            }
        }

        // Método para listar todas las personas
        public List<Persona> ListarPersonas()
        {
            return personas; // Devuelve la lista de personas
        }
    }
}
