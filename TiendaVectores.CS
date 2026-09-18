using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una tienda registra las ventas de 10 días en arrays doueble[]
            //Y necesitamos cacular:
            //1.Calcular el total vendido
            //2.Calcular el promedio diario
            //3.Encontrar el día con mayor venta
            //4.Encontrar el día con menor venta
            //5.Contar cuantos días superaron el promedio

            double[] venta =
            { 200.000, 302.300, 400.000, 300.233, 700.410, 740.432, 100.233, 99.243, 823.231, 902.211};
            double total = 0;
            double mayorVenta = venta[0];
            double menorVenta = venta[0];
            int díaMayorVenta = 0;
            int díaMenorVenta = 0;

            for (int i = 0; i < venta.Length; i++) 
            { 
                total += venta[i];

                if (venta[i] > mayorVenta)
                {
                    mayorVenta = venta[i];
                    díaMayorVenta = i;
                }
                if(venta[i] < menorVenta)
                {
                    menorVenta = venta[i];
                    díaMenorVenta = i;
                }
            
            }

            double promedio = total / venta.Length;
            int díasSobrePromedio = 0;

            for (int i = 0; i < venta.Length; i++)
            {
                if (venta[i] > promedio)
                {
                    díasSobrePromedio++;
                }
            }

            Console.WriteLine("============== REPORTE DE VENTAS ==============");
            Console.WriteLine();

            Console.WriteLine($"Total vendido: ${total:F3}");
            Console.WriteLine($"Promedio diario: ${promedio:F3}");
            Console.WriteLine();

            Console.WriteLine($"Mayor venta ${mayorVenta:F3} = el día {díaMayorVenta + 1}");
            Console.WriteLine($"Menor venta ${menorVenta:F3} = el día {díaMenorVenta + 1}");

            Console.WriteLine($"Días que superaron el promedio de ventas: ${díasSobrePromedio}");
            Console.WriteLine();

            Console.WriteLine("Ventas por Días");
            Console.WriteLine();

            for (int i = 0;i < venta.Length; i++)
            {
                Console.WriteLine($"Día {i + 1}: ${venta[i]:F3}");
            }
                

        }
    } 
}
