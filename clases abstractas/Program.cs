using clases_abstractas.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_abstractas
{
    /// <summary>
    /// ARD 20260303
    /// se ceraron las clases circulo, rectangulo y triangulorectangulo que heredan de la clase abstracta figura, cada una con sus propias implementaciones de los métodos calculararea y calcularperimetro. En el programa principal se crean instancias de cada figura, se calculan sus áreas y perímetros, se muestran sus informaciones y se ofrece la opción de cambiar el color.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            
                figura circulo = new circulo();
                figura rectangulo = new rectangulo();
                figura triangulorectangulo = new triangulorectangulo();
                Console.WriteLine("----------------");
                
                circulo.mostrarinfo();
                circulo.cambiarcolor();
                Console.WriteLine("----------------");
               
                rectangulo.mostrarinfo();
                rectangulo.cambiarcolor();

                Console.WriteLine("----------------");
                
                triangulorectangulo.mostrarinfo();
                triangulorectangulo.cambiarcolor();

            
        }
    }
}
