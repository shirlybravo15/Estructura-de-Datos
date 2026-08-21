using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Program
    {
        static void ImprimirCabecera(string nombreMateria,int grupo, string nombre)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine(" UNIVERSIDAD DEL CARIBE ");
            Console.WriteLine($" Asignatrura: {nombreMateria}");
            Console.WriteLine($" Grupo: { grupo }");
            Console.WriteLine($" Nombre: { nombre }");
            Console.WriteLine("=================================================");
        }
        static void Main(string[] args)

        {
            ImprimirCabecera(" Fundamentos de la Programación", 1 , "Shirly Nicoll Bravo K´David");


        }
    }
}
