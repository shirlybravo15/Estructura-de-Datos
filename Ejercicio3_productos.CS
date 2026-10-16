using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "C:\\Users\\Sala-1\\Desktop\\Shirly\\Ejercicio3\\product.csv";
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("ID,Nombre,precio");
                sw.WriteLine("1,Laptop,1200");
                sw.WriteLine("2,Mouse,25");
                sw.WriteLine("3,Monitor,300");
            }
            string[] lineas = File.ReadAllLines(ruta);
            for (int i = 1; i < lineas.Length; i++) 
            {
                string[] campos = lineas[i].Split(',');
                double precio = double.Parse(campos[2]);
                if (precio > 100)
                    Console.WriteLine($"{campos[1]} - ${precio}");

            }
        }
    }
}
