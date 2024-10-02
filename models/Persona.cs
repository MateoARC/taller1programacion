using System.Collections.Generic; // Se necesita para utilizar la lista de facturas

namespace PrimerProyecto.Models
{
    // Clase que representa a una persona
    public class Persona
    {
        // Propiedad que almacena el código único de la persona
        public int Codigo { get; set; }
        
        // Propiedad que almacena el correo electrónico de la persona
        public string Email { get; set; }
        
        // Propiedad que almacena el nombre de la persona
        public string Nombre { get; set; }
        
        // Propiedad que almacena el número de teléfono de la persona
        public string Telefono { get; set; }
        
        // Lista privada que almacena las facturas asociadas a la persona
        private List<Factura> facturas;


        // Constructor de la clase Persona
        // Inicializa las propiedades de la persona con los valores proporcionados
        public Persona(int codigo, string email, string nombre, string telefono)
        {
            this.Codigo = codigo; // Asigna el valor del código al atributo Codigo
            this.Email = email; // Asigna el valor del email al atributo Email
            this.Nombre = nombre; // Asigna el valor del nombre al atributo Nombre
            this.Telefono = telefono; // Asigna el valor del teléfono al atributo Telefono
            this.facturas = new List<Factura>(); // Inicializa la lista de facturas
        }

        // Método para agregar una factura a la lista de facturas de la persona
        public void AgregarFactura(Factura factura)
        {
            facturas.Add(factura); // Agrega la factura proporcionada a la lista
        }

        // Método para obtener la lista de facturas de la persona
        public List<Factura> ObtenerFacturas()
        {
            return facturas; // Devuelve la lista de facturas
        }
    }
}
