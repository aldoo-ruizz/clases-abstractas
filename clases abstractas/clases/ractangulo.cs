using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_abstractas.clases
{
    /// <summary>
    /// ARD 20260303
    /// se creo la clase rectangulo que hereda de la clase abstracta figura, con sus propias implementaciones de los métodos calculararea y calcularperimetro. En el programa principal se crean instancias de cada figura, se calculan sus áreas y perímetros, se muestran sus informaciones y se ofrece la opción de cambiar el color.
    /// </summary>
    public class rectangulo: figura
    {
        public double basee { get; set; }
        public double altura { get; set; }
        public rectangulo()
        {
            try
            {
                Console.WriteLine("----Rectangulo----");

                Console.WriteLine("escribe la base del rectangulo: ");
                basee = double.Parse(Console.ReadLine());
                Console.WriteLine("escribe la altura del rectangulo: ");
                altura = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
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

