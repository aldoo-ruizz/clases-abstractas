using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_abstractas.clases
{
    /// <summary>
    /// ARD 20260303
    /// se creo la clase circulo que hereda de la clase abstracta figura, con sus propias implementaciones de los métodos calculararea y calcularperimetro. En el programa principal se crean instancias de cada figura, se calculan sus áreas y perímetros, se muestran sus informaciones y se ofrece la opción de cambiar el color.
    /// </summary>
    public class circulo : figura
    {
        public double radio { get; set; }
        public circulo() 
        {
            try
            {
                Console.WriteLine("----Circulo----");

                Console.WriteLine("escribe el radio de el circulo: ");
                radio = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            
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
