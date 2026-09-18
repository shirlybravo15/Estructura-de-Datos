using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] estudiantes =
             {"Ester", "fernando", "Camilo", "María"};

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine(
                    $"Indice [{i}] {estudiantes[i]}");

            }


            
        }
    } 
}
