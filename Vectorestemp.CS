using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperatura = new double[5]; //  Declarando e iniciando

            // Lectura/Escritura de nuestro vector
            Console.WriteLine("=======Ingreso de Temperatura=====");

            for (int i = 0; i < temperatura.Length; i++)
            {
                Console.WriteLine($"Ingrese la temperatura del día {i + 1}: ");
                temperatura[i] = Convert.ToDouble(Console.ReadLine());
            }

            double suma = 0;
            double maxT = temperatura[0];
            double minT = temperatura[0];

            foreach (double temp in temperatura)
            {
                suma += temp;
                if (temp > maxT) maxT = temp;
                if (temp < minT) minT = temp;
            }
             double promedio = suma / temperatura.Length;

                    // salida de información
            Console.WriteLine("\n====Reporte===");
            Console.WriteLine($"Temperaturas registradas: {string.Join(", ", temperatura)}");
            Console.WriteLine($"Temperatura promedio: {promedio:F2}°C");
            Console.WriteLine($"Temperatura Máxima: {maxT}°C");
            Console.WriteLine($"Tempuratura Minima: {minT}°C");
    
        }
    }
}
