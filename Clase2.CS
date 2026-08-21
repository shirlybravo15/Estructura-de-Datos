using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect2
{
    internal class Program
    {
        static double CalcularAreaCirculo(double radio)
        {
            const double PI = 3.141592;
            // ahora voy a realizar el calculo con la formula
            double area = PI * Math.Pow(radio, 2);// double area = PI * (radio**2);
            return area;

        }
        
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el radio del círculo:");
            double r = Convert.ToDouble(Console.ReadLine());

            double result = CalcularAreaCirculo(r);
            Console.WriteLine($"El area es :{result:F2}");


        }
    }
}
