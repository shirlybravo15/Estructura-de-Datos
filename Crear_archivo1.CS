using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "C:\\Users\\Sala-1\\Desktop\\Shirly\\InformaciónEstudiantes.csv";
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("Nombre, Apellido, Edad,Nota, Programa, Asignatura, Semestre");
                sw.WriteLine("Shirly, Bravo, 18, 5, Ingeniria Informática, Estructura de datos, Segundo Semestre");
                sw.WriteLine("Nicoll, K´David, 15, 4, Ingenieria Electrica, Dibujo Electrico, primer semestre");
                sw.WriteLine("Ana, Correa, 20, 3, Ingenieria Industrial, CalculoII, Tercer Semestre");
            }

            Console.WriteLine("Archivo creado exitosamente");
        }
    }
}
