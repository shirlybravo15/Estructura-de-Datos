using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pp
{

    internal class Program
    {
        static void ImprimirCabezera(string nombreMateria, int grupo,int edad, string nombre, string horario, string comidafav,  string deporteprac, string Actfav )
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("         UNIVERSIDAD DEL CARIBE            ");
            Console.WriteLine($" Asignatura: {nombreMateria}");
            Console.WriteLine($" Grupo: { grupo }");
            Console.WriteLine($" Nombre: { nombre }");
            Console.WriteLine($" Edad: { edad }");
            Console.WriteLine($" Horario: { horario }");
            Console.WriteLine($" Comida Favorita: { comidafav }");
            Console.WriteLine($" Deporte que practico: { deporteprac }");
            Console.WriteLine($" Actividad favorita: { Actfav }");
            Console.WriteLine("===========================================");
        }
        public static void Main(string[] args) {
            //llamar a la procedimiento ImprimirCabezera
            ImprimirCabezera("fundamentos de Programación", 1, 18, "Shirly Nicoll Bravo KDavid","Lunes a viernes", "Pastas", "Calistenia", "Ver doramas");

        }
    }
}
