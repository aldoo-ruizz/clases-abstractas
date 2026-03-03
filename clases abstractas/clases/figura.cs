using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_abstractas.clases
{
    public abstract class figura
    {
        public string color { get; set; }
        public void mostrarinfo()
        {

            Console.WriteLine($"el color es: {color}");
            Console.WriteLine($"el area es: {calculararea()}");
            Console.WriteLine($"el perimetro es: {calcularperimetro()}");
        }
        public  void cambiarcolor(string nuevocolor)
        {
            
        }
        public abstract double calculararea();
        public abstract double calcularperimetro();
    }
}
