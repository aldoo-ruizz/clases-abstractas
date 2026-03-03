using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_abstractas.clases
{
    public class rectangulo: figura
    {
        public double basee { get; set; }
        public double altura { get; set; }
        public rectangulo()
        {
            Console.WriteLine("cual es el color?");
            color = Console.ReadLine();
            Console.WriteLine("escribe la base");
            basee = double.Parse(Console.ReadLine());
            Console.WriteLine("escribe la altura");
            altura = double.Parse(Console.ReadLine());
        }

        public override double calculararea()
        {
            Console.WriteLine($"el area es: ");
            return  (basee * altura);
        }
        public override double calcularperimetro()
        {
            Console.WriteLine("el perimetro es: ");
            return (basee * altura)/2;
        }

    }
}

