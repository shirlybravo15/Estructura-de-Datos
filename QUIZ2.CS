using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cantidad de estudiantes
            const int N = 22;

            // Arreglos paralelos
            string[] nombres = new string[N];
            double[] calificaciones = new double[N];

            // Registrar los 22 estudiantes
            for (int i = 0; i < N; i++)
            {
                // Validar nombre
                for (; ; )
                {
                    Console.Write("Ingrese el nombre del estudiante " + (i + 1) + ": ");
                    nombres[i] = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(nombres[i]))
                    {
                        break;
                    }

                    Console.WriteLine("Error: el nombre no puede estar vacio.");
                }

                // Validar calificacion
                for (; ; )
                {
                    Console.Write("Ingrese la calificacion de " + nombres[i] + " (0.0 - 5.0): ");

                    if (double.TryParse(Console.ReadLine(), out calificaciones[i]) &&
                        calificaciones[i] >= 0.0 &&
                        calificaciones[i] <= 5.0)
                    {
                        break;
                    }

                    Console.WriteLine("Error: la calificacion debe estar entre 0.0 y 5.0.");
                }

                Console.WriteLine();
            }

            // Variables para las estadisticas
            double suma = 0;
            double mayor = calificaciones[0];
            double menor = calificaciones[0];

            int aprobados = 0;
            int reprobados = 0;

            // Calcular estadisticas
            for (int i = 0; i < N; i++)
            {
                suma = suma + calificaciones[i];

                if (calificaciones[i] > mayor)
                {
                    mayor = calificaciones[i];
                }

                if (calificaciones[i] < menor)
                {
                    menor = calificaciones[i];
                }

                if (calificaciones[i] >= 3.0)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }

            // Calcular promedio
            double promedio = suma / N;

            // Mostrar reporte final
            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("      REPORTE DE CALIFICACIONES");
            Console.WriteLine("======================================");

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(
                    "Estudiante: " + nombres[i] +
                    " | Nota: " + calificaciones[i].ToString("F2")
                );
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Promedio:    " + promedio.ToString("F2"));
            Console.WriteLine("Nota mayor:  " + mayor.ToString("F2"));
            Console.WriteLine("Nota menor:  " + menor.ToString("F2"));
            Console.WriteLine("Aprobados:   " + aprobados);
            Console.WriteLine("Reprobados:  " + reprobados);
            Console.WriteLine("======================================");

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
