using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    internal class Program
    {
        //procedimiento sumar o imprimir
        public static void ImprimirSumar(int a, int b) // a , b son los parametros
        {
            int suma = a + b;
            Console.WriteLine(suma);
        }

        public static void MostrarPotenciaX( double num1, double potencia)
        {
            double result = Math.Pow(num1, potencia);
            Console.WriteLine($"La potencia de {num1}elevado a {potencia} es: {result} ");
        }
        static void Main(string[] args)
        {
            int x = 12, y = 23;

            ImprimirSumar(y, x);// y, x (argumentos actuales)
            ImprimirSumar(1000, -1);//1000, -1 (argumentos literarles)
            MostrarPotenciaX(12, 3);

        }
         
    }
}
