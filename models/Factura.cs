using System; // Se necesita para utilizar el tipo DateTime

namespace PrimerProyecto.Models
{
    // Clase que representa una factura
    public class Factura
    {
        // Propiedad que almacena la fecha de emisión de la factura
        public DateTime Fecha { get; set; }
        
        // Propiedad que almacena el número único de la factura
        public int Numero { get; set; }
        
        // Propiedad que almacena el total de la factura
        public decimal Total { get; set; }
        
        // Propiedad que almacena el producto asociado a la factura
        public Producto Producto { get; set; }

        // Constructor de la clase Factura
        // Inicializa las propiedades de la factura con los valores proporcionados
        public Factura(DateTime fecha, int numero, decimal total, Producto producto)
        {
            Fecha = fecha; // Asigna la fecha proporcionada al atributo Fecha
            Numero = numero; // Asigna el número proporcionado al atributo Numero
            Total = total; // Asigna el total proporcionado al atributo Total
            Producto = producto; // Asigna el producto proporcionado al atributo Producto
        }

        // Método para obtener el producto asociado a la factura
        public Producto ObtenerProducto()
        {
            return Producto; // Devuelve el producto asociado a la factura
        }
    }
}
