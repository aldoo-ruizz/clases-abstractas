using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_abstractas.clases
{
    /// <summary>
    /// ARD 20260303
    /// se creo la clase triangulorectangulo que hereda de la clase abstracta figura, con sus propias implementaciones de los métodos calculararea y calcularperimetro. En el programa principal se crean instancias de cada figura, se calculan sus áreas y perímetros, se muestran sus informaciones y se ofrece la opción de cambiar el color.
    /// </summary>
    internal class triangulorectangulo : figura
    {
        public double ca { get; set; }
        public double cb { get; set; }
        public triangulorectangulo()
        {
            try
            {
                Console.WriteLine("----Triangulo rectangulo----");
                Console.WriteLine("escribe el cateto A: ");
                ca = double.Parse(Console.ReadLine());
                Console.WriteLine("escribe el cateto B: ");
                cb = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
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
