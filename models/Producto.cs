namespace PrimerProyecto.Models
{
    // Clase que representa un producto
    public class Producto
    {
        // Propiedad que almacena el código del producto
        public int Codigo { get; set; }
        
        // Propiedad que almacena el nombre del producto
        public string Nombre { get; set; } 
        
        // Propiedad que almacena la cantidad disponible en stock del producto
        public int Stock { get; set; }
        
        // Propiedad que almacena el valor unitario del producto
        public decimal ValorUnitario { get; set; } 

        // Constructor de la clase Producto
        // Inicializa las propiedades del producto con los valores proporcionados
        public Producto(int codigo, string nombre, int stock, decimal valorUnitario)
        {
            Codigo = codigo; // Asigna el valor del código al atributo Codigo
            Nombre = nombre; // Asigna el valor del nombre al atributo Nombre
            Stock = stock; // Asigna el valor del stock al atributo Stock
            ValorUnitario = valorUnitario; // Asigna el valor unitario al atributo ValorUnitario
        }
    }
}
