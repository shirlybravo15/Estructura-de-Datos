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
            // Ejercicio 2: Búsqueda y modificación de información en vectores
            // Operaciones: Búsqueda Líneal, verificación de existencia y actualización de un elemento en un Array

            int[] codigos = new int[20];
            {
                for (int i = 0; i < codigos.Length; i++) 
                { 
                    Console.WriteLine($"Ingrese el código {i}");
                    codigos[i] = Convert.ToInt32( Console.ReadLine() );
                }

            }
              Console.WriteLine($"Códigos actuales: {string.Join(", ", codigos)}");
              Console.WriteLine("Ingrese el código que desea actualizar: ");
              int busqueda = Convert.ToInt32( Console.ReadLine() );

            int indiceEncontrado = -1;
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda) 
                {
                    indiceEncontrado = i;
                    break;
                }
            }
            if (indiceEncontrado != -1)
            {
                Console.WriteLine("Ingrese el nuevo código: ");
                codigos[indiceEncontrado] = Convert.ToInt32( Console.ReadLine() );
                Console.WriteLine($"\nVector Actualizado: {string.Join(", ", codigos)}");

            }
            else
            {
                Console.WriteLine("\nError: El código ingresado no existe en la base de datos");
            }

            Console.WriteLine($"\n Valor del indice: {indiceEncontrado}");
        }
    }
}
