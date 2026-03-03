using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_abstractas.clases
{
    /// <summary>
    /// ARD 20260303
    /// se creo la clase abstracta figura con propiedades color y figuraa, un método mostrarinfo que muestra el tipo de figura, su color, área y perímetro, y un método cambiarcolor que permite cambiar el color de la figura. Además, se definieron los métodos abstractos calculararea y calcularperimetro que deben ser implementados por las clases derivadas.
    /// </summary>
    public abstract class figura
    {
        public string color { get; set; }
        public string figuraa { get; set; } 
        public void mostrarinfo()
        {
            try
            {
                Console.WriteLine("que tipo de figura es: ");
                figuraa = Console.ReadLine();
                Console.WriteLine("cual es el color?");
                color = Console.ReadLine();
                Console.WriteLine($"el color es: {color}");
                Console.WriteLine($"la figura es: {figuraa}");
                Console.WriteLine($"{calculararea()}");
                Console.WriteLine($"{calcularperimetro()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
           
        }
        public void cambiarcolor(string nuevocolor = null)
        {
            Console.WriteLine("¿Deseas cambiar el color? (si/no)");
            var respuesta = Console.ReadLine()?.Trim().ToLower();
            if (respuesta == "si" || respuesta == "s")
            {
                if (string.IsNullOrWhiteSpace(nuevocolor))
                {
                    Console.WriteLine("Ingrese el nuevo color:");
                    nuevocolor = Console.ReadLine();
                }

                if (string.IsNullOrWhiteSpace(nuevocolor))
                {
                    Console.WriteLine("Operación cancelada: color inválido.");
                    return;
                }
            
                color = nuevocolor.Trim();
                Console.WriteLine($"Color cambiado a: {color}");
            }
            else
            {
                Console.WriteLine("No se cambió el color.");
            }
        }
        public abstract double calculararea();
        public abstract double calcularperimetro();
    }
}
