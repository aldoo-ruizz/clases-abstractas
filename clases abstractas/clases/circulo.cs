using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_abstractas.clases
{
    public class circulo : figura
    {
        public double radio { get; set; }
        public circulo() 
        {
            Console.WriteLine("cual es el color?");
            color = Console.ReadLine();
            Console.WriteLine("escribe el radio");
            radio = double.Parse(Console.ReadLine());
        }
        
        public override double calculararea()
        {
            Console.WriteLine($"el area es: ");
            return 3.1416 * (radio*radio);
        }
        public override double calcularperimetro()
        {
            Console.WriteLine("el perimetro es: "); 
            return 2 * 3.1416 * radio;
        }

    }
}
