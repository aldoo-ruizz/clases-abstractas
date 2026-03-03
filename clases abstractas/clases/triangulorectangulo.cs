using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_abstractas.clases
{
    internal class triangulorectangulo : figura
    {
        public double ca { get; set; }
        public double cb { get; set; }
        public triangulorectangulo()
        {
            Console.WriteLine("cual es el color?");
            color = Console.ReadLine();
            Console.WriteLine("escribe el cateto A");
            ca = double.Parse(Console.ReadLine());
            Console.WriteLine("escribe el cateto B");
            cb = double.Parse(Console.ReadLine());
        }

        public override double calculararea()
        {
            Console.WriteLine($"el area es: ");
            return (ca * cb)/2;
        }
        public override double calcularperimetro()
        {
            Console.WriteLine("el perimetro es: ");
            double hipotenusa = Math.Sqrt((ca * ca) + (cb * cb));
            return ca + cb + hipotenusa;
        }
    }
}
